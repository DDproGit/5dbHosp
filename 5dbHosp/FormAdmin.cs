using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace _5dbHosp
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        public SqlConnection connectionAdmin;

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;

            SqlCommand comm1 = new SqlCommand("select * from doctors", connectionAdmin);
            SqlCommand comm2 = new SqlCommand("select * from patients", connectionAdmin);

            SqlDataAdapter adp1 = new SqlDataAdapter(comm1);
            SqlDataAdapter adp2 = new SqlDataAdapter(comm2);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            adp1.Fill(dt1);
            adp2.Fill(dt2);
            dataGridView1.DataSource = dt1;
            dataGridView2.DataSource = dt2;
        }
    }
}
