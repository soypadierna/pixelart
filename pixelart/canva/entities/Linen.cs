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
                Image = _bmp(),
            };

            panel.Controls.Add(_picture);
        }

        private Bitmap _bmp()
        {
            int pixelSize = _pixelSize();
            Bitmap bmp = new Bitmap(pixelart.Columns * pixelSize, pixelart.Rows * pixelSize);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            //!TODO:cambiar fuente
            Font font = new Font("Arial", 10);
            Pen pen = new Pen(Color.Black);

            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int row = 0; row < pixelart.Rows; row++)
            {
                for (int col = 0; col < pixelart.Columns ; col++)
                {
                    int id = pixelart.Matrix[row, col];

                    if (id != 0)
                    {
                        var rect = new Rectangle(col * pixelSize, row * pixelSize, pixelSize, pixelSize);
                        g.DrawRectangle(pen, rect);
                        g.DrawString(id.ToString(), font, Brushes.Black, rect, format);
                    }
                }
            }

            return bmp;
        }

        private int _pixelSize()
        {
            const int Size = 30;

            int pixelWidth = panel.Width / pixelart.Columns;
            int pixelHeight = panel.Height / pixelart.Rows;

            int pixelSize = Math.Min(Size, Math.Min(pixelWidth, pixelHeight));

            return Math.Max(pixelSize, 1);
        }

    }
}
