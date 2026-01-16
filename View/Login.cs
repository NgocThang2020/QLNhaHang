using NhaHangBUL.Implements;
using NhaHangBUL.Interfaces;
using NhaHangDAL.DAO.Implements;
using NhaHangDAL.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = DBContextFactory.Create();
                var dao = new AccountDAO(db);
                IAccountBUS accountBUS = new AccountBUS(dao);

                accountBUS.Login(txtName.Text, txtPass.Text);

                Hide();
                using var main = new Main(); 
                main.ShowDialog();
                Show();

                txtPass.Clear();
                txtPass.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", buttons);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            var cancel = MessageBox.Show("Thoát ứng dụng?", "Đăng nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cancel == DialogResult.OK)
                Application.Exit();
        }
    }
}
