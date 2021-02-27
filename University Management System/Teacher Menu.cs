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
    public partial class Teacher_Menu : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        DBAccess con = new DBAccess();
        string tchcode = UserName.username;
        public Teacher_Menu()
        {
            InitializeComponent();
        }

        public Home_Page mainForm = null;
        public Teacher_Menu(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Teacher_Menu_Load(object sender, EventArgs e)
        {
            CourseList_LoadData();
            Auto_MarksInsertstudentid();
            Auto_MarksInsertcoursecode();
        }
        public void Auto_MarksInsertcoursecode()
        {
            con.dataGet("Select ccode from Teacher_Course"); //  '" +  +"'
                                                             //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggeststulistccode = new DataTable();
            con.sda.Fill(dtsuggeststulistccode);


            if (dtsuggeststulistccode.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggeststulistccode.Rows.Count; i++)
                {
                    coll.Add(dtsuggeststulistccode.Rows[i]["ccode"].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Course not found");
            }*/
            insertMarksccode.AutoCompleteMode = AutoCompleteMode.Suggest;
            insertMarksccode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            insertMarksccode.AutoCompleteCustomSource = coll;
        }

        public void Auto_MarksInsertstudentid()
        {
            con.dataGet("Select Student_Course.id from Student_Course,Teacher_Course where Student_Course.ccode = Teacher_Course.ccode "); //  '" +  +"'
                                                                                                                                           //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggestMarksInsert = new DataTable();
            con.sda.Fill(dtsuggestMarksInsert);


            if (dtsuggestMarksInsert.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggestMarksInsert.Rows.Count; i++)
                {
                    coll.Add(dtsuggestMarksInsert.Rows[i]["id"].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Student ID not found");
            }*/
            insertMarksstuid.AutoCompleteMode = AutoCompleteMode.Suggest;
            insertMarksstuid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            insertMarksstuid.AutoCompleteCustomSource = coll;
        }
        
        private void tchClist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Shows Course List
        private void CourseList_LoadData()
        {
            
            con.dataGet("Select * from Course,Teacher_Course where Teacher_Course.id= '" + tchcode + "' and Teacher_Course.ccode=Course.ccode");
            DataTable courselist = new DataTable();
            con.sda.Fill(courselist);
            foreach(DataRow row in courselist.Rows)
            {
                int n = tchClist.Rows.Add();
                tchClist.Rows[n].Cells["tchCserialnogrid"].Value = n + 1;
                tchClist.Rows[n].Cells["tchCcodegrid"].Value = row["ccode"].ToString();
                tchClist.Rows[n].Cells["tchCtitlegrid"].Value = row["ctitle"].ToString();
                tchClist.Rows[n].Cells["tchCtypegrid"].Value = row["ctype"].ToString();
                tchClist.Rows[n].Cells["tchCcreditgrid"].Value = row["ccredit"].ToString();
                tchClist.Rows[n].Cells["tchCdeptgrid"].Value = row["cdept"].ToString();
                tchClist.Rows[n].Cells["tchCproggrid"].Value = row["cprogram"].ToString();
                tchClist.Rows[n].Cells["tchCsemestergrid"].Value = row["tsemester"].ToString();
            }
            if (tabControl1.SelectedIndex == 0 && tabControl3.SelectedIndex == 0)
            {
                if (tchClist.Rows.Count == 0)
                {
                    MessageBox.Show("You haven't been Assigned to any course yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Shows Teacher Information
        private void tchinfopanel_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("Select * from Teacher where id='" + tchcode + "' ");
            DataTable tchinfo = new DataTable();
            con.sda.Fill(tchinfo);
            string Tchname,Tcode, Tpos,Tdept;
            Tchname = "Name : ";
            Tcode = "Teacher Code : ";
            Tpos = "Position : ";
            Tdept = "Department : ";
            if (tchinfo.Rows.Count > 0)
            {
                foreach (DataRow row in tchinfo.Rows)
                {
                    Tchname += row["tname"].ToString();
                    Tcode += row["id"].ToString();
                    Tpos += row["tposition"].ToString();
                    Tdept += row["tdept"].ToString();
                }
            }
            tchName.Text = Tchname;
            tchCode.Text = Tcode;
            tchPosition.Text = Tpos;
            tchDept.Text = Tdept;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==0 && tabControl3.SelectedIndex==0)
            {
                if (tchClist.Rows.Count == 0)
                {
                    MessageBox.Show("You haven't been Assigned to any course yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl3.SelectedIndex==0)
            {
                if (tchClist.Rows.Count  == 0)
                {
                    MessageBox.Show("You haven't been Assigned to any course yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tchstulistSrchbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select Student.id,Student.sname,Student.sintake,Student.ssection,Student.sdept,Student.sprog,Student.smobile from Teacher_Course,Student,Student_Course where Student.id=Student_Course.id and Student_Course.tid=Teacher_Course.id and Teacher_Course.ccode='"+tchCcode.Text+"' and Teacher_Course.tsemester='"+tchCsemester.Text+ "' and Student_Course.ccode='" + tchCcode.Text + "' and Student_Course.ssemester='" + tchCsemester.Text + "' and Student_Course.tid = '"+tchcode+"'");
            DataTable stulist = new DataTable();
            con.sda.Fill(stulist);
            tchstuGrid.Rows.Clear();
            if(stulist.Rows.Count>0)
            {
                foreach(DataRow row in stulist.Rows)
                {
                    int n = tchstuGrid.Rows.Add();
                    tchstuGrid.Rows[n].Cells["stulistserialnogrid"].Value = n + 1;
                    tchstuGrid.Rows[n].Cells["stulistidgrid"].Value = row["id"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistnamegrid"].Value = row["sname"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistintakegrid"].Value = row["sintake"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistsectiongrid"].Value = row["ssection"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistdeptgrid"].Value = row["sdept"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistproggrid"].Value = row["sprog"].ToString();
                    tchstuGrid.Rows[n].Cells["stulistmobilegrid"].Value = row["smobile"].ToString();
                }
                stulist_ClearData();
            }
            else
            {
                MessageBox.Show("No Student has taken this Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void stulist_ClearData()
        {
            tchCcode.Clear();
            tchCsemester.Clear();
        }
        string marksemester;
        private void marksSrchbtn_Click(object sender, EventArgs e)
        {
            marksemester = insertMarktsemester.Text;
            con.dataGet("Select Student.id,Student.sname,Student.sintake,Student.ssection,Student_Course.ccode from Student,Student_Course,Teacher_Course Where Student.id=Student_Course.id and Student_Course.tid=Teacher_Course.id and Student_Course.tid = '"+tchcode+"' and Student_Course.ccode = '"+ insertMarksccode.Text +"' and Student_Course.ssemester = '"+insertMarktsemester.Text+"' and Student_Course.ssemester = Teacher_Course.tsemester");
            DataTable Stulist = new DataTable();
            con.sda.Fill(Stulist);
            marksStulistgrid.Rows.Clear();
            if(Stulist.Rows.Count > 0)
            {
                foreach(DataRow row in Stulist.Rows)
                {
                    int n = marksStulistgrid.Rows.Add();
                    marksStulistgrid.Rows[n].Cells["insertMslgrid"].Value = n + 1;
                    marksStulistgrid.Rows[n].Cells["insertMsidgrid"].Value = row["id"].ToString();
                    marksStulistgrid.Rows[n].Cells["insertMsnamegrid"].Value = row["sname"].ToString();
                    marksStulistgrid.Rows[n].Cells["insertMsintakegrid"].Value = row["sintake"].ToString();
                    marksStulistgrid.Rows[n].Cells["insertMssectiongrid"].Value = row["ssection"].ToString();
                    marksStulistgrid.Rows[n].Cells["insertMccodegrid"].Value = row["ccode"].ToString();
                }
                Srch_Mark_Cleardata();

            }
            else
            {
                MessageBox.Show("There is no student in this Course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Srch_Mark_Cleardata()
        {
            insertMarksccode.Clear();
            insertMarktsemester.Clear();
        }
        string mcode;
        public void marksStulistgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = marksStulistgrid.Rows[e.RowIndex];
            insertMarksstuid.Text = row.Cells[1].Value.ToString();
            mcode = row.Cells[5].Value.ToString();
        }

        private void markInsertbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from Result where ccode = '" + mcode + "' and rsemester = '" + marksemester + "' and id = '" + insertMarksstumid.Text + "'");
            DataTable check = new DataTable();
            con.sda.Fill(check);
            if (check.Rows.Count > 0)
            {
                MessageBox.Show("You have inserted the marks of this Student Before.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string var = "id,ccode,rsemester,mid,final,outof25,attendence";
                string val = "'" + insertMarksstuid.Text + "','" + mcode + "','" + marksemester + "','" + insertMarksstumid.Text + "','" + insertMarksstufinal.Text + "','" + insertMarksstuct.Text + "','" + insertMarksstuatten.Text + "'";
                con.dataSend("INSERT into Result(" + var + ") values(" + val + ")");
                MessageBox.Show("Marks Successfully Inserted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                marksListgrid_LoadData();
            }
        }

        private void marksListgrid_LoadData()
        {
            con.dataGet("Select * from Result where ccode = '" + mcode + "' and rsemester = '" + marksemester + "'");
            DataTable Markt = new DataTable();
            con.sda.Fill(Markt);

            if(Markt.Rows.Count > 0)
            {
                foreach(DataRow row in Markt.Rows)
                {
                    int n = marksListgrid.Rows.Add();
                    marksListgrid.Rows[n].Cells["markslgrid"].Value = n+1;
                    marksListgrid.Rows[n].Cells["marksidgrid"].Value = row["id"].ToString();
                    marksListgrid.Rows[n].Cells["markmidgrid"].Value = row["mid"].ToString();
                    marksListgrid.Rows[n].Cells["markfinalgrid"].Value = row["final"].ToString();
                    marksListgrid.Rows[n].Cells["markof3grid"].Value = row["outof25"].ToString();
                    marksListgrid.Rows[n].Cells["markattendencegrid"].Value = row["attendence"].ToString();
                    string mid = row["mid"].ToString();
                    string final = row["final"].ToString();
                    string of25 = row["outof25"].ToString();
                    string att = row["attendence"].ToString();
                    int M, F, OF25, A,AN, Total;
                    M = int.Parse(mid);
                    F = int.Parse(final);
                    OF25 = int.Parse(of25);
                    A = int.Parse(att);
                    if (A >= 80) AN = 5;
                    else if(A<=79 && A>=70) AN = 4;
                    else if(A<=69 && A>=60) AN = 3;
                    else if(A<=59 && A>=55) AN = 2;
                    else AN = 1;
                    Total = (M+(F+(OF25 + AN)));
                    string grade;
                    //80+ = A+ =4.00
                    //75-79 = A =3.75
                    //70 - 74 =A- = 3.50
                    //65-69 = B+ = 3.25
                    //60-64 = B = 3.00
                    //55 - 59 =B- = 2.75
                    //50-54 = C+ = 2.50
                    //45-59 = C = 2.25
                    //40-44 = D = 2.00
                    //<40 = F
                    if (Total >= 80) grade = "A+";
                    else if (Total <= 79 && Total >= 75) grade = "A";
                    else if (Total <= 74 && Total >= 70) grade = "A-";
                    else if (Total <= 69 && Total >= 65) grade = "B+";
                    else if (Total <= 64 && Total >= 60) grade = "B";
                    else if (Total <= 59 && Total >= 55) grade = "B-";
                    else if (Total <= 54 && Total >= 50) grade = "C+";
                    else if (Total <= 49 && Total >= 45) grade = "C";
                    else if (Total <= 44 && Total >= 40) grade = "D";
                    else grade = "F";

                    marksListgrid.Rows[n].Cells["marktotalgrid"].Value = Total.ToString();
                    marksListgrid.Rows[n].Cells["markgradegrid"].Value = grade;
                }
            }
            else
            {
                MessageBox.Show("There is no Marks inserted yet.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void tch_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (tch_Showpass.Checked) //show pass clicked 
            {
                set_Oldpass.UseSystemPasswordChar = false;
                set_Newpass.UseSystemPasswordChar = false;
                set_Conpass.UseSystemPasswordChar = false;
            }
            else
            {
                set_Oldpass.UseSystemPasswordChar = true;
                set_Newpass.UseSystemPasswordChar = true;
                set_Conpass.UseSystemPasswordChar = true;
            }
        }
        private void tch_Setconfirmbtn_Click(object sender, EventArgs e)
        {
            if (set_Newpass.Text != "" && set_Conpass.Text != "") 
            {
                con.dataGet("select * from Teacher Where id = '" + tchcode + "' and pass = '" + set_Oldpass.Text + "'");
                DataTable oc = new DataTable();
                con.sda.Fill(oc);

                if(oc.Rows.Count > 0)
                {
                    if(set_Newpass.Text == set_Conpass.Text)
                    {
                        if (set_Newpass.Text != "" + tchcode + "bubt" && set_Conpass.Text != "" + tchcode + "bubt")
                        {
                            con.dataGet("select * from Forgot_Pass where fid = '" + tchcode + "' and fpass = '" + set_Conpass.Text + "'");
                            DataTable dc = new DataTable();
                            con.sda.Fill(dc);
                            if (dc.Rows.Count > 0)
                            {
                                MessageBox.Show("Old password can't be used again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string var = "fid,fpass";
                                string val = "'" + tchcode + "','" + set_Newpass.Text + "'";
                                con.dataSend("Update Teacher Set pass='" + set_Newpass.Text + "' where id='" + tchcode + "'");
                                con.dataSend("insert into Forgot_Pass(" + var + ") values(" + val + ")");
                                MessageBox.Show("Password changed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Old password doesn't match!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("New Password and Confirm Password can't be blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void set_Oldpass_TextChanged(object sender, EventArgs e)
        {
            if (tch_Showpass.Checked) //show pass clicked 
            {
                set_Oldpass.UseSystemPasswordChar = false;
                //set_Newpass.UseSystemPasswordChar = false;
                //set_Conpass.UseSystemPasswordChar = false;
            }
            else
            {
                set_Oldpass.UseSystemPasswordChar = true;
                //set_Newpass.UseSystemPasswordChar = true;
                //set_Conpass.UseSystemPasswordChar = true;
            }
        }

        private void set_Newpass_TextChanged(object sender, EventArgs e)
        {
            if (tch_Showpass.Checked) //show pass clicked 
            {
                //set_Oldpass.UseSystemPasswordChar = false;
                set_Newpass.UseSystemPasswordChar = false;
                //set_Conpass.UseSystemPasswordChar = false;
            }
            else
            {
                //set_Oldpass.UseSystemPasswordChar = true;
                set_Newpass.UseSystemPasswordChar = true;
                //set_Conpass.UseSystemPasswordChar = true;
            }
        }

        private void set_Conpass_TextChanged(object sender, EventArgs e)
        {
            if (tch_Showpass.Checked) //show pass clicked 
            {
                //set_Oldpass.UseSystemPasswordChar = false;
                //set_Newpass.UseSystemPasswordChar = false;
                set_Conpass.UseSystemPasswordChar = false;
            }
            else
            {
                //set_Oldpass.UseSystemPasswordChar = true;
                //set_Newpass.UseSystemPasswordChar = true;
                set_Conpass.UseSystemPasswordChar = true;
            }
        }
    }
}
