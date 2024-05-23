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
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 486);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Username_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 136);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Username_lbl
            // 
            Username_lbl.AutoSize = true;
            Username_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username_lbl.ForeColor = Color.White;
            Username_lbl.Location = new Point(32, 94);
            Username_lbl.Name = "Username_lbl";
            Username_lbl.Size = new Size(106, 28);
            Username_lbl.TabIndex = 0;
            Username_lbl.Text = "Username";
            Username_lbl.Click += Username_lbl_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(categoriesMgmt);
            groupBox2.Controls.Add(serviceMgmt);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 293);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Menu";
            // 
            // categoriesMgmt
            // 
            categoriesMgmt.BackColor = SystemColors.MenuHighlight;
            categoriesMgmt.FlatStyle = FlatStyle.Flat;
            categoriesMgmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoriesMgmt.ForeColor = SystemColors.Control;
            categoriesMgmt.Location = new Point(6, 84);
            categoriesMgmt.Name = "categoriesMgmt";
            categoriesMgmt.Size = new Size(174, 52);
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
            serviceMgmt.Location = new Point(6, 26);
            serviceMgmt.Name = "serviceMgmt";
            serviceMgmt.Size = new Size(174, 52);
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
            label2.Location = new Point(219, 9);
            label2.Name = "label2";
            label2.Size = new Size(456, 47);
            label2.TabIndex = 1;
            label2.Text = "Monitoring and Reporting";
            // 
            // groupBox1
            // 
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(233, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 341);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dashboard";
            // 
            // Monitoring_and_Reporting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(860, 486);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Name = "Monitoring_and_Reporting";
            Text = "Monitoring_and_Reporting";
            Load += Monitoring_and_Reporting_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
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
    }
}