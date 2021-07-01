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

namespace TVPprojekat2
{
    public partial class Prikaz_Racuna : Form
    {
        Form1 f1;
        List<Racun> sviRacuni;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;

        public Prikaz_Racuna()
        {
            InitializeComponent();
        }
        public Prikaz_Racuna(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            f1.Enabled = false;
            Focus();
            conn.ConnectionString=(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ch0da\Desktop\TVPprojekat2\TVPprojekat2\bin\Debug\TVPprojekat2.accdb");
            cmd.Connection = conn;
        }

        private void prikaziRacune(object sender, EventArgs e)
        {
            
        }
        private void dobavljanjeRacuna()
        {
            try
            {
                cmd.CommandText = "Select cena,datum,vreme from racun where datum";
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sviRacuni.Add(new Racun((double)reader["cena"],(DateTime)reader["datum"]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom citanja podataka iz baze. Detaljnije: " + ex.ToString());
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
