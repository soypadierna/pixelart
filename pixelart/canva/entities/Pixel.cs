using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixelart.canva.entities
{
    public class Pixel
    {
        public Color color { get; set; }
        public Color DefaultColor { get; set; }
        public bool isPainted { get; set; }  = false;
        public int Row { get; set; }
        public int Column { get; set; }
        public int Code { get; set; }

        public Pixel(int row, int column, int code, Color defaultColor)
        {
            Row = row;
            Column = column;
            color = _initColor(defaultColor);
            Code = code;
            DefaultColor = defaultColor;
        }

        private Color _initColor(Color defaultColor)
        {
            int gris = (int)(defaultColor.R * 0.3 + defaultColor.G * 0.59 + defaultColor.B * 0.11);
            gris = (int)(gris + (255 - gris) * 0.4);
            return Color.FromArgb(defaultColor.A, gris, gris, gris);
        }

        public void Painted(Color newColor)
        {
            if (newColor.ToArgb() == DefaultColor.ToArgb())
            { 
                color = newColor;
                isPainted = true;
                return;
            }

            int r = (int)(newColor.R + (255 - newColor.R) * 0.6);
            int g = (int)(newColor.G + (255 - newColor.G) * 0.6);
            int b = (int)(newColor.B + (255 - newColor.B) * 0.6);

            color = Color.FromArgb(color.A, r, g, b);
        }
    }

}
