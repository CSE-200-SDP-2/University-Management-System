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

        private void button2_Click(object sender, EventArgs e)
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
                if (tchClist.Rows.Count ==0)
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
                if (tchClist.Rows.Count <2)
                {
                    MessageBox.Show("You haven't been Assigned to any course yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl3.SelectedIndex==0)
            {
                if (tchClist.Rows.Count <2)
                {
                    MessageBox.Show("You haven't been Assigned to any course yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
