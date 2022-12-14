using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
namespace _5dbHosp
{
    class connection
    {
        public SqlConnection conn;
        static string host = "DESKTOP-U257O00";
        static string database = "hospital";
        public bool Open(string userDB, string password)
        {
            try
            {
                string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                conn = new SqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
