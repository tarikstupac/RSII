using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGFeed.WinUI
{
    public partial class frmLogin : Form
    {
        private APIService _service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                await _service.Get<dynamic>(null);

                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
