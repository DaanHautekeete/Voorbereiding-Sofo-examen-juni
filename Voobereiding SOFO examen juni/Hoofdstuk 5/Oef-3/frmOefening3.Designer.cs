﻿namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_3
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
            this.txtClientNummer = new System.Windows.Forms.TextBox();
            this.txtControleCijfer = new System.Windows.Forms.TextBox();
            this.txtBanknummer = new System.Windows.Forms.TextBox();
            this.lblBankrekeningnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClientNummer
            // 
            this.txtClientNummer.Location = new System.Drawing.Point(191, 20);
            this.txtClientNummer.MaxLength = 7;
            this.txtClientNummer.Name = "txtClientNummer";
            this.txtClientNummer.Size = new System.Drawing.Size(100, 20);
            this.txtClientNummer.TabIndex = 2;
            // 
            // txtControleCijfer
            // 
            this.txtControleCijfer.Location = new System.Drawing.Point(297, 20);
            this.txtControleCijfer.MaxLength = 2;
            this.txtControleCijfer.Name = "txtControleCijfer";
            this.txtControleCijfer.Size = new System.Drawing.Size(57, 20);
            this.txtControleCijfer.TabIndex = 3;
            this.txtControleCijfer.TextChanged += new System.EventHandler(this.txtControleCijfer_TextChanged);
            // 
            // txtBanknummer
            // 
            this.txtBanknummer.Location = new System.Drawing.Point(128, 20);
            this.txtBanknummer.MaxLength = 3;
            this.txtBanknummer.Name = "txtBanknummer";
            this.txtBanknummer.Size = new System.Drawing.Size(57, 20);
            this.txtBanknummer.TabIndex = 1;
            // 
            // lblBankrekeningnummer
            // 
            this.lblBankrekeningnummer.AutoSize = true;
            this.lblBankrekeningnummer.Location = new System.Drawing.Point(12, 23);
            this.lblBankrekeningnummer.Name = "lblBankrekeningnummer";
            this.lblBankrekeningnummer.Size = new System.Drawing.Size(110, 13);
            this.lblBankrekeningnummer.TabIndex = 3;
            this.lblBankrekeningnummer.Text = "Bankrekeningnummer";
            // 
            // frmOefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 62);
            this.Controls.Add(this.txtClientNummer);
            this.Controls.Add(this.txtControleCijfer);
            this.Controls.Add(this.txtBanknummer);
            this.Controls.Add(this.lblBankrekeningnummer);
            this.Name = "frmOefening3";
            this.Text = "Hoofdstuk 5 - oefening 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientNummer;
        private System.Windows.Forms.TextBox txtControleCijfer;
        private System.Windows.Forms.TextBox txtBanknummer;
        private System.Windows.Forms.Label lblBankrekeningnummer;
    }
}