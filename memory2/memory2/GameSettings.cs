using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory2
{
    class GameSettings
    {
        public int CzasGry;
        public int CzasStartowy;
        public int Punkty;
        public int MaxPunkty;

        public int Wiersze;
        public int Kolumny;
        public int Bok;
        internal int Margin;

        public string Logo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string Obrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\obrazki";

        

        public GameSettings()
        {
            CzasGry = 60;
            CzasStartowy = 5;
            Punkty = 0;
            

            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            Margin = 5;
        }
    }
}
