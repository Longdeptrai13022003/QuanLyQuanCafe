namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.txtSearchFoodName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpAccount.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpAccount.BackgroundImage")));
            this.tpAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpAccount.Controls.Add(this.panel22);
            this.tpAccount.Controls.Add(this.panel27);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Location = new System.Drawing.Point(4, 35);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1084, 653);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.dtgvAccount);
            this.panel28.Location = new System.Drawing.Point(8, 115);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(573, 530);
            this.panel28.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(567, 524);
            this.dtgvAccount.TabIndex = 0;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnShowAccount);
            this.panel27.Controls.Add(this.btnEditAccount);
            this.panel27.Controls.Add(this.btnDeleteAccount);
            this.panel27.Controls.Add(this.btnAddAccount);
            this.panel27.Location = new System.Drawing.Point(8, 8);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(573, 101);
            this.panel27.TabIndex = 5;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.BackgroundImage")));
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(104, 95);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.BackgroundImage")));
            this.btnDeleteAccount.Location = new System.Drawing.Point(113, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(104, 95);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xoá";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.BackgroundImage")));
            this.btnEditAccount.Location = new System.Drawing.Point(223, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(104, 95);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAccount.BackgroundImage")));
            this.btnShowAccount.Location = new System.Drawing.Point(333, 3);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(104, 95);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // panel22
            // 
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel22.Controls.Add(this.btnResetPassword);
            this.panel22.Controls.Add(this.panel24);
            this.panel22.Controls.Add(this.panel25);
            this.panel22.Controls.Add(this.panel26);
            this.panel22.Location = new System.Drawing.Point(587, 118);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(490, 524);
            this.panel22.TabIndex = 6;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtUserName);
            this.panel26.Controls.Add(this.label13);
            this.panel26.Location = new System.Drawing.Point(0, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(487, 61);
            this.panel26.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.GhostWhite;
            this.label13.Location = new System.Drawing.Point(3, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(161, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(323, 34);
            this.txtUserName.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txtDisplayName);
            this.panel25.Controls.Add(this.label12);
            this.panel25.Location = new System.Drawing.Point(0, 70);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(487, 61);
            this.panel25.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(3, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(161, 12);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(323, 34);
            this.txtDisplayName.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.nmAccountType);
            this.panel24.Controls.Add(this.label11);
            this.panel24.Location = new System.Drawing.Point(0, 137);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(487, 61);
            this.panel24.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FloralWhite;
            this.label11.Location = new System.Drawing.Point(3, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản:";
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(161, 15);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(68, 34);
            this.nmAccountType.TabIndex = 1;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.BackgroundImage")));
            this.btnResetPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnResetPassword.Location = new System.Drawing.Point(161, 204);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(192, 75);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // tpFood
            // 
            this.tpFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpFood.BackgroundImage")));
            this.tpFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 35);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(1084, 653);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Menu";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(9, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 530);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(567, 524);
            this.dtgvFood.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnViewFood);
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(9, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 101);
            this.panel4.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(104, 95);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteFood.BackgroundImage")));
            this.btnDeleteFood.Location = new System.Drawing.Point(113, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(104, 95);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xoá";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditFood.BackgroundImage")));
            this.btnEditFood.Location = new System.Drawing.Point(223, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(104, 95);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnViewFood
            // 
            this.btnViewFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewFood.BackgroundImage")));
            this.btnViewFood.Location = new System.Drawing.Point(333, 3);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(104, 95);
            this.btnViewFood.TabIndex = 3;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchFoodName);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(588, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 101);
            this.panel5.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.BackgroundImage")));
            this.btnSearchFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFood.Location = new System.Drawing.Point(383, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(104, 95);
            this.btnSearchFood.TabIndex = 1;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // txtSearchFoodName
            // 
            this.txtSearchFoodName.Location = new System.Drawing.Point(3, 34);
            this.txtSearchFoodName.Name = "txtSearchFoodName";
            this.txtSearchFoodName.Size = new System.Drawing.Size(374, 34);
            this.txtSearchFoodName.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(588, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 530);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(487, 61);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(133, 12);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(351, 34);
            this.txtFoodID.TabIndex = 1;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(0, 70);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(487, 61);
            this.panel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(133, 12);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(351, 34);
            this.txtFoodName.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(0, 137);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(487, 61);
            this.panel9.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(133, 8);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(351, 34);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(0, 204);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(487, 61);
            this.panel10.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(131, 8);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(351, 34);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // tpBill
            // 
            this.tpBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpBill.BackgroundImage")));
            this.tpBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 35);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1084, 653);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 49);
            this.panel1.TabIndex = 0;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(0, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(359, 34);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(716, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(359, 34);
            this.dtpkToDate.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(478, 5);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(120, 34);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 602);
            this.panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(1075, 592);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(-1, -2);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1092, 692);
            this.tcAdmin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 688);
            this.Controls.Add(this.tcAdmin);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tpAccount.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}