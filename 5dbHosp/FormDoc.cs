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
    public partial class FormDoc : Form
    {
        public FormDoc()
        {
            InitializeComponent();
        }
        public SqlConnection connectionDoc;

        private void FormDoc_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            SqlCommand comm = new SqlCommand("select * from patients_doctors", connectionDoc);
            SqlDataAdapter adp = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
