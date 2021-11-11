using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM staff";
            dgvDemo.DataSource = DataProvider.Instance.excuteQuery(query);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO `staff` (`staffNumber`, `fullName`, `birthday`, `email`, `address`, `city`, `country`, `phone`) " +
                "VALUES ('SD0912', 'Nguyễn Thị Hoàn', '2000-10-30', 'acekembbc@gmail.com', 'Kim Sơn', 'Ninh Bình', 'Việt Nam', '0918848155')";
            DataProvider.Instance.excuteNonQuery(insert);
            LoadData();
        }
    }
}
