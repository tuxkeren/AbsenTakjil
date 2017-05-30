using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsenTakjil
{
    public partial class frmAdministrasi : Form
    {
        public frmAdministrasi()
        {
            InitializeComponent();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdministrasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.databaseDataSet.Karyawan);

        }

    }
}
