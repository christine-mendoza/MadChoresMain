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
    public partial class AddChoresForm : Form
    {
        public AddChoresForm()
        {
            InitializeComponent();
        }
        private double total = 0.00;
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
            if(checkBoxBathroom.Checked)
            {
                ChoreItem item = new ChoreItem("Clean Bathroom", 1.00);
                ChoreManager.AddChore(item);
                checkBoxBathroom.Checked = false;
                
            }
            if (checkBoxDesk.Checked)
            {
                ChoreItem item = new ChoreItem("Clean Desk", 0.50);
                ChoreManager.AddChore(item);
                checkBoxDesk.Checked = false;


            }
            if(checkBoxDishwasher.Checked)
            {
                ChoreItem item = new ChoreItem("Empty Dishwasher", 0.25);
                ChoreManager.AddChore(item);
                checkBoxDishwasher.Checked = false;
            }
            if (checkBoxRoom.Checked)
            {
                ChoreItem item = new ChoreItem("Clean Room", 1.00);
                ChoreManager.AddChore(item);
                checkBoxRoom.Checked = false;

            }
            if (checkBoxIceTrays.Checked)
            {
                ChoreItem item = new ChoreItem("Ice Trays", 0.25);
                ChoreManager.AddChore(item);
                checkBoxIceTrays.Checked = false;

            }
            if (checkBoxLaundry.Checked)
            {
                ChoreItem item = new ChoreItem("Laundry", 1.25);
                ChoreManager.AddChore(item);
                checkBoxLaundry.Checked = false;

            }
            if (checkBoxClothes.Checked)
            {
                ChoreItem item = new ChoreItem("Pick Up Clothes", 0.25);
                ChoreManager.AddChore(item);
                checkBoxClothes.Checked = false;

            }
            if(checkBoxDustLivingRoom.Checked)
            {
                ChoreItem item = new ChoreItem("Dust Living Room", 1.00);
                ChoreManager.AddChore(item);
                checkBoxDustLivingRoom.Checked = false;
            }
            if(checkBoxDustRoom.Checked)
            {
                ChoreItem item = new ChoreItem("Dust Room", 1.00);
                ChoreManager.AddChore(item);
                checkBoxDustRoom.Checked = false;
            }
            if(checkBoxLoadDishwasher.Checked)
            {
                ChoreItem item = new ChoreItem("Load Dishwasher", 1.00);
                ChoreManager.AddChore(item);
                checkBoxLoadDishwasher.Checked = false;
            }
            if(checkBoxMop.Checked)
            {
                ChoreItem item = new ChoreItem("Mop", 1.00);
                ChoreManager.AddChore(item);
                checkBoxMop.Checked = false;
            }
            if(checkBoxSweep.Checked)
            {
                ChoreItem item = new ChoreItem("Sweep", 1.00);
                ChoreManager.AddChore(item);
                checkBoxSweep.Checked = false;
            }
            if(checkBoxPoop.Checked)
            {
                ChoreItem item = new ChoreItem("Scoop Poop", 1.00);
                ChoreManager.AddChore(item);
                checkBoxPoop.Checked = false;
            }
            if(textBoxFill1.Text != "" && textBoxFillCost1.Text != "")
            {
                ChoreItem item = new ChoreItem(textBoxFill1.Text, Convert.ToDouble(textBoxFillCost1.Text));
                ChoreManager.AddChore(item);
            }
            if (textBoxFill2.Text != "" && textBoxFillCost2.Text != "")
            {
                ChoreItem item = new ChoreItem(textBoxFill2.Text, Convert.ToDouble(textBoxFillCost2.Text));
                ChoreManager.AddChore(item);
            }
            if (textBoxFill3.Text != "" && textBoxFillCost3.Text != "")
            {
                ChoreItem item = new ChoreItem(textBoxFill3.Text, Convert.ToDouble(textBoxFillCost3.Text));
                ChoreManager.AddChore(item);
            }

            total = 0.00;
            MessageBox.Show("Chores Submitted!");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxDesk_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void checkBoxIceTrays_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLaundry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxClothes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddChoresForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            ReviewForm rf = new ReviewForm();
            
           total = 0.00;
            if(checkBoxBathroom.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Clean Bathroom   $1.00");
                total += 1.00;
            }
            if(checkBoxDesk.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Clean Desk   $0.50");
                total += 0.50;
            }
            if(checkBoxRoom.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Clean Room   $1.00");
                total += 1.00;
            }
            if(checkBoxDishwasher.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Empty Dishwasher   $0.25");
                total += 0.25;
            }
            if(checkBoxIceTrays.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Ice Trays    $0.25");
                total += 0.25;
            }
            if(checkBoxLaundry.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Laundry  $1.25");
                total += 1.25;
            }
            if(checkBoxClothes.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Pick Up Clothes  $0.25");
                total += 0.25;
            }
            if(checkBoxDustLivingRoom.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Dust Living Room   $1.00");
                total += 1.00;
            }
            if(checkBoxDustRoom.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Dust Room   $1.00");
                total += 1.00;
            }
            if(checkBoxLoadDishwasher.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Load Dishwasher   $1.00");
                total += 1.00;
            }
            if(checkBoxMop.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Mop   $1.00");
                total += 1.00;
            }
            if(checkBoxSweep.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Sweep   $1.00");
                total += 1.00;
            }
            if(checkBoxPoop.Checked)
            {
                rf.listBoxReview.Items.Add("Chore: Scoop Poop  $1.00");
                total += 1.00;
            }
            if (textBoxFill1.Text != "" && textBoxFillCost1.Text != "")
            {
                rf.listBoxReview.Items.Add("Chore: " + textBoxFill1.Text + "   $" + textBoxFillCost1.Text);
                total += Convert.ToDouble(textBoxFillCost1.Text);
            }
            if (textBoxFill2.Text != "" && textBoxFillCost2.Text != "")
            {
                rf.listBoxReview.Items.Add("Chore: " + textBoxFill2.Text + "   $" + textBoxFillCost2.Text);
                total += Convert.ToDouble(textBoxFillCost2.Text);
            }
            if (textBoxFill3.Text != "" && textBoxFillCost3.Text != "")
            {
                rf.listBoxReview.Items.Add("Chore: " + textBoxFill3.Text + "   $" + textBoxFillCost3.Text);
                total += Convert.ToDouble(textBoxFillCost3.Text);
            }

            rf.labelTotal.Text = "$" + total.ToString();
            rf.ShowDialog();

        }

        private void textBoxFillCost1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
