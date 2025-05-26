using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    internal class Palette
    {
        public Dictionary<int, Color> PaintColors { get; }
        public FlowLayoutPanel FlowPanel { get; }
        public Palette(Dictionary<int, Color> paintColors, FlowLayoutPanel flowPanel) 
        {
            PaintColors = paintColors;
            FlowPanel = flowPanel;

            _init();
        }

        private void _init()
        {
            FlowPanel.FlowDirection = FlowDirection.TopDown;
            FlowPanel.WrapContents = false;
            FlowPanel.AutoScroll = true;
            FlowPanel.Padding = new Padding(20);

            Label label = new Label
            {
                Text = "Colores",
                Height = 30,
                TextAlign = ContentAlignment.TopCenter,
                Dock = DockStyle.Top,
                Font = new Font("Rubik Black", 16F, FontStyle.Bold),
            };

            FlowPanel.Controls.Add(label);

            foreach (var color in PaintColors)
            {
                CheckBox check = new CheckBox
                {
                    Width = 140,
                    Height = 36,
                    Padding = new Padding(10, 0, 0, 0),
                    Margin = new Padding(0,10,0,0),
                    BackColor = color.Value,
                    Name = $"clr_{color.Key}",
                    Text = color.Value.Name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = color.Value.ToArgb() == Color.Black.ToArgb() ? Color.White : Color.Black,
                };

                check.Click += (s, e) =>
                {
                    foreach (var cb in FlowPanel.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    check.Checked = true;
                };

                FlowPanel.Controls.Add(check);
            }
        }
    }
}
