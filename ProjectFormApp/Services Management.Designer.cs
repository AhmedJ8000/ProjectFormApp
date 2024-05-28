namespace ProjectFormApp
{
    partial class ServicesMgmt
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
            groupBoxAdmin = new GroupBox();
            ddlCategory = new ComboBox();
            filterBtn = new Button();
            lblSearchUsr = new Label();
            resetRefreshBtn = new Button();
            searchUsrTxtInput = new TextBox();
            label1 = new Label();
            dgvServices = new DataGridView();
            addSvcBtn = new Button();
            deleteSvcBtn = new Button();
            editSvcBtn = new Button();
            backBtn = new Button();
            groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAdmin
            // 
            groupBoxAdmin.Controls.Add(ddlCategory);
            groupBoxAdmin.Controls.Add(filterBtn);
            groupBoxAdmin.Controls.Add(lblSearchUsr);
            groupBoxAdmin.Controls.Add(resetRefreshBtn);
            groupBoxAdmin.Controls.Add(searchUsrTxtInput);
            groupBoxAdmin.Controls.Add(label1);
            groupBoxAdmin.Location = new Point(11, 12);
            groupBoxAdmin.Name = "groupBoxAdmin";
            groupBoxAdmin.Size = new Size(890, 89);
            groupBoxAdmin.TabIndex = 1;
            groupBoxAdmin.TabStop = false;
            groupBoxAdmin.Text = "Filters";
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(415, 35);
            ddlCategory.Margin = new Padding(3, 4, 3, 4);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(238, 28);
            ddlCategory.TabIndex = 8;
            // 
            // filterBtn
            // 
            filterBtn.BackColor = SystemColors.Highlight;
            filterBtn.FlatAppearance.BorderColor = Color.Black;
            filterBtn.FlatStyle = FlatStyle.Flat;
            filterBtn.ForeColor = Color.White;
            filterBtn.Location = new Point(661, 35);
            filterBtn.Margin = new Padding(3, 4, 3, 4);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(86, 31);
            filterBtn.TabIndex = 7;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // lblSearchUsr
            // 
            lblSearchUsr.AutoSize = true;
            lblSearchUsr.Location = new Point(10, 40);
            lblSearchUsr.Name = "lblSearchUsr";
            lblSearchUsr.Size = new Size(95, 20);
            lblSearchUsr.TabIndex = 1;
            lblSearchUsr.Text = "Search by ID:";
            // 
            // resetRefreshBtn
            // 
            resetRefreshBtn.FlatStyle = FlatStyle.Flat;
            resetRefreshBtn.Location = new Point(752, 35);
            resetRefreshBtn.Margin = new Padding(3, 4, 3, 4);
            resetRefreshBtn.Name = "resetRefreshBtn";
            resetRefreshBtn.Size = new Size(131, 31);
            resetRefreshBtn.TabIndex = 6;
            resetRefreshBtn.Text = "Reset / Refresh";
            resetRefreshBtn.UseVisualStyleBackColor = true;
            resetRefreshBtn.Click += resetRefreshBtn_Click;
            // 
            // searchUsrTxtInput
            // 
            searchUsrTxtInput.Location = new Point(109, 35);
            searchUsrTxtInput.Name = "searchUsrTxtInput";
            searchUsrTxtInput.Size = new Size(172, 27);
            searchUsrTxtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 41);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 4;
            label1.Text = "Filter by Category: ";
            // 
            // dgvServices
            // 
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(11, 107);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(887, 404);
            dgvServices.TabIndex = 2;
            // 
            // addSvcBtn
            // 
            addSvcBtn.BackColor = Color.White;
            addSvcBtn.FlatStyle = FlatStyle.Flat;
            addSvcBtn.Location = new Point(11, 529);
            addSvcBtn.Name = "addSvcBtn";
            addSvcBtn.Size = new Size(163, 48);
            addSvcBtn.TabIndex = 4;
            addSvcBtn.Text = "Add Service";
            addSvcBtn.UseVisualStyleBackColor = false;
            addSvcBtn.Click += addSvcBtn_Click;
            // 
            // deleteSvcBtn
            // 
            deleteSvcBtn.BackColor = Color.DarkRed;
            deleteSvcBtn.FlatStyle = FlatStyle.Flat;
            deleteSvcBtn.ForeColor = Color.White;
            deleteSvcBtn.Location = new Point(351, 529);
            deleteSvcBtn.Name = "deleteSvcBtn";
            deleteSvcBtn.Size = new Size(163, 48);
            deleteSvcBtn.TabIndex = 5;
            deleteSvcBtn.Text = "Delete Service";
            deleteSvcBtn.UseVisualStyleBackColor = false;
            deleteSvcBtn.Click += deleteSvcBtn_Click;
            // 
            // editSvcBtn
            // 
            editSvcBtn.BackColor = Color.White;
            editSvcBtn.FlatStyle = FlatStyle.Flat;
            editSvcBtn.Location = new Point(182, 529);
            editSvcBtn.Name = "editSvcBtn";
            editSvcBtn.Size = new Size(163, 48);
            editSvcBtn.TabIndex = 6;
            editSvcBtn.Text = "Edit Service";
            editSvcBtn.UseVisualStyleBackColor = false;
            editSvcBtn.Click += editSvcBtn_Click;
            // 
            // backBtn
            // 
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(799, 529);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(102, 48);
            backBtn.TabIndex = 9;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // ServicesMgmt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(backBtn);
            Controls.Add(editSvcBtn);
            Controls.Add(deleteSvcBtn);
            Controls.Add(addSvcBtn);
            Controls.Add(dgvServices);
            Controls.Add(groupBoxAdmin);
            Name = "ServicesMgmt";
            Text = "Services Management";
            Load += ServicesMgmt_Load;
            groupBoxAdmin.ResumeLayout(false);
            groupBoxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxAdmin;
        private DataGridView dgvServices;
        private Button addSvcBtn;
        private Button deleteSvcBtn;
        private Button editSvcBtn;
        private TextBox searchUsrTxtInput;
        private Label lblSearchUsr;
        private Button filterBtn;
        private Button resetRefreshBtn;
        private Label label1;
        private ComboBox ddlCategory;
        private Button backBtn;
    }
}