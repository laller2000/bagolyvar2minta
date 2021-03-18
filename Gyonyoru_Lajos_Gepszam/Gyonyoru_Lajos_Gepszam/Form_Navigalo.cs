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
    public partial class Form_Navigalo : Form
    {
        public Form_Navigalo()
        {
            InitializeComponent();
        }

        private void Form_Navigalo_Load(object sender, EventArgs e)
        {
            Color hatterszin = Color.FromArgb(128, 64, 0);
            Color szovegszin = Color.FromArgb(255, 255, 128);
            button1_Kolcsonzes.BackColor = hatterszin;
            button1_Kolcsonzes.ForeColor = szovegszin;
            button2_Kesesek.BackColor = hatterszin;
            button2_Kesesek.ForeColor = szovegszin;
        }

        private void button1_Kolcsonzes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_kolcsonzes.Show();
        }

        private void button2_Kesesek_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_kesesek.Show();
        }
    }
}
