using pixelart.canva.views;
using pixelart.shared.views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pixelart.canva.entities
{
    internal static class Canva
    {

        //Falta admintrar el cierre de la ventana
        public static void show()
        {
            // Busca si ya hay un canvaView abierto
            Form openCanva = Application.OpenForms
                .OfType<canvaView>()
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
                var canva = new canvaView();
                canva.Show();
            }
        }
    
        public static bool close()
        {
            var dialog = new ExitDialog();
            bool shouldClose = false;

            dialog.show(
                () => { shouldClose = true; },   // Yes
                () => { shouldClose = true; },   // No
                () => { shouldClose = false; }   // Cancel (o X)
            );
            return shouldClose;
        }
    }
}