namespace GameCard_HuyDQ
{
    partial class GamecardForm
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
            btnCancel = new Button();
            lblFormTitle = new Label();
            btnSave = new Button();
            gbSunglassInfo = new GroupBox();
            txtPlatform = new TextBox();
            lblPlatform = new Label();
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
            lblDescription = new Label();
            lblName = new Label();
            lblId = new Label();
            gbSunglassInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(633, 543);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(226, 11);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(282, 46);
            lblFormTitle.TabIndex = 32;
            lblFormTitle.Text = "Add a Gamecard";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.Location = new Point(526, 543);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            gbSunglassInfo.Location = new Point(226, 69);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 35;
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
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(17, 184);
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
            txtPrice.Location = new Point(359, 282);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(129, 282);
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
            lblPrice.Location = new Point(300, 289);
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
            lblCreatedDate.Location = new Point(17, 238);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(17, 136);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
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
            // GamecardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(953, 582);
            Controls.Add(gbSunglassInfo);
            Controls.Add(btnCancel);
            Controls.Add(lblFormTitle);
            Controls.Add(btnSave);
            Name = "GamecardForm";
            Text = "GamecardForm";
            Load += GamecardForm_Load;
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Label lblFormTitle;
        private Button btnSave;
        private GroupBox gbSunglassInfo;
        private TextBox txtPlatform;
        private Label lblPlatform;
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
        private Label lblDescription;
        private Label lblName;
        private Label lblId;
    }
}