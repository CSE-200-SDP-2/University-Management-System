//DBAccess
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University_Management_System
{
    class DBAccess
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        //Raihan:"Data Source=DESKTOP-DP4N1ED;Initial Catalog=Unimanage;Integrated Security=True"
        //Rahat:"
        //Fahad:"
        public void connection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DP4N1ED;Initial Catalog=Unimanage;Integrated Security=True");
            con.Open();
        }
        public static string connectionDatabase()
        {
            return "Data Source=DESKTOP-DP4N1ED;Initial Catalog=Unimanage;Integrated Security=True";
        }

        public void dataSend(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                var flag = cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception ex)
            {

                pkk = ex.Message;
                MessageBox.Show(pkk);
            }
            con.Close();
        }
        public void dataGet(string SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con);
            }
            catch (Exception ex)
            {
                pkk = ex.Message;
                MessageBox.Show(pkk);

            }

        }

    }
}
