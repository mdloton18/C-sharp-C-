namespace FoodCourtManagementSystem
{
    partial class ManagerForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFoodInfo = new System.Windows.Forms.DataGridView();
            this.FoodCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnfoodSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShowFoodInfo = new System.Windows.Forms.Button();
            this.btnClearFoodInfo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblFoodManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateFormate = new System.Windows.Forms.Label();
            this.lblAutoSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveEmployeeInfo = new System.Windows.Forms.Button();
            this.btnClearEmployeeInfo = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dtpJoinningDate = new System.Windows.Forms.DateTimePicker();
            this.lblJoinningDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSalesmanName = new System.Windows.Forms.TextBox();
            this.lblSalesmanName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEmployeeManagement = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnShowDailySales = new System.Windows.Forms.Button();
            this.lblDailySales = new System.Windows.Forms.Label();
            this.dgvDailySales = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnShowMonthlySales = new System.Windows.Forms.Button();
            this.lblMonthlySales = new System.Windows.Forms.Label();
            this.dgvMonthlySales = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvFoodInfo);
            this.panel3.Location = new System.Drawing.Point(21, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 217);
            this.panel3.TabIndex = 10;
            // 
            // dgvFoodInfo
            // 
            this.dgvFoodInfo.AllowUserToAddRows = false;
            this.dgvFoodInfo.AllowUserToDeleteRows = false;
            this.dgvFoodInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodCode,
            this.FoodName,
            this.Price});
            this.dgvFoodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodInfo.Name = "dgvFoodInfo";
            this.dgvFoodInfo.ReadOnly = true;
            this.dgvFoodInfo.RowHeadersWidth = 51;
            this.dgvFoodInfo.RowTemplate.Height = 24;
            this.dgvFoodInfo.Size = new System.Drawing.Size(358, 217);
            this.dgvFoodInfo.TabIndex = 5;
            // 
            // FoodCode
            // 
            this.FoodCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodCode.DataPropertyName = "FoodCode";
            this.FoodCode.HeaderText = "Food code";
            this.FoodCode.MinimumWidth = 6;
            this.FoodCode.Name = "FoodCode";
            this.FoodCode.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnfoodSearch);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.lblSearch);
            this.panel5.Controls.Add(this.btnShowFoodInfo);
            this.panel5.Controls.Add(this.btnClearFoodInfo);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(21, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 482);
            this.panel5.TabIndex = 9;
            // 
            // btnfoodSearch
            // 
            this.btnfoodSearch.Location = new System.Drawing.Point(97, 193);
            this.btnfoodSearch.Name = "btnfoodSearch";
            this.btnfoodSearch.Size = new System.Drawing.Size(75, 23);
            this.btnfoodSearch.TabIndex = 34;
            this.btnfoodSearch.Text = "Search";
            this.btnfoodSearch.UseVisualStyleBackColor = true;
            this.btnfoodSearch.Click += new System.EventHandler(this.btnfoodSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 113);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 33;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(29, 113);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 17);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search Food";
            // 
            // btnShowFoodInfo
            // 
            this.btnShowFoodInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnShowFoodInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFoodInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowFoodInfo.Location = new System.Drawing.Point(221, 438);
            this.btnShowFoodInfo.Name = "btnShowFoodInfo";
            this.btnShowFoodInfo.Size = new System.Drawing.Size(135, 43);
            this.btnShowFoodInfo.TabIndex = 31;
            this.btnShowFoodInfo.Text = "Show Info>>>";
            this.btnShowFoodInfo.UseVisualStyleBackColor = false;
            this.btnShowFoodInfo.Click += new System.EventHandler(this.btnShowFoodInfo_Click);
            // 
            // btnClearFoodInfo
            // 
            this.btnClearFoodInfo.Location = new System.Drawing.Point(32, 420);
            this.btnClearFoodInfo.Name = "btnClearFoodInfo";
            this.btnClearFoodInfo.Size = new System.Drawing.Size(93, 39);
            this.btnClearFoodInfo.TabIndex = 31;
            this.btnClearFoodInfo.Text = "Clear";
            this.btnClearFoodInfo.UseVisualStyleBackColor = true;
            this.btnClearFoodInfo.Click += new System.EventHandler(this.btnClearFoodInfo_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblFoodManagement);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 58);
            this.panel7.TabIndex = 0;
            // 
            // lblFoodManagement
            // 
            this.lblFoodManagement.AutoSize = true;
            this.lblFoodManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodManagement.ForeColor = System.Drawing.Color.Azure;
            this.lblFoodManagement.Location = new System.Drawing.Point(60, 12);
            this.lblFoodManagement.Name = "lblFoodManagement";
            this.lblFoodManagement.Size = new System.Drawing.Size(125, 29);
            this.lblFoodManagement.TabIndex = 0;
            this.lblFoodManagement.Text = "Food view";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblDateFormate);
            this.panel1.Controls.Add(this.lblAutoSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSaveEmployeeInfo);
            this.panel1.Controls.Add(this.btnClearEmployeeInfo);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.dtpJoinningDate);
            this.panel1.Controls.Add(this.lblJoinningDate);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.LblId);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtSalesmanName);
            this.panel1.Controls.Add(this.lblSalesmanName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnShowInfo);
            this.panel1.Location = new System.Drawing.Point(385, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 491);
            this.panel1.TabIndex = 11;
            // 
            // lblDateFormate
            // 
            this.lblDateFormate.AutoSize = true;
            this.lblDateFormate.Location = new System.Drawing.Point(363, 343);
            this.lblDateFormate.Name = "lblDateFormate";
            this.lblDateFormate.Size = new System.Drawing.Size(94, 17);
            this.lblDateFormate.TabIndex = 31;
            this.lblDateFormate.Text = "(yyyy-mm-dd)";
            // 
            // lblAutoSearch
            // 
            this.lblAutoSearch.AutoSize = true;
            this.lblAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAutoSearch.Location = new System.Drawing.Point(133, 414);
            this.lblAutoSearch.Name = "lblAutoSearch";
            this.lblAutoSearch.Size = new System.Drawing.Size(144, 20);
            this.lblAutoSearch.TabIndex = 30;
            this.lblAutoSearch.Text = "Search by name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveEmployeeInfo
            // 
            this.btnSaveEmployeeInfo.Location = new System.Drawing.Point(366, 439);
            this.btnSaveEmployeeInfo.Name = "btnSaveEmployeeInfo";
            this.btnSaveEmployeeInfo.Size = new System.Drawing.Size(93, 39);
            this.btnSaveEmployeeInfo.TabIndex = 28;
            this.btnSaveEmployeeInfo.Text = "Save";
            this.btnSaveEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnSaveEmployeeInfo.Click += new System.EventHandler(this.btnSaveEmployeeInfo_Click);
            // 
            // btnClearEmployeeInfo
            // 
            this.btnClearEmployeeInfo.Location = new System.Drawing.Point(480, 439);
            this.btnClearEmployeeInfo.Name = "btnClearEmployeeInfo";
            this.btnClearEmployeeInfo.Size = new System.Drawing.Size(93, 39);
            this.btnClearEmployeeInfo.TabIndex = 27;
            this.btnClearEmployeeInfo.Text = "Clear";
            this.btnClearEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnClearEmployeeInfo.Click += new System.EventHandler(this.btnClearEmployeeInfo_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(27, 414);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(100, 22);
            this.txtAutoSearch.TabIndex = 26;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // dtpJoinningDate
            // 
            this.dtpJoinningDate.CustomFormat = "yyyy-mm-dd";
            this.dtpJoinningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoinningDate.Location = new System.Drawing.Point(160, 338);
            this.dtpJoinningDate.Name = "dtpJoinningDate";
            this.dtpJoinningDate.Size = new System.Drawing.Size(176, 22);
            this.dtpJoinningDate.TabIndex = 25;
            // 
            // lblJoinningDate
            // 
            this.lblJoinningDate.AutoSize = true;
            this.lblJoinningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinningDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblJoinningDate.Location = new System.Drawing.Point(23, 338);
            this.lblJoinningDate.Name = "lblJoinningDate";
            this.lblJoinningDate.Size = new System.Drawing.Size(131, 20);
            this.lblJoinningDate.TabIndex = 24;
            this.lblJoinningDate.Text = "Joinning Date:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSalary.Location = new System.Drawing.Point(23, 299);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(80, 20);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary : ";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCountry.Location = new System.Drawing.Point(23, 269);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 20);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCity.Location = new System.Drawing.Point(23, 234);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(54, 20);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPassword.Location = new System.Drawing.Point(23, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 20);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password :";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRole.Location = new System.Drawing.Point(23, 156);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 20);
            this.lblRole.TabIndex = 19;
            this.lblRole.Text = "Role :";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblId.Location = new System.Drawing.Point(23, 116);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(36, 20);
            this.LblId.TabIndex = 18;
            this.LblId.Text = "Id :";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(161, 297);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 16;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(161, 269);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 22);
            this.txtCountry.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(161, 232);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(161, 154);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 22);
            this.txtRole.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 116);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 11;
            // 
            // txtSalesmanName
            // 
            this.txtSalesmanName.Location = new System.Drawing.Point(161, 78);
            this.txtSalesmanName.Name = "txtSalesmanName";
            this.txtSalesmanName.Size = new System.Drawing.Size(157, 22);
            this.txtSalesmanName.TabIndex = 10;
            // 
            // lblSalesmanName
            // 
            this.lblSalesmanName.AutoSize = true;
            this.lblSalesmanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSalesmanName.Location = new System.Drawing.Point(23, 80);
            this.lblSalesmanName.Name = "lblSalesmanName";
            this.lblSalesmanName.Size = new System.Drawing.Size(63, 20);
            this.lblSalesmanName.TabIndex = 1;
            this.lblSalesmanName.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblEmployeeManagement);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 56);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(750, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 482);
            this.panel4.TabIndex = 3;
            // 
            // lblEmployeeManagement
            // 
            this.lblEmployeeManagement.AutoSize = true;
            this.lblEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmployeeManagement.Location = new System.Drawing.Point(217, 9);
            this.lblEmployeeManagement.Name = "lblEmployeeManagement";
            this.lblEmployeeManagement.Size = new System.Drawing.Size(315, 32);
            this.lblEmployeeManagement.TabIndex = 0;
            this.lblEmployeeManagement.Text = "Employee Management";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowInfo.Location = new System.Drawing.Point(595, 439);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(152, 43);
            this.btnShowInfo.TabIndex = 1;
            this.btnShowInfo.Text = "Show Info>>>";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Id,
            this.Role,
            this.Password,
            this.City,
            this.Country,
            this.Salary,
            this.JoinningDate});
            this.dgvUserInfo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUserInfo.Location = new System.Drawing.Point(384, 531);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowTemplate.Height = 24;
            this.dgvUserInfo.Size = new System.Drawing.Size(747, 220);
            this.dgvUserInfo.TabIndex = 32;
            this.dgvUserInfo.DoubleClick += new System.EventHandler(this.dgvUserInfo_DoubleClick);
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Salesman Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // JoinningDate
            // 
            this.JoinningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JoinningDate.DataPropertyName = "JoinningDate";
            this.JoinningDate.HeaderText = "Joinning Date";
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogOut);
            this.panel6.Location = new System.Drawing.Point(1395, 715);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 44);
            this.panel6.TabIndex = 33;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel10.Controls.Add(this.btnShowDailySales);
            this.panel10.Controls.Add(this.lblDailySales);
            this.panel10.Location = new System.Drawing.Point(1130, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(413, 131);
            this.panel10.TabIndex = 7;
            // 
            // btnShowDailySales
            // 
            this.btnShowDailySales.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnShowDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDailySales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowDailySales.Location = new System.Drawing.Point(274, 90);
            this.btnShowDailySales.Name = "btnShowDailySales";
            this.btnShowDailySales.Size = new System.Drawing.Size(152, 43);
            this.btnShowDailySales.TabIndex = 32;
            this.btnShowDailySales.Text = "Show Info>>>";
            this.btnShowDailySales.UseVisualStyleBackColor = false;
            this.btnShowDailySales.Click += new System.EventHandler(this.btnShowDailySales_Click);
            // 
            // lblDailySales
            // 
            this.lblDailySales.AutoSize = true;
            this.lblDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailySales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDailySales.Location = new System.Drawing.Point(162, 9);
            this.lblDailySales.Name = "lblDailySales";
            this.lblDailySales.Size = new System.Drawing.Size(144, 29);
            this.lblDailySales.TabIndex = 5;
            this.lblDailySales.Text = "Daily Sales";
            // 
            // dgvDailySales
            // 
            this.dgvDailySales.AllowUserToAddRows = false;
            this.dgvDailySales.AllowUserToDeleteRows = false;
            this.dgvDailySales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Sales});
            this.dgvDailySales.Location = new System.Drawing.Point(1130, 161);
            this.dgvDailySales.Name = "dgvDailySales";
            this.dgvDailySales.ReadOnly = true;
            this.dgvDailySales.RowTemplate.Height = 24;
            this.dgvDailySales.Size = new System.Drawing.Size(419, 192);
            this.dgvDailySales.TabIndex = 33;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Sales
            // 
            this.Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales.DataPropertyName = "Sales";
            this.Sales.HeaderText = "Sales";
            this.Sales.Name = "Sales";
            this.Sales.ReadOnly = true;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel14.Controls.Add(this.btnShowMonthlySales);
            this.panel14.Controls.Add(this.lblMonthlySales);
            this.panel14.Location = new System.Drawing.Point(1130, 359);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(413, 131);
            this.panel14.TabIndex = 35;
            // 
            // btnShowMonthlySales
            // 
            this.btnShowMonthlySales.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnShowMonthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMonthlySales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowMonthlySales.Location = new System.Drawing.Point(274, 90);
            this.btnShowMonthlySales.Name = "btnShowMonthlySales";
            this.btnShowMonthlySales.Size = new System.Drawing.Size(152, 43);
            this.btnShowMonthlySales.TabIndex = 32;
            this.btnShowMonthlySales.Text = "Show Info>>>";
            this.btnShowMonthlySales.UseVisualStyleBackColor = false;
            this.btnShowMonthlySales.Click += new System.EventHandler(this.btnShowMonthlySales_Click);
            // 
            // lblMonthlySales
            // 
            this.lblMonthlySales.AutoSize = true;
            this.lblMonthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMonthlySales.Location = new System.Drawing.Point(162, 9);
            this.lblMonthlySales.Name = "lblMonthlySales";
            this.lblMonthlySales.Size = new System.Drawing.Size(176, 29);
            this.lblMonthlySales.TabIndex = 5;
            this.lblMonthlySales.Text = "Monthly Sales";
            // 
            // dgvMonthlySales
            // 
            this.dgvMonthlySales.AllowUserToAddRows = false;
            this.dgvMonthlySales.AllowUserToDeleteRows = false;
            this.dgvMonthlySales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMonthlySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.MonthlySales});
            this.dgvMonthlySales.Location = new System.Drawing.Point(1130, 522);
            this.dgvMonthlySales.Name = "dgvMonthlySales";
            this.dgvMonthlySales.ReadOnly = true;
            this.dgvMonthlySales.RowTemplate.Height = 24;
            this.dgvMonthlySales.Size = new System.Drawing.Size(413, 192);
            this.dgvMonthlySales.TabIndex = 33;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // MonthlySales
            // 
            this.MonthlySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonthlySales.DataPropertyName = "MonthlySales";
            this.MonthlySales.HeaderText = "Monthly Sales";
            this.MonthlySales.Name = "MonthlySales";
            this.MonthlySales.ReadOnly = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 771);
            this.Controls.Add(this.dgvMonthlySales);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.dgvDailySales);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvUserInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFoodInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnfoodSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnShowFoodInfo;
        private System.Windows.Forms.Button btnClearFoodInfo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblFoodManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateFormate;
        private System.Windows.Forms.Label lblAutoSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveEmployeeInfo;
        private System.Windows.Forms.Button btnClearEmployeeInfo;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DateTimePicker dtpJoinningDate;
        private System.Windows.Forms.Label lblJoinningDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSalesmanName;
        private System.Windows.Forms.Label lblSalesmanName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEmployeeManagement;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinningDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnShowDailySales;
        private System.Windows.Forms.Label lblDailySales;
        private System.Windows.Forms.DataGridView dgvDailySales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnShowMonthlySales;
        private System.Windows.Forms.Label lblMonthlySales;
        private System.Windows.Forms.DataGridView dgvMonthlySales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySales;
    }
}