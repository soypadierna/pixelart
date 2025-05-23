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
        public int Id { get; set; }
        public Color IntColor { get; set; }
        public Color PaintColor { get; set; }
        public bool IsPainted { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Pixel(int id, Color initialColor, Color paintColor, int x, int y, bool isPainted = false)
        {
            this.Id = id;
            this.IntColor = initialColor;
            this.PaintColor = paintColor;
            this.X = x;
            this.Y = y;
            this.IsPainted = isPainted;
        }

        public void onPaintend(Color colorSelect)
        {
            this.IsPainted = (colorSelect == PaintColor);

            if(IsPainted) this.IntColor = PaintColor;
            //añadir tinte de color pero mas claro

        }
    }
}
