namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_5
{
    partial class frmOefening5
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
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.btnBerekenLeeftijd = new System.Windows.Forms.Button();
            this.txtGeboortejaar = new System.Windows.Forms.TextBox();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijd.Location = new System.Drawing.Point(12, 122);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(435, 24);
            this.lblLeeftijd.TabIndex = 7;
            this.lblLeeftijd.Text = "Vul je geboortedatump in en druk op de knop";
            // 
            // btnBerekenLeeftijd
            // 
            this.btnBerekenLeeftijd.Location = new System.Drawing.Point(15, 53);
            this.btnBerekenLeeftijd.Name = "btnBerekenLeeftijd";
            this.btnBerekenLeeftijd.Size = new System.Drawing.Size(104, 35);
            this.btnBerekenLeeftijd.TabIndex = 6;
            this.btnBerekenLeeftijd.Text = "Bereken leeftijd";
            this.btnBerekenLeeftijd.UseVisualStyleBackColor = true;
            this.btnBerekenLeeftijd.Click += new System.EventHandler(this.btnBerekenLeeftijd_Click);
            // 
            // txtGeboortejaar
            // 
            this.txtGeboortejaar.Location = new System.Drawing.Point(208, 10);
            this.txtGeboortejaar.Name = "txtGeboortejaar";
            this.txtGeboortejaar.Size = new System.Drawing.Size(140, 20);
            this.txtGeboortejaar.TabIndex = 5;
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeboortedatum.Location = new System.Drawing.Point(12, 9);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(190, 18);
            this.lblGeboortedatum.TabIndex = 4;
            this.lblGeboortedatum.Text = "Geboortedatum (jjjj-mm-dd)";
            // 
            // frmOefening5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 156);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.btnBerekenLeeftijd);
            this.Controls.Add(this.txtGeboortejaar);
            this.Controls.Add(this.lblGeboortedatum);
            this.Name = "frmOefening5";
            this.Text = "Hoofdstuk 5 - oefening 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Button btnBerekenLeeftijd;
        private System.Windows.Forms.TextBox txtGeboortejaar;
        private System.Windows.Forms.Label lblGeboortedatum;
    }
}