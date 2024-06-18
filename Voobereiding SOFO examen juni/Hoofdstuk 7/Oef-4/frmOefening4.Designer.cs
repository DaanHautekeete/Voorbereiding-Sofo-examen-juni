namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_4
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
            this.btnOmdraaien = new System.Windows.Forms.Button();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.lsbOmgekeerd = new System.Windows.Forms.ListBox();
            this.lsbAlfabetisch = new System.Windows.Forms.ListBox();
            this.lsbStandaard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOmdraaien
            // 
            this.btnOmdraaien.Location = new System.Drawing.Point(324, 175);
            this.btnOmdraaien.Name = "btnOmdraaien";
            this.btnOmdraaien.Size = new System.Drawing.Size(120, 23);
            this.btnOmdraaien.TabIndex = 7;
            this.btnOmdraaien.Text = "Omkeren";
            this.btnOmdraaien.UseVisualStyleBackColor = true;
            this.btnOmdraaien.Click += new System.EventHandler(this.btnOmdraaien_Click);
            // 
            // btnSorteer
            // 
            this.btnSorteer.Location = new System.Drawing.Point(168, 175);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(120, 23);
            this.btnSorteer.TabIndex = 8;
            this.btnSorteer.Text = "Sorteer";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // lsbOmgekeerd
            // 
            this.lsbOmgekeerd.FormattingEnabled = true;
            this.lsbOmgekeerd.Location = new System.Drawing.Point(324, 12);
            this.lsbOmgekeerd.Name = "lsbOmgekeerd";
            this.lsbOmgekeerd.Size = new System.Drawing.Size(120, 147);
            this.lsbOmgekeerd.TabIndex = 6;
            // 
            // lsbAlfabetisch
            // 
            this.lsbAlfabetisch.FormattingEnabled = true;
            this.lsbAlfabetisch.Location = new System.Drawing.Point(168, 12);
            this.lsbAlfabetisch.Name = "lsbAlfabetisch";
            this.lsbAlfabetisch.Size = new System.Drawing.Size(120, 147);
            this.lsbAlfabetisch.TabIndex = 5;
            // 
            // lsbStandaard
            // 
            this.lsbStandaard.FormattingEnabled = true;
            this.lsbStandaard.Location = new System.Drawing.Point(12, 12);
            this.lsbStandaard.Name = "lsbStandaard";
            this.lsbStandaard.Size = new System.Drawing.Size(120, 147);
            this.lsbStandaard.TabIndex = 4;
            // 
            // frmOefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 210);
            this.Controls.Add(this.btnOmdraaien);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.lsbOmgekeerd);
            this.Controls.Add(this.lsbAlfabetisch);
            this.Controls.Add(this.lsbStandaard);
            this.Name = "frmOefening4";
            this.Text = "Hoofdstuk 7 - oefening 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOmdraaien;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.ListBox lsbOmgekeerd;
        private System.Windows.Forms.ListBox lsbAlfabetisch;
        private System.Windows.Forms.ListBox lsbStandaard;
    }
}