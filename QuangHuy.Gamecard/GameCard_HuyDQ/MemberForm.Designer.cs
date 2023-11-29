namespace GameCard_HuyDQ
{
    partial class MemberForm
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
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPlatform = new TextBox();
            lblPlatform = new Label();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboProvider = new ComboBox();
            dtpCreatedDate = new DateTimePicker();
            txtName = new TextBox();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            lblFormTitle = new Label();
            lblBookList = new Label();
            txtId = new TextBox();
            lblProvider = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            btnSearch = new Button();
            lblCreatedDate = new Label();
            gbSunglassInfo = new GroupBox();
            lblDescription = new Label();
            lblName = new Label();
            lblId = new Label();
            gbSearch = new GroupBox();
            dgvGamecardList = new DataGridView();
            lblUsernameRole = new Label();
            lblUserNameAndRole = new Label();
            gbTask.SuspendLayout();
            gbSunglassInfo.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGamecardList).BeginInit();
            SuspendLayout();
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(42, 572);
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
            // 
            // txtPlatform
            // 
            txtPlatform.Location = new Point(129, 173);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(355, 27);
            txtPlatform.TabIndex = 10;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(17, 183);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(66, 20);
            lblPlatform.TabIndex = 9;
            lblPlatform.Text = "Platform";
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
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 35);
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
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(42, 43);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(332, 46);
            lblFormTitle.TabIndex = 37;
            lblFormTitle.Text = "Gamecard Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(581, 235);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(103, 20);
            lblBookList.TabIndex = 41;
            lblBookList.Text = "Gamecard List";
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
            lblProvider.Location = new Point(18, 341);
            lblProvider.Name = "lblProvider";
            lblProvider.Size = new Size(64, 20);
            lblProvider.TabIndex = 7;
            lblProvider.Text = "Provider";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(299, 288);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(18, 288);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
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
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 236);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // gbSunglassInfo
            // 
            gbSunglassInfo.Controls.Add(txtPlatform);
            gbSunglassInfo.Controls.Add(lblPlatform);
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
            gbSunglassInfo.Controls.Add(lblDescription);
            gbSunglassInfo.Controls.Add(lblName);
            gbSunglassInfo.Controls.Add(lblId);
            gbSunglassInfo.ForeColor = Color.Yellow;
            gbSunglassInfo.Location = new Point(42, 115);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 38;
            gbSunglassInfo.TabStop = false;
            gbSunglassInfo.Text = "Gamecard Info ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(17, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(17, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(581, 115);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(451, 80);
            gbSearch.TabIndex = 40;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // dgvGamecardList
            // 
            dgvGamecardList.BackgroundColor = Color.White;
            dgvGamecardList.BorderStyle = BorderStyle.Fixed3D;
            dgvGamecardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGamecardList.Location = new Point(581, 267);
            dgvGamecardList.Name = "dgvGamecardList";
            dgvGamecardList.RowHeadersWidth = 51;
            dgvGamecardList.RowTemplate.Height = 29;
            dgvGamecardList.Size = new Size(523, 371);
            dgvGamecardList.TabIndex = 36;
            // 
            // lblUsernameRole
            // 
            lblUsernameRole.AutoSize = true;
            lblUsernameRole.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsernameRole.ForeColor = Color.Yellow;
            lblUsernameRole.Location = new Point(837, 43);
            lblUsernameRole.Name = "lblUsernameRole";
            lblUsernameRole.Size = new Size(0, 46);
            lblUsernameRole.TabIndex = 42;
            // 
            // lblUserNameAndRole
            // 
            lblUserNameAndRole.AutoSize = true;
            lblUserNameAndRole.Location = new Point(978, 43);
            lblUserNameAndRole.Name = "lblUserNameAndRole";
            lblUserNameAndRole.Size = new Size(114, 20);
            lblUserNameAndRole.TabIndex = 43;
            lblUserNameAndRole.Text = "FullName | Role";
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1197, 724);
            Controls.Add(lblUserNameAndRole);
            Controls.Add(lblUsernameRole);
            Controls.Add(gbTask);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(gbSunglassInfo);
            Controls.Add(gbSearch);
            Controls.Add(dgvGamecardList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberForm";
            Text = "MemberForm";
            FormClosed += MemberForm_FormClosed;
            Load += MemberForm_Load;
            gbTask.ResumeLayout(false);
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGamecardList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPlatform;
        private Label lblPlatform;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboProvider;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtName;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private Label lblFormTitle;
        private Label lblBookList;
        private TextBox txtId;
        private Label lblProvider;
        private Label lblPrice;
        private Label lblQuantity;
        private Button btnSearch;
        private Label lblCreatedDate;
        private GroupBox gbSunglassInfo;
        private Label lblDescription;
        private Label lblName;
        private Label lblId;
        private GroupBox gbSearch;
        private DataGridView dgvGamecardList;
        private Label lblUsernameRole;
        private Label lblUserNameAndRole;
    }
}