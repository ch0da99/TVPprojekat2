using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace TVPprojekat2
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ch0da\Desktop\TVPprojekat2\TVPprojekat2\bin\Debug\TVPprojekat2.accdb");
        OleDbCommand cmd=new OleDbCommand();
        OleDbDataReader reader;
        Color defCol;
        List<Artikal> artikli=new List<Artikal>();
        List<Button> dugmici=new List<Button>();
        Thread t1;
        Artikal a;
        Racun racun;
        double ukupnaCena = 0;
        Button izabraniArtikal;
        double racunDouble = 0;
        Label l1;
        Label l2;
        Button b1;

        public Form1()
        {
            InitializeComponent();
            podesavanjeVelicineForme();
            cmd.Connection = conn;
            cmd.CommandText = "Select naziv from Artikal";
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            cmd.Connection.Close();
        }

        private void Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            defCol = btn.BackColor;
            btn.BackColor = Color.Aqua;
        }
        private void Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = defCol;
        }
        private void IzborKategorije(object sender, EventArgs e)
        {
            CiscenjeLista();
            iskljuciKontroleZaKolicinu();
            uklanjanjeLabelaZaCenu();
            Button btn = (Button)sender;
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "Select id_artikla,naziv,cena,popust,id_grupe from Artikal where id_grupe=(Select id_grupe from grupa where naziv=\"" + btn.Text + "\")";
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    artikli.Add(new Artikal((int)reader["ID_artikla"], (string)reader["naziv"], (int)reader["cena"], (int)reader["popust"], (int)reader["ID_grupe"]));
                    dugmici.Add(new Button());
                }

                pravljenjeDugmica();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske u toku rada programa. Detaljnije informacije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }
            
        }
        private void pravljenjeDugmica()
        {
            int visina = 0;
            for(int i = 0; i < dugmici.Count; i++)
            {
                dugmici[i].Parent = panel1;
                dugmici[i].Name = "btn" + artikli[i].Naziv;
                dugmici[i].Text = artikli[i].Naziv;
                dugmici[i].BackColor = defCol;
                dugmici[i].Width = panel1.Width;
                dugmici[i].Height = 30;
                dugmici[i].Left = 0;
                dugmici[i].Top = visina;
                dugmici[i].MouseClick += new MouseEventHandler(klikNaArtikal);
                dugmici[i].MouseClick += new MouseEventHandler(kreiranjeLabeleZaCenu);
                dugmici[i].MouseClick += new MouseEventHandler(promenaKolicine);
                panel1.Controls.Add(dugmici[i]);
                visina += 30;
            }
            
        }
        private void klikNaArtikal(object sender, MouseEventArgs e)
        {
            izabraniArtikal = sender as Button;
            a = artikli[dugmici.IndexOf(izabraniArtikal)];
            ukljuciKontroleZaKolicinu();
        }
        private void DodavanjeNaRacun(object sender, EventArgs e)
        {
            string s="";
            int br = kojiJeArtikalSelektovan();
            if(proveraUnosaBrojaArtikala().stanje)
            {
                ukupnaCena = artikli[br].Cena - artikli[br].Cena*artikli[br].Popust * 0.01;
                racunDouble += ukupnaCena * proveraUnosaBrojaArtikala().kolicina;
                lblUkupanRacun.Text = racunDouble.ToString();
                s += artikli[br].Naziv.ToString() + ", " + txtKolicina.Text.ToString() + ". kom, Cena: " + 
                    (ukupnaCena*proveraUnosaBrojaArtikala().kolicina).ToString() +Environment.NewLine+Environment.NewLine;
                txtRacun.Text += s;
            }
            btnIzdajRacun.Enabled = true;
            btnStornirajRacun.Enabled = true;
            iskljuciKontroleZaKolicinu();
            uklanjanjeLabelaZaCenu();

        }
        private void IzdavanjeRacuna(object sender, EventArgs e)
        {
            racun = new Racun(racunDouble, DateTime.Now);
            if(MessageBox.Show("Da li ste sigurni da zelite da izdate ovaj racun?","Izdavanje racuna?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                upisivanjeNaRacunUbazi();
                vratiSveNaPocetak(sender, e as MouseEventArgs);
            }
            racun = null;
        }
        private int kojiJeArtikalSelektovan()
        {
            for (int i = 0; i < dugmici.Count; i++)
                if (dugmici[i].Text.Equals(artikli[i].Naziv))
                    return i;
            return -1;
        }
        private Artikal_Kolicina proveraUnosaBrojaArtikala()
        {
            Artikal_Kolicina artKol;
            artKol.stanje = int.TryParse(txtKolicina.Text, out artKol.kolicina);
            return artKol;
        }
        private void ukljuciKontroleZaKolicinu()
        {
            btnManje.Enabled = true;
            txtKolicina.Text = "1";
            txtKolicina.Enabled = true;
            btnVise.Enabled = true;
            btnDodajNaRacun.Enabled = true;
        }
        private void iskljuciKontroleZaKolicinu()
        {
            btnManje.Enabled = false;
            txtKolicina.Text = "";
            txtKolicina.Enabled = false;
            btnVise.Enabled = false;
            btnDodajNaRacun.Enabled = false;
        }
        private void CiscenjeLista()
        {
            for (int i = 0; i < dugmici.Count; i++)
            {
                dugmici[i].Dispose();
            }
            dugmici.Clear();
            artikli.Clear();
        }
        struct Artikal_Kolicina
        {
            public bool stanje;
            public int kolicina;
        }
        private void upisivanjeNaRacunUbazi()
        {
            try {
                cmd.CommandText = "Insert into Racun(cena,datum,vreme) values(@Cena,@Datum,@Vreme)";
                cmd.Parameters.AddWithValue("Cena", racun.Cena);
                cmd.Parameters.AddWithValue("Datum", racun.Datum);
                cmd.Parameters.AddWithValue("Vreme", racun.Vreme);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Racun je uspesno sacuvan.");
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dogodila se greska pri upisu racuna u bazu podataka! Detaljnije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        private void promenaKolicine(object sender, EventArgs e)
        {
            if (txtKolicina.Text == "1")
                btnManje.Enabled = false;
        }
        private void manjeJedan(object sender, EventArgs e)
        {
            txtKolicina.Text = (int.Parse(txtKolicina.Text) - 1).ToString();
        }
        private void viseJedan(object sender, EventArgs e)
        {
            txtKolicina.Text = (int.Parse(txtKolicina.Text) + 1).ToString();
        }
        private void vratiSveNaPocetak(object sender, MouseEventArgs e)
        {
            CiscenjeLista();
            txtRacun.Text = "";
            lblUkupanRacun.Text = "";
            btnStornirajRacun.Enabled = false;
            btnIzdajRacun.Enabled = false;
            iskljuciKontroleZaKolicinu();
        }
        private void kreiranjeLabeleZaCenu(object sender, MouseEventArgs e)
        {
            uklanjanjeLabelaZaCenu();
            int br = kojiJeArtikalSelektovan();
            b1 = sender as Button;
            l1 = new Label
            {
                Left = panel1.Left + b1.Width + 20,
                Top = panel1.Top + b1.Top,
                ForeColor = Color.Red,
                //Font = b1.Font,
                Name = "l1",
                Size = new Size(b1.Size.Width, b1.Size.Height / 2),
                Text = "Cena produkta bez popusta je: " + artikli[br].Cena.ToString(),
                BackColor = Color.LightGray
            };
            l2 = new Label
            {
                Left = panel1.Left + b1.Width + 20,
                Top = panel1.Top + b1.Top + l1.Height,
                ForeColor = Color.Blue,
                //Font = b1.Font,
                Name = "l2",
                Size = new Size(b1.Size.Width, b1.Size.Height / 2),
                Text = "Cena produkta sa popustom je: " + (artikli[br].Cena - artikli[br].Cena * artikli[br].Popust * 0.01).ToString(),
                BackColor = Color.LightGray
            };
            Controls.Add(l2);
            Controls.Add(l1);
            
        }
        private void uklanjanjeLabelaZaCenu()
        {
            this.Controls.Remove(l1);
            this.Controls.Remove(l2);
        }
        private void podesavanjeVelicineForme()
        {
            MaximumSize = Size;
            MinimumSize = Size;
        }
        private void NoviArtikal(object sender, EventArgs e)
        {
            Novi_Artikal novi = new Novi_Artikal(this);
            novi.Show();
        }
    }
}
