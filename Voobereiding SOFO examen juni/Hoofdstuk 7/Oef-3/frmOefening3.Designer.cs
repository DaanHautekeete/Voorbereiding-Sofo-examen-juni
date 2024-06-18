namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_3
{
    partial class frmOefening3
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
            this.lblHoogsteIndexwaarde = new System.Windows.Forms.Label();
            this.lblLaagsteWaarde = new System.Windows.Forms.Label();
            this.lblHoogsteWaarde = new System.Windows.Forms.Label();
            this.lblAantalGetallen = new System.Windows.Forms.Label();
            this.lsbRandomGetallen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHoogsteIndexwaarde
            // 
            this.lblHoogsteIndexwaarde.AutoSize = true;
            this.lblHoogsteIndexwaarde.Location = new System.Drawing.Point(156, 111);
            this.lblHoogsteIndexwaarde.Name = "lblHoogsteIndexwaarde";
            this.lblHoogsteIndexwaarde.Size = new System.Drawing.Size(110, 13);
            this.lblHoogsteIndexwaarde.TabIndex = 3;
            this.lblHoogsteIndexwaarde.Text = "Hoogste indexwaarde";
            // 
            // lblLaagsteWaarde
            // 
            this.lblLaagsteWaarde.AutoSize = true;
            this.lblLaagsteWaarde.Location = new System.Drawing.Point(156, 76);
            this.lblLaagsteWaarde.Name = "lblLaagsteWaarde";
            this.lblLaagsteWaarde.Size = new System.Drawing.Size(83, 13);
            this.lblLaagsteWaarde.TabIndex = 4;
            this.lblLaagsteWaarde.Text = "Laagste waarde";
            // 
            // lblHoogsteWaarde
            // 
            this.lblHoogsteWaarde.AutoSize = true;
            this.lblHoogsteWaarde.Location = new System.Drawing.Point(156, 46);
            this.lblHoogsteWaarde.Name = "lblHoogsteWaarde";
            this.lblHoogsteWaarde.Size = new System.Drawing.Size(85, 13);
            this.lblHoogsteWaarde.TabIndex = 5;
            this.lblHoogsteWaarde.Text = "Hoogste waarde";
            // 
            // lblAantalGetallen
            // 
            this.lblAantalGetallen.AutoSize = true;
            this.lblAantalGetallen.Location = new System.Drawing.Point(156, 12);
            this.lblAantalGetallen.Name = "lblAantalGetallen";
            this.lblAantalGetallen.Size = new System.Drawing.Size(77, 13);
            this.lblAantalGetallen.TabIndex = 6;
            this.lblAantalGetallen.Text = "Aantal getallen";
            // 
            // lsbRandomGetallen
            // 
            this.lsbRandomGetallen.FormattingEnabled = true;
            this.lsbRandomGetallen.Location = new System.Drawing.Point(12, 12);
            this.lsbRandomGetallen.Name = "lsbRandomGetallen";
            this.lsbRandomGetallen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsbRandomGetallen.Size = new System.Drawing.Size(119, 342);
            this.lsbRandomGetallen.TabIndex = 2;
            // 
            // frmOefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 361);
            this.Controls.Add(this.lblHoogsteIndexwaarde);
            this.Controls.Add(this.lblLaagsteWaarde);
            this.Controls.Add(this.lblHoogsteWaarde);
            this.Controls.Add(this.lblAantalGetallen);
            this.Controls.Add(this.lsbRandomGetallen);
            this.Name = "frmOefening3";
            this.Text = "Hoofdstuk 7 - oefening 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoogsteIndexwaarde;
        private System.Windows.Forms.Label lblLaagsteWaarde;
        private System.Windows.Forms.Label lblHoogsteWaarde;
        private System.Windows.Forms.Label lblAantalGetallen;
        private System.Windows.Forms.ListBox lsbRandomGetallen;
    }
}