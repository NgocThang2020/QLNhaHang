using NhaHangBUL.Implements;
using NhaHangBUL.Interfaces;
using NhaHangDAL.DTO;
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
    public partial class frmStaff : Form
    {
        private readonly IStaffBUS _staffBUS;

        private List<StaffDTO> _staffs;
        private List<int> _deletedIds = new();
        public frmStaff(IStaffBUS staffBUS)
        {
            InitializeComponent();
            _staffBUS = staffBUS;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadStaffs();
        }
        private void LoadStaffs()
        {
            _staffs = _staffBUS.GetAll();

            dgvStaff.AutoGenerateColumns = true;
            dgvStaff.DataSource = _staffs
                .OrderBy(x => x.StaffId)
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = (txtName.Text ?? "").Trim().ToLower();

            var result = _staffs.Where(s =>
                string.IsNullOrWhiteSpace(kw) ||
                (s.FullName ?? "").ToLower().Contains(kw) ||
                (s.Phone ?? "").ToLower().Contains(kw) ||
                (s.Email ?? "").ToLower().Contains(kw)
            ).ToList();

            dgvStaff.DataSource = null;
            dgvStaff.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var staff = new StaffDTO
            {
                StaffId = 0,
                FullName = txtName.Text.Trim(),
                Role = txtRole.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            _staffs.Add(staff);

            dgvStaff.DataSource = null;
            dgvStaff.DataSource = _staffs;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            var staff = dgvStaff.CurrentRow.DataBoundItem as StaffDTO;
            if (staff == null) return;

            staff.FullName = txtName.Text.Trim();
            staff.Role = txtRole.Text.Trim();
            staff.Phone = txtPhone.Text.Trim();
            staff.Email = txtEmail.Text.Trim();

            dgvStaff.Refresh();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            var staff = dgvStaff.CurrentRow.DataBoundItem as StaffDTO;
            if (staff == null) return;

            var ok = MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ok != DialogResult.Yes) return;

            if (staff.StaffId > 0)
                _deletedIds.Add(staff.StaffId);

            _staffs.Remove(staff);

            dgvStaff.DataSource = null;
            dgvStaff.DataSource = _staffs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _staffBUS.Commit(_staffs, _deletedIds);

            MessageBox.Show("Đã lưu dữ liệu.");

            _staffs = _staffBUS.GetAll();
            _deletedIds.Clear();

            dgvStaff.DataSource = null;
            dgvStaff.DataSource = _staffs
                .OrderBy(x => x.StaffId)
                .ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show("Thoát màn hình nhân viên?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (ok == DialogResult.Yes)
                Close();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var s = dgvStaff.Rows[e.RowIndex].DataBoundItem as StaffDTO;
            if (s == null) return;

            txtName.Text = s.FullName;
            txtRole.Text = s.Role;
            txtPhone.Text = s.Phone;
            txtEmail.Text = s.Email;
        }
    }
}
