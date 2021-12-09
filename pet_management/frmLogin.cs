using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using pet_management.utils;

namespace pet_management
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void ResetPassword()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.GetTextTrim();
            string password = txtPassword.GetTextTrim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show(Const.MESSAGE_LOGIN_REQUIRE, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                Staff s = StaffBUS.GetStaffAuthentication(email, password);
                if (s == null)
                {
                    XtraMessageBox.Show(Const.MESSAGE_LOGIN_FAILE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    frmMain f = (frmMain)Owner;
                    f.SetLoginInfor(s);
                    this.Close();
                }
            }
        }
    }
}