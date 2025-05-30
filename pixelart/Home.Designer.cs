namespace pixelart
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.picFree = new System.Windows.Forms.PictureBox();
            this.pnlBar.SuspendLayout();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFree)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBar.Controls.Add(this.pnlNav);
            this.pnlBar.Location = new System.Drawing.Point(230, 48);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(800, 60);
            this.pnlBar.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Gray;
            this.pnlNav.Location = new System.Drawing.Point(200, 15);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(400, 30);
            this.pnlNav.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(90, 591);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(300, 40);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Ir";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(480, 591);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(300, 40);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Ir";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(870, 591);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(300, 40);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "ir";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(91, 175);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(300, 400);
            this.pnl1.TabIndex = 7;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(480, 175);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(300, 400);
            this.pnl2.TabIndex = 8;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.picFree);
            this.pnl3.Location = new System.Drawing.Point(870, 175);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(300, 400);
            this.pnl3.TabIndex = 9;
            // 
            // picFree
            // 
            this.picFree.BackgroundImage = global::pixelart.Properties.Resources.mas_simbolo_negro;
            this.picFree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFree.Location = new System.Drawing.Point(114, 148);
            this.picFree.Name = "picFree";
            this.picFree.Size = new System.Drawing.Size(84, 78);
            this.picFree.TabIndex = 0;
            this.picFree.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pnlBar);
            this.Font = new System.Drawing.Font("Rubik", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Home";
            this.Text = "Piselart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.PictureBox picFree;
    }
}

