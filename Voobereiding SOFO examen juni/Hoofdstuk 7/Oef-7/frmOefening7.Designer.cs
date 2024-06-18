namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_7
{
    partial class frmOefening7
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
            this.lblWaardenArray = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWaardenArray
            // 
            this.lblWaardenArray.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblWaardenArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaardenArray.Location = new System.Drawing.Point(107, 9);
            this.lblWaardenArray.Name = "lblWaardenArray";
            this.lblWaardenArray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWaardenArray.Size = new System.Drawing.Size(128, 219);
            this.lblWaardenArray.TabIndex = 3;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(6, 9);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "GO!";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // frmOefening7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 237);
            this.Controls.Add(this.lblWaardenArray);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "frmOefening7";
            this.Text = "Hoofdstuk 7 - oefening 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWaardenArray;
        private System.Windows.Forms.Button btnToevoegen;
    }
}