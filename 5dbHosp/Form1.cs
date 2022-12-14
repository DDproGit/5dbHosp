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
            conn.Open(nameDoc.Text, passDoc.Text);
            FormDoc formShow = new FormDoc();
            formShow.Show();
        }
    }
}
