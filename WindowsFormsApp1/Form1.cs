using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mesajgonder(string number, string mesaj)
        {
            try
            {
                if(number == "")
                {
                    MessageBox.Show("NUMARA GİRİLMEDİ");
                }
                if(number.Length <= 0)
                {
                    number = "+90" + number;
                }
                number = number.Replace(" ", " ");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesajgonder(textBox1.Text, textBox2.Text);
        }
        public void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
