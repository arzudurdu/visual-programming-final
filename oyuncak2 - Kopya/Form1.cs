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


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            this.Hide();
            personel.ShowDialog();

        }

        private void yARDIMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void faturaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faturalar bilgi = new Faturalar();
            this.Hide();
            bilgi.ShowDialog();
        } 

        private void faturaDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faturalar detay = new Faturalar();
            this.Hide();
            detay.ShowDialog();
        }

        private void fATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faturalar fatura = new Faturalar();
            this.Hide();
            fatura.ShowDialog();
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletişim iletism = new iletişim();
            this.Hide();
            iletism.ShowDialog();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void sTOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stok stokk = new stok();
            this.Hide();
            stokk.ShowDialog();

        }

        private void dövizKuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dvz döviz = new dvz();
            this.Hide();
            döviz.ShowDialog();
        }
    }
}
