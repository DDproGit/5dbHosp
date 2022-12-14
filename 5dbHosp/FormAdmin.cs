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

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertAdminD frm = new InsertAdminD();
            frm.ShowDialog();
            string surname, name, patronymic, specialty, login;
            surname = frm.surname.Text;
            name = frm.name.Text;
            patronymic = frm.patronymic.Text;
            specialty = frm.speciality.Text;
            login = frm.login.Text;
            try
            {
                SqlCommand cmd0 = new SqlCommand("insert into doctors (surname, name, patronymic, specialty, login) VALUES " +
                    "('" + surname + "', '" + name + "', '" + patronymic + "', '" + specialty + "', '" + login + "')", connectionAdmin);
                cmd0.ExecuteNonQuery();
                SqlCommand comm1 = new SqlCommand("select * from doctors", connectionAdmin);
                SqlDataAdapter adp1 = new SqlDataAdapter(comm1);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error ! " + er.Message, "Information");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAdminD frm = new DeleteAdminD();
            frm.ShowDialog();
            int id = ((int)frm.idDoc.Value);
            try
            {
                SqlCommand cmd0 = new SqlCommand("delete from doctors where id = " + id.ToString(), connectionAdmin);
                cmd0.ExecuteNonQuery();
                SqlCommand comm1 = new SqlCommand("select * from doctors", connectionAdmin);
                SqlDataAdapter adp1 = new SqlDataAdapter(comm1);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error ! " + er.Message, "Information");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAdminD frm = new UpdateAdminD();
            frm.ShowDialog();
            int id = ((int)frm.idDoc.Value);
            string speciality = frm.updateSpec.Text;
            try
            {
                SqlCommand cmd0 = new SqlCommand("update doctors set specialty = '" + speciality + "' where id = " + id.ToString(), connectionAdmin);
                cmd0.ExecuteNonQuery();
                SqlCommand comm1 = new SqlCommand("select * from doctors", connectionAdmin);
                SqlDataAdapter adp1 = new SqlDataAdapter(comm1);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error ! " + er.Message, "Information");
            }
        }
    }
}
