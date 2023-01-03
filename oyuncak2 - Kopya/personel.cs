using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncak2
{
    public partial class personel : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd ='arzu123';");
        public personel()
        {
            InitializeComponent();
        }

        private void personel_Load(object sender, EventArgs e)
        {

            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from personel", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt); //listeyi dolduracak
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 35;
            dataGridView1.Columns[2].Width = 30;
            dataGridView1.Columns[3].Width = 35;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.Columns[6].Width = 35;
            dataGridView1.Columns[7].Width = 30;
            dataGridView1.Columns[8].Width = 30;

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e) //kayıt butonu
        {
            int hata = 0; //textbox boş olmaması
            if (ad.Text == String.Empty)
                hata = 1;
            if (soyad.Text == String.Empty)
                hata = 1;
            if (tc.Text == String.Empty)
                hata = 1;
            if (mail.Text == String.Empty)
                hata = 1;
            if (il.Text == String.Empty)
                hata = 1;
            if (ilce.Text == String.Empty)
                hata = 1;
            if (adres.Text == String.Empty)
                hata = 1; 
            if (görev.Text == String.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show(" Boş Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("insert into personel(ad,soyad,tc,telefon,mail,il,ilçe,adres,görev)values('" + ad.Text + "','" + soyad.Text + "','" + tc.Text + "','" + telno.Text + "','" + mail.Text + "','" + il.Text + "','" + ilce.Text + "','" + adres.Text + "','" + görev.Text + "')", con);
                int basari = cm.ExecuteNonQuery();

                if (basari == 1)
                    MessageBox.Show("Kişi Eklendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kişi Eklenemedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ad.Clear();
                soyad.Clear();
                tc.Clear();
                telno.Clear();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(id.Text);
            con.Open(); 
            MySqlCommand cmd = new MySqlCommand("delete from personel WHERE idpersonel = '" + delete + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (id.Text == "")
            {
                MessageBox.Show("Kişi SİLİNMEDİ");
            }
            else
            {
                if (reader.Read())
                {

                }
                MessageBox.Show("Kişi SİLİNDİ");
                reader.Close();
            }
            con.Close();
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cm = new MySqlCommand("update personel set ad=@p1, soyad=@p2, tc=@p3, telefon=@p4, mail=@p5, il=@p6, ilçe=@p7, adres=@p8, görev=@p9 where idpersonel=@p10", con);
            cm.Parameters.AddWithValue("@p1", ad.Text); //sorunsuz çalışması ve hatayı aza indirgemek için parametreler kullandım
            cm.Parameters.AddWithValue("@p2", soyad.Text);
            cm.Parameters.AddWithValue("@p3", tc.Text);
            cm.Parameters.AddWithValue("@p4", telno.Text);
            cm.Parameters.AddWithValue("@p5", mail.Text);
            cm.Parameters.AddWithValue("@p6", il.Text);
            cm.Parameters.AddWithValue("@p7", ilce.Text);
            cm.Parameters.AddWithValue("@p8", adres.Text);
            cm.Parameters.AddWithValue("@p9", görev.Text);
            cm.Parameters.AddWithValue("@p10", id.Text);

            int basari = cm.ExecuteNonQuery();
            con.Close();

            if (basari == 1)
                MessageBox.Show("Kişi GÜNCELLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kişi GÜNCELLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ad.Clear();
            soyad.Clear();
            tc.Clear();
            telno.Clear();
            mail.Clear();
            il.Clear();
            ilce.Clear();
            adres.Clear();
            görev.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //tabloyu otomatik doldurması için
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            il.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ilce.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            adres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            görev.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
