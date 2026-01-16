namespace QLNhaHang.View
{
    partial class frmInvoice
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
            txtMoney = new TextBox();
            rdbtnPaid = new RadioButton();
            rdbtnNotPaid = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboTableName = new ComboBox();
            cboStaffName = new ComboBox();
            cboShiftTime = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnExit = new Button();
            dgvInvoice = new DataGridView();
            btnDetails = new Button();
            dtpCreatedDate = new DateTimePicker();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 81);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 122);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Tổng số tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 166);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(154, 119);
            txtMoney.Name = "txtMoney";
            txtMoney.ReadOnly = true;
            txtMoney.Size = new Size(221, 27);
            txtMoney.TabIndex = 5;
            // 
            // rdbtnPaid
            // 
            rdbtnPaid.AutoSize = true;
            rdbtnPaid.Location = new Point(154, 164);
            rdbtnPaid.Name = "rdbtnPaid";
            rdbtnPaid.Size = new Size(71, 24);
            rdbtnPaid.TabIndex = 6;
            rdbtnPaid.TabStop = true;
            rdbtnPaid.Text = "Đã trả";
            rdbtnPaid.UseVisualStyleBackColor = true;
            // 
            // rdbtnNotPaid
            // 
            rdbtnNotPaid.AutoSize = true;
            rdbtnNotPaid.Location = new Point(289, 164);
            rdbtnNotPaid.Name = "rdbtnNotPaid";
            rdbtnNotPaid.Size = new Size(86, 24);
            rdbtnNotPaid.TabIndex = 7;
            rdbtnNotPaid.TabStop = true;
            rdbtnNotPaid.Text = "Chưa trả";
            rdbtnNotPaid.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 81);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Tên bàn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 122);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Nhân viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 166);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 10;
            label7.Text = "Ca làm";
            // 
            // cboTableName
            // 
            cboTableName.FormattingEnabled = true;
            cboTableName.Location = new Point(561, 78);
            cboTableName.Name = "cboTableName";
            cboTableName.Size = new Size(157, 28);
            cboTableName.TabIndex = 11;
            // 
            // cboStaffName
            // 
            cboStaffName.FormattingEnabled = true;
            cboStaffName.Location = new Point(561, 119);
            cboStaffName.Name = "cboStaffName";
            cboStaffName.Size = new Size(157, 28);
            cboStaffName.TabIndex = 12;
            // 
            // cboShiftTime
            // 
            cboShiftTime.FormattingEnabled = true;
            cboShiftTime.Location = new Point(561, 163);
            cboShiftTime.Name = "cboShiftTime";
            cboShiftTime.Size = new Size(157, 28);
            cboShiftTime.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(800, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(945, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(800, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(945, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(800, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(945, 162);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvInvoice
            // 
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(48, 273);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.Size = new Size(991, 188);
            dgvInvoice.TabIndex = 20;
            dgvInvoice.CellContentClick += dgvInvoice_CellContentClick;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(945, 238);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 29);
            btnDetails.TabIndex = 21;
            btnDetails.Text = "Chi tiết";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Location = new Point(154, 76);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(221, 27);
            dtpCreatedDate.TabIndex = 22;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(800, 238);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 23;
            btnReturn.Text = "Trở về";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // frmInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 490);
            Controls.Add(btnReturn);
            Controls.Add(dtpCreatedDate);
            Controls.Add(btnDetails);
            Controls.Add(dgvInvoice);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(cboShiftTime);
            Controls.Add(cboStaffName);
            Controls.Add(cboTableName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rdbtnNotPaid);
            Controls.Add(rdbtnPaid);
            Controls.Add(txtMoney);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInvoice";
            Text = "frmInvoice";
            Load += frmInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMoney;
        private RadioButton rdbtnPaid;
        private RadioButton rdbtnNotPaid;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboTableName;
        private ComboBox cboStaffName;
        private ComboBox cboShiftTime;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExit;
        private DataGridView dgvInvoice;
        private Button btnDetails;
        private DateTimePicker dtpCreatedDate;
        private Button btnReturn;
    }
}