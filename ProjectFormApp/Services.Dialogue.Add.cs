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
    public partial class frmServicesDialogueAdd : Form
    {
        HSMSContext context;
        Service service;
        public frmServicesDialogueAdd()
        {
            InitializeComponent();

            context = new HSMSContext();

            service = new Service();
        }

        public frmServicesDialogueAdd(Service s)
        {
            InitializeComponent();

            context = new HSMSContext();

            service = s;
        }

        private void frmServicesDialogueAdd_Load(object sender, EventArgs e)
        {
            
            ddlManager.DataSource = context.Categories.ToList();
            ddlManager.DisplayMember = "CategoryName";
            ddlManager.ValueMember = "CategoryId";
            ddlManager.SelectedItem = null;

            if (service.ServiceId > 0)
            {
                txtSvcID.Text = service.ServiceId.ToString();
                svcTxtName.Text = service.ServiceName;
                svcTxtDescription.Text = service.Description;
                svcPriceTxt.Text = service.Price.ToString();
                ddlManager.SelectedValue = service.CategoryId;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                service.Category = null;
                service.ServiceName = svcTxtName.Text;
                service.Description = svcTxtDescription.Text;
                service.Price = Double.Parse(svcPriceTxt.Text);


                if (ddlManager.SelectedItem != null)
                {
                    service.CategoryId = Convert.ToInt32(ddlManager.SelectedValue);
                }
                else
                {
                    return;
                }

                if (service.ServiceId > 0)
                {
                    context.Update(service);
                }
                else
                {
                    context.Add(service);
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
    }
}
