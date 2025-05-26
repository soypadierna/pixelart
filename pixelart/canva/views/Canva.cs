using pixelart.canva.entities;
using pixelart.shared.entities;
using pixelart.shared.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.canva.views
{
    public partial class Canva : Form
    {
        private Pixelart _pixelart;
        public Canva(Pixelart pixelart)
        {
            InitializeComponent();
            _pixelart = pixelart;
            this.FormClosing += closing;
        }

        private void Canva_Load(object sender, EventArgs e)
        {
            Linen linen = new Linen(Pixelart.boardOne, pnlCanva);
            pnlCanva = linen.panel;
        }

        public static void show(Pixelart pixelart)
        {
            Form openCanva = Application.OpenForms
                .OfType<Canva>()
                .FirstOrDefault();

            if (openCanva != null)
            {
                openCanva.WindowState = FormWindowState.Normal;
                openCanva.BringToFront();
                openCanva.Activate();

                var dialog = new ExitDialog();

                dialog.show(
                    () => openCanva.Close(),
                    () => openCanva.Show(),
                    () => { }
                );
            }
            else
            {
                var canva = new Canva(pixelart);
                canva.Show();
            }
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            var dialog = new ExitDialog();
            bool shouldClose = false;

            dialog.show(
                () => { shouldClose = true; },
                () => { shouldClose = true; },  
                () => { shouldClose = false; }
            );

            if (!shouldClose) e.Cancel = true;

        }
    }
}
