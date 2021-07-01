namespace TVPprojekat2
{
    partial class Form1
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
            this.btnNegazirana = new System.Windows.Forms.Button();
            this.btnHrana = new System.Windows.Forms.Button();
            this.btnGazirana = new System.Windows.Forms.Button();
            this.btnVoce = new System.Windows.Forms.Button();
            this.btnHemikalije = new System.Windows.Forms.Button();
            this.btnPovrce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlkohol = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnVise = new System.Windows.Forms.Button();
            this.btnManje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnStornirajRacun = new System.Windows.Forms.Button();
            this.txtRacun = new System.Windows.Forms.TextBox();
            this.lblUkupanRacun = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajArtikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlistajRacuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNegazirana
            // 
            this.btnNegazirana.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNegazirana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegazirana.Location = new System.Drawing.Point(39, 137);
            this.btnNegazirana.Name = "btnNegazirana";
            this.btnNegazirana.Size = new System.Drawing.Size(174, 32);
            this.btnNegazirana.TabIndex = 0;
            this.btnNegazirana.TabStop = false;
            this.btnNegazirana.Text = "Bezalkoholna negazirana pica";
            this.btnNegazirana.UseVisualStyleBackColor = false;
            this.btnNegazirana.Click += new System.EventHandler(this.IzborKategorije);
            this.btnNegazirana.MouseEnter += new System.EventHandler(this.Enter);
            this.btnNegazirana.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // btnHrana
            // 
            this.btnHrana.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnHrana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHrana.Location = new System.Drawing.Point(39, 201);
            this.btnHrana.Name = "btnHrana";
            this.btnHrana.Size = new System.Drawing.Size(174, 32);
            this.btnHrana.TabIndex = 0;
            this.btnHrana.TabStop = false;
            this.btnHrana.Text = "Hrana";
            this.btnHrana.UseVisualStyleBackColor = false;
            this.btnHrana.Click += new System.EventHandler(this.IzborKategorije);
            this.btnHrana.MouseEnter += new System.EventHandler(this.Enter);
            this.btnHrana.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // btnGazirana
            // 
            this.btnGazirana.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGazirana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGazirana.Location = new System.Drawing.Point(39, 169);
            this.btnGazirana.Name = "btnGazirana";
            this.btnGazirana.Size = new System.Drawing.Size(174, 32);
            this.btnGazirana.TabIndex = 0;
            this.btnGazirana.TabStop = false;
            this.btnGazirana.Text = "Bezalkoholna gazirana pica";
            this.btnGazirana.UseVisualStyleBackColor = false;
            this.btnGazirana.Click += new System.EventHandler(this.IzborKategorije);
            this.btnGazirana.MouseEnter += new System.EventHandler(this.Enter);
            this.btnGazirana.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // btnVoce
            // 
            this.btnVoce.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnVoce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoce.Location = new System.Drawing.Point(39, 265);
            this.btnVoce.Name = "btnVoce";
            this.btnVoce.Size = new System.Drawing.Size(174, 32);
            this.btnVoce.TabIndex = 0;
            this.btnVoce.TabStop = false;
            this.btnVoce.Text = "Voce";
            this.btnVoce.UseVisualStyleBackColor = false;
            this.btnVoce.Click += new System.EventHandler(this.IzborKategorije);
            this.btnVoce.MouseEnter += new System.EventHandler(this.Enter);
            this.btnVoce.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // btnHemikalije
            // 
            this.btnHemikalije.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnHemikalije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHemikalije.Location = new System.Drawing.Point(39, 233);
            this.btnHemikalije.Name = "btnHemikalije";
            this.btnHemikalije.Size = new System.Drawing.Size(174, 32);
            this.btnHemikalije.TabIndex = 0;
            this.btnHemikalije.TabStop = false;
            this.btnHemikalije.Text = "Hemikalije";
            this.btnHemikalije.UseVisualStyleBackColor = false;
            this.btnHemikalije.Click += new System.EventHandler(this.IzborKategorije);
            this.btnHemikalije.MouseEnter += new System.EventHandler(this.Enter);
            this.btnHemikalije.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // btnPovrce
            // 
            this.btnPovrce.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPovrce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPovrce.Location = new System.Drawing.Point(39, 297);
            this.btnPovrce.Name = "btnPovrce";
            this.btnPovrce.Size = new System.Drawing.Size(174, 32);
            this.btnPovrce.TabIndex = 0;
            this.btnPovrce.TabStop = false;
            this.btnPovrce.Text = "Povrce";
            this.btnPovrce.UseVisualStyleBackColor = false;
            this.btnPovrce.Click += new System.EventHandler(this.IzborKategorije);
            this.btnPovrce.MouseEnter += new System.EventHandler(this.Enter);
            this.btnPovrce.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Izaberite kategoriju:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(259, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 176);
            this.panel1.TabIndex = 9;
            // 
            // btnAlkohol
            // 
            this.btnAlkohol.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAlkohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlkohol.Location = new System.Drawing.Point(39, 105);
            this.btnAlkohol.Name = "btnAlkohol";
            this.btnAlkohol.Size = new System.Drawing.Size(174, 32);
            this.btnAlkohol.TabIndex = 0;
            this.btnAlkohol.TabStop = false;
            this.btnAlkohol.Text = "Alkoholna pica";
            this.btnAlkohol.UseVisualStyleBackColor = false;
            this.btnAlkohol.Click += new System.EventHandler(this.IzborKategorije);
            this.btnAlkohol.MouseEnter += new System.EventHandler(this.Enter);
            this.btnAlkohol.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Enabled = false;
            this.txtKolicina.Location = new System.Drawing.Point(337, 277);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(41, 20);
            this.txtKolicina.TabIndex = 10;
            this.txtKolicina.TabStop = false;
            this.txtKolicina.EnabledChanged += new System.EventHandler(this.promenaKolicine);
            // 
            // btnVise
            // 
            this.btnVise.Enabled = false;
            this.btnVise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVise.Location = new System.Drawing.Point(385, 271);
            this.btnVise.Name = "btnVise";
            this.btnVise.Size = new System.Drawing.Size(31, 32);
            this.btnVise.TabIndex = 11;
            this.btnVise.TabStop = false;
            this.btnVise.Text = ">";
            this.btnVise.UseVisualStyleBackColor = true;
            this.btnVise.Click += new System.EventHandler(this.viseJedan);
            // 
            // btnManje
            // 
            this.btnManje.Enabled = false;
            this.btnManje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManje.Location = new System.Drawing.Point(301, 271);
            this.btnManje.Name = "btnManje";
            this.btnManje.Size = new System.Drawing.Size(31, 32);
            this.btnManje.TabIndex = 12;
            this.btnManje.TabStop = false;
            this.btnManje.Text = "<";
            this.btnManje.UseVisualStyleBackColor = true;
            this.btnManje.Click += new System.EventHandler(this.manjeJedan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Proizvodi iz kategorije:\r\n";
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.BackColor = System.Drawing.Color.Aqua;
            this.btnDodajNaRacun.Enabled = false;
            this.btnDodajNaRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaRacun.Location = new System.Drawing.Point(310, 309);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(95, 46);
            this.btnDodajNaRacun.TabIndex = 14;
            this.btnDodajNaRacun.TabStop = false;
            this.btnDodajNaRacun.Text = "Dodaj na racun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = false;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.DodavanjeNaRacun);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(700, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ukupan racun:";
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.Color.Lime;
            this.btnIzdajRacun.Enabled = false;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdajRacun.Location = new System.Drawing.Point(710, 311);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(95, 46);
            this.btnIzdajRacun.TabIndex = 17;
            this.btnIzdajRacun.TabStop = false;
            this.btnIzdajRacun.Text = "Izdaj racun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IzdavanjeRacuna);
            // 
            // btnStornirajRacun
            // 
            this.btnStornirajRacun.BackColor = System.Drawing.Color.Red;
            this.btnStornirajRacun.Enabled = false;
            this.btnStornirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStornirajRacun.Location = new System.Drawing.Point(811, 311);
            this.btnStornirajRacun.Name = "btnStornirajRacun";
            this.btnStornirajRacun.Size = new System.Drawing.Size(95, 46);
            this.btnStornirajRacun.TabIndex = 18;
            this.btnStornirajRacun.TabStop = false;
            this.btnStornirajRacun.Text = "Storniraj racun";
            this.btnStornirajRacun.UseVisualStyleBackColor = false;
            this.btnStornirajRacun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vratiSveNaPocetak);
            // 
            // txtRacun
            // 
            this.txtRacun.Location = new System.Drawing.Point(697, 69);
            this.txtRacun.Multiline = true;
            this.txtRacun.Name = "txtRacun";
            this.txtRacun.ReadOnly = true;
            this.txtRacun.Size = new System.Drawing.Size(224, 234);
            this.txtRacun.TabIndex = 19;
            this.txtRacun.TabStop = false;
            // 
            // lblUkupanRacun
            // 
            this.lblUkupanRacun.AutoSize = true;
            this.lblUkupanRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanRacun.Location = new System.Drawing.Point(857, 37);
            this.lblUkupanRacun.Name = "lblUkupanRacun";
            this.lblUkupanRacun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUkupanRacun.Size = new System.Drawing.Size(19, 20);
            this.lblUkupanRacun.TabIndex = 20;
            this.lblUkupanRacun.Text = "0";
            this.lblUkupanRacun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajArtikalToolStripMenuItem,
            this.izlistajRacuneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajArtikalToolStripMenuItem
            // 
            this.dodajArtikalToolStripMenuItem.Name = "dodajArtikalToolStripMenuItem";
            this.dodajArtikalToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.dodajArtikalToolStripMenuItem.Text = "Dodaj artikal";
            this.dodajArtikalToolStripMenuItem.Click += new System.EventHandler(this.NoviArtikal);
            // 
            // izlistajRacuneToolStripMenuItem
            // 
            this.izlistajRacuneToolStripMenuItem.Name = "izlistajRacuneToolStripMenuItem";
            this.izlistajRacuneToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.izlistajRacuneToolStripMenuItem.Text = "Izlistaj racune";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(946, 385);
            this.Controls.Add(this.lblUkupanRacun);
            this.Controls.Add(this.txtRacun);
            this.Controls.Add(this.btnStornirajRacun);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManje);
            this.Controls.Add(this.btnVise);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPovrce);
            this.Controls.Add(this.btnVoce);
            this.Controls.Add(this.btnHemikalije);
            this.Controls.Add(this.btnHrana);
            this.Controls.Add(this.btnGazirana);
            this.Controls.Add(this.btnNegazirana);
            this.Controls.Add(this.btnAlkohol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacija za izdavanje racuna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNegazirana;
        private System.Windows.Forms.Button btnHrana;
        private System.Windows.Forms.Button btnGazirana;
        private System.Windows.Forms.Button btnVoce;
        private System.Windows.Forms.Button btnHemikalije;
        private System.Windows.Forms.Button btnPovrce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlkohol;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnVise;
        private System.Windows.Forms.Button btnManje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Button btnStornirajRacun;
        private System.Windows.Forms.TextBox txtRacun;
        private System.Windows.Forms.Label lblUkupanRacun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajArtikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlistajRacuneToolStripMenuItem;
    }
}

