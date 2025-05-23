using pixelart.canva.entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixelart.shared.entities
{
    internal class PixelArtList
    {

        public Pixelart lobo = new Pixelart("Lobo", 17, 15, new List<Color>
            {
                Color.Black,
                Color.LightBlue,
            }
        );
        
    }
}
