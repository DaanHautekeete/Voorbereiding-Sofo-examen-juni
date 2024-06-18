namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_14
{
    partial class frmOefening14
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cobAfbeeldingen = new System.Windows.Forms.ComboBox();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(12, 54);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(397, 266);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            // 
            // cobAfbeeldingen
            // 
            this.cobAfbeeldingen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobAfbeeldingen.FormattingEnabled = true;
            this.cobAfbeeldingen.Location = new System.Drawing.Point(109, 12);
            this.cobAfbeeldingen.Name = "cobAfbeeldingen";
            this.cobAfbeeldingen.Size = new System.Drawing.Size(300, 21);
            this.cobAfbeeldingen.TabIndex = 4;
            this.cobAfbeeldingen.SelectedIndexChanged += new System.EventHandler(this.cobAfbeeldingen_SelectedIndexChanged);
            // 
            // btnBladeren
            // 
            this.btnBladeren.Location = new System.Drawing.Point(12, 10);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(75, 23);
            this.btnBladeren.TabIndex = 3;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOefening14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 337);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.cobAfbeeldingen);
            this.Controls.Add(this.btnBladeren);
            this.Name = "frmOefening14";
            this.Text = "Hoofdstuk  4 - iteraties - oefening 14";
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cobAfbeeldingen;
        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}