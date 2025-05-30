using pixelart.canva.entities;
using pixelart.canva.views;
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

namespace pixelart
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();

            //!TODO: Poner padings a los paneles

            //Cartel 1
            Sign sign1 = new Sign(Pixelart.boardOne, pnl1, btn1);
            pnl1 = sign1.panel;
            btn1 = sign1.button;

            //Cartel 2
            Sign sign2 = new Sign(Pixelart.flower, pnl2, btn2);
            pnl2 = sign2.panel;
            btn2 = sign2.button;

            //Cartel 3
            Sign sign3 = new Sign(Pixelart.boardOne, pnl3, btn3);
            pnl3 = sign3.panel;
            btn3 = sign3.button;
        }
    }
}
