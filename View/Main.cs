using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = DBContextFactory.Create();
            var categoryBUS = new CategoryBUS(new CategoryDAO(db));
            var foodBUS = new FoodBUS(new FoodDAO(db), new CategoryDAO(db));
            OpenChild(new frmMenu(foodBUS, categoryBUS));
        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void OpenChild(Form frm)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == frm.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = DBContextFactory.Create();
            var staffBUS = new StaffBUS(new StaffDAO(db));

            OpenChild(new frmStaff(staffBUS));
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = DBContextFactory.Create();
            var tableBUS = new TableBUS(new TableDAO(db));

            OpenChild(new frmTable(tableBUS));
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = DBContextFactory.Create();
            var workShiftBUS = new WorkShiftBUS(new WorkShiftDAO(db));
            var staffBUS = new StaffBUS(new StaffDAO(db));

            OpenChild(new frmWorkShift(workShiftBUS, staffBUS));
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = DBContextFactory.Create();

            var invoiceBUS = new InvoiceBUS(new InvoiceDAO(db));
            var invoiceDetailBUS = new InvoiceDetailBUS(new InvoiceDetailDAO(db));
            var tableBUS = new TableBUS(new TableDAO(db));
            var staffBUS = new StaffBUS(new StaffDAO(db));
            var workShiftBUS = new WorkShiftBUS(new WorkShiftDAO(db));

            OpenChild(new frmInvoice(invoiceBUS, tableBUS, staffBUS, workShiftBUS, invoiceDetailBUS));
        }
    }
}
