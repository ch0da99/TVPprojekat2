namespace TVPprojekat2
{
    partial class Novi_Artikal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma za dodavanje novog artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Popust (%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategorija:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(163, 109);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(203, 26);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(163, 150);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(203, 26);
            this.txtCena.TabIndex = 6;
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(163, 190);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(203, 26);
            this.txtPopust.TabIndex = 7;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(163, 231);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(203, 28);
            this.cmbKategorija.TabIndex = 8;
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.BackColor = System.Drawing.Color.Aqua;
            this.btnDodajArtikal.Location = new System.Drawing.Point(117, 328);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(173, 48);
            this.btnDodajArtikal.TabIndex = 9;
            this.btnDodajArtikal.Text = "Dodaj";
            this.btnDodajArtikal.UseVisualStyleBackColor = false;
            this.btnDodajArtikal.Click += new System.EventHandler(this.DodavanjeArtiklaUBazu);
            // 
            // Novi_Artikal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 398);
            this.Controls.Add(this.btnDodajArtikal);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Novi_Artikal";
            this.Text = "Novi_Artikal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IskljucivanjeForme);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnDodajArtikal;
    }
}