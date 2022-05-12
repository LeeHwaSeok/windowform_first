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
            label7.Text = "후기를 남겨 주시면 이벤트에 응모됩니다. \n이벤트에 응모하려면 개인정보 동의해 주세요.";

            if (checkBox1.Checked)
            {
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("응모완료", "응모 확인");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("응모","응모 확인");
            }
            else
            {
                MessageBox.Show("개인정보 동의 여부 체크하세요", "응모 확인");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = "", b = "", c = "", d = "", f = "";
            if (checkBox1.Checked)
            {
                a = checkBox1.Text + " ";
            }
            else if (checkBox2.Checked)
            {
                b = checkBox2.Text + " ";
            }
            else if (checkBox3.Checked)
            {
                c = checkBox3.Text + " ";
            }
            else if (checkBox4.Checked)
            {
                d = checkBox4.Text + " ";
            }
            else { a = "주문하지 않음";  }
            f = textBox1.Text + " ";

            label9.Text = "주문하신 메뉴는 '" + a + b + c + d + "'입니다." + "\n주문 시 요구사항은 " + f + "입니다.";


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] lst1 = { "나라사랑카드", "다라사랑카드", "라라사랑카드" };
            string[] lst2 = { "무통장입금", "유통장입금", "부통장입금" };
            string[] lst3 = { "포인트사용", "포인트4용", "포인드" };

            if (comboBox1.SelectedIndex == 0) listBox1.Items.AddRange(lst1);
            else if (comboBox1.SelectedIndex == 1) listBox1.Items.AddRange(lst2);
            else if (comboBox1.SelectedIndex == 2) listBox1.Items.AddRange(lst3);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("결제 수단 : " + comboBox1.Text +" " + "\n할부 종류 : "+listBox1.Text, "결제 확인");
        }
    }
}
