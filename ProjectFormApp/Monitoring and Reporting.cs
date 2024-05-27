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

    public partial class Monitoring_and_Reporting : Form
    {
        HSMSContext context;
        public Monitoring_and_Reporting()
        {
            InitializeComponent();
            context = new HSMSContext();
        }

        private void Monitoring_and_Reporting_Load(object sender, EventArgs e)
        {
            Username_lbl.Text = Global.User.UserName;
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryId";
            ddlCategory.SelectedItem = null;
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                var listToShow = context.ServiceRequests.AsQueryable();

                if (ddlCategory.SelectedValue != null)
                {
                    listToShow = listToShow.Where(x => x.IdNavigation.CategoryId.ToString() == ddlCategory.SelectedValue.ToString());
                }


                int PendingRequests = listToShow.Where(x => x.IsPending == true).Count();
                PendRequestCount.Text = PendingRequests.ToString();

                int TotalRequests = listToShow.Count();
                RequestsCount.Text = TotalRequests.ToString();

                DateTime today = DateTime.Today;

                int overdueRows = listToShow.Where(x => x.DateNeeded < today).Count();
                OverdueRequestCount.Text = overdueRows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serviceMgmt_Click(object sender, EventArgs e)
        {
            ServicesMgmt sm = new ServicesMgmt();
            sm.ShowDialog();
        }

        private void categoriesMgmt_Click(object sender, EventArgs e)
        {
            CategoriesMgmt cm = new CategoriesMgmt();
            cm.Show();
            this.Close();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void resetRefreshBtn_Click(object sender, EventArgs e)
        {
            ddlCategory.SelectedItem = null;
            RefreshData();
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void SetSelectedCategory(int categoryId)
        {
            ddlCategory.SelectedValue = categoryId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
