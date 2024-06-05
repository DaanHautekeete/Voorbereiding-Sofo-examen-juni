namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_2
{
    partial class frmOefening2
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
            this.lblSom = new System.Windows.Forms.Label();
            this.lblIngegevenGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSom.Location = new System.Drawing.Point(30, 76);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(47, 16);
            this.lblSom.TabIndex = 3;
            this.lblSom.Text = "uitvoer";
            // 
            // lblIngegevenGetal
            // 
            this.lblIngegevenGetal.AutoSize = true;
            this.lblIngegevenGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngegevenGetal.Location = new System.Drawing.Point(30, 26);
            this.lblIngegevenGetal.Name = "lblIngegevenGetal";
            this.lblIngegevenGetal.Size = new System.Drawing.Size(47, 16);
            this.lblIngegevenGetal.TabIndex = 2;
            this.lblIngegevenGetal.Text = "uitvoer";
            // 
            // frmOefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 199);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblIngegevenGetal);
            this.Name = "frmOefening2";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Label lblIngegevenGetal;
    }
}