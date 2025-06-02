using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator0;


namespace Calculator0._1._1
{
    public partial class Form1 : Form
    {
        Calc GG =new Calc();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_result.Text = GG.AddNumber(textBox_result.Text, Convert.ToChar(button.Text));
        }// 1 ~ 9

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_result.Text = GG.AddZero(textBox_result.Text, Convert.ToChar(button.Text));
        }// 0

        private void button_sum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_result.Text = GG.AddOperations(textBox_result.Text,Convert.ToChar(button.Text));
        }// + - × ÷ 

        private void button_dot_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_result.Text = GG.AddDot(textBox_result.Text);
        }// .

        private void button_percent_Click(object sender, EventArgs e)
        {
            textBox_result.Text = GG.AddPercentChar(textBox_result.Text);
        }// %

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text= GG.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_result.Text = GG.Remove(textBox_result.Text);
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            GG.Calc_num_of_num(textBox_result.Text);
            GG.SaveData(textBox_result.Text);
            textBox_result.Text = GG.Show_Result(textBox_result.Text);
            GG.Is_there_dot(textBox_result.Text);
        }
    }
}
