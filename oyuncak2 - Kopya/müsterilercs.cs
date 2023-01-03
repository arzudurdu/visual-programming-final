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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace oyuncak2
{
    public partial class müsterilercs : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd='arzu123';");

        public müsterilercs()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(id.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from musteriler WHERE idmusteriler = '" + delete + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (id.Text == "")
            {
                MessageBox.Show("MÜŞTERİ SİLİNMEDİ");
            }
            else
            {
                if (reader.Read())
                {

                }
                MessageBox.Show("MÜŞTERİ SİLİNDİ");
                reader.Close();
            }
            con.Close();
            cmd.Dispose();
        }

        private void müsterilercs_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from musteriler", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 45;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0; //textbox boş olmaması
            if (ad.Text == String.Empty) //hata kontrolü
                hata = 1;
            if (soyad.Text == String.Empty)
                hata = 1;
            if (telno.Text == String.Empty)
                hata = 1;
            if (mail.Text == String.Empty)
                hata = 1;
            if (adres.Text == String.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Bütün Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("insert into musteriler(ad,soyad,telefon,mail,adres)values(@p1,@p2,@p3,@p4,@p5)", con);
                cm.Parameters.AddWithValue("@p1", ad.Text);
                cm.Parameters.AddWithValue("@p2", soyad.Text);
                cm.Parameters.AddWithValue("@p3", telno.Text);
                cm.Parameters.AddWithValue("@p4", mail.Text);
                cm.Parameters.AddWithValue("@p5", adres.Text); 

                int basari = cm.ExecuteNonQuery();
                if (basari == 1)
                    MessageBox.Show("Kayıt Eklendi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt Eklenmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ad.Clear();
                soyad.Clear();
                telno.Clear();
                mail.Clear();
                adres.Clear();
            }

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cm = new MySqlCommand("update musteriler set ad=@p1, soyad=@p2, telefon=@p3, mail=@p4, adres=@p5 where idmusteriler=@p6", con);
            cm.Parameters.AddWithValue("@p1", ad.Text); //sorunsuz çalışması ve hatayı aza indirgemek için parametreler kullandım
            cm.Parameters.AddWithValue("@p2", soyad.Text);
            cm.Parameters.AddWithValue("@p3", telno.Text);
            cm.Parameters.AddWithValue("@p4", mail.Text);
            cm.Parameters.AddWithValue("@p5", adres.Text);
            cm.Parameters.AddWithValue("@p6", id.Text);

            int basari = cm.ExecuteNonQuery();
            con.Close();

            if (basari == 1)
                MessageBox.Show("GÜNCELLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("GÜNCELLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ad.Clear();
            soyad.Clear();
            telno.Clear();
            mail.Clear();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
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