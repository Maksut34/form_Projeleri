using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Projesi_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.Second.ToString();
            label3.Text = DateTime.Now.Minute.ToString();
            label4.Text = DateTime.Now.Hour.ToString();

            label5.Text = DateTime.Today.ToString();
            DateTime today = DateTime.Now;
            label1.Text=("Today is: " + today.DayOfWeek);

        }

       
    }
}
