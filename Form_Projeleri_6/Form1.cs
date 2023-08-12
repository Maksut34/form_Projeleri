using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Projeleri_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            pazatesi();
            salı();
            çarşamba();
            perşembe();
            cuma();
        }
        public void pazatesi()
        {
            int year = 2023;
            int month = 1;
            int day = 1;
            int hour = random.Next(1, 25);
            int minute = random.Next(1, 60);
            lbl_day.Text = day.ToString();
            lbl_month.Text = month.ToString();
            lbl_year.Text = year.ToString();
            lbl_hour.Text = hour.ToString();
            lbl_minute.Text = minute.ToString();

            int nem = random.Next(1, 30);
            lbl_nem.Text = nem.ToString();
            int d_hour = random.Next(4, 7);
            lbl_d_hour.Text = d_hour.ToString();
            int d_minute = random.Next(1, 60);
            lbl_d_minute.Text = d_minute.ToString();
            int b_hour = random.Next(18, 22);
            lbl_b_hour.Text = b_hour.ToString();
            int b_minute = random.Next(1, 60);
            lbl_b_minute.Text = b_minute.ToString();
            pictureBox5.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPf9CZDyvaaObUkZhXYP3nMjJqKconANUjZg&usqp=CAU";
        }
        public void salı()
        {

            int year = 2023;
            int month = 1;
            int day =2;
            int hour = random.Next(1, 25);
            int minute = random.Next(1, 60);
            lbl_s_day.Text = day.ToString();
            lbl_s_month.Text = month.ToString();
            lbl_s_year.Text = year.ToString();
            lbl_s_hour.Text = hour.ToString();
            lbl_s_minute.Text = minute.ToString();

            int nem = random.Next(30, 40);
            lbl_s_nem.Text = nem.ToString();
            int d_hour = random.Next(4, 7);
            lbl_s_d_hour.Text = d_hour.ToString();
            int d_minute = random.Next(1, 60);
            lbl_s_d_minute.Text = d_minute.ToString();
            int b_hour = random.Next(18, 22);
            lbl_s_b_hour.Text = b_hour.ToString();
            int b_minute = random.Next(1, 60);
            lbl_s_b_minute.Text = b_minute.ToString();
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAHoJahv1u6rjOqVglwM--6bPdlnnpNOFkUQ&usqp=CAU";
            
        }
        public void çarşamba()
        {
            int year = 2023;
            int month = 1;
            int day = 3;
            int hour = random.Next(1, 25);
            int minute = random.Next(1, 60);
            lbl_ç_day.Text = day.ToString();
            lbl_ç_month.Text = month.ToString();
            lbl_ç_year.Text = year.ToString();
            lbl_ç_hour.Text = hour.ToString();
            lbl_ç_minute.Text = minute.ToString();

            int nem = random.Next(45,60);
            lbl_ç_nem.Text = nem.ToString();
            int d_hour = random.Next(4, 7);
            lbl_ç_d_hour.Text = d_hour.ToString();
            int d_minute = random.Next(1, 60);
            lbl_ç_d_minute.Text = d_minute.ToString();
            int b_hour = random.Next(18, 22);
            lbl_ç_b_hour.Text = b_hour.ToString();
            int b_minute = random.Next(1, 60);
            lbl_ç_b_minute.Text = b_minute.ToString();
            pictureBox2.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQch3h_LlRN_3LqzhNEZx0e7beqhpCPEAlMBw&usqp=CAU";
            
        }
        public void perşembe()
        {
            int year = 2023;
            int month = 1;
            int day = 4;
            int hour = random.Next(1, 25);
            int minute = random.Next(1, 60);
            lbl_p_day.Text = day.ToString();
            lbl_p_month.Text = month.ToString();
            lbl_p_year.Text = year.ToString();
            lbl_p_hour.Text = hour.ToString();
            lbl_p_minute.Text = minute.ToString();

            int nem = random.Next(60,80);
            lbl_p_nem.Text = nem.ToString();
            int d_hour = random.Next(4, 7);
            lbl_p_d_hour.Text = d_hour.ToString();
            int d_minute = random.Next(1, 60);
            lbl_p_d_minute.Text = d_minute.ToString();
            int b_hour = random.Next(18, 22);
            lbl_p_b_hour.Text = b_hour.ToString();
            int b_minute = random.Next(1, 60);
            lbl_p_b_minute.Text = b_minute.ToString();
            pictureBox3.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBkgtKULgDr7G4UDN5OoBJpp6KVda_roeBtw&usqp=CAU";
        }
        public void cuma()
        {
            int year = 2023;
            int month = 1;
            int day = 5;
            int hour = random.Next(1, 25);
            int minute = random.Next(1, 60);
            lbl_c_day.Text = day.ToString();
            lbl_c_month.Text = month.ToString();
            lbl_c_year.Text = year.ToString();
            lbl_c_hour.Text = hour.ToString();
            lbl_c_minute.Text = minute.ToString();

            int nem = random.Next(80,100);
            lbl_c_nem.Text = nem.ToString();
            int d_hour = random.Next(4, 7);
            lbl_c_d_hour.Text = d_hour.ToString();
            int d_minute = random.Next(1, 60);
            lbl_c_d_minute.Text = d_minute.ToString();
            int b_hour = random.Next(18, 22);
            lbl_c_b_hour.Text = b_hour.ToString();
            int b_minute = random.Next(1, 60);
            lbl_c_b_minute.Text = b_minute.ToString();
            pictureBox4.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbO2LS8kOlu7LKq3KChIjpl9SmpcKmV418VA&usqp=CAU";
        }

    }
}
