namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_5
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
            this.lblTafels = new System.Windows.Forms.Label();
            this.lsbTafels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTafels
            // 
            this.lblTafels.Location = new System.Drawing.Point(214, 12);
            this.lblTafels.Name = "lblTafels";
            this.lblTafels.Size = new System.Drawing.Size(181, 225);
            this.lblTafels.TabIndex = 3;
            // 
            // lsbTafels
            // 
            this.lsbTafels.FormattingEnabled = true;
            this.lsbTafels.Location = new System.Drawing.Point(12, 12);
            this.lsbTafels.Name = "lsbTafels";
            this.lsbTafels.Size = new System.Drawing.Size(180, 225);
            this.lsbTafels.TabIndex = 2;
            this.lsbTafels.SelectedIndexChanged += new System.EventHandler(this.lsbTafels_SelectedIndexChanged);
            // 
            // frmOefening5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 279);
            this.Controls.Add(this.lblTafels);
            this.Controls.Add(this.lsbTafels);
            this.Name = "frmOefening5";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTafels;
        private System.Windows.Forms.ListBox lsbTafels;
    }
}