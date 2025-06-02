using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {

        bool check;
        int addone;
        int count = 0;

        public void Enable_false() // الغاء الكبسة مرتين
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public void back() //     ميثود الاعادة1  تفضاية النص وتغير ون الخلفية
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
        public void back2()// اعادة الدور 2 مشان يشتغل الزر
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }

        public void Game()
        {

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("player X won");


                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);

                Enable_false();
            }

            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("player X won");

                addone = int.Parse(plx.Text);
                plx.Text = Convert.ToString(addone + 1);
                Enable_false();
            }
            //oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();


            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                MessageBox.Show("player O won");
                addone = int.Parse(plo.Text);
                plo.Text = Convert.ToString(addone + 1);
                Enable_false();

            }
            else if (count == 9)
            {
                MessageBox.Show("it is a drow");
                addone = int.Parse(lbld.Text);
                lbld.Text = Convert.ToString(addone + 1);
                count = 0;
            }




        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if (check == false)
            {
                button1.Text = "X";
                check = true;
            }
            else
            {
                button1.Text = "O";
                check = false;
            }
            button1.Enabled = false;
            count++;
            Game();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button2.Text = "X";
                check = true;
            }
            else
            {
                button2.Text = "O";
                check = false;
            }
            button2.Enabled = false;
            count++;
            Game();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button3.Text = "X";
                check = true;
            }
            else
            {
                button3.Text = "O";
                check = false;
            }
            button3.Enabled = false;
            count++;
            Game();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            button4.Enabled = false;
            count++;
            Game();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            button5.Enabled = false;
            count++;
            Game();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            button6.Enabled = false;
            count++;
            Game();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            button7.Enabled = false;
            count++;
            Game();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            button8.Enabled = false;
            count++;
            Game();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            button9.Enabled = false;
            count++;
            Game();

        }

        private void reset_Click(object sender, EventArgs e) // New round
        {
            count = 0;
            back();
            back2();
        }

        private void button10_Click(object sender, EventArgs e) // New Game
        {
            check = false;
            plx.Text = Convert.ToString(0);
            plo.Text = Convert.ToString(0);
            lbld.Text = Convert.ToString(0);
            count = 0;
            back();
            back2();
        }

        private void exit_Click(object sender, EventArgs e) // Exit
        {
            Application.Exit();
        }



    }
}




