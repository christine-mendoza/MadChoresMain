
namespace MadChoresMain
{
    partial class BalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBalance = new System.Windows.Forms.ListBox();
            this.buttonOwed = new System.Windows.Forms.Button();
            this.buttonPaid = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDue = new System.Windows.Forms.Label();
            this.buttonDateSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxBalance
            // 
            this.listBoxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBalance.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBalance.FormattingEnabled = true;
            this.listBoxBalance.ItemHeight = 20;
            this.listBoxBalance.Location = new System.Drawing.Point(0, 2);
            this.listBoxBalance.Name = "listBoxBalance";
            this.listBoxBalance.Size = new System.Drawing.Size(999, 404);
            this.listBoxBalance.TabIndex = 0;
            this.listBoxBalance.SelectedIndexChanged += new System.EventHandler(this.listBoxBalance_SelectedIndexChanged);
            // 
            // buttonOwed
            // 
            this.buttonOwed.Location = new System.Drawing.Point(41, 528);
            this.buttonOwed.Name = "buttonOwed";
            this.buttonOwed.Size = new System.Drawing.Size(75, 23);
            this.buttonOwed.TabIndex = 1;
            this.buttonOwed.Text = "Show Due";
            this.buttonOwed.UseVisualStyleBackColor = true;
            this.buttonOwed.Click += new System.EventHandler(this.buttonOwed_Click);
            // 
            // buttonPaid
            // 
            this.buttonPaid.Location = new System.Drawing.Point(265, 528);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(75, 23);
            this.buttonPaid.TabIndex = 2;
            this.buttonPaid.Text = "Show Paid";
            this.buttonPaid.UseVisualStyleBackColor = true;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(508, 528);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "Show All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(724, 528);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Paid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount Due:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(912, 446);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "$0.00";
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(912, 480);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(34, 13);
            this.labelDue.TabIndex = 8;
            this.labelDue.Text = "$0.00";
            // 
            // buttonDateSearch
            // 
            this.buttonDateSearch.Location = new System.Drawing.Point(517, 443);
            this.buttonDateSearch.Name = "buttonDateSearch";
            this.buttonDateSearch.Size = new System.Drawing.Size(129, 23);
            this.buttonDateSearch.TabIndex = 9;
            this.buttonDateSearch.Text = "Search Dates";
            this.buttonDateSearch.UseVisualStyleBackColor = true;
            this.buttonDateSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 446);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 572);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDateSearch);
            this.Controls.Add(this.labelDue);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonPaid);
            this.Controls.Add(this.buttonOwed);
            this.Controls.Add(this.listBoxBalance);
            this.Name = "BalanceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxBalance;
        private System.Windows.Forms.Button buttonOwed;
        private System.Windows.Forms.Button buttonPaid;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDateSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label labelTotal;
        public System.Windows.Forms.Label labelDue;
    }
}