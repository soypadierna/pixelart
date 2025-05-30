using pixelart.canva.entities;
using pixelart.canva.providers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pixelart.canva.components
{
    internal class DrawGrid
    {
        public int Columns => _pixelart.Columns;
        public int Rows => _pixelart.Rows;
        private Pixelart _pixelart;
        public Size size { get; set; }
        public int PixelSize { get; set; } = 1;
        public Bitmap bmp { get; set; }

        public DrawGrid(Pixelart pixelart, Size size)
        {
            _pixelart = pixelart;
            this.size = size;

            _changeCellSize();
            _createBmp();
        }

        private void _changeCellSize()
        {
            int pixelWidth = size.Width / Columns;
            int pixelHeight = size.Height / Rows;

            PixelSize = Math.Max(1, Math.Min(pixelWidth, pixelHeight));
        }

        private void _createBmp()
        {
            Bitmap newBmp = new Bitmap(Columns * PixelSize, Rows * PixelSize);

            using (Graphics g = Graphics.FromImage(newBmp))
            {
                g.Clear(Color.White);

                if (_pixelart.isFree) _createGrid(g);
                else _createBookmark(g);
            }
            bmp = newBmp;
        }

        //!TODO: Falta agregar las ultimas líneas
        private void _createGrid(Graphics g)
        {
            for (int i = 0; i <= Columns; i++)
            {
                g.DrawLine(Pens.Gray, i * PixelSize, 0, i * PixelSize, Rows * PixelSize);
            }
            for (int j = 0; j <= Rows; j++)
            {
                g.DrawLine(Pens.Gray, 0, j * PixelSize, Columns * PixelSize, j * PixelSize);
            }
        }

        private void _createBookmark(Graphics g)
        {
            int fontSize = (int)(PixelSize * 0.4);
            Font font = new Font("Rubik", fontSize);

            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    Pixel p = _pixelart.Pixels[x, y];
                    if (p.isPainted || p.Code == 0) continue;

                    Rectangle rect = new Rectangle(y * PixelSize, x * PixelSize, PixelSize, PixelSize);
                    g.DrawRectangle(Pens.Gray, rect);
                    g.DrawString(p.Code.ToString(), font, Brushes.Black, rect, format);
                }
            }
        }

        public void paintDrawing(int col, int row) 
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (_pixelart.isFree)
                    _paintFree(col, row, g);
                else _paintPixelart(col, row, g);
            }
        }

        private void _paintFree(int col, int row, Graphics g) 
        {
            Color color = ColorProvider.Instance.SelectedColor;
            g.FillRectangle(new SolidBrush(color), col * PixelSize + 1, row * PixelSize + 1, PixelSize - 1, PixelSize - 1);
        }

        private void _paintPixelart(int col, int row, Graphics g) 
        {
            Pixel p = _pixelart.Pixels[row, col];

            if (p.isPainted || p.Code == 0)
                return;

            p.Painted(ColorProvider.Instance.SelectedColor);
            g.FillRectangle(new SolidBrush(p.color), col * PixelSize, row * PixelSize, PixelSize, PixelSize);

            _createBookmark(g);
        }
    }
}
