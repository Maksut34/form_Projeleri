using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Projesi_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kişiler kişi=new Kişiler();

            kişi.Ad = txt_Ad.Text;
            kişi.Soyad = txt_Soyad.Text;
            kişi.Tel=txt_Tel.Text;
            kişi.Adres=txt_Adres.Text;
            kişi.Email=txt_email.Text;

            Ad.Items.Add(kişi.Ad);
            Soyad.Items.Add(kişi.Soyad);
            Tel.Items.Add(kişi.Tel);
            Adres.Items.Add(kişi.Adres);
            Email.Items.Add(kişi.Email);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data bağlantısı bulunmamaktadır!");
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data bağlantısı bulunmamaktadır!");
        }

        class Kişiler
        {
            
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Tel { get; set; }
            public string Adres { get; set; }
            public string Email { get; set; }
        }
    }
}
