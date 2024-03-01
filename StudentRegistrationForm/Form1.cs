using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {

                comboBox1.Items.Add(day);

            }

            ArrayList months = new ArrayList()
            {
                "January" , "Febuary" , "March" , "April" , "May" , "June" , "July" , "August" , "September" ,
                "October" , "November" , "December"
            };

           foreach (string  month in months)
            {
                comboBox2.Items.Add(month);
            }
            

            for (int year = 1990; year <= 2024; year++)
            {

                comboBox3.Items.Add(year);
            }

            ArrayList courses = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string course in courses)
            {
                comboBox4.Items.Add(course);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (male.Checked)
            {
                MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox1.Text
                    + "\nGender: Male\nDate of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/x   "+ comboBox3.Text + "\nProgram: " + comboBox4.Text);
            }
            else
            {
                MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox1.Text
                    + "\nGender: Female\nDate of Birth: " + comboBox1.Text + "/"  + comboBox2.Text + "/"+ comboBox3.Text + "\nProgram: " + comboBox4.Text);
            }
        }
    }
}
