namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_7
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
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.btnTonen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.Location = new System.Drawing.Point(12, 42);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(623, 252);
            this.lblUitvoer.TabIndex = 3;
            // 
            // btnTonen
            // 
            this.btnTonen.Location = new System.Drawing.Point(281, 7);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(75, 23);
            this.btnTonen.TabIndex = 2;
            this.btnTonen.Text = "Tonen";
            this.btnTonen.UseVisualStyleBackColor = true;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // frmOefening7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 323);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnTonen);
            this.Name = "frmOefening7";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUitvoer;
        private System.Windows.Forms.Button btnTonen;
    }
}