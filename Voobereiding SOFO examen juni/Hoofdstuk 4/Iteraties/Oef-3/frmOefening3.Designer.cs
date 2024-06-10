namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_3
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
            this.lblSterren = new System.Windows.Forms.Label();
            this.btnToon = new System.Windows.Forms.Button();
            this.txtAantalSterren = new System.Windows.Forms.TextBox();
            this.lblAantalSterren = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSterren
            // 
            this.lblSterren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSterren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSterren.Location = new System.Drawing.Point(16, 97);
            this.lblSterren.Name = "lblSterren";
            this.lblSterren.Size = new System.Drawing.Size(772, 334);
            this.lblSterren.TabIndex = 7;
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(16, 55);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(75, 23);
            this.btnToon.TabIndex = 6;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // txtAantalSterren
            // 
            this.txtAantalSterren.Location = new System.Drawing.Point(150, 20);
            this.txtAantalSterren.Name = "txtAantalSterren";
            this.txtAantalSterren.Size = new System.Drawing.Size(141, 20);
            this.txtAantalSterren.TabIndex = 5;
            // 
            // lblAantalSterren
            // 
            this.lblAantalSterren.AutoSize = true;
            this.lblAantalSterren.Location = new System.Drawing.Point(13, 20);
            this.lblAantalSterren.Name = "lblAantalSterren";
            this.lblAantalSterren.Size = new System.Drawing.Size(130, 13);
            this.lblAantalSterren.TabIndex = 4;
            this.lblAantalSterren.Text = "Hoeveel sterren wil je zien";
            // 
            // frmOefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSterren);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.txtAantalSterren);
            this.Controls.Add(this.lblAantalSterren);
            this.Name = "frmOefening3";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSterren;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.TextBox txtAantalSterren;
        private System.Windows.Forms.Label lblAantalSterren;
    }
}