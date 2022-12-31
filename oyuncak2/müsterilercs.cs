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
    public partial class müsterilercs : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak; Uid = root; Pwd='arzu123';");

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

        }

        private void müsterilercs_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from musteriler", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            con.Close();
        }
    }
}
