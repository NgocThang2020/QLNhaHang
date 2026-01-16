namespace QLNhaHang.View
{
    partial class frmMenu
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
            txtPrice = new TextBox();
            txtDescribe = new TextBox();
            dgvMenu = new DataGridView();
            txtFoodName = new TextBox();
            label1 = new Label();
            rdbtnNoMore = new RadioButton();
            rdbtnAvailable = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboCateName = new ComboBox();
            txtUnit = new TextBox();
            label7 = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnErase = new Button();
            btnSave = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(174, 116);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(203, 27);
            txtPrice.TabIndex = 0;
            // 
            // txtDescribe
            // 
            txtDescribe.Location = new Point(174, 167);
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(203, 27);
            txtDescribe.TabIndex = 2;
            // 
            // dgvMenu
            // 
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(72, 291);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(1063, 244);
            dgvMenu.TabIndex = 4;
            dgvMenu.CellContentClick += dgvMenu_CellContentClick;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(174, 64);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(203, 27);
            txtFoodName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 6;
            label1.Text = "Danh sách món ăn";
            // 
            // rdbtnNoMore
            // 
            rdbtnNoMore.AutoSize = true;
            rdbtnNoMore.Location = new Point(174, 222);
            rdbtnNoMore.Name = "rdbtnNoMore";
            rdbtnNoMore.Size = new Size(101, 24);
            rdbtnNoMore.TabIndex = 7;
            rdbtnNoMore.TabStop = true;
            rdbtnNoMore.Text = "Không còn";
            rdbtnNoMore.UseVisualStyleBackColor = true;
            // 
            // rdbtnAvailable
            // 
            rdbtnAvailable.AutoSize = true;
            rdbtnAvailable.Location = new Point(284, 222);
            rdbtnAvailable.Name = "rdbtnAvailable";
            rdbtnAvailable.Size = new Size(93, 24);
            rdbtnAvailable.TabIndex = 8;
            rdbtnAvailable.TabStop = true;
            rdbtnAvailable.Text = "Còn hàng";
            rdbtnAvailable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 67);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Giá thành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 67);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 11;
            label4.Text = "Cách thức phục vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 167);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 12;
            label5.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 222);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 13;
            label6.Text = "Tình trạng";
            // 
            // cboCateName
            // 
            cboCateName.FormattingEnabled = true;
            cboCateName.Location = new Point(932, 61);
            cboCateName.Name = "cboCateName";
            cboCateName.Size = new Size(203, 28);
            cboCateName.TabIndex = 14;
            cboCateName.SelectedIndexChanged += cboCateName_SelectedIndexChanged;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(567, 64);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(203, 27);
            txtUnit.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(825, 64);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 16;
            label7.Text = "Loại món ăn";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(825, 116);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(135, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1010, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(825, 163);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(135, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(1010, 163);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(125, 29);
            btnErase.TabIndex = 20;
            btnErase.Text = "Xóa";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(825, 213);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 29);
            btnSave.TabIndex = 21;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1010, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 29);
            btnExit.TabIndex = 22;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 582);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnErase);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(label7);
            Controls.Add(txtUnit);
            Controls.Add(cboCateName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdbtnAvailable);
            Controls.Add(rdbtnNoMore);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Controls.Add(dgvMenu);
            Controls.Add(txtDescribe);
            Controls.Add(txtPrice);
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice;
        private TextBox txtDescribe;
        private DataGridView dgvMenu;
        private TextBox txtFoodName;
        private Label label1;
        private RadioButton rdbtnNoMore;
        private RadioButton rdbtnAvailable;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboCateName;
        private TextBox txtUnit;
        private Label label7;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnErase;
        private Button btnSave;
        private Button btnExit;
    }
}