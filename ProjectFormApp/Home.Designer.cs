
namespace ProjectFormApp
{
    partial class Home
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
            lblUserName = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUserEmail = new Label();
            btnLogout = new Button();
            label4 = new Label();
            lblUserID = new Label();
            label5 = new Label();
            lblRole = new Label();
            monRptBtn = new Button();
            serviceMgmt = new Button();
            categoriesMgmt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(122, 124);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(100, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "lblUserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 124);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 156);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserEmail.Location = new Point(122, 156);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(96, 20);
            lblUserEmail.TabIndex = 3;
            lblUserEmail.Text = "lblUserEmail";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Lavender;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(201, 374);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(256, 47);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 91);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 7;
            label4.Text = "ID:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserID.Location = new Point(122, 91);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(74, 20);
            lblUserID.TabIndex = 6;
            lblUserID.Text = "lblUserID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 191);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 9;
            label5.Text = "Role:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(122, 191);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(57, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "lblRole";
            // 
            // monRptBtn
            // 
            monRptBtn.BackColor = SystemColors.ActiveCaption;
            monRptBtn.FlatStyle = FlatStyle.Flat;
            monRptBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            monRptBtn.Location = new Point(12, 238);
            monRptBtn.Name = "monRptBtn";
            monRptBtn.Size = new Size(216, 29);
            monRptBtn.TabIndex = 10;
            monRptBtn.Text = "Monitoring and Reporting";
            monRptBtn.UseVisualStyleBackColor = false;
            monRptBtn.Click += monRptBtn_Click;
            // 
            // serviceMgmt
            // 
            serviceMgmt.BackColor = SystemColors.ActiveCaption;
            serviceMgmt.FlatStyle = FlatStyle.Flat;
            serviceMgmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            serviceMgmt.Location = new Point(12, 273);
            serviceMgmt.Name = "serviceMgmt";
            serviceMgmt.Size = new Size(216, 29);
            serviceMgmt.TabIndex = 11;
            serviceMgmt.Text = "Services Management";
            serviceMgmt.UseVisualStyleBackColor = false;
            serviceMgmt.Click += serviceMgmt_Click;
            // 
            // categoriesMgmt
            // 
            categoriesMgmt.BackColor = SystemColors.ActiveCaption;
            categoriesMgmt.FlatStyle = FlatStyle.Flat;
            categoriesMgmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoriesMgmt.Location = new Point(12, 308);
            categoriesMgmt.Name = "categoriesMgmt";
            categoriesMgmt.Size = new Size(216, 29);
            categoriesMgmt.TabIndex = 12;
            categoriesMgmt.Text = "Categories Management";
            categoriesMgmt.UseVisualStyleBackColor = false;
            categoriesMgmt.Click += categoriesMgmt_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(674, 443);
            Controls.Add(categoriesMgmt);
            Controls.Add(serviceMgmt);
            Controls.Add(monRptBtn);
            Controls.Add(label5);
            Controls.Add(lblRole);
            Controls.Add(label4);
            Controls.Add(lblUserID);
            Controls.Add(btnLogout);
            Controls.Add(label3);
            Controls.Add(lblUserEmail);
            Controls.Add(label2);
            Controls.Add(lblUserName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += Home_FormClosing;
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserID;
        private Label label5;
        private Label lblRole;
        private Button monRptBtn;
        private Button serviceMgmt;
        private Button categoriesMgmt;
    }
}