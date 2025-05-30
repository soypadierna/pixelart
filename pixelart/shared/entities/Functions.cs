using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixelart.shared.entities
{
    internal class Functions
    {
        public static int changeCellSize(Size size, int col, int row)
        {
            int pixelWidth = size.Width / col;
            int pixelHeight = size.Height / row;

            return Math.Max(1, Math.Min(pixelWidth, pixelHeight));
        }
    }
}
