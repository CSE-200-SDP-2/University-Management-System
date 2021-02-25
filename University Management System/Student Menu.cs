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
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        DBAccess con = new DBAccess();
        string studentid = UserName.username;
        string teacherid = TeacherCode.teachercode;
        public Student_Menu()
        {
            InitializeComponent();
            
        }

        public Home_Page mainForm = null;
        public Student_Menu(Form callingForm)
        {
            mainForm = callingForm as Home_Page;
            InitializeComponent();
        }
        private void Student_Menu_Load(object sender, EventArgs e)
        {
            StuCourse_LoadData();
            Auto_studentCourseSelectioncoursecode();
            Auto_studentCourseSelectionsemester();
            Stu_CurrentCourse_LoadData();
        }

        public void Auto_studentCourseSelectioncoursecode()
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
            stu_Ccode.AutoCompleteMode = AutoCompleteMode.Suggest;
            stu_Ccode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            stu_Ccode.AutoCompleteCustomSource = coll;
        }
        public void Auto_studentCourseSelectionsemester()
        {
            con.dataGet("Select tsemester from Teacher_Course"); //  '" +  +"'
                                                             //}                                                                               //con.dataGet("Select * from Admin where id='" + aname.Text + "' and pass='" + apass.Text + "'"); //  '" +  +"'
            DataTable dtsuggestsemester = new DataTable();
            con.sda.Fill(dtsuggestsemester);


            if (dtsuggestsemester.Rows.Count > 0)
            {
                for (int i = 0; i < dtsuggestsemester.Rows.Count; i++)
                {
                    coll.Add(dtsuggestsemester.Rows[i]["tsemester"].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Course not found");
            }*/
            stu_Csemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            stu_Csemester.AutoCompleteSource = AutoCompleteSource.CustomSource;
            stu_Csemester.AutoCompleteCustomSource = coll;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void stumenuinfopanel_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select * from Student where id = '" + studentid + "'");

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
                    name += row["sname"].ToString();
                    id2 += row["id"].ToString();
                    intake += row["sintake"].ToString();
                    section += row["ssection"].ToString();
                }
            }
            stuId.Text = id2;
            stuName.Text = name;
            stuIntake.Text = intake;
            stuSection.Text = section;
        }
        string semester;
        public void stu_Srchbtn_Click(object sender, EventArgs e)
        {
            semester = stu_Csemester.Text;
            con.dataGet("Select * from Teacher_Course,Course where Teacher_Course.ccode=Course.ccode and Course.cprogram='"+ stu_Cprogram.Text+"' and Course.cdept='"+stu_Cdept.Text+"' and Teacher_Course.ccode='"+stu_Ccode.Text+"' and Teacher_Course.tsemester='" + stu_Csemester.Text + "'");
            DataTable stuCA = new DataTable();
            con.sda.Fill(stuCA);
            stu_Availablegrid.Rows.Clear();
            if(stuCA.Rows.Count>0)
            {
                foreach(DataRow row in stuCA.Rows)
                {
                    int n = stu_Availablegrid.Rows.Add();
                    stu_Availablegrid.Rows[n].Cells["stuCAserialnogrid"].Value = n + 1;
                    stu_Availablegrid.Rows[n].Cells["stuCAtchcodegrid"].Value = row["id"].ToString();
                    stu_Availablegrid.Rows[n].Cells["stuCAcodegrid"].Value = row["ccode"].ToString();
                    stu_Availablegrid.Rows[n].Cells["stuCAtitlegrid"].Value = row["ctitle"].ToString();
                    stu_Availablegrid.Rows[n].Cells["stuCAcreditgrid"].Value = row["ccredit"].ToString();
                    stu_Availablegrid.Rows[n].Cells["stuCAtypegrid"].Value = row["ctype"].ToString();
                }
                Stu_ClearData();
            }
            else
            {
                MessageBox.Show("Course Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Stu_ClearData()
        {
            stu_Ccode.Clear();
            stu_Csemester.Clear();
        }
        string coursecode;
        public void stu_Availablegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            coursecode = stu_Availablegrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            teacherid = stu_Availablegrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            //MessageBox.Show(String.Format(semester), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(String.Format(teacherid),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void stu_CSelectbtn_Click(object sender, EventArgs e)
        {
            string variables = "id,ccode,ssemester,tid";
            string values = "'" + studentid + "','" + coursecode + "','" + semester + "','" + teacherid + "'";
            con.dataSend("Insert into Student_Course(" + variables + ")values(" + values + ")");
            stu_SelectedCgrid.Rows.Clear();
            StuCourse_LoadData();
            Stu_CurrentCourse_LoadData();
        }

        private void StuCourse_LoadData()
        {
            con.dataGet("Select * from Student_Course,Course where Student_Course.ccode=Course.ccode and Student_Course.id='" + studentid + "'");
            DataTable stuccourse = new DataTable();
            con.sda.Fill(stuccourse);
          foreach(DataRow row in stuccourse.Rows)
            {
                    int n = stu_SelectedCgrid.Rows.Add();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYserialnogrid"].Value = n + 1;
                    stu_SelectedCgrid.Rows[n].Cells["stuCYtchcodegrid"].Value = row["tid"].ToString();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYcodegrid"].Value = row["ccode"].ToString();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYtitlegrid"].Value = row["ctitle"].ToString();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYcreditgrid"].Value = row["ccredit"].ToString();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYtypegrid"].Value = row["ctype"].ToString();
                    stu_SelectedCgrid.Rows[n].Cells["stuCYsemestergrid"].Value = row["ssemester"].ToString();
            }
        }
        string selected="";
        string stuSemester = "";
        private void stu_SelectedCgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = stu_SelectedCgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            //MessageBox.Show(String.Format(selected), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stuSemester = stu_SelectedCgrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void stu_Clearbtn_Click(object sender, EventArgs e)
        {
            //stu_SelectedCgrid.Refresh();
        }

        
        private void stu_Deletebtn_Click(object sender, EventArgs e)
        {
            if(selected!="" && stuSemester!="")
            {
                DialogResult dl = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    con.dataSend("Delete from Student_Course where ccode='" + selected + "' and Student_Course.id='" + studentid + "' and ssemester='"+stuSemester+"'");
                    MessageBox.Show("Course information deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stu_SelectedCgrid.Rows.Clear();
                    StuCourse_LoadData();
                    selected = "";
                    stuSemester = "";
                    Stu_CurrentCourse_LoadData();
                }
            }
        }
        private void Stu_CurrentCourse_LoadData()
        {
            con.dataGet("Select * from Student_Course,Teacher,Course where Student_Course.ccode=Course.ccode and Student_Course.tid=Teacher.id and Student_Course.id='" + studentid + "'");
            DataTable stucourse = new DataTable();
            con.sda.Fill(stucourse);
            foreach (DataRow row in stucourse.Rows)
            {
                int n = stu_ViewCgrid.Rows.Add();
                stu_ViewCgrid.Rows[n].Cells["stuCserialnogrid"].Value = n + 1;
                stu_ViewCgrid.Rows[n].Cells["stuCcodegrid"].Value = row["ccode"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCtitlegrid"].Value = row["ctitle"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCcreditgrid"].Value = row["ccredit"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCtypegrid"].Value = row["ctype"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCsemestergrid"].Value = row["ssemester"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCtchcodegrid"].Value = row["tid"].ToString();
                stu_ViewCgrid.Rows[n].Cells["stuCtchnamegrid"].Value = row["tname"].ToString();
            }
        }
        private void stu_ViewCgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
