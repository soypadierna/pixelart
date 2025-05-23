using pixelart.canva.entities;
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
    public partial class canvaView : Form
    {
        public canvaView()
        {
            InitializeComponent();
            this.FormClosing += closing;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if (!Canva.close()) e.Cancel = true;

        }
    }
}
