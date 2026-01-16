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
    public partial class frmInvoice : Form
    {
        private readonly IInvoiceBUS _invoiceBUS;
        private readonly ITableBUS _tableBUS;
        private readonly IStaffBUS _staffBUS;
        private readonly IWorkShiftBUS _workShiftBUS;
        private readonly IInvoiceDetailBUS _invoiceDetailBUS;

        private List<InvoiceDTO> _invoices;
        private bool _isViewingDetail = false;
        private List<InvoiceDTO> _invoiceBackup;
        private List<int> _deletedIds = new();
        public frmInvoice(IInvoiceBUS invoiceBUS, ITableBUS tableBUS, IStaffBUS staffBUS, IWorkShiftBUS workShiftBUS, IInvoiceDetailBUS invoiceDetailBUS)
        {
            InitializeComponent();
            _invoiceBUS = invoiceBUS;
            _tableBUS = tableBUS;
            _staffBUS = staffBUS;
            _workShiftBUS = workShiftBUS;
            _invoiceDetailBUS = invoiceDetailBUS;
            btnReturn.Enabled = false;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadStaffs();
            LoadWorkShifts();
            LoadInvoices();
        }
        private void LoadTables()
        {
            var tables = _tableBUS.GetAll();
            tables.Insert(0, new TableDTO
            {
                TableId = 0,
                TableName = "-- Tất cả --"
            });

            cboTableName.DataSource = tables;
            cboTableName.DisplayMember = "TableName";
            cboTableName.ValueMember = "TableId";
        }
        private void LoadStaffs()
        {
            var staffs = _staffBUS.GetAll();
            staffs.Insert(0, new StaffDTO
            {
                StaffId = 0,
                FullName = "-- Tất cả --"
            });

            cboStaffName.DataSource = staffs;
            cboStaffName.DisplayMember = "FullName";
            cboStaffName.ValueMember = "StaffId";
        }
        private void LoadWorkShifts()
        {
            var shifts = _workShiftBUS.GetAll();
            shifts.Insert(0, new WorkShiftDTO
            {
                WorkShiftId = 0
            });

            cboShiftTime.DataSource = shifts;
            cboShiftTime.DisplayMember = "StartTime";
            cboShiftTime.ValueMember = "WorkShiftId";
        }
        private void LoadInvoices()
        {
            _invoices = _invoiceBUS.GetAll();

            dgvInvoice.AutoGenerateColumns = true;
            dgvInvoice.DataSource = _invoices.OrderBy(x => x.InvoiceId).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int tableId = (int)cboTableName.SelectedValue;
            int staffId = (int)cboStaffName.SelectedValue;
            int shiftId = (int)cboShiftTime.SelectedValue;

            var result = _invoices.Where(i =>
                (tableId == 0 || i.TableId == tableId) &&
                (staffId == 0 || i.StaffId == staffId) &&
                (shiftId == 0 || i.ShiftId == shiftId)
            ).ToList();

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var invoice = new InvoiceDTO
            {
                InvoiceId = 0,
                CreatedDate = dtpCreatedDate.Value,
                TableId = (int)cboTableName.SelectedValue,
                StaffId = (int)cboStaffName.SelectedValue,
                ShiftId = (int)cboShiftTime.SelectedValue,
                Status = rdbtnPaid.Checked,
                TotalMoney = 0
            };

            _invoices.Add(invoice);

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = _invoices;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow == null) return;

            var inv = dgvInvoice.CurrentRow.DataBoundItem as InvoiceDTO;
            if (inv == null) return;

            inv.CreatedDate = dtpCreatedDate.Value;
            inv.TableId = (int)cboTableName.SelectedValue;
            inv.StaffId = (int)cboStaffName.SelectedValue;
            inv.ShiftId = (int)cboShiftTime.SelectedValue;
            inv.Status = rdbtnPaid.Checked;

            dgvInvoice.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow == null) return;

            var inv = dgvInvoice.CurrentRow.DataBoundItem as InvoiceDTO;
            if (inv == null) return;

            var ok = MessageBox.Show("Xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes) return;

            if (inv.InvoiceId > 0)
                _deletedIds.Add(inv.InvoiceId);

            _invoices.Remove(inv);

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = _invoices;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _invoiceBUS.Commit(_invoices, _deletedIds);

            MessageBox.Show("Đã lưu dữ liệu.");

            _invoices = _invoiceBUS.GetAll();
            _deletedIds.Clear();

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = _invoices.OrderBy(x => x.InvoiceId).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var inv = dgvInvoice.Rows[e.RowIndex].DataBoundItem as InvoiceDTO;
            if (inv == null) return;

            dtpCreatedDate.Value = inv.CreatedDate;
            cboTableName.SelectedValue = inv.TableId;
            cboStaffName.SelectedValue = inv.StaffId;
            cboShiftTime.SelectedValue = inv.ShiftId;

            rdbtnPaid.Checked = inv.Status;
            rdbtnNotPaid.Checked = !inv.Status;

            txtMoney.Text = inv.TotalMoney.ToString("N0");
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (_isViewingDetail) return;

            if (dgvInvoice.CurrentRow == null)
            {
                MessageBox.Show("Chọn hóa đơn cần xem chi tiết.");
                return;
            }

            var inv = dgvInvoice.CurrentRow.DataBoundItem as InvoiceDTO;
            if (inv == null) return;

            _invoiceBackup = _invoices.ToList();

            var details = _invoiceDetailBUS.GetByInvoiceId(inv.InvoiceId);

            dgvInvoice.DataSource = null;
            dgvInvoice.AutoGenerateColumns = true;
            dgvInvoice.DataSource = details;

            _isViewingDetail = true;
            btnReturn.Enabled = true;
            btnDetails.Enabled = false;

            txtMoney.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!_isViewingDetail) return;

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = _invoiceBackup;

            _isViewingDetail = false;
            btnReturn.Enabled = false;
            btnDetails.Enabled = true;
        }
    }
}
