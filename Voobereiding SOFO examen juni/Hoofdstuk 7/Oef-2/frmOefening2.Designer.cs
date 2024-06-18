namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_2
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
            this.btnToonMaand = new System.Windows.Forms.Button();
            this.txtGeboortedatum = new System.Windows.Forms.TextBox();
            this.lblMaandVanGeboorte = new System.Windows.Forms.Label();
            this.lblUitleg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToonMaand
            // 
            this.btnToonMaand.Location = new System.Drawing.Point(132, 30);
            this.btnToonMaand.Name = "btnToonMaand";
            this.btnToonMaand.Size = new System.Drawing.Size(75, 23);
            this.btnToonMaand.TabIndex = 6;
            this.btnToonMaand.Text = "Go!";
            this.btnToonMaand.UseVisualStyleBackColor = true;
            this.btnToonMaand.Click += new System.EventHandler(this.btnToonMaand_Click);
            // 
            // txtGeboortedatum
            // 
            this.txtGeboortedatum.Location = new System.Drawing.Point(15, 34);
            this.txtGeboortedatum.Name = "txtGeboortedatum";
            this.txtGeboortedatum.Size = new System.Drawing.Size(100, 20);
            this.txtGeboortedatum.TabIndex = 5;
            // 
            // lblMaandVanGeboorte
            // 
            this.lblMaandVanGeboorte.AutoSize = true;
            this.lblMaandVanGeboorte.Location = new System.Drawing.Point(12, 71);
            this.lblMaandVanGeboorte.Name = "lblMaandVanGeboorte";
            this.lblMaandVanGeboorte.Size = new System.Drawing.Size(0, 13);
            this.lblMaandVanGeboorte.TabIndex = 3;
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Location = new System.Drawing.Point(12, 9);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(196, 13);
            this.lblUitleg.TabIndex = 4;
            this.lblUitleg.Text = "Geef je geboortedatum in (dd/mm/yyyy).";
            // 
            // frmOefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 114);
            this.Controls.Add(this.btnToonMaand);
            this.Controls.Add(this.txtGeboortedatum);
            this.Controls.Add(this.lblMaandVanGeboorte);
            this.Controls.Add(this.lblUitleg);
            this.Name = "frmOefening2";
            this.Text = "Hoofdstuk 7 - oefening 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToonMaand;
        private System.Windows.Forms.TextBox txtGeboortedatum;
        private System.Windows.Forms.Label lblMaandVanGeboorte;
        private System.Windows.Forms.Label lblUitleg;
    }
}