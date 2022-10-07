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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddChores_Click(object sender, EventArgs e)
        {
            AddChoresForm cf = new AddChoresForm();
            cf.ShowDialog();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            BalanceForm bf = new BalanceForm();
            ChoreManager cm = new ChoreManager();
            List<ChoreItem> list = cm.AllChores();
            list.Reverse();
            foreach(ChoreItem c in list)
            {
                bf.listBoxBalance.Items.Add(c.ToString());
            }

            bf.labelTotal.Text = "$" + cm.PaidChores().ToString();
            bf.labelDue.Text = "$" + cm.UnpaidChores().ToString();
            bf.ShowDialog();

        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            PasswordBox pb = new PasswordBox();
            pb.ShowDialog();
        }

        public List<ChoreItem> reverseList(List<ChoreItem> list)
        {
            List<ChoreItem> rev = new List<ChoreItem>();
          for(int i = list.Count() - 1; i <= 0; i--)
            {
                rev.Add(list[i]);
            }
            return rev;
        }
    }
}
