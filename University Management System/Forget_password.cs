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
    public partial class Forget_password : Form
    {
        DBAccess con = new DBAccess();
        string user = User.user;
        string username = UserName.username;
        public Forget_password()
        {
            InitializeComponent();
        }

        public Home_Page mainForm = null;
        public Forget_password(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
            resetpanel.Hide();
        }

        private void Submitpassbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from Forgot_Pass Where fid = '" + username + "' and fpass = '" + foldpass.Text + "'");
            DataTable oldp = new DataTable();
            con.sda.Fill(oldp);
            if(oldp.Rows.Count > 0)
            {
                submitpanel.Hide();
                resetpanel.Show();
            }
            else
            {
                MessageBox.Show("Password didn't match with any old passwords !\nPlease contact Admin.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Fshow_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Fshow_pass.Checked) //show pass clicked 
            {
                foldpass.UseSystemPasswordChar = false;
            }
            else
            {
                foldpass.UseSystemPasswordChar = true;
            }
        }

        private void foldpass_TextChanged(object sender, EventArgs e)
        {
            if (Fshow_pass.Checked) //show pass clicked 
            {
                foldpass.UseSystemPasswordChar = false;
            }
            else
            {
                foldpass.UseSystemPasswordChar = true;
            }
        }

        private void fnewpass_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                fnewpass.UseSystemPasswordChar = false;
                //fnewpasscon.UseSystemPasswordChar = false;
            }
            else
            {
                fnewpass.UseSystemPasswordChar = true;
                //fnewpasscon.UseSystemPasswordChar = true;
            }
        }

        private void fnewpasscon_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                //fnewpass.UseSystemPasswordChar = false;
                fnewpasscon.UseSystemPasswordChar = false;
            }
            else
            {
                //fnewpass.UseSystemPasswordChar = true;
                fnewpasscon.UseSystemPasswordChar = true;
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked) //show pass clicked 
            {
                fnewpass.UseSystemPasswordChar = false;
                fnewpasscon.UseSystemPasswordChar = false;
            }
            else
            {
                fnewpass.UseSystemPasswordChar = true;
                fnewpasscon.UseSystemPasswordChar = true;
            }
        }

        private void confirmPass_Click(object sender, EventArgs e)
        {
            if (fnewpass.Text == fnewpasscon.Text)
            {
                if (fnewpasscon.Text != "" + username + "bubt")
                {
                    con.dataGet("select * from Forgot_Pass Where fid = '" + username + "' and fpass = '" + fnewpass.Text + "'");
                    DataTable dc = new DataTable();
                    con.sda.Fill(dc);
                    if (dc.Rows.Count > 0)
                    {
                        MessageBox.Show("Old password can't be used again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string var = "fid,fpass";
                        string val = "'" + username + "','" + fnewpass.Text + "'";
                        con.dataSend("Update " + user + " Set pass='" + fnewpasscon.Text + "' where id='" + username + "'");
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
    }
}
