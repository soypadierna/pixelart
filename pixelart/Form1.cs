using pixelart.shared.views;
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

namespace pixelart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnNav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e) => Canva.show();

        private void btnMake_Click(object sender, EventArgs e) => Canva.show();

        private void btn1_Click(object sender, EventArgs e) => Canva.show();

        
    }
}
