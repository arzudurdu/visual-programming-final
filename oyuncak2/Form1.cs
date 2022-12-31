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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void üRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürünler urn = new ürünler();
            this.Hide();
            urn.ShowDialog();
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müsterilercs müsteri = new müsterilercs();
            this.Hide();
            müsteri.ShowDialog();
            this.Close();


        }
    }
}
