namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_1
{
    partial class frmOefening1
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
            this.trackBarBlauw = new System.Windows.Forms.TrackBar();
            this.trackBarGroen = new System.Windows.Forms.TrackBar();
            this.trackBarRood = new System.Windows.Forms.TrackBar();
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblGroen = new System.Windows.Forms.Label();
            this.lblBlauw = new System.Windows.Forms.Label();
            this.lblRood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlauw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRood)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarBlauw
            // 
            this.trackBarBlauw.Location = new System.Drawing.Point(97, 152);
            this.trackBarBlauw.Maximum = 255;
            this.trackBarBlauw.Name = "trackBarBlauw";
            this.trackBarBlauw.Size = new System.Drawing.Size(449, 45);
            this.trackBarBlauw.TabIndex = 13;
            this.trackBarBlauw.Scroll += new System.EventHandler(this.trackBarBlauw_Scroll);
            // 
            // trackBarGroen
            // 
            this.trackBarGroen.Location = new System.Drawing.Point(97, 84);
            this.trackBarGroen.Maximum = 255;
            this.trackBarGroen.Name = "trackBarGroen";
            this.trackBarGroen.Size = new System.Drawing.Size(449, 45);
            this.trackBarGroen.TabIndex = 12;
            this.trackBarGroen.Scroll += new System.EventHandler(this.trackBarGroen_Scroll);
            // 
            // trackBarRood
            // 
            this.trackBarRood.Location = new System.Drawing.Point(97, 22);
            this.trackBarRood.Maximum = 255;
            this.trackBarRood.Name = "trackBarRood";
            this.trackBarRood.Size = new System.Drawing.Size(449, 45);
            this.trackBarRood.TabIndex = 11;
            this.trackBarRood.Scroll += new System.EventHandler(this.trackBarRood_Scroll);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.BackColor = System.Drawing.Color.White;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.ForeColor = System.Drawing.Color.Black;
            this.lblRGB.Location = new System.Drawing.Point(16, 231);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(87, 18);
            this.lblRGB.TabIndex = 10;
            this.lblRGB.Text = "RGB (0,0,0)";
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroen
            // 
            this.lblGroen.AutoSize = true;
            this.lblGroen.BackColor = System.Drawing.Color.White;
            this.lblGroen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroen.ForeColor = System.Drawing.Color.Black;
            this.lblGroen.Location = new System.Drawing.Point(16, 84);
            this.lblGroen.Name = "lblGroen";
            this.lblGroen.Size = new System.Drawing.Size(50, 18);
            this.lblGroen.TabIndex = 9;
            this.lblGroen.Text = "Groen";
            this.lblGroen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlauw
            // 
            this.lblBlauw.AutoSize = true;
            this.lblBlauw.BackColor = System.Drawing.Color.White;
            this.lblBlauw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlauw.ForeColor = System.Drawing.Color.Black;
            this.lblBlauw.Location = new System.Drawing.Point(16, 152);
            this.lblBlauw.Name = "lblBlauw";
            this.lblBlauw.Size = new System.Drawing.Size(48, 18);
            this.lblBlauw.TabIndex = 8;
            this.lblBlauw.Text = "Blauw";
            this.lblBlauw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRood
            // 
            this.lblRood.AutoSize = true;
            this.lblRood.BackColor = System.Drawing.Color.White;
            this.lblRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRood.ForeColor = System.Drawing.Color.Black;
            this.lblRood.Location = new System.Drawing.Point(16, 22);
            this.lblRood.Name = "lblRood";
            this.lblRood.Size = new System.Drawing.Size(45, 18);
            this.lblRood.TabIndex = 7;
            this.lblRood.Text = "Rood";
            this.lblRood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 265);
            this.Controls.Add(this.trackBarBlauw);
            this.Controls.Add(this.trackBarGroen);
            this.Controls.Add(this.trackBarRood);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblGroen);
            this.Controls.Add(this.lblBlauw);
            this.Controls.Add(this.lblRood);
            this.Name = "frmOefening1";
            this.Text = "Hoofdstuk 5 - oefening 1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlauw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarBlauw;
        private System.Windows.Forms.TrackBar trackBarGroen;
        private System.Windows.Forms.TrackBar trackBarRood;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblGroen;
        private System.Windows.Forms.Label lblBlauw;
        private System.Windows.Forms.Label lblRood;
    }
}