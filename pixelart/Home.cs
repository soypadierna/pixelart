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

            //Free Board
            create();

        }

        private void create()
        {
            Create create = new Create();
            Label _label = new Label
            {
                Text = "Tablero Libre",
                Height = 40,
                TextAlign = ContentAlignment.BottomLeft,
                Dock = DockStyle.Bottom,
                Font = new Font("Rubik Black", 24F, FontStyle.Bold),
                BackColor = Color.White,
            };

            _label.Click += (s, e) => create.ShowDialog();
            picFree.Click += (s, e) => create.ShowDialog();
            pnl3.Click += (s, e1) => create.ShowDialog();
            btn3.Click += (s, e1) => create.ShowDialog();

            pnl3.Controls.Add(_label);
            _label.BringToFront();
        }
    }
}
