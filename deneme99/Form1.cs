using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace deneme99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BJO2DGU\\SQLEXPRESS;Initial Catalog=DbFilmArsivi;Integrated Security=True;");

        private void button2_Click(object sender, EventArgs e)
        {
            string s1, s2, v1, v2;
            s1 = textBox2.Text;
            s2 = textBox3.Text;
            v1 = textBox4.Text;
            v2 = textBox5.Text;

            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("create table " + textBox1.Text + " ( " + s1 + " " + v1 + "," + s2 + " " + v2 + ")", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Tablo Oluşturuldu");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
