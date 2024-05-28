using HSMSBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFormApp
{
    public partial class CategoriesMgmt : Form
    {
        HSMSContext context;
        public CategoriesMgmt()
        {
            InitializeComponent();
            context = new HSMSContext();
        }

        private void CategoriesMgmt_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            if (Global.RoleName != "Manager" && Global.RoleName != "Admin")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                backBtn.Visible = true;
                mntrBtn.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                mntrBtn.Visible = true;
                backBtn.Visible = false;
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshGrid()
        {
            try
            {
                dgvCategories.DataSource = null;

                var ordersToShow = context.Categories.AsQueryable();

                if (txtCategoryID.Text != "")
                {
                    ordersToShow = ordersToShow.Where(x => x.CategoryId == Convert.ToInt32(txtCategoryID.Text));
                }

                dgvCategories.DataSource = ordersToShow
                    .OrderBy(m => m.CategoryId)
                    .Select(o => new
                    {
                        OrderID = o.CategoryId,
                        CategoryName = o.CategoryName,
                        Description = o.Description,
                        ManagerName = o.Manager.UserName
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = "";
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoriesDialogueAdd frmCategoriesAdd = new frmCategoriesDialogueAdd();
            frmCategoriesAdd.ShowDialog();

            if (frmCategoriesAdd.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfuly");
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int firstCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);
                Category category = context.Categories.Find(firstCell);
                frmCategoriesDialogueAdd frmCategoriesAdd = new frmCategoriesDialogueAdd(category);
                frmCategoriesAdd.ShowDialog();

                if (frmCategoriesAdd.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int firstCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);
            Category category = context.Categories.Find(firstCell);

            if (MessageBox.Show("Are you sure you want to delete this category (" + firstCell + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Categories.Remove(category);

                context.SaveChanges();

                RefreshGrid();
            }

        }

        private void mntrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int firstCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);
                Category category = context.Categories.Find(firstCell);
                Monitoring_and_Reporting mar = new Monitoring_and_Reporting();
                mar.Show();
                mar.SetSelectedCategory(category.CategoryId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Monitoring_and_Reporting mar = new Monitoring_and_Reporting();
            this.Hide();
            mar.Show();
        }
    }
}
