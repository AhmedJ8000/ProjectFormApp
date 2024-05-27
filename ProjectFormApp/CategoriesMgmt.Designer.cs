namespace ProjectFormApp
{
    partial class CategoriesMgmt
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
            txtCategoryID = new TextBox();
            label2 = new Label();
            btnFilter = new Button();
            btnReset = new Button();
            dgvCategories = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            mntrBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Location = new Point(103, 37);
            txtCategoryID.Margin = new Padding(3, 4, 3, 4);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(114, 27);
            txtCategoryID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 47);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Search by ID: ";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.Highlight;
            btnFilter.FlatAppearance.BorderColor = Color.Black;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(656, 36);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(86, 31);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(749, 36);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset / Refresh";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(14, 124);
            dgvCategories.Margin = new Padding(3, 4, 3, 4);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(887, 404);
            dgvCategories.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(14, 536);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 48);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Category";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(184, 536);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 48);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Category";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(354, 536);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Category";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // mntrBtn
            // 
            mntrBtn.FlatStyle = FlatStyle.Flat;
            mntrBtn.Location = new Point(523, 536);
            mntrBtn.Margin = new Padding(3, 4, 3, 4);
            mntrBtn.Name = "mntrBtn";
            mntrBtn.Size = new Size(166, 48);
            mntrBtn.TabIndex = 7;
            mntrBtn.Text = "Monitor";
            mntrBtn.UseVisualStyleBackColor = true;
            mntrBtn.Click += mntrBtn_Click;
            // 
            // CategoriesMgmt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(mntrBtn);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategories);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoriesMgmt";
            Text = "CategoriesMgmt";
            Load += CategoriesMgmt_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFilter;
        private Button btnReset;
        private DataGridView dgvCategories;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtCategoryID;
        private Label label2;
        private Button mntrBtn;
    }
}