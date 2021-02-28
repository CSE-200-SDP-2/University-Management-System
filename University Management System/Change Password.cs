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
    public partial class Change_Password : Form
    {
        DBAccess con = new DBAccess();
        string username = UserName.username;
        string user = User.user;
        public Change_Password()
        {
            InitializeComponent();
        }

        public Home_Page mainForm = null;
        public Change_Password(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
            
            MessageBox.Show("First Login? You have to change password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Change_Password_Load(object sender, EventArgs e)
        {
            passwordpanel.Hide();
        }

        private void confirmPass_Click(object sender, EventArgs e)
        {
            //con.dataGet("select * from Student where id='" + username + "'");
            if(newPass.Text==newPasscon.Text)
            {
                if (newPasscon.Text != "" + username + "bubt")
                {
                    string var = "fid,fpass";
                    string val = "'" + username + "','" + newPass.Text + "'";
                    con.dataSend("Update "+user+" Set pass='" + newPasscon.Text + "' where id='"+username+"'");
                    con.dataSend("insert into Forgot_Pass(" + var + ") values(" + val + ")");
                    MessageBox.Show("Password changed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mainForm.logoutbtn.Show();
                    if (user == "Teacher")
                    {
                        this.mainForm.openChildForm(new Teacher_Menu(mainForm));
                    }
                    else if (user == "Student")
                    {
                        this.mainForm.openChildForm(new Student_Menu(mainForm));
                    }
                }
                else
                {
                    MessageBox.Show("Old password can't be used again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password doesn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                newPass.UseSystemPasswordChar = false;
                newPasscon.UseSystemPasswordChar = false;
            }
            else
            {
                newPass.UseSystemPasswordChar = true;
                newPasscon.UseSystemPasswordChar = true;
            }
               
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                newPass.UseSystemPasswordChar = false;
               
            }
            else
            {
                newPass.UseSystemPasswordChar = true;
                
            }
        }

        private void newPasscon_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                
                newPasscon.UseSystemPasswordChar = false;
            }
            else
            {
               
                newPasscon.UseSystemPasswordChar = true;
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if(SecureQues.Text!="" && SecureAns.Text!="")
            {
                string var = "sid,squestion,sanswer";
                string val = "'" + username + "','" + SecureQues.Text + "','" + SecureAns.Text + "'";
                con.dataSend("insert into Security_Question(" + var + ") values(" + val + ")");
                MessageBox.Show("Security question setup successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                securitypanel.Hide();
                passwordpanel.Show();
            }
            else
            {
                MessageBox.Show("Question or Answer box is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
