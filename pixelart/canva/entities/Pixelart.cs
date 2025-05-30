using pixelart.shared.entities;
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
        public bool isFree;
        public string Name { get; set; }
        public int Rows;
        public int Columns;
        public Pixel[,] Pixels { get; }
        public Dictionary<int, Color> PaintColors { get; }

        public Pixelart(
            string name,
            Dictionary<int, Color> paintColors,
            int[,] matrix,
            bool isFree = false
            )
        {
            Name = name;
            this.isFree = isFree;
            PaintColors = paintColors;
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

        public Bitmap PreView(Size size)
        {
            int PixelSize = Functions.changeCellSize(size, Columns, Rows);
            ;
            Bitmap newBmp = new Bitmap(Columns * PixelSize, Rows * PixelSize);

            using (Graphics g = Graphics.FromImage(newBmp))
            {
                g.Clear(Color.White);

                for (int x = 0; x < Rows; x++)
                {
                    for (int y = 0; y < Columns; y++)
                    {
                        Pixel p = Pixels[x, y];
                        if (p.isPainted || p.Code == 0)
                            continue;

                        g.FillRectangle(new SolidBrush(p.color), y * PixelSize, x * PixelSize, PixelSize, PixelSize);
                    }
                }

            }
            return newBmp;
        }


        public static Pixelart flower = new Pixelart(
    "Flor",
    new Dictionary<int, Color>
    {
        { 1, Color.FromArgb(255, 0, 128, 0) },      
        { 2, Color.FromArgb(255, 255, 255, 0) },    
        { 3, Color.FromArgb(255, 255, 105, 180) },  
        { 4, Color.FromArgb(255, 255, 20, 147) },   
    },
    new int[,]
    {
        {0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 3, 4, 3, 4, 3, 0, 0, 0, 0},
        {0, 0, 0, 3, 4, 3, 3, 3, 4, 3, 0, 0, 0},
        {0, 0, 3, 4, 3, 3, 2, 3, 3, 4, 3, 0, 0},
        {0, 0, 3, 3, 3, 2, 2, 2, 3, 3, 3, 0, 0},
        {0, 3, 4, 3, 2, 2, 2, 2, 2, 3, 4, 3, 0},
        {0, 0, 3, 3, 3, 2, 2, 2, 3, 3, 3, 0, 0},
        {0, 0, 0, 3, 4, 3, 2, 3, 4, 3, 0, 0, 0},
        {0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0},
        {0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0},
        {0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}
    });


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

