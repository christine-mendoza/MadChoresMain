
namespace MadChoresMain
{
    partial class MainForm
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
            this.ButtonAddChores = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddChores
            // 
            this.ButtonAddChores.BackColor = System.Drawing.Color.PowderBlue;
            this.ButtonAddChores.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddChores.Location = new System.Drawing.Point(110, 185);
            this.ButtonAddChores.Name = "ButtonAddChores";
            this.ButtonAddChores.Size = new System.Drawing.Size(178, 41);
            this.ButtonAddChores.TabIndex = 0;
            this.ButtonAddChores.Text = "Add Chores";
            this.ButtonAddChores.UseVisualStyleBackColor = false;
            this.ButtonAddChores.Click += new System.EventHandler(this.ButtonAddChores_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(110, 454);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 41);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonApprove.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.Location = new System.Drawing.Point(110, 361);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(178, 41);
            this.buttonApprove.TabIndex = 3;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonBalance.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.Location = new System.Drawing.Point(110, 271);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(178, 41);
            this.buttonBalance.TabIndex = 4;
            this.buttonBalance.Text = "Check Balance";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "MADISON\'S CHORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::MadChoresMain.Properties.Resources.Sammy;
            this.pictureBox1.Location = new System.Drawing.Point(460, -61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 702);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ButtonAddChores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chore App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddChores;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

