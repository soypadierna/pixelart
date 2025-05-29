using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    public class Pixelart
    {
        public string Name { get; set; }
        public int Rows { get; }
        public int Columns { get; }
        public Pixel[,] Pixels { get; }
        public Dictionary<int, Color> PaintColors { get; }

        //public int Size { get; set; } = 10;
        //private Dictionary<int, Color> InitColors { get; }
        //private Color?[,] Painteds;
        //public int[,] Matrix { get; }
        public double Percentage { get; set; }

        public Pixelart(
            string name,
            Dictionary<int, Color> paintColors,
            int[,] matrix
            )
        {
            Name = name;
            PaintColors = paintColors;
            //Matrix = matrix;
            //InitColors = _initColors(paintColors);
            //Painteds = new Color?[Rows, Columns];
            Percentage = 0.0;

            Rows = matrix.GetLength(0);
            Columns = matrix.GetLength(1);
            Pixels = _initPixels(matrix);
        }

        private Pixel[,] _initPixels(int[,] matrix)
        {
            Pixel[,] pixels = new Pixel[Rows, Columns];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    int code = matrix[row, col];
                    Color defaultColor = PaintColors.ContainsKey(code) ? PaintColors[code] : Color.White;
                    pixels[row, col] = new Pixel(row, col, code, defaultColor);
                }
            }

            return pixels;
        }
        //!TODO: Revisar
        public void Paint(int row, int col, Color newColor)
        {
            if (row >= 0 && row < Rows && col >= 0 && col < Columns)
            {
                Pixels[row, col].Painted(newColor);
            }
        }

        private int _changePixelSize(int width, int height)
        {
            int pixelWidth = width / Columns;
            int pixelHeight = height / Rows;

            int pixelSize = Math.Min(40, Math.Min(pixelWidth, pixelHeight));

            return Math.Max(pixelSize, 1);
        }

        public Bitmap Bmp(int width, int height, bool viewGrid = false)
        {
            int size = _changePixelSize(width, height);
            Bitmap bmp = new Bitmap(Columns * size, Rows * size);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Font font = new Font("Rubik Medium", 10F);
            Pen borderPen = new Pen(Color.Black);

            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    Pixel p = Pixels[row, col];
                    var rect = new Rectangle(col * size, row * size, size, size);

                    SolidBrush brush = new SolidBrush(p.color);
                    g.FillRectangle(brush, rect);

                    if (!p.isPainted && viewGrid && p.Code != 0)
                    {
                        g.DrawRectangle(borderPen, rect);
                        g.DrawString(p.Code.ToString(), font, Brushes.Black, rect, format);
                    }
                }
            }

            return bmp;
        }

        public static Pixelart boardOne = new Pixelart(
            "Lobo",
    new Dictionary<int, Color>
{
        { 1, Color.FromArgb(255, 0, 0, 0) },
        { 3, Color.FromArgb(255, 128, 128, 128) }
},
    new int[,]
    {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 1, 3, 3, 1, 0, 0, 0, 1, 3, 3, 1, 0, 0, 0, 0},
                {0, 1, 3, 3, 0, 1, 0, 0, 0, 1, 0, 3, 3, 1, 0, 0, 0},
                {0, 1, 3, 0, 0, 3, 1, 1, 1, 3, 0, 0, 3, 1, 0, 0, 0},
                {0, 1, 3, 0, 0, 3, 3, 3, 3, 3, 0, 0, 3, 1, 0, 0, 0},
                {0, 1, 3, 0, 0, 0, 3, 3, 3, 0, 0, 0, 3, 1, 0, 0, 0},
                {0, 1, 0, 0, 1, 0, 0, 3, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                {0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 3, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 3, 1, 1, 3, 3, 1, 0},
                {0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 3, 3, 1, 0},
                {0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 3, 3, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    }
);
    }
}

