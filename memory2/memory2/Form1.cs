using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory2
{
    public partial class Form1 : Form
    {
        private GameSettings _settings;
        private Card _pierwsza;
        private Card _druga;

        public Form1()
        {
            InitializeComponent();


            _settings = new GameSettings();

            UstawWyglądOkienko();

            GenerujKarty();

            timerStartowy.Start();
        }

        

        private void UstawWyglądOkienko()
        {
            panelKart.Width = _settings.Kolumny * _settings.Bok + _settings.Kolumny*_settings.Margin;
            panelKart.Height = _settings.Wiersze * _settings.Bok + _settings.Wiersze * _settings.Margin;

            Width = panelKart.Width + 40;
            Height = panelKart.Height + 100;

            lblCzasGry.Text = _settings.CzasGry.ToString();
            lblPunkty.Text = _settings.Punkty.ToString();
            lblCzasStart.Text = $"Start za {_settings.CzasStartowy}...";

            lblCzasStart.Visible = true;


        }
        private void GenerujKarty()
        {
            string[] paths = Directory.GetFiles(_settings.Obrazki);

            _settings.MaxPunkty = paths.Length;

            List<Card> cardsToPosition = new List<Card>();

            foreach (string path in paths)
            {
                Guid id = Guid.NewGuid();

                Card card1 = new Card(id, _settings.Logo, path);
                Card card2 = new Card(id, _settings.Logo, path);

                cardsToPosition.Add(card1);
                cardsToPosition.Add(card2);
            }

            Random rng = new Random();

            panelKart.Controls.Clear();
            int StartPos = (int)(0.5 * _settings.Margin);
            for(int x = 0; x < _settings.Kolumny; x++)
            {
                for (int y = 0; y < _settings.Wiersze; y++)
                {
                    int index = rng.Next(0, cardsToPosition.Count);
                    Card card = cardsToPosition[index];
                    card.Location = 
                            new Point(StartPos+x * _settings.Bok+x*_settings.Margin, StartPos+y * _settings.Bok+y * _settings.Margin);
                    

                    card.Width = _settings.Bok;
                    card.Height = _settings.Bok;

                    panelKart.Controls.Add(card);

                    cardsToPosition.Remove(card);

                    card.Odkryj();

                    card.Click += CardClicker;
                }
            }
            

        }

        private void TimerStartowy_Tick(object sender, EventArgs e)
        {
            _settings.CzasStartowy--;
            lblCzasStart.Text = $"Start za {_settings.CzasStartowy}";

            if (_settings.CzasStartowy <= 0)
            {
                lblCzasStart.Visible = false;

                foreach (Control karta in panelKart.Controls)
                {
                    Card card = (Card)karta;
                    card.Zakryj();
                }

                timerStartowy.Stop();
                timerCzasGry.Start();
            }


        }

        void CardClicker(object sender, EventArgs args)
        {
            Card clickedCard=(Card)sender;
            clickedCard.Odkryj();

            if (_pierwsza == null)
            {
                _pierwsza = clickedCard;
            }
            else
            {
                _druga = clickedCard;
                panelKart.Enabled = false;
                if (_pierwsza.Id == _druga.Id)
                {
                    _settings.Punkty++;
                    lblPunkty.Text = _settings.Punkty.ToString();

                    _pierwsza = null;
                    _druga = null;
                    panelKart.Enabled = true;
                }
                else
                {
                    timerZakrywajacy.Start();
                }
            }
        }

        private void TimerZakrywajacy_Tick(object sender, EventArgs e)
        {
            _pierwsza.Zakryj();
            _druga.Zakryj();

            _pierwsza = null;
            _druga = null;

            panelKart.Enabled = true;

            timerZakrywajacy.Stop();
        }

        private void TimerCzasGry_Tick(object sender, EventArgs e)
        {
            _settings.CzasGry--;
            lblCzasGry.Text = _settings.CzasGry.ToString();
            if (_settings.CzasGry <= 0 || _settings.Punkty == _settings.MaxPunkty)
            {
                timerCzasGry.Stop();
                timerZakrywajacy.Stop();

               DialogResult result = MessageBox.Show($"Zdobyto punkty: {_settings.Punkty}/12 Pozostało czasu: {_settings.CzasGry} sekund .Graj ponownie ?",
                    "Koniec Gry", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    _settings = new GameSettings();
                    UstawWyglądOkienko();
                    GenerujKarty();

                    timerStartowy.Start();

                }
                else
                {
                    Application.Exit();
                }

            }

        }
    }
}
