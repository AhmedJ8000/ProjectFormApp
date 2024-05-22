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
            label2 = new Label();
            panel2 = new Panel();
            Overdue_Reqest_lbl = new Label();
            Pending_Request_lbl = new Label();
            Completed_Request_lbl = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(186, 450);
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
            panel1.Size = new Size(186, 144);
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
            Username_lbl.ForeColor = Color.Black;
            Username_lbl.Location = new Point(35, 94);
            Username_lbl.Name = "Username_lbl";
            Username_lbl.Size = new Size(106, 28);
            Username_lbl.TabIndex = 0;
            Username_lbl.Text = "Username";
            Username_lbl.Click += Username_lbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 9);
            label2.Name = "label2";
            label2.Size = new Size(199, 47);
            label2.TabIndex = 1;
            label2.Text = "DashBoard";
            // 
            // panel2
            // 
            panel2.Controls.Add(Overdue_Reqest_lbl);
            panel2.Controls.Add(Pending_Request_lbl);
            panel2.Controls.Add(Completed_Request_lbl);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(195, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 2;
            // 
            // Overdue_Reqest_lbl
            // 
            Overdue_Reqest_lbl.AutoSize = true;
            Overdue_Reqest_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Overdue_Reqest_lbl.Location = new Point(28, 94);
            Overdue_Reqest_lbl.Name = "Overdue_Reqest_lbl";
            Overdue_Reqest_lbl.Size = new Size(126, 20);
            Overdue_Reqest_lbl.TabIndex = 3;
            Overdue_Reqest_lbl.Text = "Overdue Request";
            // 
            // Pending_Request_lbl
            // 
            Pending_Request_lbl.AutoSize = true;
            Pending_Request_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Pending_Request_lbl.Location = new Point(28, 74);
            Pending_Request_lbl.Name = "Pending_Request_lbl";
            Pending_Request_lbl.Size = new Size(127, 20);
            Pending_Request_lbl.TabIndex = 2;
            Pending_Request_lbl.Text = "Ongoing Request";
            // 
            // Completed_Request_lbl
            // 
            Completed_Request_lbl.AutoSize = true;
            Completed_Request_lbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Completed_Request_lbl.Location = new Point(28, 51);
            Completed_Request_lbl.Name = "Completed_Request_lbl";
            Completed_Request_lbl.Size = new Size(161, 23);
            Completed_Request_lbl.TabIndex = 1;
            Completed_Request_lbl.Text = "Request Completed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "Pending Request";
            // 
            // Monitoring_and_Reporting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Name = "Monitoring_and_Reporting";
            Text = "Monitoring_and_Reporting";
            Load += Monitoring_and_Reporting_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label Username_lbl;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label Overdue_Reqest_lbl;
        private Label Pending_Request_lbl;
        private Label Completed_Request_lbl;
        private Label label1;
    }
}