using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    public class Pixelart
    {
        // Propiedades
        public string Name { get; set; }
        public List<Color> Palette { get; set; }
        public PixelMap pixelMap { get; set; }
        public DateTime Created { get; set; }

        // Constructor
        public Pixelart(string name, int width, int height, List<Color> palette = null)
        {
            Name = name;
            Palette = palette ?? new List<Color>();
            pixelMap = new PixelMap(width, height);
            Created = DateTime.Now;
        }


        //Lista de pruebas
        public static List<Pixelart> list = new List<Pixelart>
        {
            new Pixelart("Lobo", 17, 15, new List<Color>
            {
                Color.Black,
                Color.LightBlue
            }),
            new Pixelart("Gato", 10, 10, new List<Color>
            {
                Color.Black,
                Color.White
            }),
            //Crear clase especial para el pixelart libre
            new Pixelart("Libre", 20, 20, new List<Color>
            {
                Color.Black,
                Color.White
            })
    };
    };
}

