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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();

            List<Pixelart> pixelarts = Pixelart.list;

            //Cartel 1
            lb1.Text = pixelarts[0].Name;
            //añadir imagen
            btn1.Click += (s, e1) => Canva.show(pixelarts[0]);
            lb1.Click += (s, e1) => Canva.show(pixelarts[0]);
            pnl1.Click += (s, e1) => Canva.show(pixelarts[0]);

            //Cartel 2
            lb2.Text = pixelarts[1].Name;
            //añadir imagen
            btn2.Click += (s, e1) => Canva.show(pixelarts[1]);
            lb2.Click += (s, e1) => Canva.show(pixelarts[1]);
            pnl2.Click += (s, e1) => Canva.show(pixelarts[1]);

            //Cartel 3
            lb3.Text = pixelarts[2].Name;
            //añadir imagen
            btn3.Click += (s, e1) => Canva.show(pixelarts[2]);
            lb3.Click += (s, e1) => Canva.show(pixelarts[2]);
            pnl3.Click += (s, e1) => Canva.show(pixelarts[2]);
        }   
    }
}
