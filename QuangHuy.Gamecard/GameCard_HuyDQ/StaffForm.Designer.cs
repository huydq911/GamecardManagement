namespace GameCard_HuyDQ
{
    partial class StaffForm
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
            lblFormTitle = new Label();
            lblBookList = new Label();
            dgvGamecardList = new DataGridView();
            gbSunglassInfo = new GroupBox();
            txtPlatform = new TextBox();
            lblMaterial = new Label();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboProvider = new ComboBox();
            dtpCreatedDate = new DateTimePicker();
            txtName = new TextBox();
            txtId = new TextBox();
            lblProvider = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCreatedDate = new Label();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            lblUserNameAndRole = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGamecardList).BeginInit();
            gbSunglassInfo.SuspendLayout();
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(34, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(332, 46);
            lblFormTitle.TabIndex = 37;
            lblFormTitle.Text = "Gamecard Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(573, 189);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(103, 20);
            lblBookList.TabIndex = 41;
            lblBookList.Text = "Gamecard List";
            // 
            // dgvGamecardList
            // 
            dgvGamecardList.BackgroundColor = Color.White;
            dgvGamecardList.BorderStyle = BorderStyle.Fixed3D;
            dgvGamecardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGamecardList.Location = new Point(573, 221);
            dgvGamecardList.Name = "dgvGamecardList";
            dgvGamecardList.RowHeadersWidth = 51;
            dgvGamecardList.RowTemplate.Height = 29;
            dgvGamecardList.Size = new Size(523, 371);
            dgvGamecardList.TabIndex = 36;
            dgvGamecardList.SelectionChanged += dgvGamecardList_SelectionChanged;
            // 
            // gbSunglassInfo
            // 
            gbSunglassInfo.Controls.Add(txtPlatform);
            gbSunglassInfo.Controls.Add(lblMaterial);
            gbSunglassInfo.Controls.Add(txtDesc);
            gbSunglassInfo.Controls.Add(txtPrice);
            gbSunglassInfo.Controls.Add(txtQuantity);
            gbSunglassInfo.Controls.Add(cboProvider);
            gbSunglassInfo.Controls.Add(dtpCreatedDate);
            gbSunglassInfo.Controls.Add(txtName);
            gbSunglassInfo.Controls.Add(txtId);
            gbSunglassInfo.Controls.Add(lblProvider);
            gbSunglassInfo.Controls.Add(lblPrice);
            gbSunglassInfo.Controls.Add(lblQuantity);
            gbSunglassInfo.Controls.Add(lblCreatedDate);
            gbSunglassInfo.Controls.Add(lblDesc);
            gbSunglassInfo.Controls.Add(lblName);
            gbSunglassInfo.Controls.Add(lblId);
            gbSunglassInfo.ForeColor = Color.Yellow;
            gbSunglassInfo.Location = new Point(34, 69);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 38;
            gbSunglassInfo.TabStop = false;
            gbSunglassInfo.Text = "Gamecard Info ";
            // 
            // txtPlatform
            // 
            txtPlatform.Location = new Point(129, 173);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(355, 27);
            txtPlatform.TabIndex = 10;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(17, 184);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(66, 20);
            lblMaterial.TabIndex = 9;
            lblMaterial.Text = "Platform";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(131, 125);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(353, 27);
            txtDesc.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(359, 283);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(129, 283);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(153, 27);
            txtQuantity.TabIndex = 4;
            // 
            // cboProvider
            // 
            cboProvider.FormattingEnabled = true;
            cboProvider.Location = new Point(129, 340);
            cboProvider.Name = "cboProvider";
            cboProvider.Size = new Size(353, 28);
            cboProvider.TabIndex = 7;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            dtpCreatedDate.Format = DateTimePickerFormat.Custom;
            dtpCreatedDate.Location = new Point(129, 231);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(153, 27);
            dtpCreatedDate.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(131, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblProvider
            // 
            lblProvider.AutoSize = true;
            lblProvider.Location = new Point(18, 343);
            lblProvider.Name = "lblProvider";
            lblProvider.Size = new Size(64, 20);
            lblProvider.TabIndex = 7;
            lblProvider.Text = "Provider";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(299, 289);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(18, 289);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 237);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(17, 136);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(85, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(17, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(331, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 36);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(91, 35);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(221, 27);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(34, 527);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(501, 80);
            gbTask.TabIndex = 39;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(389, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(264, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(141, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(17, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(573, 69);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(451, 80);
            gbSearch.TabIndex = 40;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // lblUserNameAndRole
            // 
            lblUserNameAndRole.AutoSize = true;
            lblUserNameAndRole.Location = new Point(945, 25);
            lblUserNameAndRole.Name = "lblUserNameAndRole";
            lblUserNameAndRole.Size = new Size(114, 20);
            lblUserNameAndRole.TabIndex = 42;
            lblUserNameAndRole.Text = "FullName | Role";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1131, 605);
            Controls.Add(lblUserNameAndRole);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvGamecardList);
            Controls.Add(gbSunglassInfo);
            Controls.Add(gbTask);
            Controls.Add(gbSearch);
            Name = "StaffForm";
            Text = "StaffForm";
            FormClosed += StaffForm_FormClosed;
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGamecardList).EndInit();
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblBookList;
        private DataGridView dgvGamecardList;
        private GroupBox gbSunglassInfo;
        private TextBox txtPlatform;
        private Label lblMaterial;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboProvider;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblProvider;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCreatedDate;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Label lblUserNameAndRole;
    }
}