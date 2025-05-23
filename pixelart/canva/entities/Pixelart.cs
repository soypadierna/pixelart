using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canvas.entities
{
    internal class Pixelart
    {
        // Propiedades
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Color> Palette { get; set; }
        public int[,] Matrix { get; set; }
        public int Width => Matrix?.GetLength(0) ?? 0;
        public int Height => Matrix?.GetLength(1) ?? 0;
        public DateTime Created { get; set; }

        // Constructor
        public Pixelart(string name, int width, int height, List<Color> palette = null, string description = "")
        {
            Name = name;
            Description = description;
            Palette = palette ?? new List<Color>();
            Matrix = new int[width, height];
            Created = DateTime.Now;
        }
    }
}
