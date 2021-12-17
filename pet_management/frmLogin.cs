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
        private const string MESSAGE_LOGIN_SUCCESS = "Đăng nhập thành công!";
        private int tryCount = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (tryCount >= 2)
            {
                MyHelper.ShowErrorMessage("Bạn đã nhập sai password quá 3 lần! Phần mềm sẽ tự thoát", "Cảnh báo");
                Application.Exit();
            }
            string email = txtEmail.GetTextTrim();
            string password = txtPassword.GetTextTrim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MyHelper.ShowErrorMessage(Const.MESSAGE_LOGIN_REQUIRE, "Cảnh báo");
                return;
            }
            else
            {
                Staff s = StaffBUS.GetStaffAuthentication(email, password);
                if (s == null)
                {
                    MyHelper.ShowErrorMessage(Const.MESSAGE_LOGIN_FAILE, "Cảnh báo");
                    tryCount++;
                }
                else
                {
                    frmMain f = (frmMain)Owner;
                    f.SetLoginInfor(s);
                    //f.InitializeView();
                    MyHelper.ShowSuccessMessage(MESSAGE_LOGIN_SUCCESS, "Thông báo");
                    this.Hide();
                }
            }
        }

        private void frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            frmMain f = (frmMain)Owner;
            if (f == null) Application.Exit();
            if (!f.isLogin)
            {
                Application.Exit();
            }
        }
    }
}