namespace testprüfung
{
    partial class CKugelDlg
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblUmfang = new System.Windows.Forms.Label();
            this.lblSchnittflaeche = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtUmfang = new System.Windows.Forms.TextBox();
            this.txtSchnittflaeche = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(29, 25);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(50, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // lblUmfang
            // 
            this.lblUmfang.AutoSize = true;
            this.lblUmfang.Location = new System.Drawing.Point(29, 58);
            this.lblUmfang.Name = "lblUmfang";
            this.lblUmfang.Size = new System.Drawing.Size(54, 16);
            this.lblUmfang.TabIndex = 1;
            this.lblUmfang.Text = "Umfang";
            // 
            // lblSchnittflaeche
            // 
            this.lblSchnittflaeche.AutoSize = true;
            this.lblSchnittflaeche.Location = new System.Drawing.Point(29, 92);
            this.lblSchnittflaeche.Name = "lblSchnittflaeche";
            this.lblSchnittflaeche.Size = new System.Drawing.Size(82, 16);
            this.lblSchnittflaeche.TabIndex = 2;
            this.lblSchnittflaeche.Text = "Schnittfläche";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(29, 123);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(60, 16);
            this.lblVolumen.TabIndex = 3;
            this.lblVolumen.Text = "Volumen";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(139, 22);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 4;
            // 
            // txtUmfang
            // 
            this.txtUmfang.Location = new System.Drawing.Point(139, 55);
            this.txtUmfang.Name = "txtUmfang";
            this.txtUmfang.Size = new System.Drawing.Size(100, 22);
            this.txtUmfang.TabIndex = 5;
            // 
            // txtSchnittflaeche
            // 
            this.txtSchnittflaeche.Location = new System.Drawing.Point(139, 89);
            this.txtSchnittflaeche.Name = "txtSchnittflaeche";
            this.txtSchnittflaeche.Size = new System.Drawing.Size(100, 22);
            this.txtSchnittflaeche.TabIndex = 6;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(139, 120);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(100, 22);
            this.txtVolumen.TabIndex = 7;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(276, 22);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(120, 22);
            this.btnBerechnen.TabIndex = 8;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(276, 120);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(121, 22);
            this.btnSchliessen.TabIndex = 9;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(273, 92);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(47, 16);
            this.lblAnzahl.TabIndex = 10;
            this.lblAnzahl.Text = "Anzahl";
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Enabled = false;
            this.txtAnzahl.Location = new System.Drawing.Point(326, 89);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(71, 22);
            this.txtAnzahl.TabIndex = 11;
            // 
            // CKugelDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 169);
            this.Controls.Add(this.txtAnzahl);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtSchnittflaeche);
            this.Controls.Add(this.txtUmfang);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblSchnittflaeche);
            this.Controls.Add(this.lblUmfang);
            this.Controls.Add(this.lblRadius);
            this.Name = "CKugelDlg";
            this.Text = "Kugel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblUmfang;
        private System.Windows.Forms.Label lblSchnittflaeche;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtUmfang;
        private System.Windows.Forms.TextBox txtSchnittflaeche;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.TextBox txtAnzahl;
    }
}

