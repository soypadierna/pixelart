using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    public class PixelMap
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Pixel[,] Matrix { get; set; }
        public List<Pixel> Pixels { get; set; }

        public PixelMap(int width, int height)
        {
            // se pueden sacar estos valores de la matriz?
            Width = width;
            Height = height;
            Matrix = new Pixel[width, height];
            Pixels = new List<Pixel>();

            initMatrix();

        }

        void initMatrix()
        {
            // Inicializa la matriz y la lista con píxeles vacíos
            //cambiar el id por un id unico por cada color
            int id = 0;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var pixel = new Pixel(id++, Color.LightGray, Color.Green, x, y);
                    Matrix[x, y] = pixel;
                    Pixels.Add(pixel);
                }
            }
        }

        public void View(Control container)
        {
            int panelSize = 30;

            int totalWidth = Width * panelSize;
            int totalHeight = Height * panelSize;

            int startX = (container.Width - totalWidth) / 2;
            int startY = (container.Height - totalHeight) / 2;

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    // Crear panel centrado
                    Panel panel = new Panel
                    {
                        Size = new Size(panelSize, panelSize),
                        Location = new Point(
                            startX + x * panelSize,
                            startY + y * panelSize
                        ),
                        BackColor = this.Matrix[x, y].IntColor,
                        Name = $"pnl_{x}_{y}",
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Crear label centrado
                    Label label = new Label
                    {
                        Text = this.Matrix[x, y].Id.ToString(),
                        AutoSize = false,
                        Size = panel.Size,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Name = $"lbl_{x}_{y}",
                        BackColor = Color.Transparent
                    };

                    panel.Controls.Add(label);
                    container.Controls.Add(panel);
                }
            }
        }
    }
}
