using Microsoft.EntityFrameworkCore.Internal;
using NhaHangBUL.Implements;
using NhaHangBUL.Interfaces;
using NhaHangDAL.DAO.Implements;
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
    public partial class frmMenu : Form
    {
        private readonly IFoodBUS _foodBUS;
        private readonly ICategoryBUS _categoryBUS;

        private List<FoodDTO> _foods;
        private List<int> _deletedIds = new();
        public frmMenu(IFoodBUS foodBUS, ICategoryBUS categoryBUS)
        {
            InitializeComponent();
            _foodBUS = foodBUS;
            _categoryBUS = categoryBUS;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadFoods();
        }
        private void LoadCategories()
        {
            var categories = _categoryBUS.GetAll();
            categories.Insert(0, new CategoryDTO
            {
                CategoryId = 0,
                CategoryName = "-- Tất cả --"
            });

            cboCateName.DataSource = categories;
            cboCateName.DisplayMember = "CategoryName";
            cboCateName.ValueMember = "CategoryId";
        }
        private void LoadFoods()
        {
            _foods = _foodBUS.GetAll();

            dgvMenu.AutoGenerateColumns = true;
            dgvMenu.DataSource = _foods.OrderBy(x => x.FoodId).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = (txtFoodName.Text ?? "").Trim().ToLower();
            int cateId = (int)cboCateName.SelectedValue;

            var result = _foods.Where(f =>
                (string.IsNullOrWhiteSpace(kw) || f.FoodName.ToLower().Contains(kw)) &&
                (cateId == 0 || f.CategoryId == cateId)
            ).ToList();

            dgvMenu.DataSource = null;
            dgvMenu.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int cateId = (int)cboCateName.SelectedValue;
            if (cateId == 0)
            {
                MessageBox.Show("Chọn loại món ăn.");
                return;
            }

            var food = new FoodDTO
            {
                FoodId = 0,
                FoodName = txtFoodName.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text),
                Unit = txtUnit.Text.Trim(),
                Description = txtDescribe.Text.Trim(),
                Status = rdbtnAvailable.Checked,
                CategoryId = cateId,
            };

            _foods.Add(food);

            dgvMenu.DataSource = null;
            dgvMenu.DataSource = _foods;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;

            var food = dgvMenu.CurrentRow.DataBoundItem as FoodDTO;
            if (food == null) return;

            food.FoodName = txtFoodName.Text.Trim();
            food.Price = decimal.Parse(txtPrice.Text);
            food.Unit = txtUnit.Text.Trim();
            food.Description = txtDescribe.Text.Trim();
            food.Status = rdbtnAvailable.Checked;
            food.CategoryId = (int)cboCateName.SelectedValue;

            dgvMenu.Refresh();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;

            var food = dgvMenu.CurrentRow.DataBoundItem as FoodDTO;
            if (food == null) return;

            var ok = MessageBox.Show("Xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes) return;

            if (food.FoodId > 0)
                _deletedIds.Add(food.FoodId);

            _foods.Remove(food);

            dgvMenu.DataSource = null;
            dgvMenu.DataSource = _foods;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _foodBUS.Commit(_foods, _deletedIds);

            MessageBox.Show("Đã lưu dữ liệu.");

            _foods = _foodBUS.GetAll();
            _deletedIds.Clear();

            dgvMenu.DataSource = null;
            dgvMenu.DataSource = _foods.OrderBy(x => x.FoodId).ToList();
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var f = dgvMenu.Rows[e.RowIndex].DataBoundItem as FoodDTO;
            if (f == null) return;

            txtFoodName.Text = f.FoodName;
            txtPrice.Text = f.Price.ToString();
            txtUnit.Text = f.Unit;
            txtDescribe.Text = f.Description;
            cboCateName.SelectedValue = f.CategoryId;

            rdbtnAvailable.Checked = f.Status;
            rdbtnNoMore.Checked = !f.Status;
        }

        private void cboCateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_foods == null) return;

            int cateId = (int)cboCateName.SelectedValue;

            dgvMenu.DataSource = null;
            dgvMenu.DataSource = (cateId == 0)
                ? _foods
                : _foods.Where(x => x.CategoryId == cateId).ToList();
        }
    }
}
