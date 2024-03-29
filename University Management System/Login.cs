﻿using System;
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

    
    public partial class Login : Form
    {
        //string table;
        DBAccess con = new DBAccess();
        public Login()
        {
            InitializeComponent();

        }
        private Home_Page mainForm = null;
        public Login(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (loginas.SelectedIndex > -1)
            {
                User.user = loginas.Text;
                UserName.username = aname.Text;
                //MessageBox.Show(loginas.Text);
                DBAccess con = new DBAccess();
                string table = "";
                table += loginas.Text;
                con.dataGet("Select * from " + table + " where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
                                                                                                                        //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (apass.Text == "" + aname.Text + "bubt")
                    {
                        
                        this.mainForm.openChildForm(new Change_Password(mainForm));
                        this.Hide();

                    }
                    else
                    {
                        this.Hide();
                        this.mainForm.logoutbtn.Show();
                        //this.mainForm.openChildForm(new Admin_Menu());
                        /*Admin_Menu frm = new Admin_Menu();
                        frm.Show();
                        foreach (Form frm1 in Application.OpenForms)
                        {
                            if (frm1.Name != "Admin_Menu")
                                frm1.Hide();
                        }*/

                        if (table == "Admin")
                        {
                            this.mainForm.openChildForm(new Admin_Menu(mainForm));
                        }
                        else if (table == "Teacher")
                        {
                            this.mainForm.openChildForm(new Teacher_Menu(mainForm));
                        }
                        else if (table == "Student")
                        {
                            this.mainForm.openChildForm(new Student_Menu(mainForm));
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// }
            }
            else
            {
                MessageBox.Show("Please select an User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void loginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aname.Text = loginas.Text;
             //table = loginas.SelectedItem.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void showpass_Click(object sender, EventArgs e)
        {
            apass.UseSystemPasswordChar = false;
            showpass.Hide();
            hidepass.Show();
        }

        private void hidepass_Click(object sender, EventArgs e)
        {
            apass.UseSystemPasswordChar = true;
            hidepass.Hide();
            showpass.Show();
        }

        private void apass_TextChanged(object sender, EventArgs e)
        {
            if (showpass.Visible == true)
            {
                apass.UseSystemPasswordChar = true;
            }
            else
                apass.UseSystemPasswordChar = false;
        }

        private void FPassbtn_Click(object sender, EventArgs e)
        {
            if (loginas.SelectedIndex > -1)
            {
                if (loginas.Text != "Admin")
                { 
                    con.dataGet("Select * from " + loginas.Text + " where id = '" + aname.Text + "'");
                DataTable cc = new DataTable();
                con.sda.Fill(cc);
                if (cc.Rows.Count > 0)
                {
                    User.user = loginas.Text;
                    UserName.username = aname.Text;
                    this.mainForm.openChildForm(new Forget_password(mainForm));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter a correct username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } }
                else
                {
                    MessageBox.Show("Admin password can't be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
    

}
