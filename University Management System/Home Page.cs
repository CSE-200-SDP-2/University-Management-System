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
           // customizedesign();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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

        private void library_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_Login());

        }

        private void bubtlogo_Click(object sender, EventArgs e)
        {
            try
            {
                Admin_Login Al = (Admin_Login)Application.OpenForms["Admin_Login"];
                //Teacher_Login Tl = (Teacher_Login)Application.OpenForms["Teacher_Login"];
                Al.Close(); //Tl.Close();
            }
            catch (NullReferenceException ne)
            {
                //One of the forms is not opened
            }
        }
    }
}
