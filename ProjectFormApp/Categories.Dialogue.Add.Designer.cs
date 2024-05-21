
namespace ProjectFormApp
{
    partial class frmCategoriesDialogueAdd
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
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            txtDescription = new RichTextBox();
            label1 = new Label();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ddlManager = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Category ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Category Name:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(123, 33);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.PlaceholderText = "New";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(217, 23);
            txtCategoryID.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlManager);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 265);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Info";
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 39;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(122, 105);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(217, 97);
            txtDescription.TabIndex = 38;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 108);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 37;
            label1.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 220);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 35;
            label8.Text = "Manager:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(1, 90, 132);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(17, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 41);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(291, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 41);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ddlManager
            // 
            ddlManager.FormattingEnabled = true;
            ddlManager.Location = new Point(122, 217);
            ddlManager.Name = "ddlManager";
            ddlManager.Size = new Size(217, 23);
            ddlManager.TabIndex = 40;
            // 
            // frmCategoriesDialogueAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(387, 331);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "frmCategoriesDialogueAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New/Edit Category";
            Load += frmOrdersDialogueAdd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private Label label1;
        private RichTextBox txtDescription;
        private TextBox txtName;
        private ComboBox ddlManager;
    }
}