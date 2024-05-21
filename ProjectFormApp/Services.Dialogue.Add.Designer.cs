namespace ProjectFormApp
{
    partial class frmServicesDialogueAdd
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
            groupBox1 = new GroupBox();
            CategoryLbl = new Label();
            ddlManager = new ComboBox();
            svcPriceTxt = new TextBox();
            svcTxtName = new TextBox();
            svcTxtDescription = new RichTextBox();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSvcID = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CategoryLbl);
            groupBox1.Controls.Add(ddlManager);
            groupBox1.Controls.Add(svcPriceTxt);
            groupBox1.Controls.Add(svcTxtName);
            groupBox1.Controls.Add(svcTxtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSvcID);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(411, 353);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Service Info";
            // 
            // CategoryLbl
            // 
            CategoryLbl.AutoSize = true;
            CategoryLbl.Location = new Point(19, 316);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(72, 20);
            CategoryLbl.TabIndex = 41;
            CategoryLbl.Text = "Category:";
            // 
            // ddlManager
            // 
            ddlManager.FormattingEnabled = true;
            ddlManager.Location = new Point(139, 312);
            ddlManager.Margin = new Padding(3, 4, 3, 4);
            ddlManager.Name = "ddlManager";
            ddlManager.Size = new Size(247, 28);
            ddlManager.TabIndex = 42;
            // 
            // svcPriceTxt
            // 
            svcPriceTxt.Location = new Point(139, 128);
            svcPriceTxt.Margin = new Padding(3, 4, 3, 4);
            svcPriceTxt.Name = "svcPriceTxt";
            svcPriceTxt.Size = new Size(247, 27);
            svcPriceTxt.TabIndex = 40;
            // 
            // svcTxtName
            // 
            svcTxtName.Location = new Point(139, 84);
            svcTxtName.Margin = new Padding(3, 4, 3, 4);
            svcTxtName.Name = "svcTxtName";
            svcTxtName.Size = new Size(247, 27);
            svcTxtName.TabIndex = 39;
            // 
            // svcTxtDescription
            // 
            svcTxtDescription.Location = new Point(139, 175);
            svcTxtDescription.Margin = new Padding(3, 4, 3, 4);
            svcTxtDescription.Name = "svcTxtDescription";
            svcTxtDescription.Size = new Size(247, 128);
            svcTxtDescription.TabIndex = 38;
            svcTxtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 175);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 37;
            label1.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 128);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 35;
            label8.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Service ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Service Name:";
            // 
            // txtSvcID
            // 
            txtSvcID.Location = new Point(141, 44);
            txtSvcID.Margin = new Padding(3, 4, 3, 4);
            txtSvcID.Name = "txtSvcID";
            txtSvcID.PlaceholderText = "New";
            txtSvcID.ReadOnly = true;
            txtSvcID.Size = new Size(247, 27);
            txtSvcID.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(327, 377);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 55);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(1, 90, 132);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(14, 377);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 55);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmServicesDialogueAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 441);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmServicesDialogueAdd";
            Text = "Add/Edit Service";
            Load += frmServicesDialogueAdd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox svcTxtName;
        private RichTextBox svcTxtDescription;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private TextBox txtSvcID;
        private TextBox svcPriceTxt;
        private Label CategoryLbl;
        private ComboBox ddlManager;
        private Button btnCancel;
        private Button btnSave;
    }
}