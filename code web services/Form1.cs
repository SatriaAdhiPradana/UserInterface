using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ServiceReference1;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client pop = new Service1Client();
            string input = this.textBox1.Text;
            this.label2.Text=pop.population(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client password = new Service1Client();
            int length = Convert.ToInt32(this.textBox2.Text);
            this.label4.Text = password.password(length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1Client list = new Service1Client();
            string input = this.textBox3.Text;
            this.label6.Text = list.list(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Service1Client price = new Service1Client();
            double a = Convert.ToDouble(this.textBox4.Text);
            double b = Convert.ToDouble(this.textBox5.Text);
            int c = Convert.ToInt32(this.textBox6.Text);
            this.label11.Text = price.expenses(a, b, c);
        }
    }
}
