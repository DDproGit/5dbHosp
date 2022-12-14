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
    public partial class UpdateDoc : Form
    {
        public UpdateDoc(FormDoc parent)
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
