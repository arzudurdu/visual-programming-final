using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncak2
{
    public partial class Faturalar : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd ='arzu123';");
        public Faturalar()
        {
            InitializeComponent();
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from fatura", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt); //listeyi dolduracak
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 55;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 65;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(id.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from fatura WHERE idfatura = '" + delete + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (id.Text == "")
            {
                MessageBox.Show("Fatura Kaydı SİLİNMEDİ");
            }
            else
            {
                if (reader.Read())
                {

                }
                MessageBox.Show("Fatura Kaydı SİLİNDİ");
                reader.Close();
            }
            con.Close();
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0; //textbox boş olmaması
            if (serino.Text == String.Empty) //hata kontrolü
                hata = 1;
            if (tarih.Text == String.Empty)
                hata = 1;
            if (saat.Text == String.Empty)
                hata = 1;
            if (teslime.Text == String.Empty)
                hata = 1;
            if (teslima.Text == String.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Tüm Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("insert into fatura(serino,tarih,saat,teslimeden,teslimalan)values(@p1,@p2,@p3,@p4,@p5)", con);
                cm.Parameters.AddWithValue("@p1", serino.Text);
                cm.Parameters.AddWithValue("@p2", tarih.Text);
                cm.Parameters.AddWithValue("@p3", saat.Text);
                cm.Parameters.AddWithValue("@p4", teslime.Text);
                cm.Parameters.AddWithValue("@p5", teslima.Text);

                int basari = cm.ExecuteNonQuery();
                if (basari == 1)
                    MessageBox.Show("Fatura Kaydı Eklendi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Fatura Kaydı Eklenmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serino.Clear();
                tarih.Clear();
                saat.Clear();
                teslime.Clear();
                teslima.Clear();
            }

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            serino.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            saat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            teslime.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            teslima.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
