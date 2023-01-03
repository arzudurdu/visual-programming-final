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
    public partial class giris : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd='arzu123';");
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cm = new MySqlCommand("select * from admin where kullanıcıadı=@p1 and sifre=@p2",con);
            cm.Parameters.AddWithValue("@p1",textBox1.Text);
            cm.Parameters.AddWithValue("@p2", textBox2.Text);
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Error); 

            con.Close(); 
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar= '*';
        }
    }
}
