using pixelart.canva.entities;
using pixelart.canva.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.shared.entities
{
    internal class Sign
    {
        public Pixelart pixelart;
        public Panel panel;
        public Button button;

        public Sign(
            Pixelart pixelart, 
            Panel panel, 
            Button button 
            )
        {
            this.pixelart = pixelart;
            this.panel = panel;
            this.button = button;

            _init(pixelart);
        }

        private void _init(Pixelart pixelart) 
        {
            Label _label = new Label
            {
                Text = pixelart.Name,
                Height = 40,
                TextAlign = ContentAlignment.BottomLeft,
                Dock = DockStyle.Bottom,
                Font = new Font("Rubik Black", 24F, FontStyle.Bold),
                BackColor = Color.White,
            };

            PictureBox _picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.White,
            };

            _picture.Paint += (s, e) => pixelart.scaler(_picture, e);
            _picture.Click += (s, e) => Canva.show(pixelart);
            _label.Click += (s, e) => Canva.show(pixelart);
            button.Click += (s, e1) => Canva.show(pixelart);
            panel.Click += (s, e1) => Canva.show(pixelart);

            panel.Controls.Add(_picture);
            panel.Controls.Add(_label);
            _label.BringToFront();
        }
    }
}
