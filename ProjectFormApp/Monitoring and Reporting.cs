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
        ProjectIdentityDBContext context;
        public Monitoring_and_Reporting()
        {
            InitializeComponent();
            context = new ProjectIdentityDBContext();
        }

        private void Monitoring_and_Reporting_Load(object sender, EventArgs e)
        {
            Username_lbl.Text = Global.User.UserName;
        }

        private void serviceMgmt_Click(object sender, EventArgs e)
        {
            ServicesMgmt sm = new ServicesMgmt();
            sm.ShowDialog();
        }

        private void categoriesMgmt_Click(object sender, EventArgs e)
        {
            CategoriesMgmt cm = new CategoriesMgmt();
            cm.ShowDialog();
        }
    }
}
