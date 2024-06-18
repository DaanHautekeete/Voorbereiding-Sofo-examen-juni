namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_6
{
    partial class frmOefening6
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.picSaai = new System.Windows.Forms.PictureBox();
            this.picLeuk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSaai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeuk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(12, 18);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(164, 20);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "Programmeren is....";
            // 
            // picSaai
            // 
            this.picSaai.Image = global::Voobereiding_SOFO_examen_juni.Properties.Resources.bad;
            this.picSaai.Location = new System.Drawing.Point(167, 164);
            this.picSaai.Name = "picSaai";
            this.picSaai.Size = new System.Drawing.Size(103, 66);
            this.picSaai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaai.TabIndex = 5;
            this.picSaai.TabStop = false;
            this.picSaai.MouseEnter += new System.EventHandler(this.picSaai_MouseEnter);
            // 
            // picLeuk
            // 
            this.picLeuk.Image = global::Voobereiding_SOFO_examen_juni.Properties.Resources.good;
            this.picLeuk.Location = new System.Drawing.Point(332, 164);
            this.picLeuk.Name = "picLeuk";
            this.picLeuk.Size = new System.Drawing.Size(103, 66);
            this.picLeuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeuk.TabIndex = 4;
            this.picLeuk.TabStop = false;
            this.picLeuk.Click += new System.EventHandler(this.picLeuk_Click);
            // 
            // frmOefening6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.picSaai);
            this.Controls.Add(this.picLeuk);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmOefening6";
            this.Text = "Hoofdstuk 6 - oefening 6";
            ((System.ComponentModel.ISupportInitialize)(this.picSaai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaai;
        private System.Windows.Forms.PictureBox picLeuk;
        private System.Windows.Forms.Label lblTitel;
    }
}