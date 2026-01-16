namespace QLNhaHang.View
{
    partial class frmWorkShift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStart = new TextBox();
            cboStaff = new ComboBox();
            txtEnd = new TextBox();
            dgvWorkShift = new DataGridView();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkShift).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách ca làm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Giờ bắt đầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 124);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Giờ kết thúc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 76);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhân viên";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(171, 73);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(175, 27);
            txtStart.TabIndex = 4;
            // 
            // cboStaff
            // 
            cboStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaff.FormattingEnabled = true;
            cboStaff.Location = new Point(548, 73);
            cboStaff.Name = "cboStaff";
            cboStaff.Size = new Size(205, 28);
            cboStaff.TabIndex = 5;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(171, 121);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(175, 27);
            txtEnd.TabIndex = 6;
            // 
            // dgvWorkShift
            // 
            dgvWorkShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkShift.Location = new Point(64, 260);
            dgvWorkShift.Name = "dgvWorkShift";
            dgvWorkShift.RowHeadersWidth = 51;
            dgvWorkShift.Size = new Size(689, 188);
            dgvWorkShift.TabIndex = 7;
            dgvWorkShift.CellContentClick += dgvWorkShift_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(447, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(642, 124);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 33);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(447, 163);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 33);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(642, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 33);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(447, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 33);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 33);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmWorkShift
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 493);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(dgvWorkShift);
            Controls.Add(txtEnd);
            Controls.Add(cboStaff);
            Controls.Add(txtStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmWorkShift";
            Text = "frmWorkShift";
            Load += frmWorkShift_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStart;
        private ComboBox cboStaff;
        private TextBox txtEnd;
        private DataGridView dgvWorkShift;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExit;
    }
}