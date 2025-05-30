namespace pixelart.canva.views
{
    partial class Canva
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
            this.pnlCanva = new System.Windows.Forms.Panel();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.pnlPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Rubik Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(128, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(265, 86);
            this.title.TabIndex = 0;
            this.title.Text = "Titulo";
            // 
            // pnlCanva
            // 
            this.pnlCanva.BackColor = System.Drawing.Color.White;
            this.pnlCanva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanva.Location = new System.Drawing.Point(128, 142);
            this.pnlCanva.Name = "pnlCanva";
            this.pnlCanva.Size = new System.Drawing.Size(800, 400);
            this.pnlCanva.TabIndex = 1;
            // 
            // pnlColors
            // 
            this.pnlColors.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlColors.Location = new System.Drawing.Point(128, 562);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(800, 100);
            this.pnlColors.TabIndex = 2;
            // 
            // pnlPalette
            // 
            this.pnlPalette.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPalette.Location = new System.Drawing.Point(948, 142);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(180, 520);
            this.pnlPalette.TabIndex = 4;
            // 
            // Canva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pnlPalette);
            this.Controls.Add(this.pnlColors);
            this.Controls.Add(this.pnlCanva);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Rubik", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Canva";
            this.Text = "Canva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel pnlCanva;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.FlowLayoutPanel pnlPalette;
    }
}