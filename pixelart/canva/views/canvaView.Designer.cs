namespace pixelart.canva.views
{
    partial class canvaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Rubik Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(220, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(265, 86);
            this.title.TabIndex = 0;
            this.title.Text = "Titulo";
            // 
            // pnlMapa
            // 
            this.pnlMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMapa.Location = new System.Drawing.Point(220, 140);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(800, 400);
            this.pnlMapa.TabIndex = 1;
            // 
            // pnlColors
            // 
            this.pnlColors.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlColors.Location = new System.Drawing.Point(220, 560);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(800, 100);
            this.pnlColors.TabIndex = 2;
            // 
            // canvaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pnlColors);
            this.Controls.Add(this.pnlMapa);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Rubik", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "canvaView";
            this.Text = "Canva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.Panel pnlColors;
    }
}