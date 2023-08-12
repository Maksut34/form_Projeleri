using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Projeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity entity = new Entity();

            entity.not_alan=txt_not_alan.Text;
            entity.takip=txt_takip.Text;
            entity.not=richTextBox1.Text;
            entity.tarih = dateTimePicker1.Text;
            entity.saat=txt_saat.Text;
            entity.dakika=txt_dak.Text;

            if(entity!=null )
            {
                MessageBox.Show("Not takibe alındı!");
            }
        }

        class Entity
        {
            public int ID { get; set; }
            public string not_alan { get; set; }
            public string takip { get; set; }
            public string not { get; set; }
            public string tarih { get; set; }
            public string saat { get; set; }
            public string dakika { get; set; }
        }
    }
}
