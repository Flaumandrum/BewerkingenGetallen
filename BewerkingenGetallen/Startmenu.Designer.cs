namespace BewerkingenGetallen
{
    partial class Startmenu
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnOptellen = new System.Windows.Forms.Button();
            this.btnVerminderen = new System.Windows.Forms.Button();
            this.btnVermenigvuldigen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(47, 21);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(429, 72);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Welkom\r\nDit programma maakt bewerkingen met 2 getallen.\r\nKies uw bewerking.";
            // 
            // btnOptellen
            // 
            this.btnOptellen.Location = new System.Drawing.Point(146, 107);
            this.btnOptellen.Name = "btnOptellen";
            this.btnOptellen.Size = new System.Drawing.Size(217, 37);
            this.btnOptellen.TabIndex = 1;
            this.btnOptellen.Text = "Optellen";
            this.btnOptellen.UseVisualStyleBackColor = true;
            this.btnOptellen.Click += new System.EventHandler(this.btnOptellen_Click);
            // 
            // btnVerminderen
            // 
            this.btnVerminderen.Location = new System.Drawing.Point(146, 150);
            this.btnVerminderen.Name = "btnVerminderen";
            this.btnVerminderen.Size = new System.Drawing.Size(217, 37);
            this.btnVerminderen.TabIndex = 2;
            this.btnVerminderen.Text = "Verminderen";
            this.btnVerminderen.UseVisualStyleBackColor = true;
            this.btnVerminderen.Click += new System.EventHandler(this.btnVerminderen_Click);
            // 
            // btnVermenigvuldigen
            // 
            this.btnVermenigvuldigen.Location = new System.Drawing.Point(146, 193);
            this.btnVermenigvuldigen.Name = "btnVermenigvuldigen";
            this.btnVermenigvuldigen.Size = new System.Drawing.Size(217, 37);
            this.btnVermenigvuldigen.TabIndex = 3;
            this.btnVermenigvuldigen.Text = "Vermenigvuldigen";
            this.btnVermenigvuldigen.UseVisualStyleBackColor = true;
            this.btnVermenigvuldigen.Click += new System.EventHandler(this.btnVermenigvuldigen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(146, 236);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(217, 37);
            this.btnAfsluiten.TabIndex = 4;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // Startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(512, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnVermenigvuldigen);
            this.Controls.Add(this.btnVerminderen);
            this.Controls.Add(this.btnOptellen);
            this.Controls.Add(this.lblIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Startmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnOptellen;
        private System.Windows.Forms.Button btnVerminderen;
        private System.Windows.Forms.Button btnVermenigvuldigen;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

