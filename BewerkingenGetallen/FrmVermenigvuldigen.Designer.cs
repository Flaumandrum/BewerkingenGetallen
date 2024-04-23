namespace BewerkingenGetallen
{
    partial class FrmVermenigvuldigen
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(216, 146);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(151, 41);
            this.btnAnnuleren.TabIndex = 11;
            this.btnAnnuleren.Text = "Annuleer";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(31, 146);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(151, 41);
            this.btnBereken.TabIndex = 10;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(136, 85);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(231, 29);
            this.txtGetal2.TabIndex = 9;
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(136, 29);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(231, 29);
            this.txtGetal1.TabIndex = 8;
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(27, 88);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(73, 24);
            this.lblGetal2.TabIndex = 7;
            this.lblGetal2.Text = "Getal 2:";
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(27, 32);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(73, 24);
            this.lblGetal1.TabIndex = 6;
            this.lblGetal1.Text = "Getal 1:";
            // 
            // FrmVermenigvuldigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(397, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVermenigvuldigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVermenigvuldigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblGetal1;
    }
}