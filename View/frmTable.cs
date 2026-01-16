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
    public partial class frmTable : Form
    {
        private readonly ITableBUS _tableBUS;

        private List<TableDTO> _tables;
        private List<int> _deletedIds = new();
        public frmTable(ITableBUS tableBUS)
        {
            InitializeComponent();
            _tableBUS = tableBUS;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void LoadTables()
        {
            _tables = _tableBUS.GetAll();

            dgvTable.AutoGenerateColumns = true;
            dgvTable.DataSource = _tables
                .OrderBy(x => x.TableId)
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = (txtTableName.Text ?? "").Trim().ToLower();

            var result = _tables.Where(t =>
                string.IsNullOrWhiteSpace(kw) ||
                (t.TableName ?? "").ToLower().Contains(kw)
            ).ToList();

            dgvTable.DataSource = null;
            dgvTable.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var table = new TableDTO
            {
                TableId = 0,
                TableName = txtTableName.Text.Trim(),
                Seats = int.Parse(txtSeat.Text),
                Status = rdbtnYes.Checked
            };

            _tables.Add(table);

            dgvTable.DataSource = null;
            dgvTable.DataSource = _tables;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow == null) return;

            var table = dgvTable.CurrentRow.DataBoundItem as TableDTO;
            if (table == null) return;

            table.TableName = txtTableName.Text.Trim();
            table.Seats = int.Parse(txtSeat.Text);
            table.Status = rdbtnYes.Checked;

            dgvTable.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow == null) return;

            var table = dgvTable.CurrentRow.DataBoundItem as TableDTO;
            if (table == null) return;

            var ok = MessageBox.Show(
                "Xóa bàn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ok != DialogResult.Yes) return;

            if (table.TableId > 0)
                _deletedIds.Add(table.TableId);

            _tables.Remove(table);

            dgvTable.DataSource = null;
            dgvTable.DataSource = _tables;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _tableBUS.Commit(_tables, _deletedIds);

            MessageBox.Show("Đã lưu dữ liệu.");

            _tables = _tableBUS.GetAll();
            _deletedIds.Clear();

            dgvTable.DataSource = null;
            dgvTable.DataSource = _tables
                .OrderBy(x => x.TableId)
                .ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show(
                "Thoát màn hình bàn ăn?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (ok == DialogResult.Yes)
                Close();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var t = dgvTable.Rows[e.RowIndex].DataBoundItem as TableDTO;
            if (t == null) return;

            txtTableName.Text = t.TableName;
            txtSeat.Text = t.Seats.ToString();

            rdbtnYes.Checked = t.Status;
            rdbtnNo.Checked = !t.Status;
        }
    }
}
