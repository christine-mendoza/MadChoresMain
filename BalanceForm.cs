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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void listBoxBalance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            listBoxBalance.Items.Clear();
            ChoreManager cm = new ChoreManager();
            List<ChoreItem> list = cm.AllChores();
            list.Reverse();
            foreach (ChoreItem c in list)
            {
                listBoxBalance.Items.Add(c.ToString());
            }
           
        }

        private void buttonPaid_Click(object sender, EventArgs e)
        {
            listBoxBalance.Items.Clear();
            ChoreManager cm = new ChoreManager();
            List<ChoreItem> list = cm.ApprovedChores();
            list.Reverse();
            foreach (ChoreItem c in list)
            {
                listBoxBalance.Items.Add(c.ToString());
            }
        }

        private void buttonOwed_Click(object sender, EventArgs e)
        {
            listBoxBalance.Items.Clear();
            ChoreManager cm = new ChoreManager();
            List<ChoreItem> list = cm.UnapprovedChores();
            list.Reverse();
            foreach (ChoreItem c in list)
            {
                listBoxBalance.Items.Add(c.ToString());
            }
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxBalance.Items.Clear();
            ChoreManager cm = new ChoreManager();
            List<ChoreItem> list = cm.DateSearchChores(dateTimePicker1.Value, dateTimePicker2.Value);
            list.Reverse();
            foreach(ChoreItem c in list)
            {
                listBoxBalance.Items.Add(c.ToString());
            }
        }
    }
}
