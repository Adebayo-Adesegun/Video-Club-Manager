using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class FrmMain_Page : Form
    {
        public FrmMain_Page()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegForm regCustomer = new FrmRegForm();
            regCustomer.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTransactionTracker makeTransaction = new FrmTransactionTracker();
            makeTransaction.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd_Video_to_Catalogue videoClub = new FrmAdd_Video_to_Catalogue();
            videoClub.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSelectCustomer view_update_customer = new FrmSelectCustomer();
            view_update_customer.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmView_Video_Collection vvc = new FrmView_Video_Collection();
            vvc.Show();
        }
    }
}
