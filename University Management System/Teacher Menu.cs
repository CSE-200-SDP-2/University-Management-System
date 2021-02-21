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
        DBAccess con = new DBAccess();
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
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
            Auto_MarksInsert();
            Auto_Stulistccode();
        }
        public void Auto_Stulistccode()
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
            tchCcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            tchCcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tchCcode.AutoCompleteCustomSource = coll;
        }

        public void Auto_MarksInsert()
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
    }
}
