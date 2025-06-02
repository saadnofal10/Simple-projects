using System;
using System.Windows.Forms;

namespace List_Employees
{
    public partial class Form1 : Form
    {
        Employees[] em = new Employees[10];
        int index = 0;
        int RB;
        //int j = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//Show
        {
            listBox1.Items.Add(em[index - 1].name + " " + em[index - 1].age);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                RB = int.Parse(textBox5.Text);
                listBox1.Items.Remove(listBox1.Items[RB]);

                em[RB] = null;
            }
            catch
            {
                MessageBox.Show("uncorect input");
            }


            for (int i = RB; i < em.Length - 1; i++)
            {
                em[i] = em[i + 1];
            }

        }//Remove

        private void button2_Click_1(object sender, EventArgs e) // show
        {

            try
            {
                listBox1.Items.Clear();

                for (int i = 0; i < index; i++)
                {
                    listBox1.Items.Add(em[i].name + " " + "(" + em[i].age + ")");
                }
            }
            catch
            {
                MessageBox.Show("no informaition to show");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //add
        {
            try
            {
                em[index++] = new Employees(textBox1.Text, int.Parse(textBox2.Text),
                int.Parse(textBox3.Text), textBox4.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                index--;
                MessageBox.Show("the information empty try agin");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

class Person
{
    public string name { set; get; }
    public int age { set; get; }
    public Person() { }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}

class Employees : Person
{
    int sallary;
    string workType;
    public Employees() { }
    public Employees(string name, int age, int sallary, string workType) : base(name, age)
    {
        this.sallary = sallary;
        this.workType = workType;
    }
    public int Sallary { set; get; }
    public string WorkType { set; get; }
}
