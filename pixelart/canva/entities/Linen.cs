using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    internal class Linen
    {
        public Pixelart pixelart;
        public Panel panel;

        public Linen(
            Pixelart pixelart,
            Panel panel
            )
        {
            this.pixelart = pixelart;
            this.panel = panel;

            _init(pixelart);
        }

        private void _init(Pixelart pixelart)
        {

            PictureBox _picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.White,
                Image = pixelart.Bmp(panel.Width, panel.Height, true),
            };

            panel.Controls.Add(_picture);
        }
    }
}
