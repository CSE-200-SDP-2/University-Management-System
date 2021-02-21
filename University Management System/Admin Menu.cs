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
    public partial class Admin_Menu : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        DBAccess con = new DBAccess();
        //string sn;
        //string assignid="";
        //string assigncoursecode="";
        public Admin_Menu()
        {
            InitializeComponent();
        }
        public Home_Page mainForm = null;
        public Admin_Menu(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuinfo_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {
            
            Course_LoadData();
            Assign_LoadData();
            Auto_ccode();
            Auto_modstuid();
        }
        public void Auto_ccode()
        {
            con.dataGet("Select ccode from Course"); //  '" +  +"'
                                                                                                                                                              //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggestccode = new DataTable();
            con.sda.Fill(dtsuggestccode);


            if (dtsuggestccode.Rows.Count > 0)
            {
                for(int i=0;i<dtsuggestccode.Rows.Count;i++)
                {
                    coll.Add(dtsuggestccode.Rows[i]["ccode"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Course not found");
            }
            cCode2.AutoCompleteMode = AutoCompleteMode.Suggest;
            cCode2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cCode2.AutoCompleteCustomSource = coll;
            }

        public void Auto_modstuid()
        {
            con.dataGet("Select id from Student"); //  '" +  +"'
                                                     //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggestmodstuid = new DataTable();
            con.sda.Fill(dtsuggestmodstuid);


            if (dtsuggestmodstuid.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggestmodstuid.Rows.Count; i++)
                {
                    coll.Add(dtsuggestmodstuid.Rows[i]["id"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Student ID not found");
            }
            mod_stuId.AutoCompleteMode = AutoCompleteMode.Suggest;
            mod_stuId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mod_stuId.AutoCompleteCustomSource = coll;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void tchinfo_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void stuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuRegbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select Student.id from Student where Student.id='" + stuId.Text + "'");                                                                                                                                                              //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtstudent = new DataTable();
            con.sda.Fill(dtstudent);


            if (dtstudent.Rows.Count > 0)
            {
                MessageBox.Show("Student Information Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string stuPass = "" + stuId.Text + "bubt";
                string variables = "id,sname,sfname,smname,sdob,sbg,sgender,sreligion,snationality,sintake,ssection,sprog,sdept,smobile,pass";
                string values = "'" + stuId.Text + "','" + stuName.Text + "','" + stuFname.Text + "','" + stuMname.Text + "','" + stuDob.Text + "','" + stuBg.Text + "','" + stuGender.Text + "','" + stuReligion.Text + "','" + stuNationality.Text + "','" + stuIntake.Text + "','" + stuSection.Text + "','" + stuProgram.Text + "','" + stuDept.Text + "','" + stuMobile.Text + "','" + stuPass + "'";
                con.dataSend("Insert into Student(" + variables + ") values(" + values + ")");
                MessageBox.Show("Student information Registered Successfully");
                Student_ClearData();
            }
        }
        private void Student_ClearData()
        {
            stuId.Clear();
            stuName.Clear();
            stuFname.Clear();
            stuMname.Clear();
            stuDob.ResetText();
            stuBg.SelectedIndex = -1;
            stuGender.SelectedIndex = -1;
            stuReligion.Clear();
            stuNationality.Clear();
            stuIntake.Clear();
            stuSection.Clear();
            stuProgram.SelectedIndex = -1;
            stuDept.SelectedIndex = -1;
            stuMobile.Clear();
        }

        
        private void tchRegbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select Teacher.id from Teacher where Teacher.id='" + tchCode.Text + "'");                                                                                                                                                        //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtteacher = new DataTable();
            con.sda.Fill(dtteacher);


            if (dtteacher.Rows.Count > 0)
            {
                MessageBox.Show("Teacher Information Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tchPass = "" + tchCode.Text + "bubt";
                string variables = "id,tname,tfname,tmname,tdob,tbg,tgender,treligion,tnationality,tposition,tdept,tmobile,pass";
                string values = "'" + tchCode.Text + "','" + tchName.Text + "','" + tchFname.Text + "','" + tchMname.Text + "','" + tchDob.Text + "','" + tchBg.Text + "','" + tchGender.Text + "','" + tchReligion.Text + "','" + tchNationality.Text + "','" + tchPosition.Text + "','" + tchDept.Text + "','" + tchMobile.Text + "','" + tchPass + "'";
                con.dataSend("Insert into Teacher(" + variables + ") values(" + values + ")");
                MessageBox.Show("Teacher information Registered Successfully");
                Teacher_ClearData();
            }
        }
        private void Teacher_ClearData()
        {
            tchCode.Clear();
            tchName.Clear();
            tchFname.Clear();
            tchMname.Clear();
            tchDob.ResetText();
            tchBg.SelectedIndex = -1;
            tchGender.SelectedIndex = -1;
            tchReligion.Clear();
            tchNationality.Clear();
            tchPosition.SelectedIndex = -1;
            tchDept.SelectedIndex = -1;
            tchMobile.Clear();
        }

        private void cRegbtn_Click(object sender, EventArgs e)
        {
            con.dataGet("Select Course.ccode from Course where Course.ccode='" + cCode.Text + "'"); //  '" +  +"'                                                                                                                                                              //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtcourse= new DataTable();
            con.sda.Fill(dtcourse);


            if (dtcourse.Rows.Count > 0)
            {
                MessageBox.Show("Course Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string variables = "ccode,ctitle,ccredit,cprogram,cdept,ctype";
                string values = "'" + cCode.Text + "','" + cTitle.Text + "','" + cCredit.Text + "','" + cProgram.Text + "','" + cDept.Text + "','" + cType.Text + "'";
                con.dataSend("Insert into Course(" + variables + ") values(" + values + ")");
                MessageBox.Show("Course information Registered Successfully");
                Course_ClearData();
                Course_LoadData();
            }
        }
        private void Course_ClearData()
        {
            cCode.Clear();
            cTitle.Clear();
            cCredit.Clear();
            cProgram.SelectedIndex=-1;
            cDept.SelectedIndex = -1;
            cType.SelectedIndex = -1;
        }
        private void Course_LoadData()
        {
            con.dataGet("Select* from [Course]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            cReggrid.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                int n = cReggrid.Rows.Add();
                cReggrid.Rows[n].Cells["serialno"].Value = n + 1;
                cReggrid.Rows[n].Cells["ccodegrid"].Value = row["ccode"].ToString();
                cReggrid.Rows[n].Cells["ctitlegrid"].Value = row["ctitle"].ToString();
                cReggrid.Rows[n].Cells["ctypegrid"].Value = row["ctype"].ToString();
                cReggrid.Rows[n].Cells["ccreditgrid"].Value = row["ccredit"].ToString();
                cReggrid.Rows[n].Cells["cproggrid"].Value = row["cprogram"].ToString();
                cReggrid.Rows[n].Cells["cdeptgrid"].Value = row["cdept"].ToString();
            }
        }

        private void cReggrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* DataGridViewRow row = cReggrid.Rows[e.RowIndex];
            sn = row.Cells[1].Value.ToString();
            //cCode.Text = cReggrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            cCode.Text = row.Cells[1].Value.ToString();
            cTitle.Text = row.Cells[2].Value.ToString();
            cType.Text = row.Cells[3].Value.ToString();
            cCredit.Text = row.Cells[4].Value.ToString();
            cProgram.Text = row.Cells[5].Value.ToString();
            cDept.Text = row.Cells[6].Value.ToString();  */
        }

        private void Admin_Menu_Activated(object sender, EventArgs e)
        {
            //Course_LoadData();
        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void cAssignbtn_Click(object sender, EventArgs e)
        {
            //string check;
            //con.dataGet("select id from [Teacher]");
            con.dataGet("Select Teacher.id,Course.ccode from Teacher,Course where Teacher.id='" + tchCode2.Text + "'and Course.ccode='" + cCode2.Text + "'"); //  '" +  +"'
                                                                                                                    //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dt = new DataTable();
            con.sda.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                con.dataGet("Select * from Teacher_Course where id='" + tchCode2.Text + "' and ccode='" + cCode2.Text + "'");
                DataTable dt2 = new DataTable();
                con.sda.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("Teacher Already Assigned to Course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //assignid += tchCode2.Text;
                    //assigncoursecode += cCode2.Text;
                    //check = con.dataGet("Select id from Teacher where id='" + tchCode2.Text + "'");
                    string variables = "id,ccode";
                    string values = "'" + tchCode2.Text + "','" + cCode2.Text + "'";  //'"++"'
                    con.dataSend("Insert into Teacher_Course(" + variables + ") values(" + values + ")");
                    MessageBox.Show("Teacher Assigned To Course");
                    //Assign_ClearData();
                    Assign_LoadData();
                    
                }
            }
            else
            {
                MessageBox.Show("Teacher or Course Information doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Assign_ClearData()
        {
            tchCode2.Clear();
            cCode2.Clear();
        }

        private void Assign_LoadData()
        {
             con.dataGet("Select Teacher.tname,Teacher.id,Course.ccode,Course.ctitle,Course.ctype,Course.ccredit from Teacher,Course where Teacher.id='" + tchCode2.Text + "' and Course.ccode='" + cCode2.Text + "'"); //  or Course.ccode='" + cCode2.Text + "'               Teacher_Course.id=Teacher.id and Teacher_Course.ccode=Course.ccode          Teacher.id='" + tchCode2.Text + "' and Course.ccode='" + cCode2.Text + "'
            DataTable dtassign = new DataTable();
             con.sda.Fill(dtassign);
             cassigngrid.Rows.Clear();
             foreach(DataRow row in dtassign.Rows)
             {
                 int n = cassigngrid.Rows.Add();
                 cassigngrid.Rows[n].Cells["assignserialno"].Value = n + 1;
                 cassigngrid.Rows[n].Cells["assigntchname"].Value = row["tname"].ToString();
                 cassigngrid.Rows[n].Cells["assigntchcode"].Value = row["id"].ToString();
                 cassigngrid.Rows[n].Cells["assignccode"].Value = row["ccode"].ToString();
                 cassigngrid.Rows[n].Cells["assigncname"].Value = row["ctitle"].ToString();
                 cassigngrid.Rows[n].Cells["assignctype"].Value = row["ctype"].ToString();
                 cassigngrid.Rows[n].Cells["assignccredit"].Value = row["ccredit"].ToString();
             }  
            Assign_ClearData();
        }

        private void cassigngrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cCode2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mod_stuSrchbtn_Click(object sender, EventArgs e)
        {
            //con.dataGet("Select id from Student")
        }

        public void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl4.SelectedIndex == 0)
            {
                MessageBox.Show("Please Enter only Student ID and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tabControl4.SelectedIndex == 1)
            {
                MessageBox.Show("Please Enter only Teacher Code and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2 && tabControl4.SelectedIndex==0)
            {
                MessageBox.Show("Please Enter only Student ID and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tabControl1.SelectedIndex == 2 && tabControl4.SelectedIndex == 1)
            {
                MessageBox.Show("Please Enter only Teacher Code and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Clear_Studata()
        {
            srch_stuId.Clear();
            srch_stuName.Clear();
            srch_stuIntake.Clear();
            srch_stuSection.Clear();
        }
        private void srch_stubtn_Click(object sender, EventArgs e)
        {
            string id, name, intake, section;
            id = srch_stuId.Text;
            name = srch_stuName.Text;
            intake = srch_stuIntake.Text;
            section = srch_stuSection.Text;

            if (id != "" && name != "" && intake != "" && section != "")//____
            {
                con.dataGet("Select * from Student Where id = '"+id+"' and sname = '"+name+"' and sintake = '"+intake+"' and ssection = '"+section+"'");
            }
            else if (id == "" && name != "" && intake != "" && section != "")//_BCD
            {
                con.dataGet("Select * from Student Where sname = '" + name + "' and sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if(id != "" && name == "" && intake != "" && section != "")//A_CD
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and  sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if(id != "" && name != "" && intake == "" && section != "")//AB_D
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and sname = '" + name + "' and  ssection = '" + section + "'");
            }
            else if(id != "" && name != "" && intake != "" && section == "")//ABC_
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and sname = '" + name + "' and sintake = '" + intake + "'");
            }
            // edit korte hobe-------<<<<<<<<<<<<<<<<
            else if (id == "" && name == "" && intake != "" && section != "")//__CD
            {
                con.dataGet("Select * from Student Where  sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if (id == "" && name != "" && intake == "" && section != "")//_B_D
            {
                con.dataGet("Select * from Student Where sname = '" + name + "' and ssection = '" + section + "'");
            }
            else if (id == "" && name != "" && intake != "" && section == "")//_BC_
            {
                con.dataGet("Select * from Student Where  sname = '" + name + "' and sintake = '" + intake + "'");
            }
            else if (id != "" && name == "" && intake == "" && section != "")//A__D
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and ssection = '" + section + "'");
            }
            else if (id != "" && name == "" && intake != "" && section == "")//A_C_
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and sintake = '" + intake + "'");
            }
            else if (id != "" && name != "" && intake == "" && section == "")//AB__
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and sname = '" + name + "'");
            }
            //-----<<<<<<<<<<<<<<<<<<<
            else if (id == "" && name == "" && intake == "" && section != "")//___D
            {
                con.dataGet("Select * from Student Where ssection = '" + section + "'");
            }
            else if (id == "" && name == "" && intake != "" && section == "")//__C_
            {
                con.dataGet("Select * from Student Where sintake = '" + intake + "'");
            }
            else if (id == "" && name != "" && intake == "" && section == "")//_B__
            {
                con.dataGet("Select * from Student Where sname = '" + name + "'");
            }
            else if (id != "" && name == "" && intake == "" && section == "")//A___
            {
                con.dataGet("Select * from Student Where id = '" + id + "'");
            }
            else
            {
                MessageBox.Show("Please Enter at least 1 Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable Stuinfo = new DataTable();
            con.sda.Fill(Stuinfo);
            srch_stuGrid.Rows.Clear();

            if (Stuinfo.Rows.Count > 0)
            {
                foreach(DataRow row in Stuinfo.Rows)
                {
                    int n = srch_stuGrid.Rows.Add();
                    srch_stuGrid.Rows[n].Cells["stuslgrid"].Value = n + 1;
                    srch_stuGrid.Rows[n].Cells["stunamegrid"].Value = row["sname"].ToString();
                    srch_stuGrid.Rows[n].Cells["stuidgrid"].Value = row["id"].ToString();
                    srch_stuGrid.Rows[n].Cells["stuintakegrid"].Value = row["sintake"].ToString();
                    srch_stuGrid.Rows[n].Cells["stusectiongrid"].Value = row["ssection"].ToString();
                    srch_stuGrid.Rows[n].Cells["stuproggrid"].Value = row["sprog"].ToString();
                    srch_stuGrid.Rows[n].Cells["studeptgrid"].Value = row["sdept"].ToString();
                    srch_stuGrid.Rows[n].Cells["stumobilegrid"].Value = row["smobile"].ToString();
                }
                Clear_Studata();
            }
            else
            {
                MessageBox.Show("Student Information doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
