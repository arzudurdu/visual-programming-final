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
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd ='arzu123';");
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
            dataGridView1.DataSource=dt;
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
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("insert into urunler(ürünadı,marka,model,adet,fiyat)values('" +ürnad.Text + "','" + marka.Text + "','" + model.Text + "','" + adet.Text + "','" + fiyat.Text + "')",con);
                int basari = cm.ExecuteNonQuery();

                if (basari == 1)
                    MessageBox.Show("Kayıt Eklendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt Eklenmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ürnad.Clear();
                marka.Clear();
                model.Clear();
                fiyat.Clear();

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(id.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from urunler WHERE idurunler = '"+ delete+"'",con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(id.Text=="")
            {
                MessageBox.Show("ÜRÜN SİLİNMEDİ");
            }
            else
            {
                if (reader.Read())
                {

                }
                MessageBox.Show("ÜRÜN SİLİNDİ");
                reader.Close();
            }
            con.Close();
            cmd.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //tablodan satır seçince otomatik doldurmak için
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ürnad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            adet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //ürün güncelleme butonu
        {
            con.Open();
            MySqlCommand cm = new MySqlCommand("update urunler set ürünadı=@p1, marka=@p2, model=@p3, adet=@p4, fiyat=@p5 where idurunler=@p6", con);
            cm.Parameters.AddWithValue("@p1", ürnad.Text); //sorunsuz çalışması ve hatayı aza indirgemek için parametreler kullandım
            cm.Parameters.AddWithValue("@p2", marka.Text);
            cm.Parameters.AddWithValue("@p3", model.Text);
            cm.Parameters.AddWithValue("@p4", int.Parse(((adet.Value).ToString())));
            cm.Parameters.AddWithValue("@p5", decimal.Parse(fiyat.Text));
            cm.Parameters.AddWithValue("@p6", id.Text);

            int basari = cm.ExecuteNonQuery();
            con.Close();

            if (basari ==1)
                MessageBox.Show("ÜRÜN GÜNCELLENDİ", "UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ÜRÜN GÜNCELLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ürnad.Clear();
            marka.Clear();
            model.Clear();
            fiyat.Clear();        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
