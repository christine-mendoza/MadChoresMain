
namespace MadChoresMain
{
    partial class Approve
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
            this.listBoxApprove = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDue = new System.Windows.Forms.Label();
            this.labelTotalDue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxApprove
            // 
            this.listBoxApprove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxApprove.FormattingEnabled = true;
            this.listBoxApprove.Location = new System.Drawing.Point(0, 0);
            this.listBoxApprove.Name = "listBoxApprove";
            this.listBoxApprove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxApprove.Size = new System.Drawing.Size(1016, 472);
            this.listBoxApprove.TabIndex = 0;
            this.listBoxApprove.SelectedIndexChanged += new System.EventHandler(this.listBoxApprove_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Approve All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Approve Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(774, 530);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(111, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(12, 502);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(69, 13);
            this.labelDue.TabIndex = 6;
            this.labelDue.Text = "Amount Due:";
            // 
            // labelTotalDue
            // 
            this.labelTotalDue.AutoSize = true;
            this.labelTotalDue.Location = new System.Drawing.Point(27, 530);
            this.labelTotalDue.Name = "labelTotalDue";
            this.labelTotalDue.Size = new System.Drawing.Size(34, 13);
            this.labelTotalDue.TabIndex = 7;
            this.labelTotalDue.Text = "$0.00";
            // 
            // Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 574);
            this.Controls.Add(this.labelTotalDue);
            this.Controls.Add(this.labelDue);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxApprove);
            this.Name = "Approve";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDue;
        public System.Windows.Forms.ListBox listBoxApprove;
        public System.Windows.Forms.Label labelTotalDue;
    }
}