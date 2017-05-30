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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "admin123";
            if(txtPassword.Text == password)
            {
                frmAdministrasi frm = new frmAdministrasi();
                frm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Password salah!");
            }
        }
    }
}
