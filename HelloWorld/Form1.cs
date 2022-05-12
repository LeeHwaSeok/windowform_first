using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "후기를 남겨 주시면 이벤트에 응모됩니다. \n이벤트에 응모하려면 개인정보 동의해 주세요.";




            if (checkBox1.Checked) {
                label3.Text = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                label4.Text = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                label5.Text = checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                label6.Text = checkBox4.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("응모완료");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("응모");
            }
            else
            {
                MessageBox.Show("개인정보 동의 여부 체크하세요");
            }
        }
    }
}
