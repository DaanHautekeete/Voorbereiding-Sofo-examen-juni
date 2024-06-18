namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_13
{
    partial class frmOefening13
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
            this.lsbDefecteComputers = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.checkedlistboxComputers = new System.Windows.Forms.CheckedListBox();
            this.lblDefecteComputers = new System.Windows.Forms.Label();
            this.lblComputers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbDefecteComputers
            // 
            this.lsbDefecteComputers.FormattingEnabled = true;
            this.lsbDefecteComputers.Location = new System.Drawing.Point(263, 42);
            this.lsbDefecteComputers.Name = "lsbDefecteComputers";
            this.lsbDefecteComputers.ScrollAlwaysVisible = true;
            this.lsbDefecteComputers.Size = new System.Drawing.Size(224, 264);
            this.lsbDefecteComputers.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(16, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Location = new System.Drawing.Point(16, 223);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(131, 27);
            this.btnToevoegen.TabIndex = 10;
            this.btnToevoegen.Text = "Defecte PC\'s";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // checkedlistboxComputers
            // 
            this.checkedlistboxComputers.CheckOnClick = true;
            this.checkedlistboxComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedlistboxComputers.FormattingEnabled = true;
            this.checkedlistboxComputers.Items.AddRange(new object[] {
            "PC 01",
            "PC 02",
            "PC 03",
            "PC 04",
            "PC 05",
            "PC 06",
            "PC 07",
            "PC 08"});
            this.checkedlistboxComputers.Location = new System.Drawing.Point(16, 42);
            this.checkedlistboxComputers.Name = "checkedlistboxComputers";
            this.checkedlistboxComputers.Size = new System.Drawing.Size(131, 174);
            this.checkedlistboxComputers.TabIndex = 9;
            // 
            // lblDefecteComputers
            // 
            this.lblDefecteComputers.AutoSize = true;
            this.lblDefecteComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefecteComputers.Location = new System.Drawing.Point(260, 10);
            this.lblDefecteComputers.Name = "lblDefecteComputers";
            this.lblDefecteComputers.Size = new System.Drawing.Size(112, 18);
            this.lblDefecteComputers.TabIndex = 8;
            this.lblDefecteComputers.Text = "Defecte PC\'s ";
            // 
            // lblComputers
            // 
            this.lblComputers.AutoSize = true;
            this.lblComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputers.Location = new System.Drawing.Point(13, 10);
            this.lblComputers.Name = "lblComputers";
            this.lblComputers.Size = new System.Drawing.Size(134, 18);
            this.lblComputers.TabIndex = 7;
            this.lblComputers.Text = "Computers E504";
            // 
            // frmOefening13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 320);
            this.Controls.Add(this.lsbDefecteComputers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.checkedlistboxComputers);
            this.Controls.Add(this.lblDefecteComputers);
            this.Controls.Add(this.lblComputers);
            this.Name = "frmOefening13";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDefecteComputers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.CheckedListBox checkedlistboxComputers;
        private System.Windows.Forms.Label lblDefecteComputers;
        private System.Windows.Forms.Label lblComputers;
    }
}