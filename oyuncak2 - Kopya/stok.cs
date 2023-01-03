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
using MySql.Data;


namespace oyuncak2
{
    public partial class stok : Form
    {

        MySqlConnection con = new MySqlConnection("server = localhost; Database = oyuncak2; Uid = root; Pwd ='arzu123';");
        public stok()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void stok_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select ürünadı,adet from urunler", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;

            MySqlCommand cm = new MySqlCommand("select ürünadı,adet from urunler", con);
            MySqlDataReader dr = cm.ExecuteReader();
            while(dr.Read()) //komut okuması için
            {
                chart1.Series["Series1"].Points.AddXY(dr[0], dr[1]);

            }
            con.Close();

        }
    }
}
