using pixelart.canva.components;
using pixelart.canva.providers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    internal class Linen
    {
        private DrawGrid _drawGrid;
        public Panel panel;

        public Linen(Panel panel, DrawGrid drawGrid)
        {
            this.panel = panel;
            _drawGrid = drawGrid;

            _init();
        }

        private void _init()
        {

            Panel pnlLinen = new Panel
            {
                Name = "pnlLinen",
                Width = _drawGrid.PixelSize * _drawGrid.Columns,
                Height = _drawGrid.PixelSize * _drawGrid.Rows,
                BackColor = Color.White,
            };

            int x = (panel.Width - pnlLinen.Width) / 2;
            int y = (panel.Height - pnlLinen.Height) / 2;
            pnlLinen.Location = new Point(x, y);

            panel.Controls.Add(pnlLinen);

            pnlLinen.Paint += CreateCanvasPanel;
            pnlLinen.MouseClick += OnCanvasClick;
        }   

        private void CreateCanvasPanel(object sender, PaintEventArgs e) =>
            e.Graphics.DrawImage(_drawGrid.bmp, 0, 0);

        //private void OnCanvasClick(object sender, MouseEventArgs e)
        //{
        //    int pixelSize = _drawGrid.PixelSize;

        //    int col = e.X / pixelSize;
        //    int row = e.Y / pixelSize;

        //    if (col < _drawGrid.Columns && row < _drawGrid.Rows)
        //    {

        //        using (Graphics g = Graphics.FromImage(_drawGrid.bmp))
        //        {
        //            g.FillRectangle(new SolidBrush(ColorProvider.Instance.SelectedColor), col * pixelSize + 1, row * pixelSize + 1, pixelSize - 1, pixelSize - 1);
        //            //!TODO: si queremos que se vuelva a pintar las cuadriculas de la celdas 
        //        }

        //        ((Control)sender).Invalidate();
        //    }
        //}

        private void OnCanvasClick(object sender, MouseEventArgs e)
        {
            int pixelSize = _drawGrid.PixelSize;

            int col = e.X / pixelSize;
            int row = e.Y / pixelSize;

            if (col > _drawGrid.Columns || row > _drawGrid.Rows)
                return;
            _drawGrid.paintDrawing(col, row);
            ((Control)sender).Invalidate();
        }

    }
}
