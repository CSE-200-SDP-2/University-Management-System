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
        string sn;
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

        private void Admin_Menu_Load(object sender, EventArgs e)
        { 
            Course_LoadData();
            Assign_LoadData();
            Auto_ccode();
            Auto_modstuid();
            Auto_tchcode();
           
        }
        AutoCompleteStringCollection collc = new AutoCompleteStringCollection();
        public void Auto_ccode()
        {
            
            con.dataGet("Select ccode from Course"); //  '" +  +"'
                                                     //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggestccode = new DataTable();
            con.sda.Fill(dtsuggestccode);


            if (dtsuggestccode.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggestccode.Rows.Count; i++)
                {
                    collc.Add(dtsuggestccode.Rows[i]["ccode"].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Course not found");
            }*/
            cCode2.AutoCompleteMode = AutoCompleteMode.Suggest;
            cCode2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cCode2.AutoCompleteCustomSource = collc;
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

        public void Auto_tchcode()
        {
            con.dataGet("Select id from Teacher"); //  '" +  +"'
                                                   //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggesttchcode = new DataTable();
            con.sda.Fill(dtsuggesttchcode);


            if (dtsuggesttchcode.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggesttchcode.Rows.Count; i++)
                {
                    coll.Add(dtsuggesttchcode.Rows[i]["id"].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Course not found");
            }*/
            tchCode2.AutoCompleteMode = AutoCompleteMode.Suggest;
            tchCode2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tchCode2.AutoCompleteCustomSource = coll;
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
            DataTable dtcourse = new DataTable();
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
            cProgram.SelectedIndex = -1;
            cDept.SelectedIndex = -1;
            cType.SelectedIndex = -1;
        }
        private void Course_LoadData()
        {
            con.dataGet("Select* from [Course]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            cReggrid.Rows.Clear();
            foreach (DataRow row in dt.Rows)
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
                con.dataGet("Select * from Teacher_Course where id='" + tchCode2.Text + "' and ccode='" + cCode2.Text + "' and tsemester='"+cSemester.Text+"'");
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
                    string variables = "id,ccode,tsemester";
                    string values = "'" + tchCode2.Text + "','" + cCode2.Text + "','" + cSemester.Text + "'";  //'"++"'
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
            cSemester.Clear();
        }
        private void Assign_LoadData()
        {
            con.dataGet("Select Teacher.tname,Teacher.id,Course.ccode,Course.ctitle,Course.ctype,Course.ccredit,Teacher_Course.tsemester from Teacher_Course,Teacher,Course where Teacher_Course.id=Teacher.id and Teacher_Course.ccode=Course.ccode and Course.ccode='" + cCode2.Text + "'"); //  or Course.ccode='" + cCode2.Text + "'               Teacher_Course.id=Teacher.id and Teacher_Course.ccode=Course.ccode          Teacher.id='" + tchCode2.Text + "' and Course.ccode='" + cCode2.Text + "' ---> Teacher.id='" + tchCode2.Text + "' or
            DataTable dtassign = new DataTable();
            con.sda.Fill(dtassign);
            cassigngrid.Rows.Clear();
            foreach (DataRow row in dtassign.Rows)
            {
                int n = cassigngrid.Rows.Add();
                cassigngrid.Rows[n].Cells["assignserialno"].Value = n + 1;
                cassigngrid.Rows[n].Cells["assigntchname"].Value = row["tname"].ToString();
                cassigngrid.Rows[n].Cells["assigntchcode"].Value = row["id"].ToString();
                cassigngrid.Rows[n].Cells["assignccode"].Value = row["ccode"].ToString();
                cassigngrid.Rows[n].Cells["assigncname"].Value = row["ctitle"].ToString();
                cassigngrid.Rows[n].Cells["assignctype"].Value = row["ctype"].ToString();
                cassigngrid.Rows[n].Cells["assignccredit"].Value = row["ccredit"].ToString();
                cassigngrid.Rows[n].Cells["assignsemester"].Value = row["tsemester"].ToString();
            }
            Assign_ClearData();
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
                con.dataGet("Select * from Student Where id = '" + id + "' and sname = '" + name + "' and sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if (id == "" && name != "" && intake != "" && section != "")//_BCD
            {
                con.dataGet("Select * from Student Where sname = '" + name + "' and sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if (id != "" && name == "" && intake != "" && section != "")//A_CD
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and  sintake = '" + intake + "' and ssection = '" + section + "'");
            }
            else if (id != "" && name != "" && intake == "" && section != "")//AB_D
            {
                con.dataGet("Select * from Student Where id = '" + id + "' and sname = '" + name + "' and  ssection = '" + section + "'");
            }
            else if (id != "" && name != "" && intake != "" && section == "")//ABC_
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
                foreach (DataRow row in Stuinfo.Rows)
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

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2 && tabControl4.SelectedIndex == 0)
            {
                MessageBox.Show("Please Enter only Student ID and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mod_stuGrid.Rows.Clear();
                Modstu_ClearData();
            }
            if (tabControl1.SelectedIndex == 2 && tabControl4.SelectedIndex == 1)
            {
                MessageBox.Show("Please Enter only Teacher Code and click Search.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mod_tchGrid.Rows.Clear();
                modtch_ClearData();
            }
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
        public void Clear_Tchdata()
        {
            srch_tchCode.Clear();
            srch_tchName.Clear();
            srch_tchPosition.SelectedIndex = -1;
            srch_tchDept.SelectedIndex = -1;
        }
        private void srch_tchSrchbtn_Click(object sender, EventArgs e)
        {
            string id, name, position, department;
            id = srch_tchCode.Text;
            name = srch_tchName.Text;
            position = srch_tchPosition.Text;
            department = srch_tchDept.Text;

            if (id != "" && name != "" && position != "" && department != "")//____
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tname = '" + name + "' and tposition = '" + position + "' and tdept = '" + department + "'");
            }
            else if (id == "" && name != "" && position != "" && department != "")//_BCD
            {
                con.dataGet("Select * from Teacher Where tname = '" + name + "' and tposition = '" + position + "' and tdept = '" + department + "'");
            }
            else if (id != "" && name == "" && position != "" && department != "")//A_CD
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and  tposition = '" + position + "' and tdept = '" + department + "'");
            }
            else if (id != "" && name != "" && position == "" && department != "")//AB_D
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tname = '" + name + "' and  tdept = '" + department + "'");
            }
            else if (id != "" && name != "" && position != "" && department == "")//ABC_
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tname = '" + name + "' and tposition = '" + position + "'");
            }
            // edit korte hobe-------<<<<<<<<<<<<<<<<
            else if (id == "" && name == "" && position != "" && department != "")//__CD
            {
                con.dataGet("Select * from Teacher Where  tposition = '" + position + "' and tdept = '" + department + "'");
            }
            else if (id == "" && name != "" && position == "" && department != "")//_B_D
            {
                con.dataGet("Select * from Teacher Where tname = '" + name + "' and tdept = '" + department + "'");
            }
            else if (id == "" && name != "" && position != "" && department == "")//_BC_
            {
                con.dataGet("Select * from Teacher Where  tname = '" + name + "' and tposition = '" + position + "'");
            }
            else if (id != "" && name == "" && position == "" && department != "")//A__D
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tdept = '" + department + "'");
            }
            else if (id != "" && name == "" && position != "" && department == "")//A_C_
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tposition = '" + position + "'");
            }
            else if (id != "" && name != "" && position == "" && department == "")//AB__
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "' and tname = '" + name + "'");
            }
            //-----<<<<<<<<<<<<<<<<<<<
            else if (id == "" && name == "" && position == "" && department != "")//___D
            {
                con.dataGet("Select * from Teacher Where tdept = '" + department + "'");
            }
            else if (id == "" && name == "" && position != "" && department == "")//__C_
            {
                con.dataGet("Select * from Teacher Where tposition = '" + position + "'");
            }
            else if (id == "" && name != "" && position == "" && department == "")//_B__
            {
                con.dataGet("Select * from Teacher Where tname = '" + name + "'");
            }
            else if (id != "" && name == "" && position == "" && department == "")//A___
            {
                con.dataGet("Select * from Teacher Where id = '" + id + "'");
            }
            else
            {
                MessageBox.Show("Please Enter at least 1 Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable tchinfo = new DataTable();
            con.sda.Fill(tchinfo);
            srch_tchGrid.Rows.Clear();

            if (tchinfo.Rows.Count > 0)
            {
                foreach (DataRow row in tchinfo.Rows)
                {
                    int n = srch_tchGrid.Rows.Add();
                    srch_tchGrid.Rows[n].Cells["srchtchslgrid"].Value = n + 1;
                    srch_tchGrid.Rows[n].Cells["srchtchnamegrid"].Value = row["tname"].ToString();
                    srch_tchGrid.Rows[n].Cells["srchtchidgrid"].Value = row["id"].ToString();
                    srch_tchGrid.Rows[n].Cells["srchtchpositiongrid"].Value = row["tposition"].ToString();
                    srch_tchGrid.Rows[n].Cells["srchtchdeptgrid"].Value = row["tdept"].ToString();
                    srch_tchGrid.Rows[n].Cells["srchtchmobilegrid"].Value = row["tmobile"].ToString();
                }
                Clear_Tchdata();
            }
            else
            {
                MessageBox.Show("Teacher Information doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void res_srchbtn_Click(object sender, EventArgs e)
        {
            string id = res_srchId.Text;
            string semester = res_srchSemester.Text;
            con.dataGet("select * from Student where id = '" + id + "'");

            DataTable Stuinfo = new DataTable();
            con.sda.Fill(Stuinfo);
            string id2, name, intake, section;
            name = "Name : ";
            id2 = "ID : ";
            intake = "Intake : ";
            section = "Section : ";
            if (Stuinfo.Rows.Count > 0)
            {
                foreach (DataRow row in Stuinfo.Rows)
                {
                    name += row["id"].ToString();
                    id2 += row["sname"].ToString();
                    intake += row["sintake"].ToString();
                    section += row["ssection"].ToString();
                }
            }
            else
            {
                MessageBox.Show("The Result isn't publish yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            res_srchStuid.Text = id2;
            res_srchStuname.Text = name;
            res_srchStuintake.Text = intake;
            res_srchStusection.Text = section;


            con.dataGet("Select * from Result,Course Where Result.ccode = Course.ccode and id = '" + id + "' and rsemester = '" + semester + "'");
            DataTable result = new DataTable();
            con.sda.Fill(result);

            float totalcredit = 0.00f;
            float totalgpa = 0.00f;
            res_srchGrid.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {

                int n = res_srchGrid.Rows.Add();
                res_srchGrid.Rows[n].Cells["rescslgrid"].Value = n + 1;
                res_srchGrid.Rows[n].Cells["resccodegrid"].Value = row["ccode"].ToString();
                res_srchGrid.Rows[n].Cells["rescmidgrid"].Value = row["mid"].ToString();
                res_srchGrid.Rows[n].Cells["rescfinalgrid"].Value = row["final"].ToString();
                res_srchGrid.Rows[n].Cells["rescoutof30"].Value = row["outof25"].ToString();
                res_srchGrid.Rows[n].Cells["rescattendence"].Value = row["attendence"].ToString();


                /// mid,final,out of 25 and attendence 
                string mid = row["mid"].ToString();
                string final = row["final"].ToString();
                string of25 = row["outof25"].ToString();
                string att = row["attendence"].ToString();

                //
                string credit = row["ccredit"].ToString();
                float ccredit1 = float.Parse(credit);

                float M, F, OF25, A, AN, Total;
                M = float.Parse(mid);
                F = float.Parse(final);
                OF25 = float.Parse(of25);
                A = float.Parse(att);
                if (A >= 80) AN = 5;
                else if (A <= 79 && A >= 70) AN = 4;
                else if (A <= 69 && A >= 60) AN = 3;
                else if (A <= 59 && A >= 55) AN = 2;
                else AN = 1;
                Total = (M + (F + (OF25 + AN)));
                string grade;
                float gpa;
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
                if (Total >= 80) { grade = "A+"; gpa = 4.00f; }
                else if (Total <= 79 && Total >= 75) { grade = "A"; gpa = 3.75f; }
                else if (Total <= 74 && Total >= 70) { grade = "A-"; gpa = 3.50f; }
                else if (Total <= 69 && Total >= 65) { grade = "B+"; gpa = 3.25f; }
                else if (Total <= 64 && Total >= 60) { grade = "B"; gpa = 3.00f; }
                else if (Total <= 59 && Total >= 55) { grade = "B-"; gpa = 2.75f; }
                else if (Total <= 54 && Total >= 50) { grade = "C+"; gpa = 2.50f; }
                else if (Total <= 49 && Total >= 45) { grade = "C"; gpa = 2.25f; }
                else if (Total <= 44 && Total >= 40) { grade = "D"; gpa = 2.00f; }
                else { grade = "F"; gpa = 0.00f; }



                res_srchGrid.Rows[n].Cells["resctotal"].Value = Total.ToString();
                res_srchGrid.Rows[n].Cells["rescgrade"].Value = grade;

                gpa *= ccredit1;
                totalcredit += ccredit1;
                totalgpa += gpa;

            }

            float sgpa;
            string sgpaa;
            sgpa = (totalgpa / totalcredit);
            sgpaa = String.Format("{0:0.00}", sgpa);

            if (!float.IsNaN(sgpa))
                rsgpa.Text = "SGPA : " + sgpaa;
            else
                rsgpa.Text = "SGPA : ";


        }
        private void mod_stuSrchbtn_Click(object sender, EventArgs e)
        {
            Modstu_LoadData();
        }
        private void Modstu_LoadData()
        {
            con.dataGet("Select * from Student where id='" + mod_stuId.Text + "'");
            DataTable modstudent = new DataTable();
            con.sda.Fill(modstudent);
            mod_stuGrid.Rows.Clear();
            if (modstudent.Rows.Count > 0)
            {
                // con.dataGet("Select * from Student where id='" + mod_stuId.Text + "'");
                // DataTable modstu = new DataTable();
                // con.sda.Fill(modstu);
                foreach (DataRow row in modstudent.Rows)
                {
                    int n = mod_stuGrid.Rows.Add();
                    mod_stuGrid.Rows[n].Cells["modstuserialnogrid"].Value = n + 1;
                    mod_stuGrid.Rows[n].Cells["modstuidgrid"].Value = row["id"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstunamegrid"].Value = row["sname"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstufnamegrid"].Value = row["sfname"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstumnamegrid"].Value = row["smname"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstudobgrid"].Value = row["sdob"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstubggrid"].Value = row["sbg"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstugendergrid"].Value = row["sgender"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstureligiongrid"].Value = row["sreligion"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstunationalitygrid"].Value = row["snationality"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstusectiongrid"].Value = row["ssection"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstuproggrid"].Value = row["sprog"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstudeptgrid"].Value = row["sdept"].ToString();
                    mod_stuGrid.Rows[n].Cells["modstumobilegrid"].Value = row["smobile"].ToString();
                }
                Modstu_ClearData();

            }
            else
            {
                MessageBox.Show("Student ID doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modstu_ClearData()
        {
            mod_stuId.Clear();
            mod_stuName.Clear();
            mod_stuFname.Clear();
            mod_stuMname.Clear();
            mod_stuDob.ResetText();
            mod_stuBg.SelectedIndex = -1;
            mod_stuGender.SelectedIndex = -1;
            mod_stuReligion.Clear();
            mod_stuNationality.Clear();
            mod_stuSection.Clear();
            mod_stuProgram.SelectedIndex = -1;
            mod_stuDept.SelectedIndex = -1;
            mod_stuMobile.Clear();

        }
        string agerid;
        public void mod_Stugrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = mod_stuGrid.Rows[e.RowIndex];
            sn = row.Cells[1].Value.ToString();
            mod_stuId.Text = mod_stuGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            agerid = mod_stuGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            mod_stuName.Text = row.Cells[2].Value.ToString();
            mod_stuFname.Text = row.Cells[3].Value.ToString();
            mod_stuMname.Text = row.Cells[4].Value.ToString();
            mod_stuDob.Text = row.Cells[5].Value.ToString();
            mod_stuBg.Text = row.Cells[6].Value.ToString();
            mod_stuGender.Text = row.Cells[7].Value.ToString();
            mod_stuReligion.Text = row.Cells[8].Value.ToString();
            mod_stuNationality.Text = row.Cells[9].Value.ToString();
            mod_stuSection.Text = row.Cells[10].Value.ToString();
            mod_stuProgram.Text = row.Cells[11].Value.ToString();
            mod_stuDept.Text = row.Cells[12].Value.ToString();
            mod_stuMobile.Text = row.Cells[13].Value.ToString();

        }
        private void mod_stuUpdatebtn_Click(object sender, EventArgs e)
        {
            DialogResult stuupdate = MessageBox.Show("Update student information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (stuupdate == DialogResult.Yes)
            {
                if (agerid == mod_stuId.Text)
                {
                    con.dataSend("Update Student Set sname ='" + mod_stuName.Text + "',sfname='" + mod_stuFname.Text + "',smname='" + mod_stuMname.Text + "',sdob='" + mod_stuDob.Text + "',sbg ='" + mod_stuBg.Text + "',sgender='" + mod_stuGender.Text + "',sreligion='" + mod_stuReligion.Text + "',snationality='" + mod_stuNationality.Text + "',ssection='" + mod_stuSection.Text + "',sprog='" + mod_stuProgram.Text + "',sdept='" + mod_stuDept.Text + "',smobile='" + mod_stuMobile.Text + "' where id = '" + mod_stuId.Text + "'");
                    mod_stuGrid.Rows.Clear();
                    Modstu_LoadData();
                    Modstu_ClearData();
                }
                else
                {
                    MessageBox.Show("Student ID can't be changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mod_stuDeletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                con.dataSend("Delete From Student Where id = '" + mod_stuId.Text + "'");
                mod_stuGrid.Rows.Clear();
                Modstu_ClearData();
            }
        }
        private void mod_tchSrchbtn_Click(object sender, EventArgs e)
        {
            modtch_LoadData();
        }
        private void mod_tchUpdatebtn_Click(object sender, EventArgs e)
        {
            DialogResult tchupdate = MessageBox.Show("Update teacher information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tchupdate == DialogResult.Yes)
            {
                if (agercode == mod_tchCode.Text)
                {
                    con.dataSend("Update Teacher Set tname ='" + mod_tchName.Text + "',tfname='" + mod_tchFname.Text + "',tmname='" + mod_tchMname.Text + "',tdob='" + mod_tchDob.Text + "',tbg ='" + mod_tchBg.Text + "',tgender='" + mod_tchGender.Text + "',treligion='" + mod_tchReligion.Text + "',tnationality='" + mod_tchNationality.Text + "',tposition='" + mod_tchPosition.Text + "',tdept='" + mod_tchDept.Text + "',tmobile='" + mod_tchMobile.Text + "' where id = '" + mod_tchCode.Text + "'");
                    mod_tchGrid.Rows.Clear();
                    modtch_LoadData();
                    modtch_ClearData();
                }
                else
                {
                    MessageBox.Show("Teacher code can't be changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mod_tchDeletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                con.dataSend("Delete From Teacher Where id = '" + mod_tchCode.Text + "'");
                mod_tchGrid.Rows.Clear();
                modtch_ClearData();
            }
        }
        private void modtch_LoadData()
        {
            con.dataGet("select * from Teacher where id = '" + mod_tchCode.Text + "'");
            DataTable modtchinfo = new DataTable();
            con.sda.Fill(modtchinfo);
            if(modtchinfo.Rows.Count > 0)
            {
                foreach(DataRow row in modtchinfo.Rows)
                {
                    int n = mod_tchGrid.Rows.Add();
                    mod_tchGrid.Rows[n].Cells["modtchslnogrid"].Value = n + 1;
                    mod_tchGrid.Rows[n].Cells["modtchcodegrid"].Value = row["id"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchnamegrid"].Value = row["tname"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchfnamegrid"].Value = row["tfname"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchmnamegrid"].Value = row["tmname"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchdobgrid"].Value = row["tdob"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchbggrid"].Value = row["tbg"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchgendergrid"].Value = row["tgender"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchreligiongrid"].Value = row["treligion"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchnationalitygrid"].Value = row["tnationality"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchpositiongrid"].Value = row["tposition"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchdeptgrid"].Value = row["tdept"].ToString();
                    mod_tchGrid.Rows[n].Cells["modtchmobilegrid"].Value = row["tmobile"].ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("The teacher doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void modtch_ClearData()
        {
            mod_tchCode.Clear();
            mod_tchName.Clear();
            mod_tchFname.Clear();
            mod_tchMname.Clear();
            mod_tchDob.ResetText();
            mod_tchBg.SelectedIndex = -1;
            mod_tchGender.SelectedIndex = -1;
            mod_tchReligion.Clear();
            mod_tchNationality.Clear();
            mod_tchPosition.SelectedIndex = -1;
            mod_tchDept.SelectedIndex = -1;
            mod_tchMobile.Clear();

        }
        string agercode;
        public void mod_tchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = mod_tchGrid.Rows[e.RowIndex];
            mod_tchCode.Text = row.Cells[1].Value.ToString();
            agercode = row.Cells[1].Value.ToString();
            mod_tchName.Text = row.Cells[2].Value.ToString();
            mod_tchFname.Text = row.Cells[3].Value.ToString();
            mod_tchMname.Text = row.Cells[4].Value.ToString();
            mod_tchDob.Text = row.Cells[5].Value.ToString();
            mod_tchBg.Text = row.Cells[6].Value.ToString();
            mod_tchGender.Text = row.Cells[7].Value.ToString();
            mod_tchReligion.Text = row.Cells[8].Value.ToString();
            mod_tchNationality.Text = row.Cells[9].Value.ToString();
            mod_tchPosition.Text = row.Cells[10].Value.ToString();
            mod_tchDept.Text = row.Cells[11].Value.ToString();
            mod_tchMobile.Text = row.Cells[12].Value.ToString();
        }

        private void modTchremove_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(del==DialogResult.Yes)
            {
                con.dataSend("Delete from Teacher_Course where Teacher_Course.id='" + modTchcode.Text + "' and Teacher_Course.ccode='" + modCcode.Text + "' and Teacher_Course.tsemester='" + modSemester.Text + "'");
                con.dataSend("Delete from Student_Course where Student_Course.tid='" + modTchcode.Text + "' and Student_Course.ccode='" + modCcode.Text + "' and Student_Course.ssemester='" + modSemester.Text + "'");
                mod_Tchremove_ClearData();
            }
        }
        private void mod_Tchremove_ClearData()
        {
            modTchcode.Clear();
            modCcode.Clear();
            modSemester.Clear();
        }
        string srno,Ccode;
        private void modCoursegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = modCoursegrid.Rows[e.RowIndex];
            srno = row.Cells[1].Value.ToString();
            modCcode2.Text= modCoursegrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Ccode = modCoursegrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            modCtitle2.Text = modCoursegrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            modCcredit2.Text = modCoursegrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void modCsrch_Click(object sender, EventArgs e)
        {
            mod_Course_LoadData();
            modCcode2.Clear();
        }
        private void mod_Course_LoadData()
        {
            con.dataGet("Select * from Course where ccode='" + modCcode2.Text + "'");
            DataTable modCourse = new DataTable();
            con.sda.Fill(modCourse);
            modCoursegrid.Rows.Clear();
            if(modCourse.Rows.Count>0)
            {
                foreach(DataRow row in modCourse.Rows)
                {
                    int n = modCoursegrid.Rows.Add();
                    modCoursegrid.Rows[n].Cells["modCserialnogrid"].Value = n + 1;
                    modCoursegrid.Rows[n].Cells["modCcodegrid"].Value = row["ccode"].ToString();
                    modCoursegrid.Rows[n].Cells["modCtitlegrid"].Value = row["ctitle"].ToString();
                    modCoursegrid.Rows[n].Cells["modCcreditgrid"].Value = row["ccredit"].ToString();
                    modCoursegrid.Rows[n].Cells["modCtypegrid"].Value = row["ctype"].ToString();
                    modCoursegrid.Rows[n].Cells["modCproggrid"].Value = row["cprogram"].ToString();
                    modCoursegrid.Rows[n].Cells["modCdeptgrid"].Value = row["cdept"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Course information doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modDelete_Course_Click(object sender, EventArgs e)
        {
            DialogResult coursedel = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (coursedel == DialogResult.Yes)
            {
                con.dataSend("Delete from Course where ccode ='" + modCcode2.Text + "'");
            }
        }

        private void res_totalSrchbtn_Click(object sender, EventArgs e)
        {
            con.dataSend("Drop View Slist");
            con.dataSend("Drop View Clist");
            con.dataSend("Create View [Slist] As Select student.id,Student_Course.ccode from Student,Student_Course Where Student.id = Student_Course.id and Student.sdept = '" + res_totalDept.Text + "' and Student.sintake = '" + res_totalIntake.Text + "' and  Student.ssection ='" + res_totalSection.Text + "' and Student_Course.ssemester = '" + res_totalSemester.Text + "'");
            con.dataSend("Create View [Clist] As Select id,Count(ccode) as A From Slist group by id");

            con.dataGet("Select Max(A) As maxx from Clist");
            DataTable cmax = new DataTable();
            con.sda.Fill(cmax);
            res_totalResultgrid.Rows.Clear();
            int Max2 = 0;
            if (cmax.Rows.Count > 0)
            {
                //int Max2;
                foreach (DataRow row in cmax.Rows)
                {
                    string Max1 = row["maxx"].ToString();
                    Max2 = int.Parse(Max1);
                }

                //int totalcoloumn = 3;
                for(int i = 1; i <= Max2 ; i++)
                {
                    string s = i.ToString();
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.DataPropertyName = "subject" + s + "";
                    col.Name = "Subject " + s + "";
                    res_totalResultgrid.Columns.Add(col);
                    DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                    col2.DataPropertyName = "subject" + s + "g";
                    col2.Name = "Grade";
                    res_totalResultgrid.Columns.Add(col2);
                }

                con.dataGet("Select distinct id from [Slist]");
                DataTable Sl = new DataTable();
                con.sda.Fill(Sl);
                foreach(DataRow row in Sl.Rows)
                {
                    int n = res_totalResultgrid.Rows.Add();
                    res_totalResultgrid.Rows[n].Cells["totalresAdminslgrid"].Value = n + 1;
                    string iid = row["id"].ToString();
                    con.dataGet("Select id,sname from Student Where id = '" + iid + "'");
                    DataTable Stu = new DataTable();
                    con.sda.Fill(Stu);
                    foreach(DataRow row1 in Stu.Rows)
                    {
                        res_totalResultgrid.Rows[n].Cells["totalresAdminidgrid"].Value = row1["id"].ToString();
                        res_totalResultgrid.Rows[n].Cells["totalresAdminsnamegrid"].Value = row1["sname"].ToString();
                    }

                    con.dataGet("Select Course.ccode,Course.ccredit,Result.mid,Result.final,Result.outof25,Result.attendence From Course,Result Where Result.ccode = Course.ccode and Result.id = '" + iid + "' and rsemester = '" + res_totalSemester.Text + "'");
                    DataTable result = new DataTable();
                    con.sda.Fill(result);
                    float totalcredit = 0.00f;
                    float totalgpa = 0.00f;
                    int j = 3;
                    foreach (DataRow row2 in result.Rows)
                    {
                        /// mid,final,out of 25 and attendence 
                        string mid = row2["mid"].ToString();
                        string final = row2["final"].ToString();
                        string of25 = row2["outof25"].ToString();
                        string att = row2["attendence"].ToString();

                        //
                        string credit = row2["ccredit"].ToString();
                        float ccredit1 = float.Parse(credit);

                        float  M, F, OF25, AN, Total;
                        int A;
                        M = float.Parse(mid);
                        F = float.Parse(final);
                        OF25 = float.Parse(of25);
                        A = int.Parse(att);
                        if (A >= 80) AN = 5;
                        else if (A <= 79 && A >= 70) AN = 4;
                        else if (A <= 69 && A >= 60) AN = 3;
                        else if (A <= 59 && A >= 55) AN = 2;
                        else AN = 1;
                        Total = (M + (F + (OF25 + AN)));
                        string grade;
                        float gpa;
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
                        if (Total >= 80) { grade = "A+"; gpa = 4.00f; }
                        else if (Total <= 79 && Total >= 75) { grade = "A"; gpa = 3.75f; }
                        else if (Total <= 74 && Total >= 70) { grade = "A-"; gpa = 3.50f; }
                        else if (Total <= 69 && Total >= 65) { grade = "B+"; gpa = 3.25f; }
                        else if (Total <= 64 && Total >= 60) { grade = "B"; gpa = 3.00f; }
                        else if (Total <= 59 && Total >= 55) { grade = "B-"; gpa = 2.75f; }
                        else if (Total <= 54 && Total >= 50) { grade = "C+"; gpa = 2.50f; }
                        else if (Total <= 49 && Total >= 45) { grade = "C"; gpa = 2.25f; }
                        else if (Total <= 44 && Total >= 40) { grade = "D"; gpa = 2.00f; }
                        else { grade = "F"; gpa = 0.00f; }

                        //string sub = "subject" + j + "";
                        res_totalResultgrid.Rows[n].Cells[++j].Value = row2["ccode"].ToString();
                        //string gg = "subject" + j + "g";
                        res_totalResultgrid.Rows[n].Cells[++j].Value = grade;



                        gpa *= ccredit1;
                        totalcredit += ccredit1;
                        totalgpa += gpa;

                    }

                    float sgpa;
                    string sgpaa;
                    sgpa = (totalgpa / totalcredit);
                    sgpaa = String.Format("{0:0.00}", sgpa);

                    if (!float.IsNaN(sgpa))
                    {
                        res_totalResultgrid.Rows[n].Cells["totalresAdminsgpagrid"].Value = sgpaa;
                    }
                    else
                    {
                        //kisuina
                    }
                }
            }
            else
            {
                // Pore lekhmu ne
            }

            
        }

        private void res_srchClearbtn_Click(object sender, EventArgs e)
        {
            res_srchStuid.Text = "ID";
            res_srchStuname.Text = "Name";
            res_srchStuintake.Text = "Intake";
            res_srchStusection.Text = "Section";
            res_srchGrid.Rows.Clear();
            rsgpa.Text = "SGPA : ";
            res_srchId.Clear();
            res_srchSemester.Clear();

        }

        private void modUpdate_Course_Click(object sender, EventArgs e)
        {
            DialogResult courseupdate = MessageBox.Show("Update teacher information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (courseupdate == DialogResult.Yes)
            {
                con.dataSend("Update Course set ccode='" + modCcode2.Text + "',ctitle='" + modCtitle2.Text + "',ccredit='" + modCcredit2.Text + "' where ccode='" + Ccode + "'");
                modCoursegrid.Rows.Clear();
                mod_Course_LoadData();
                modCcode2.Clear();
                modCtitle2.Clear();
                modCcredit2.Clear();
            }
        }
    }
}
