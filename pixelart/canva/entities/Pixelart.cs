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
        public int Rows => Matrix.GetLength(0);
        public int Columns => Matrix.GetLength(1);
        public Dictionary<int, Color> PaintColors { get; }
        public Dictionary<int, Color> InitColors { get; }
        public int[,] Matrix { get; }
        public double Percentage { get; set; }
        public Bitmap Bitmap => Bmp();

        public Pixelart(
            string name,
            Dictionary<int, Color> paintColors,
            Dictionary<int, Color> initColors,
            int[,] matrix
            )
        {
            Name = name;
            PaintColors = paintColors;
            Matrix = matrix;
            InitColors = initColors;
            Percentage = 0.0;
        }
        public Bitmap Bmp()
        {
            Bitmap bmp = new Bitmap(Columns, Rows);

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    int colorId = Matrix[x, y];
                    Color color = PaintColors.ContainsKey(colorId) ? InitColors[colorId] : Color.White;
                    bmp.SetPixel(y, x, color);
                }
            }
            return bmp;
        }

        private int _pixelSize(int Width, int Height)
        {
            const int Size = 30;

            int pixelWidth = Width / Columns;
            int pixelHeight = Height / Rows;

            int pixelSize = Math.Min(Size, Math.Min(pixelWidth, pixelHeight));

            return Math.Max(pixelSize, 1);
        }

        //!TODO: Cambiar funcion por la funcion del tamaño del pixel
        public void scaler(PictureBox pictureBox, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            g.Clear(pictureBox.BackColor);

            float scale = Math.Min(
                (float)pictureBox.Width / Columns,
                (float)pictureBox.Height / Rows
            );

            int drawWidth = (int)(Columns * scale);
            int drawHeight = (int)(Rows * scale);
            int offsetX = (pictureBox.Width - drawWidth) / 2;
            int offsetY = (pictureBox.Height - drawHeight) / 2;

            g.DrawImage(Bitmap, new Rectangle(offsetX, offsetY, drawWidth, drawHeight));
        }

        public static Pixelart boardOne = new Pixelart(
            "Lobo",
    new Dictionary<int, Color>
{
        { 1, Color.FromArgb(255, 0, 0, 0) },         // Negro
        { 2, Color.FromArgb(255, 192, 192, 192) },   // Gris claro
        { 3, Color.FromArgb(255, 128, 128, 128) }    // Gris oscuro
},
    new Dictionary<int, Color>
{
        { 1, Color.FromArgb(255, 0, 0, 0) },         // Negro
        { 2, Color.FromArgb(255, 192, 192, 192) },   // Gris claro
        { 3, Color.FromArgb(255, 128, 128, 128) }    // Gris oscuro
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

