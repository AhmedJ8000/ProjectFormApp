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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Completed_Request_lbl = new System.Windows.Forms.Label();
            this.Pending_Request_lbl = new System.Windows.Forms.Label();
            this.Overdue_Reqest_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Username_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 144);
            this.panel1.TabIndex = 0;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_lbl.ForeColor = System.Drawing.Color.Black;
            this.Username_lbl.Location = new System.Drawing.Point(35, 94);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(106, 28);
            this.Username_lbl.TabIndex = 0;
            this.Username_lbl.Text = "Username";
            this.Username_lbl.Click += new System.EventHandler(this.Username_lbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "DashBoard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Overdue_Reqest_lbl);
            this.panel2.Controls.Add(this.Pending_Request_lbl);
            this.panel2.Controls.Add(this.Completed_Request_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(195, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 150);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending Request";
            // 
            // Completed_Request_lbl
            // 
            this.Completed_Request_lbl.AutoSize = true;
            this.Completed_Request_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Completed_Request_lbl.Location = new System.Drawing.Point(28, 51);
            this.Completed_Request_lbl.Name = "Completed_Request_lbl";
            this.Completed_Request_lbl.Size = new System.Drawing.Size(161, 23);
            this.Completed_Request_lbl.TabIndex = 1;
            this.Completed_Request_lbl.Text = "Request Completed";
            // 
            // Pending_Request_lbl
            // 
            this.Pending_Request_lbl.AutoSize = true;
            this.Pending_Request_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pending_Request_lbl.Location = new System.Drawing.Point(28, 74);
            this.Pending_Request_lbl.Name = "Pending_Request_lbl";
            this.Pending_Request_lbl.Size = new System.Drawing.Size(127, 20);
            this.Pending_Request_lbl.TabIndex = 2;
            this.Pending_Request_lbl.Text = "Ongoing Request";
            // 
            // Overdue_Reqest_lbl
            // 
            this.Overdue_Reqest_lbl.AutoSize = true;
            this.Overdue_Reqest_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Overdue_Reqest_lbl.Location = new System.Drawing.Point(28, 94);
            this.Overdue_Reqest_lbl.Name = "Overdue_Reqest_lbl";
            this.Overdue_Reqest_lbl.Size = new System.Drawing.Size(126, 20);
            this.Overdue_Reqest_lbl.TabIndex = 3;
            this.Overdue_Reqest_lbl.Text = "Overdue Request";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Monitoring_and_Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Monitoring_and_Reporting";
            this.Text = "Monitoring_and_Reporting";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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