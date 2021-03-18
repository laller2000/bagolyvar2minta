using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gyonyoru_Lajos_Gepszam
{
    public partial class Form_Kesesek : Form
    {
        public Form_Kesesek()
        {
            InitializeComponent();
        }

        private void Form_Kesesek_Load(object sender, EventArgs e)
        {
            ComboBoxKesesekFeltotlese();
        }

        private void ComboBoxKesesekFeltotlese()
        {
            comboBox1_Kesesek.Items.Clear();
            try
            {
                Program.sql.CommandText = "SELECT DISTINCT  kolcsonzo.ID, kolcsonzo.nev FROM kolcsonzo JOIN kolcsonzes ON kolcsonzo.ID=kolcsonzes.kolcsonzoID WHERE kolcsonzes.kivetelDatum > 30; ";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox1_Kesesek.Items.Add(new Kolcsonzo(dr.GetInt32("ID"), dr.GetString("nev")));
                    }
                }

            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
        }

        private void comboBox1_Kesesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListboxFeltoltese();
        }

        private void ListboxFeltoltese()
        {
            listBox1_Kesesek.Items.Clear();
            if (comboBox1_Kesesek.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztva kölcsönző");
            }
            Program.sql.CommandText = "SELECT  kolcsonzes.konyvID,kolcsonzes.kolcsonzoId,konyvek.Szerzo,konyvek.Cím,konyvek.KiadasEve,konyvek.Ar,konyvek.ISBN,kolcsonzo.nev,kolcsonzes.kivetelDatum,kolcsonzes.peldany FROM konyvek JOIN kolcsonzes ON konyvek.Kod=kolcsonzes.konyvID JOIN kolcsonzo ON kolcsonzes.kolcsonzoID = kolcsonzo.ID WHERE kolcsonzo.ID="+((Kolcsonzo)comboBox1_Kesesek.SelectedItem).ID;
            try
            {
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kolcsonzes kolcsonzes = new Kolcsonzes(dr.GetString("konyvID"), dr.GetInt32("kolcsonzoID"), dr.GetInt32("peldany"));
                        kolcsonzes.AddKonyvek(new Konyvek(dr.GetString("konyvId"), dr.GetString("Szerzo"), dr.GetString("Cím"), dr.GetInt32("KiadasEve"), dr.GetInt32("Ar"), dr.GetString("ISBN")));
                        kolcsonzes.AddKolcsonzo(new Kolcsonzo(dr.GetInt32("kolcsonzoID"), dr.GetString("nev")));
                        listBox1_Kesesek.Items.Add(kolcsonzes);
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
        }
    }
}
