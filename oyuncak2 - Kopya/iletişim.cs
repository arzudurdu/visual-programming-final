using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace oyuncak2
{
    public partial class iletişim : Form
    {
        public iletişim()
        {
            InitializeComponent();
        }
        public string mail;

        private void button1_Click(object sender, EventArgs e)
        {

            int hata = 0; //textbox boş olmaması
            if (textBox1.Text == String.Empty) //hata kontrolü
                hata = 1;
            if (textBox2.Text == String.Empty)
                hata = 1;
            if (textBox3.Text == String.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Boş Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            MailMessage msg = new MailMessage();
            SmtpClient istemci = new SmtpClient(); //posta gönderme protokolü
            istemci.Credentials = new System.Net.NetworkCredential("arzuusare@outlook.com", "arzusdurdu3");
            istemci.Port = 587; //tr de kullanılan port
            istemci.Host = "smtp.live.com"; //sunucu adresi
            istemci.EnableSsl = true; //mail şifrelenmesini belirlemek
            msg.To.Add(textBox1.Text); //mail gönderme 
            msg.From = new MailAddress("arzuusare@outlook.com");
            msg.Subject = textBox2.Text; //mesaj konusu
            msg.Body= textBox3.Text; //içerik
            istemci.Send(msg);
        }

        private void iletişim_Load(object sender, EventArgs e)
        {
           textBox1.Text = mail;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
