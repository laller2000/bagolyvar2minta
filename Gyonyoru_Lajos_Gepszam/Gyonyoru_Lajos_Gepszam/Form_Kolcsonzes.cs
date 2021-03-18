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
    public partial class Form_Kolcsonzes : Form
    {
         List<Konyvek> konyvek = new List<Konyvek>();
        Color hatterszin = Color.FromArgb(128, 64, 0);
        Color betuszin = Color.FromArgb(255, 255, 128);
        public Form_Kolcsonzes()
        {
            InitializeComponent();
        }

        private void Form_Kolcsonzes_Load(object sender, EventArgs e)
        {
            button1_Listaba.BackColor = hatterszin;
            button1_Listaba.ForeColor = betuszin;
            button2_Adatbazisba.BackColor = hatterszin;
            button2_Adatbazisba.ForeColor = betuszin;
            KonyvAdatokfeltoltese();
            BerloAdatokfeltoltese();
        }

        private void BerloAdatokfeltoltese()
        {
            comboBox2_Berlo.Items.Clear();
            Program.sql.CommandText = "SELECT `ID`, `nev` FROM `kolcsonzo` WHERE 1";
            try
            {
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox2_Berlo.Items.Add(new Kolcsonzo(dr.GetInt32("ID"), dr.GetString("nev")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
        }

        private void KonyvAdatokfeltoltese()
        {
            comboBox1_Konyv.Items.Clear();
            Program.sql.CommandText = "SELECT `Kod`, `Szerzo`, `Cím`, `KiadasEve`, `Ar`, `ISBN` FROM `konyvek` WHERE 1";
            try
            {
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox1_Konyv.Items.Add(new Konyvek(dr.GetString("Kod"),dr.GetString("Szerzo"),dr.GetString("Cím"),dr.GetInt32("KiadasEve"),dr.GetInt32("Ar"),dr.GetString("ISBN")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
        }

        private void button1_Listaba_Click(object sender, EventArgs e)
        {
            if (comboBox1_Konyv.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon könyvet!");
            }
            if (comboBox2_Berlo.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon bérlőt!");
            }
            Konyvek kiv = (Konyvek)comboBox1_Konyv.SelectedItem;
            Kolcsonzo berlo = (Kolcsonzo)comboBox2_Berlo.SelectedItem;
            int peldany = Convert.ToInt32(numericUpDown1_Peldany.Value);
            Kolcsonzes kolcsonzes = new Kolcsonzes(kiv.Kod, berlo.ID,peldany);
            kolcsonzes.AddKonyvek(kiv);
            kolcsonzes.AddKolcsonzo(berlo);
            listBox1_Kolcsonzoadatok.Items.Add(kolcsonzes);
        }

        private void button2_Adatbazisba_Click(object sender, EventArgs e)
        {
            if (listBox1_Kolcsonzoadatok.Items.Count<1)
            {
                MessageBox.Show("Nincsennek kölcsönzések!");
                return;
            }
            try
            {
                foreach (Kolcsonzes item in listBox1_Kolcsonzoadatok.Items)
                {
                    Program.sql.CommandText = "INSERT INTO `kolcsonzes`(`konyvID`, `kolcsonzoID`,  `peldany`) VALUES ('"+item.KonyvID+"','"+item.KolcsonzoID+"','"+item.Peldany+"')";
                    Program.sql.ExecuteNonQuery();
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
            listBox1_Kolcsonzoadatok.Items.Clear();
            MessageBox.Show("Az adatrögzítés megtörtént!");
        }
    }
}
