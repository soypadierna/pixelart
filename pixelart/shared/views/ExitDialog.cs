using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelart.shared.views
{
    internal class ExitDialog
    {
        //Propiedades
        string title;
        string message;
        MessageBoxButtons buttons;
        MessageBoxIcon icon;

        //Constructor
        public ExitDialog(
            string title = "Cerrar canva",
            string message = "¿Deseas guardar los cambios?",
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel,
            MessageBoxIcon icon = MessageBoxIcon.Question)
        {
            this.title = title;
            this.message = message;
            this.buttons = buttons;
            this.icon = icon;
        }

        public void show(Action yes, Action no, Action cancel)
        {
            DialogResult view = MessageBox.Show(message, title, buttons, icon);

            switch (view)
            {
                case DialogResult.Yes:
                    yes?.Invoke();
                    break;
                case DialogResult.No:
                    no?.Invoke();
                    break;
                case DialogResult.Cancel:
                    cancel?.Invoke();
                    break;

            }
        }
    }
}
