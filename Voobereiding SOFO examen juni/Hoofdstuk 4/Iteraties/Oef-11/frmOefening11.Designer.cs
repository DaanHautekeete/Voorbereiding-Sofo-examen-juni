﻿namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_11
{
    partial class frmOefening11
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
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInvoeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoeren.Location = new System.Drawing.Point(12, 12);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(736, 375);
            this.btnInvoeren.TabIndex = 1;
            this.btnInvoeren.Text = "Voer het wachtwoord in";
            this.btnInvoeren.UseVisualStyleBackColor = false;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // frmOefening11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 408);
            this.Controls.Add(this.btnInvoeren);
            this.Name = "frmOefening11";
            this.Text = "Hoofdstuk 4 - iteraties - oefening 11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvoeren;
    }
}