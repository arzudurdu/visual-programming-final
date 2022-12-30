using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace oyuncak2
{
    public partial class ürünler : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak; Uid = root; Pwd ='arzu123';");
        public ürünler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ürünler_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from urunler", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt); //listeyi dolduracak
            dataGridView1.DataSource=dt;  //veri tabanından bağladığım tablonun ölçüleri
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 25;
            dataGridView1.Columns[5].Width = 80;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0; //textbox boş olmaması
            if (ürnad.Text == String.Empty)
                hata = 1;
            if (marka.Text == String.Empty)
                hata = 1;
            if (model.Text == String.Empty)
                hata = 1;
            if (adet.Text == String.Empty)
                hata = 1;
            if (fiyat.Text == String.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Lütfen Boş Alabları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("insert into urunler(ürünadı,marka,model,adet,fiyat)values('" +ürnad.Text + "','" + marka.Text + "','" + model.Text + "','" + adet.Text + "','" + fiyat.Text + "')",con);
                int basari = cm.ExecuteNonQuery();

                if (basari == 1)
                    MessageBox.Show("Kayıt Eklendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt Eklendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ürnad.Clear();
                marka.Clear();
                model.Clear();
                fiyat.Clear();

            }
            con.Close();
        }
    }
}
