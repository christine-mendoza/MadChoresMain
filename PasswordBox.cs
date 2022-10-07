using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadChoresMain
{
    public partial class PasswordBox : Form
    {
        public PasswordBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChoreManager cm = new ChoreManager();
            Approve af = new Approve();
            string pw = File.ReadAllText("C:\\MadChores\\pw.txt");
            if(textBoxPw.Text == pw)
            {

                this.Close();
                List<ChoreItem> list = cm.UnapprovedChores();
                list.Reverse();
                foreach(ChoreItem c in list)
                {
                    
                    af.listBoxApprove.Items.Add(c);
                }
                
                af.labelTotalDue.Text = "$" + cm.UnpaidChores().ToString();
                af.ShowDialog();
                
            }
            else
            {
                textBoxPw.Text = "";
            }
        }
    }
}
