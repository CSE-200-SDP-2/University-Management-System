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
    public partial class Login : Form
    {
        //string table;
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            DBAccess con = new DBAccess();
            string table = "";
            table += loginas.Text;
            
            //string check = loginas.Items.Add((string)["Table_Name"]);
            con.dataGet("Select * from "+ table +" where id='" + aname.Text + "' and pass='" + apass.Text + "'");         //  '" +  +"'
                                                                                                                
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                //this.Hide();
                //Admin_Menu frm = new Admin_Menu();
                //frm.Show();
                /*foreach (Form frm1 in Application.OpenForms)
                {
                    if (frm1.Name != "Admin_Menu")
                        frm1.Hide();
                }*/
                this.Hide();
                //Home_Page frm = new Home_Page();
                // frm.openChildForm(new Admin_Menu());

                //frm.Show();
                ActiveForm = Home_Page();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } //}
        }

        public void loginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aname.Text = loginas.Text;
             //table = loginas.SelectedItem.ToString();
        }
    }
}
