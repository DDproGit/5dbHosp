using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5dbHosp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginDoc_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            if (conn.Open(nameDoc.Text, passDoc.Text) == false)
                return;
            FormDoc formShow = new FormDoc();
            formShow.connectionDoc = conn.conn;
            formShow.ShowDialog();
            conn.Close();
        }

        private void loginPatient_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            if (conn.Open(namePatient.Text, passPatient.Text) == false)
                return;
            FormPatient formShow = new FormPatient();
            formShow.connectionPat = conn.conn;
            formShow.ShowDialog();
            conn.Close();
        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            if (conn.Open(nameAdmin.Text, passAdmin.Text) == false)
                return;
            FormAdmin formShow = new FormAdmin();
            formShow.connectionAdmin = conn.conn;
            formShow.ShowDialog();
            conn.Close();
        }
    }
}
