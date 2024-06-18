namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_1
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
            this.components = new System.ComponentModel.Container();
            this.picAfbeelding = new System.Windows.Forms.PictureBox();
            this.tmrAfbeelding = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // picAfbeelding
            // 
            this.picAfbeelding.Location = new System.Drawing.Point(39, 12);
            this.picAfbeelding.Name = "picAfbeelding";
            this.picAfbeelding.Size = new System.Drawing.Size(328, 282);
            this.picAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAfbeelding.TabIndex = 1;
            this.picAfbeelding.TabStop = false;
            // 
            // tmrAfbeelding
            // 
            this.tmrAfbeelding.Interval = 1000;
            this.tmrAfbeelding.Tick += new System.EventHandler(this.tmrAfbeelding_Tick);
            // 
            // frmOefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.picAfbeelding);
            this.Name = "frmOefening1";
            this.Text = "Hoofdstuk 6 - oefening 1";
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeelding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAfbeelding;
        private System.Windows.Forms.Timer tmrAfbeelding;
    }
}