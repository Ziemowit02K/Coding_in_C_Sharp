using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory2
{
    class Card : Label
    {
        public Guid Id;
        Image Logo;
        Image Obrazek;

        public Card(Guid id, string logo, string obrazek)
        {
            Id = id;
            Logo = Image.FromFile(logo);
            Obrazek = Image.FromFile(obrazek);

            BackgroundImageLayout = ImageLayout.Stretch;
            // BackgroundImage = Obrazek;
            //Zakryj();
            //Odkryj();
        }

        public void Zakryj()
        {
            BackgroundImage = Logo;
            Enabled = true;
        }

        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }
    }
}
