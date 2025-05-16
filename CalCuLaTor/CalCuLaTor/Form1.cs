using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCuLaTor
{
    public partial class Form1 : Form
    {
        char islemtipi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //radio1 işaretliyse
            if(radioButton1.Checked==true)
            {
                textBox1.Text += "1";

            }
            else if(radioButton2.Checked==true)
            {
                textBox2.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "2";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "3";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox1.Text += "4";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "5";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
       
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "6";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "7";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "8";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "9";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text += "0";

            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text += "0";
            }
        }

        private void buttonarti_Click(object sender, EventArgs e)
        {
            islemtipi = '+';
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            islemtipi = '-';
        }

        private void buttoncarpma_Click(object sender, EventArgs e)
        {
            islemtipi = '*';
        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            islemtipi = '/';
        }

        private void buttonSonuc_Click(object sender, EventArgs e)
        {
            int sayi1= Convert.ToInt32(textBox1.Text);
            int sayi2= Convert.ToInt32(textBox2.Text);

            int toplam = 0;

            if (islemtipi=='+')
            {
                toplam = sayi1 + sayi2;
            }
            else if (islemtipi == '-')
            {
                toplam = sayi1 - sayi2;
            }
            else if (islemtipi == '*')
            {
                toplam = sayi1 * sayi2;
            }
            else if (islemtipi == '/')
            {
                toplam = sayi1 / sayi2;
            }
            label1.Text=toplam.ToString();

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }
    }
}
