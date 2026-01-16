namespace QLNhaHang.View
{
    partial class frmTable
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
            txtTableName = new TextBox();
            txtSeat = new TextBox();
            rdbtnYes = new RadioButton();
            rdbtnNo = new RadioButton();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnExit = new Button();
            dgvTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bàn ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 72);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 120);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Số chỗ ngồi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 169);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Còn trống";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(197, 69);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(183, 27);
            txtTableName.TabIndex = 4;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(197, 117);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(183, 27);
            txtSeat.TabIndex = 5;
            // 
            // rdbtnYes
            // 
            rdbtnYes.AutoSize = true;
            rdbtnYes.Location = new Point(197, 167);
            rdbtnYes.Name = "rdbtnYes";
            rdbtnYes.Size = new Size(48, 24);
            rdbtnYes.TabIndex = 6;
            rdbtnYes.TabStop = true;
            rdbtnYes.Text = "Có";
            rdbtnYes.UseVisualStyleBackColor = true;
            // 
            // rdbtnNo
            // 
            rdbtnNo.AutoSize = true;
            rdbtnNo.Location = new Point(307, 167);
            rdbtnNo.Name = "rdbtnNo";
            rdbtnNo.Size = new Size(73, 24);
            rdbtnNo.TabIndex = 7;
            rdbtnNo.TabStop = true;
            rdbtnNo.Text = "Không";
            rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(632, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(778, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 116);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(778, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(632, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(778, 165);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(81, 241);
            dgvTable.Name = "dgvTable";
            dgvTable.ReadOnly = true;
            dgvTable.RowHeadersWidth = 51;
            dgvTable.Size = new Size(791, 188);
            dgvTable.TabIndex = 14;
            dgvTable.CellContentClick += dgvTable_CellContentClick;
            // 
            // frmTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 479);
            Controls.Add(dgvTable);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(rdbtnNo);
            Controls.Add(rdbtnYes);
            Controls.Add(txtSeat);
            Controls.Add(txtTableName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTable";
            Text = "frmTable";
            Load += frmTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTableName;
        private TextBox txtSeat;
        private RadioButton rdbtnYes;
        private RadioButton rdbtnNo;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExit;
        private DataGridView dgvTable;
    }
}