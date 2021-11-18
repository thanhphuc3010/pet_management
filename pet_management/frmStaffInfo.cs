using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_management
{
    public partial class frmStaffInfo : Form
    {
        private readonly frmStaff frmStaff;
        private Staff staff;
        public frmStaffInfo(frmStaff frmStaff, Staff staff)
        {
            InitializeComponent();
            this.frmStaff = frmStaff;
            this.staff = staff;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BeginInvoke(new MethodInvoker(() =>
            {
                txtFirstname.FocusEnd();
            }));
        }

        private void frmStaffInfo_Load(object sender, EventArgs e)
        {
            roleBindingSource.DataSource = RoleBUS.GetRoles();
            txtNumber.ReadOnly = true;
            if (staff == null)
            {
                txtNumber.ReadOnly = true;
                string query = "SELECT * FROM staff ORDER BY staff_number DESC LIMIT 1";
                txtNumber.Text = Helper.GenerateId("S", query, "staff_number");
            }
            else
            {
                this.Text = "Thông tin khách hàng";
                //isEdit = true;
                BindStaffInfo();
            }
            txtFirstname.Focus();
        }

        private void BindStaffInfo()
        {
            txtNumber.Text = staff.StaffNumber;
            txtFirstname.Text = staff.FirstName;
            txtLastname.Text = staff.LastName;
            dtBirthday.DateTime = staff.Birthday.Value;
            txtPhone.Text = staff.Phone;
            txtEmail.Text = staff.Email;
            txtAddress.Text = staff.Address;
            cboRole.EditValue = staff.IdRole;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.StaffNumber = txtNumber.Text.ToString().Trim();
            staff.FirstName = txtFirstname.Text.ToString().Trim();
            staff.LastName = txtLastname.Text.ToString().Trim();
            staff.Birthday = dtBirthday.DateTime;
            staff.Phone = txtPhone.Text.ToString().Trim();
            staff.Email = txtEmail.Text.ToString().Trim();
            staff.IdRole = Convert.ToInt32(cboRole.GetColumnValue("Id"));
            staff.Active = true;
            staff.Password = GeneratePassword(6);
            staff.Address = txtAddress.Text.ToString().Trim();

            StaffBUS.Save(staff);
            SendPassword(staff);

            if (frmStaff != null)
            {
                frmStaff.LoadData();
                this.Close();
            }

            // Call send password function to send the password via email
            //sendPassword(staff);
        }


        private string CreateEmailBody(Staff staff)
        {
            string body = string.Empty;
            //using streamreader for reading my htmltemplate   

            Assembly assembly = Assembly.GetExecutingAssembly();
            string workingDirectory = Environment.CurrentDirectory;
            using (StreamReader reader = new StreamReader(Directory.GetParent(workingDirectory).Parent.FullName + "\\" + "MailTemplate.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{Name}", staff.FirstName + " " + staff.LastName); //replacing the required things  

            body = body.Replace("{Email}", staff.Email);

            body = body.Replace("{Password}", staff.Password);

            return body;
        }

        private void SendPassword(Staff staff)
        {
            try
            {
                MailMessage msg = new MailMessage();
                string addressTo = staff.Email.Trim();

                msg.From = new MailAddress("acekembbc2@gmail.com");
                msg.To.Add(addressTo);
                msg.Subject = String.Format("Chào mừng {0}!", staff.FirstName + " " + staff.LastName);

                string fullname = staff.FirstName + " " + staff.LastName;


                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                //msg.Body = String.Format("Xin chào {0}. Để đăng nhập vào tài khoản của bạn vui lòng sử dụng tên đăng nhập là {1} và mật khẩu tạm thời sau: {2}", fullname, staff.Email, staff.Password);
                msg.Body = CreateEmailBody(staff);

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "acekembbc2@gmail.com";
                ntcd.Password = "0989916807";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                MessageBox.Show("Your Mail is sended");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GeneratePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
