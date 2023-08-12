using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Projeleri_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int sayı1, sayı2;
        private void button1_Click(object sender, EventArgs e)
        {
            sayı2=random.Next(1,100);
            sayı1 = Convert.ToInt32(textBox1.Text);

            lbl_sayı.Text = "";
            lbl_sayı.Text = sayı2.ToString();

            if (sayı1==sayı2)
            {
                textBox1.Text = "";
                MessageBox.Show("Tebrikler!");
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Bilemediniz!");
            }
            
        }
    }
}
