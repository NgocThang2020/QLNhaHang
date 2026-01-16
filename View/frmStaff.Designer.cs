namespace QLNhaHang.View
{
    partial class frmStaff
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
            txtName = new TextBox();
            txtRole = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnErase = new Button();
            btnSave = new Button();
            btnExit = new Button();
            dgvStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 58);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 58);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 102);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 4;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(140, 99);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(218, 27);
            txtRole.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(603, 55);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 27);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 102);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 7;
            label5.Text = "Chức vụ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(603, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(892, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1056, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(892, 98);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(1056, 98);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(104, 29);
            btnErase.TabIndex = 14;
            btnErase.Text = "Xóa";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(892, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1056, 149);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(63, 217);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.Size = new Size(1097, 260);
            dgvStaff.TabIndex = 17;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 526);
            Controls.Add(dgvStaff);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnErase);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(txtRole);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStaff";
            Text = "frmStaff";
            Load += frmStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtRole;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnErase;
        private Button btnSave;
        private Button btnExit;
        private DataGridView dgvStaff;
    }
}