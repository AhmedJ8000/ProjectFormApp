using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSMSBusinessObjects;

namespace ProjectFormApp
{
    public partial class frmCategoriesDialogueAdd : Form
    {
        FormsIdentityContext context;
        Category category;

        public frmCategoriesDialogueAdd()
        {
            InitializeComponent();

            context = new FormsIdentityContext();

            category = new Category();
        }

        public frmCategoriesDialogueAdd(Category c)
        {
            InitializeComponent();

            context = new FormsIdentityContext();

            category = c;
        }

        private void frmOrdersDialogueAdd_Load(object sender, EventArgs e)
        {
            ddlManager.DataSource = context.Users.Where(x => x.Role == "Manager").ToList();
            ddlManager.DisplayMember = "Name";
            ddlManager.ValueMember = "UserId";
            ddlManager.SelectedItem = null;

            if(category.CategoryId > 0)
            {
                txtCategoryID.Text = category.CategoryId.ToString();
                txtName.Text = category.CategoryName;
                txtDescription.Text = category.Description;
                ddlManager.SelectedValue = category.ManagerId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //category.Manager = null;

                category.CategoryName = txtName.Text;
                category.Description = txtDescription.Text;


                if(ddlManager.SelectedItem != null)
                {
                    category.ManagerId = Convert.ToInt32(ddlManager.SelectedValue);
                }
                else
                {
                    return;
                }
                //category.Manager = context.Users.Where(x => x.UserId == category.ManagerId).FirstOrDefault();

                if(category.CategoryId > 0)
                {
                    context.Update(category);
                }
                else
                {
                    context.Add(category);
                }

                context.SaveChanges();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

