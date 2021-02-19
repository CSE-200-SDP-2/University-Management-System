using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
            //string a = "Md Asfakur Rahat";
            //stuname.Text = "Name : " + a +"";
        }

        public Home_Page mainForm = null;
        public Student_Menu(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
        }
        private void Student_Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
