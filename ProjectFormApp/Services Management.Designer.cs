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
            button2 = new Button();
            lblSearchUsr = new Label();
            resetRefreshBtn = new Button();
            searchUsrTxtInput = new TextBox();
            label1 = new Label();
            dgvServices = new DataGridView();
            addSvcBtn = new Button();
            deleteSvcBtn = new Button();
            editSvcBtn = new Button();
            groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAdmin
            // 
            groupBoxAdmin.Controls.Add(ddlCategory);
            groupBoxAdmin.Controls.Add(button2);
            groupBoxAdmin.Controls.Add(lblSearchUsr);
            groupBoxAdmin.Controls.Add(resetRefreshBtn);
            groupBoxAdmin.Controls.Add(searchUsrTxtInput);
            groupBoxAdmin.Controls.Add(label1);
            groupBoxAdmin.Location = new Point(10, 9);
            groupBoxAdmin.Margin = new Padding(3, 2, 3, 2);
            groupBoxAdmin.Name = "groupBoxAdmin";
            groupBoxAdmin.Padding = new Padding(3, 2, 3, 2);
            groupBoxAdmin.Size = new Size(779, 67);
            groupBoxAdmin.TabIndex = 1;
            groupBoxAdmin.TabStop = false;
            groupBoxAdmin.Text = "Filters";
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(363, 26);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(209, 23);
            ddlCategory.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(578, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += filterBtn_Click;
            // 
            // lblSearchUsr
            // 
            lblSearchUsr.AutoSize = true;
            lblSearchUsr.Location = new Point(9, 30);
            lblSearchUsr.Name = "lblSearchUsr";
            lblSearchUsr.Size = new Size(75, 15);
            lblSearchUsr.TabIndex = 1;
            lblSearchUsr.Text = "Search by ID:";
            // 
            // resetRefreshBtn
            // 
            resetRefreshBtn.FlatStyle = FlatStyle.Flat;
            resetRefreshBtn.Location = new Point(658, 26);
            resetRefreshBtn.Name = "resetRefreshBtn";
            resetRefreshBtn.Size = new Size(115, 23);
            resetRefreshBtn.TabIndex = 6;
            resetRefreshBtn.Text = "Reset / Refresh";
            resetRefreshBtn.UseVisualStyleBackColor = true;
            resetRefreshBtn.Click += resetRefreshBtn_Click;
            // 
            // searchUsrTxtInput
            // 
            searchUsrTxtInput.Location = new Point(95, 26);
            searchUsrTxtInput.Margin = new Padding(3, 2, 3, 2);
            searchUsrTxtInput.Name = "searchUsrTxtInput";
            searchUsrTxtInput.Size = new Size(151, 23);
            searchUsrTxtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Filter by Category: ";
            // 
            // dgvServices
            // 
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(10, 80);
            dgvServices.Margin = new Padding(3, 2, 3, 2);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(776, 303);
            dgvServices.TabIndex = 2;
            // 
            // addSvcBtn
            // 
            addSvcBtn.BackColor = Color.White;
            addSvcBtn.FlatStyle = FlatStyle.Flat;
            addSvcBtn.Location = new Point(10, 397);
            addSvcBtn.Margin = new Padding(3, 2, 3, 2);
            addSvcBtn.Name = "addSvcBtn";
            addSvcBtn.Size = new Size(143, 36);
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
            deleteSvcBtn.Location = new Point(307, 397);
            deleteSvcBtn.Margin = new Padding(3, 2, 3, 2);
            deleteSvcBtn.Name = "deleteSvcBtn";
            deleteSvcBtn.Size = new Size(143, 36);
            deleteSvcBtn.TabIndex = 5;
            deleteSvcBtn.Text = "Delete Service";
            deleteSvcBtn.UseVisualStyleBackColor = false;
            deleteSvcBtn.Click += deleteSvcBtn_Click;
            // 
            // editSvcBtn
            // 
            editSvcBtn.BackColor = Color.White;
            editSvcBtn.FlatStyle = FlatStyle.Flat;
            editSvcBtn.Location = new Point(159, 397);
            editSvcBtn.Margin = new Padding(3, 2, 3, 2);
            editSvcBtn.Name = "editSvcBtn";
            editSvcBtn.Size = new Size(143, 36);
            editSvcBtn.TabIndex = 6;
            editSvcBtn.Text = "Edit Service";
            editSvcBtn.UseVisualStyleBackColor = false;
            editSvcBtn.Click += editSvcBtn_Click;
            // 
            // ServicesMgmt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editSvcBtn);
            Controls.Add(deleteSvcBtn);
            Controls.Add(addSvcBtn);
            Controls.Add(dgvServices);
            Controls.Add(groupBoxAdmin);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button2;
        private Button resetRefreshBtn;
        private Label label1;
        private ComboBox ddlCategory;
    }
}