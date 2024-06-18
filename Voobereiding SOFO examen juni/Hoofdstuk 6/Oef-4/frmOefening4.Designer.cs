namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_4
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
            this.components = new System.ComponentModel.Container();
            this.lblTijdOver = new System.Windows.Forms.Label();
            this.btnWis = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAantalSeconden = new System.Windows.Forms.TextBox();
            this.lblUitleg = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTijdOver
            // 
            this.lblTijdOver.AutoSize = true;
            this.lblTijdOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdOver.Location = new System.Drawing.Point(97, 115);
            this.lblTijdOver.Name = "lblTijdOver";
            this.lblTijdOver.Size = new System.Drawing.Size(107, 20);
            this.lblTijdOver.TabIndex = 9;
            this.lblTijdOver.Text = "Je tijd is over!!";
            this.lblTijdOver.Visible = false;
            // 
            // btnWis
            // 
            this.btnWis.Location = new System.Drawing.Point(207, 62);
            this.btnWis.Name = "btnWis";
            this.btnWis.Size = new System.Drawing.Size(75, 23);
            this.btnWis.TabIndex = 8;
            this.btnWis.Text = "Wis";
            this.btnWis.UseVisualStyleBackColor = true;
            this.btnWis.Click += new System.EventHandler(this.btnWis_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAantalSeconden
            // 
            this.txtAantalSeconden.Location = new System.Drawing.Point(99, 42);
            this.txtAantalSeconden.Name = "txtAantalSeconden";
            this.txtAantalSeconden.Size = new System.Drawing.Size(100, 20);
            this.txtAantalSeconden.TabIndex = 6;
            this.txtAantalSeconden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitleg.Location = new System.Drawing.Point(66, 9);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(155, 20);
            this.lblUitleg.TabIndex = 5;
            this.lblUitleg.Text = "Geef je seconden in:";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // frmOefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 150);
            this.Controls.Add(this.lblTijdOver);
            this.Controls.Add(this.btnWis);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAantalSeconden);
            this.Controls.Add(this.lblUitleg);
            this.Name = "frmOefening4";
            this.Text = "Hoofdstuk 6 - oefening 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTijdOver;
        private System.Windows.Forms.Button btnWis;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAantalSeconden;
        private System.Windows.Forms.Label lblUitleg;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}