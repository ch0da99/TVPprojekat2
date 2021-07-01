using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace TVPprojekat2
{
    public partial class Novi_Artikal : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        Thread t;
        Artikal a;
        int pom;
        Form1 f1;
        List<string> artikli;

        public Novi_Artikal()
        {
            InitializeComponent();
        }
        public Novi_Artikal(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            podesavanjeVelicineForme();
            f1.Enabled = false;
            Focus();
            try
            {
                conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ch0da\Desktop\TVPprojekat2\TVPprojekat2\bin\Debug\TVPprojekat2.accdb");
                cmd = new OleDbCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske pri povezivanju sa bazom podataka. Detaljnije: " + ex.ToString());
            }
            ucitavanjeKategorija();
        }

        private void DodavanjeArtiklaUBazu(object sender, EventArgs e)
        {
            a = new Artikal();
            if (daLiPostojiArtikal())
            {
                txtNaziv.Text = "";
                MessageBox.Show("Vec imamo taj proizvod!");
                return;
            }
            if (!daLiPostojiGrupa())
            {
                cmbKategorija.Text = "";
                MessageBox.Show("Izabrana grupa ne postoji, molimo vas izaberite jednu od ponudjenih u padajucem meniju");
                return;
            }
            if(txtNaziv.Text == "" || txtCena.Text == "" || txtPopust.Text == "" || cmbKategorija.Text == "" || !int.TryParse(txtCena.Text, out pom) || !int.TryParse(txtPopust.Text, out pom))
            {
                if (txtNaziv.Text == "" || txtCena.Text == "" || txtPopust.Text == "" || cmbKategorija.Text == "")
                {
                    MessageBox.Show("Niste popunili sva polja!");
                    return;
                }
                if (!int.TryParse(txtCena.Text.Trim(), out pom))
                {
                    txtCena.Text = "";
                    MessageBox.Show("Morate uneti ceo broj u polje za cenu!");
                    return;
                }
                else if (int.Parse(txtCena.Text) < 1)
                {
                    txtCena.Text = "";
                    MessageBox.Show("Cena ne moze biti manja od 1!");
                    return;
                }
                else
                    a.Cena = pom;
                if (!int.TryParse(txtPopust.Text.Trim(), out pom))
                {
                    txtPopust.Text = "";
                    MessageBox.Show("Morate uneti ceo broj u polje za popust!");
                    return;
                }
                else if (int.Parse(txtPopust.Text) < 1 || int.Parse(txtPopust.Text) > 100)
                {
                    txtPopust.Text = "";
                    MessageBox.Show("Popust moze biti u intervalu od 1-100!");
                    return;
                }
                else
                    a.Popust = pom;
            }
            else
            {
                try
                {
                    pom = 0;
                    cmd.CommandText = "Select id_grupe from grupa where naziv=@naziv";
                    cmd.Parameters.AddWithValue("naziv", cmbKategorija.Text.Trim());
                    cmd.Connection.Open();
                    pom = (int)cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "Insert into Artikal(naziv,cena,popust,id_grupe) values(@naziv,@cena,@popust,@id_grupe)";
                    cmd.Parameters.AddWithValue("naziv", txtNaziv.Text.Trim());
                    cmd.Parameters.AddWithValue("cena", txtCena.Text.Trim());
                    cmd.Parameters.AddWithValue("popust", txtPopust.Text.Trim());
                    cmd.Parameters.AddWithValue("id_grupe", pom);
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Novi artikal je uspesno azuriran.");
                    }
                    cmd.Parameters.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Doslo je do greske prilikom unosenja novog artikla u bazu podataka. Detaljnije: " + ex.ToString());
                }
                finally
                {
                    txtNaziv.Text = "";
                    txtCena.Text = "";
                    txtPopust.Text = "";
                    cmbKategorija.Text = "";
                    cmd.Connection.Close();
                }
            }
        }
        private void podesavanjeVelicineForme()
        {
            MinimumSize = Size;
            MaximumSize = Size;
        }
        private void ucitavanjeKategorija()
        {
            try
            {
                cmd.CommandText = "Select naziv from grupa";
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbKategorija.Items.Add((string)reader["naziv"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom citanja podataka iz baze podataka. Detaljnije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        private void IskljucivanjeForme(object sender, FormClosedEventArgs e)
        {
            f1.Enabled = true;
        }
        private bool daLiPostojiArtikal()
        {
            bool var=false;
            try
            {
                cmd.CommandText = "Select naziv from artikal";
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (((string)reader["naziv"]).ToLower().Equals(txtNaziv.Text.Trim().ToLower()))
                        var = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska pri pristupu bazi podataka. Detaljnije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }

            return var;
        }
        private bool daLiPostojiGrupa()
        {
            bool var = false;
            try
            {
                cmd.CommandText = "Select naziv from grupa";
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (((string)reader["naziv"]).ToLower().Equals(cmbKategorija.Text.Trim().ToLower()))
                        var = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pristupu bazi podataka. Detaljnije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }

            return var;
        }
    }
}
