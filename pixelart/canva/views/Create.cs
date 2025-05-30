using pixelart.canva.entities;
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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();

            txtColumns.KeyPress += OnlyNumbers_KeyPress;
            txtRows.KeyPress += OnlyNumbers_KeyPress;
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public Pixelart FreeBoard()
        {

            int[,] matrix = new int[int.Parse(txtColumns.Text), int.Parse(txtRows.Text)];

            Dictionary<int, Color> colors = new Dictionary<int, Color>
            {
                { 1, Color.Black }
            };

            return new Pixelart("Tablero Libre", colors, matrix, true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtColumns.Text == "" || txtRows.Text == "")
                return;

            Canva.show(FreeBoard());
            this.Close();
        }
    }
}
