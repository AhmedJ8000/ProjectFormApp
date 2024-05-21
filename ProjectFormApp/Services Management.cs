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
    public partial class ServicesMgmt : Form
    {
        ProjectIdentityDBContext context;
        public ServicesMgmt()
        {
            InitializeComponent();
            context = new ProjectIdentityDBContext();
        }

        private void ServicesMgmt_Load(object sender, EventArgs e)
        {
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryId";
            ddlCategory.SelectedItem = null;
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            try
            {
                dgvServices.DataSource = null;

                var serviceToShow = context.Services.AsQueryable();

                if (searchUsrTxtInput.Text != "")
                {
                    serviceToShow = serviceToShow.Where(x => x.ServiceId == Convert.ToInt32(searchUsrTxtInput.Text));
                }
                if (ddlCategory.SelectedValue != null)
                {
                    serviceToShow = serviceToShow.Where(x => x.CategoryId == Convert.ToInt32(ddlCategory.SelectedValue.ToString()));
                }

                dgvServices.DataSource = serviceToShow
                    .OrderBy(m => m.ServiceId)
                    .Select(o => new
                    {
                        ServiceID = o.ServiceId,
                        ServiceName = o.ServiceName,
                        Description = o.Description,
                        Price = o.Price,
                        Category = o.Category.CategoryName
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSvcBtn_Click(object sender, EventArgs e)
        {
            frmServicesDialogueAdd frmServicesAdd = new frmServicesDialogueAdd();
            frmServicesAdd.ShowDialog();

            if (frmServicesAdd.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfuly");
                RefreshGrid();
            }
        }

        private void editSvcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int firstCell = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
                Service service = context.Services.Find(firstCell);
                frmServicesDialogueAdd frmServicesAdd = new frmServicesDialogueAdd(service);
                frmServicesAdd.ShowDialog();

                if (frmServicesAdd.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteSvcBtn_Click(object sender, EventArgs e)
        {
            int firstCell = Convert.ToInt32(dgvServices.SelectedCells[0].OwningRow.Cells[0].Value);
            Service service = context.Services.Find(firstCell);
            if (MessageBox.Show("Are you sure you want to delete this service (" + firstCell + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Services.Remove(service);

                context.SaveChanges();

                RefreshGrid();
            }
        }

        private void resetRefreshBtn_Click(object sender, EventArgs e)
        {
            searchUsrTxtInput.Text = string.Empty;
            ddlCategory.Text = string.Empty;
            ddlCategory.SelectedItem = null;
            RefreshGrid();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

    }
}
