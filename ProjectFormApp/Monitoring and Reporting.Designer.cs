namespace ProjectFormApp
{
    partial class Monitoring_and_Reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring_and_Reporting));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Username_lbl = new Label();
            groupBox2 = new GroupBox();
            categoriesMgmt = new Button();
            serviceMgmt = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            accessLbl = new Label();
            OverdueRequestCount = new Label();
            PendRequestCount = new Label();
            RequestsCount = new Label();
            noOfOverdueRequests = new Label();
            pendingRequest = new Label();
            numberOFRequests = new Label();
            ddlCategory = new ComboBox();
            filterLbl = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(199, 364);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Username_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 102);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Username_lbl
            // 
            Username_lbl.AutoSize = true;
            Username_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Username_lbl.ForeColor = Color.White;
            Username_lbl.Location = new Point(38, 70);
            Username_lbl.Name = "Username_lbl";
            Username_lbl.Size = new Size(76, 19);
            Username_lbl.TabIndex = 0;
            Username_lbl.Text = "Username";
            Username_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(categoriesMgmt);
            groupBox2.Controls.Add(serviceMgmt);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 108);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(179, 220);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admins/Managers Menu";
            // 
            // categoriesMgmt
            // 
            categoriesMgmt.BackColor = SystemColors.MenuHighlight;
            categoriesMgmt.FlatStyle = FlatStyle.Flat;
            categoriesMgmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoriesMgmt.ForeColor = SystemColors.Control;
            categoriesMgmt.Location = new Point(10, 63);
            categoriesMgmt.Margin = new Padding(3, 2, 3, 2);
            categoriesMgmt.Name = "categoriesMgmt";
            categoriesMgmt.Size = new Size(163, 45);
            categoriesMgmt.TabIndex = 13;
            categoriesMgmt.Text = "Categories Management";
            categoriesMgmt.UseVisualStyleBackColor = false;
            categoriesMgmt.Click += categoriesMgmt_Click;
            // 
            // serviceMgmt
            // 
            serviceMgmt.BackColor = SystemColors.MenuHighlight;
            serviceMgmt.FlatStyle = FlatStyle.Flat;
            serviceMgmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            serviceMgmt.ForeColor = SystemColors.Control;
            serviceMgmt.Location = new Point(10, 20);
            serviceMgmt.Margin = new Padding(3, 2, 3, 2);
            serviceMgmt.Name = "serviceMgmt";
            serviceMgmt.Size = new Size(163, 39);
            serviceMgmt.TabIndex = 12;
            serviceMgmt.Text = "Services Management";
            serviceMgmt.UseVisualStyleBackColor = false;
            serviceMgmt.Click += serviceMgmt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(204, 6);
            label2.Name = "label2";
            label2.Size = new Size(363, 38);
            label2.TabIndex = 1;
            label2.Text = "Monitoring and Reporting";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OverdueRequestCount);
            groupBox1.Controls.Add(PendRequestCount);
            groupBox1.Controls.Add(RequestsCount);
            groupBox1.Controls.Add(noOfOverdueRequests);
            groupBox1.Controls.Add(pendingRequest);
            groupBox1.Controls.Add(numberOFRequests);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(204, 95);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(508, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category Dashboard";
            // 
            // accessLbl
            // 
            accessLbl.AutoSize = true;
            accessLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            accessLbl.ForeColor = Color.Red;
            accessLbl.Location = new Point(260, 72);
            accessLbl.Name = "accessLbl";
            accessLbl.Size = new Size(374, 25);
            accessLbl.TabIndex = 6;
            accessLbl.Text = "Access to Category DashBoard is Denied!";
            // 
            // OverdueRequestCount
            // 
            OverdueRequestCount.AutoSize = true;
            OverdueRequestCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OverdueRequestCount.Location = new Point(240, 163);
            OverdueRequestCount.Name = "OverdueRequestCount";
            OverdueRequestCount.Size = new Size(23, 25);
            OverdueRequestCount.TabIndex = 5;
            OverdueRequestCount.Text = "0";
            // 
            // PendRequestCount
            // 
            PendRequestCount.AutoSize = true;
            PendRequestCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PendRequestCount.Location = new Point(356, 69);
            PendRequestCount.Name = "PendRequestCount";
            PendRequestCount.Size = new Size(23, 25);
            PendRequestCount.TabIndex = 4;
            PendRequestCount.Text = "0";
            // 
            // RequestsCount
            // 
            RequestsCount.AutoSize = true;
            RequestsCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RequestsCount.Location = new Point(109, 69);
            RequestsCount.Name = "RequestsCount";
            RequestsCount.Size = new Size(23, 25);
            RequestsCount.TabIndex = 3;
            RequestsCount.Text = "0";
            // 
            // noOfOverdueRequests
            // 
            noOfOverdueRequests.AutoSize = true;
            noOfOverdueRequests.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            noOfOverdueRequests.Location = new Point(99, 128);
            noOfOverdueRequests.Name = "noOfOverdueRequests";
            noOfOverdueRequests.Size = new Size(275, 25);
            noOfOverdueRequests.TabIndex = 2;
            noOfOverdueRequests.Text = "Number of Overdue Requests";
            // 
            // pendingRequest
            // 
            pendingRequest.AutoSize = true;
            pendingRequest.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRequest.Location = new Point(288, 35);
            pendingRequest.Name = "pendingRequest";
            pendingRequest.Size = new Size(170, 25);
            pendingRequest.TabIndex = 1;
            pendingRequest.Text = "Pending Requests";
            // 
            // numberOFRequests
            // 
            numberOFRequests.AutoSize = true;
            numberOFRequests.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numberOFRequests.Location = new Point(23, 35);
            numberOFRequests.Name = "numberOFRequests";
            numberOFRequests.Size = new Size(194, 25);
            numberOFRequests.TabIndex = 0;
            numberOFRequests.Text = "Number of Requests";
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(269, 45);
            ddlCategory.Margin = new Padding(3, 2, 3, 2);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(189, 23);
            ddlCategory.TabIndex = 3;
            ddlCategory.SelectedIndexChanged += ddlCategory_SelectedIndexChanged;
            // 
            // filterLbl
            // 
            filterLbl.AutoSize = true;
            filterLbl.ForeColor = SystemColors.Window;
            filterLbl.Location = new Point(208, 48);
            filterLbl.Name = "filterLbl";
            filterLbl.Size = new Size(55, 15);
            filterLbl.TabIndex = 10;
            filterLbl.Text = "Category";
            // 
            // Monitoring_and_Reporting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(752, 364);
            Controls.Add(accessLbl);
            Controls.Add(filterLbl);
            Controls.Add(ddlCategory);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Monitoring_and_Reporting";
            Text = "Monitoring_and_Reporting";
            Load += Monitoring_and_Reporting_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label Username_lbl;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button serviceMgmt;
        private Button categoriesMgmt;
        private Label numberOFRequests;
        private Label noOfOverdueRequests;
        private Label pendingRequest;
        private Label OverdueRequestCount;
        private Label PendRequestCount;
        private Label RequestsCount;
        private ComboBox ddlCategory;
        private Label filterLbl;
        private Label accessLbl;
    }
}