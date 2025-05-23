namespace pixelart
{
    partial class Form1
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
            this.pnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl1.Location = new System.Drawing.Point(90, 175);
            this.pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(300, 400);
            this.pnl1.TabIndex = 1;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl2.Location = new System.Drawing.Point(480, 175);
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(300, 400);
            this.pnl2.TabIndex = 2;
            // 
            // pnl3
            // 
            this.pnl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl3.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl3.Location = new System.Drawing.Point(870, 175);
            this.pnl3.Margin = new System.Windows.Forms.Padding(0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(300, 400);
            this.pnl3.TabIndex = 3;
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
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
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
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(870, 591);
            this.btnMake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(300, 40);
            this.btnMake.TabIndex = 6;
            this.btnMake.Text = "Crear";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnlBar);
            this.Font = new System.Drawing.Font("Rubik", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnl1;
        private System.Windows.Forms.FlowLayoutPanel pnl2;
        private System.Windows.Forms.FlowLayoutPanel pnl3;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnMake;
    }
}

