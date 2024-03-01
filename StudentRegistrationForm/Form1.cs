using System;
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
            for (int month = 1; month <= 12; month++)
            {

                comboBox2.Items.Add(month);
            }
            for (int year = 1990; year <= 2024; year++)
            {

                comboBox3.Items.Add(year);
            }
        }
    }
}
