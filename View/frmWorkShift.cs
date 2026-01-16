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
    public partial class frmWorkShift : Form
    {
        private readonly IWorkShiftBUS _workShiftBUS;
        private readonly IStaffBUS _staffBUS;

        private List<WorkShiftDTO> _shifts;
        private List<int> _deletedIds = new();
        public frmWorkShift(IWorkShiftBUS workShiftBUS, IStaffBUS staffBUS)
        {
            InitializeComponent();
            _workShiftBUS = workShiftBUS;
            _staffBUS = staffBUS;
        }

        private void frmWorkShift_Load(object sender, EventArgs e)
        {
            LoadStaffs();
            LoadShifts();
        }
        private void LoadStaffs()
        {
            var staffs = _staffBUS.GetAll();

            staffs.Insert(0, new StaffDTO
            {
                StaffId = 0,
                FullName = "-- Tất cả --"
            });

            cboStaff.DataSource = staffs;
            cboStaff.DisplayMember = "FullName";
            cboStaff.ValueMember = "StaffId";
        }
        private void LoadShifts()
        {
            _shifts = _workShiftBUS.GetAll();

            dgvWorkShift.AutoGenerateColumns = true;
            dgvWorkShift.DataSource = _shifts
                .OrderBy(x => x.WorkShiftId)
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int staffId = (int)cboStaff.SelectedValue;

            var result = _shifts.Where(s =>
                staffId == 0 || s.StaffId == staffId
            ).ToList();

            dgvWorkShift.DataSource = null;
            dgvWorkShift.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int staffId = (int)cboStaff.SelectedValue;
            if (staffId == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return;
            }

            var shift = new WorkShiftDTO
            {
                WorkShiftId = 0,
                StartTime = DateTime.Parse(txtStart.Text),
                EndTime = DateTime.Parse(txtEnd.Text),
                StaffId = staffId,
                StaffName = cboStaff.Text
            };

            _shifts.Add(shift);

            dgvWorkShift.DataSource = null;
            dgvWorkShift.DataSource = _shifts;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWorkShift.CurrentRow == null) return;

            var s = dgvWorkShift.CurrentRow.DataBoundItem as WorkShiftDTO;
            if (s == null) return;

            s.StartTime = DateTime.Parse(txtStart.Text);
            s.EndTime = DateTime.Parse(txtEnd.Text);
            s.StaffId = (int)cboStaff.SelectedValue;
            s.StaffName = cboStaff.Text;

            dgvWorkShift.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWorkShift.CurrentRow == null) return;

            var s = dgvWorkShift.CurrentRow.DataBoundItem as WorkShiftDTO;
            if (s == null) return;

            var ok = MessageBox.Show("Xóa ca làm này?", "Xác nhận",
                MessageBoxButtons.YesNo);

            if (ok != DialogResult.Yes) return;

            if (s.WorkShiftId > 0)
                _deletedIds.Add(s.WorkShiftId);

            _shifts.Remove(s);

            dgvWorkShift.DataSource = null;
            dgvWorkShift.DataSource = _shifts;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _workShiftBUS.Commit(_shifts, _deletedIds);

            MessageBox.Show("Đã lưu dữ liệu.");

            _shifts = _workShiftBUS.GetAll();
            _deletedIds.Clear();

            dgvWorkShift.DataSource = null;
            dgvWorkShift.DataSource = _shifts
                .OrderBy(x => x.WorkShiftId)
                .ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvWorkShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var s = dgvWorkShift.Rows[e.RowIndex].DataBoundItem as WorkShiftDTO;
            if (s == null) return;

            txtStart.Text = s.StartTime.ToString();
            txtEnd.Text = s.EndTime.ToString();
            cboStaff.SelectedValue = s.StaffId;
        }
    }
}
