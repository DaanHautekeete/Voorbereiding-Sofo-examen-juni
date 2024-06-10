namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_4
{
    partial class frmOefening4
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
            this.lblGrootsteGetal = new System.Windows.Forms.Label();
            this.btnGrootste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrootsteGetal
            // 
            this.lblGrootsteGetal.AutoSize = true;
            this.lblGrootsteGetal.Location = new System.Drawing.Point(13, 65);
            this.lblGrootsteGetal.Name = "lblGrootsteGetal";
            this.lblGrootsteGetal.Size = new System.Drawing.Size(35, 13);
            this.lblGrootsteGetal.TabIndex = 3;
            this.lblGrootsteGetal.Text = "label1";
            // 
            // btnGrootste
            // 
            this.btnGrootste.Location = new System.Drawing.Point(12, 12);
            this.btnGrootste.Name = "btnGrootste";
            this.btnGrootste.Size = new System.Drawing.Size(75, 23);
            this.btnGrootste.TabIndex = 2;
            this.btnGrootste.Text = "grootste";
            this.btnGrootste.UseVisualStyleBackColor = true;
            this.btnGrootste.Click += new System.EventHandler(this.btnGrootste_Click);
            // 
            // frmOefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 126);
            this.Controls.Add(this.lblGrootsteGetal);
            this.Controls.Add(this.btnGrootste);
            this.Name = "frmOefening4";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrootsteGetal;
        private System.Windows.Forms.Button btnGrootste;
    }
}