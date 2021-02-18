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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();

            //openChildForm(new Student_Menu());
            // customizedesign();
            logoutbtn.Hide();
            //string a =;
            
            
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            loginpanel.Controls.Add(childForm);
            loginpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Home_Page_Load(object sender, EventArgs e)
        {
          
        }

        private void bubtlogo_Click(object sender, EventArgs e)
        {
            logoutbtn.Hide();
            loginbtn.Show();
            Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Login" || x.Name == "Teacher_Login" || x.Name == "Student_Login").ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }
            /* try
             {
                 Admin_Login Al = (Admin_Login)Application.OpenForms["Admin_Login"];
                 //Teacher_Login Tl = (Teacher_Login)Application.OpenForms["Teacher_Login"];
                 Al.Close();  //Tl.Close();
             }
             catch (NullReferenceException ne)
             {
                 //One of the forms is not opened


             }
         }*/
            // private void button1_Click(object sender, EventArgs e)
            /* foreach (Form f in Application.OpenForms)
             {
                 if (f is Admin_Login)
                 {
                     //Form2 is activated. Close it
                     f.Close();
                 }
                else if (f is Teacher_Login)
                 {
                     //Form3 is activated. Close it
                     f.Close();
                 }
             }*/
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Login());
            loginbtn.Hide();
            logoutbtn.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Login" || x.Name == "Admin_Menu" || x.Name == "Student_Menu" || x.Name == "Teacher_Menu").ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }
            logoutbtn.Hide();
            loginbtn.Show();
        }
    }
}
