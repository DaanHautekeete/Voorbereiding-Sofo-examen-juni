namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_3
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
            this.components = new System.ComponentModel.Container();
            this.lblKlok = new System.Windows.Forms.Label();
            this.tmrKlok = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKlok
            // 
            this.lblKlok.AutoSize = true;
            this.lblKlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlok.ForeColor = System.Drawing.Color.White;
            this.lblKlok.Location = new System.Drawing.Point(98, 30);
            this.lblKlok.Name = "lblKlok";
            this.lblKlok.Size = new System.Drawing.Size(319, 55);
            this.lblKlok.TabIndex = 1;
            this.lblKlok.Text = "klok komt hier";
            this.lblKlok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrKlok
            // 
            this.tmrKlok.Interval = 1;
            this.tmrKlok.Tick += new System.EventHandler(this.tmrKlok_Tick);
            // 
            // frmOefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(544, 123);
            this.Controls.Add(this.lblKlok);
            this.Name = "frmOefening3";
            this.Text = "Hoofdstuk 6 - oefening 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlok;
        private System.Windows.Forms.Timer tmrKlok;
    }
}