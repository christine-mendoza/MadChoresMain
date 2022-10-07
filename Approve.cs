using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadChoresMain
{
    public partial class Approve : Form
    {
        public Approve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoreManager cm = new ChoreManager();
            cm.approveAll();
            listBoxApprove.Items.Clear();
            labelTotalDue.Text = "$" + cm.UnpaidChores().ToString();
            MessageBox.Show("Chores Approved!");
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoreManager cm = new ChoreManager();

            foreach (ChoreItem item in listBoxApprove.SelectedItems)
            {
                cm.approveSelected(item);
                
            }
            listBoxApprove.Items.Clear();
            List<ChoreItem> list = cm.UnapprovedChores();
            list.Reverse();
            foreach(ChoreItem item in list)
            {
                listBoxApprove.Items.Add(item);
            }
            labelTotalDue.Text = "$" + cm.UnpaidChores().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoreManager cm = new ChoreManager();

            foreach(ChoreItem item in listBoxApprove.SelectedItems)
            {
                cm.deleteSelected(item);
            }
            listBoxApprove.Items.Clear();
            List<ChoreItem> list = cm.UnapprovedChores();
            list.Reverse();
            foreach (ChoreItem item in list)
            {
                listBoxApprove.Items.Add(item);
            }
            labelTotalDue.Text = "$" + cm.UnpaidChores().ToString();
        }

        private void listBoxApprove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
