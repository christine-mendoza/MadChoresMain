
namespace MadChoresMain
{
    partial class AddChoresForm
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
            this.checkBoxBathroom = new System.Windows.Forms.CheckBox();
            this.checkBoxDesk = new System.Windows.Forms.CheckBox();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.labelBathroomCost = new System.Windows.Forms.Label();
            this.labelDeskCost = new System.Windows.Forms.Label();
            this.labelRoomCost = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClothesCost = new System.Windows.Forms.Label();
            this.labelLaundryCost = new System.Windows.Forms.Label();
            this.labelIceCost = new System.Windows.Forms.Label();
            this.labelDishwasherCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxClothes = new System.Windows.Forms.CheckBox();
            this.checkBoxLaundry = new System.Windows.Forms.CheckBox();
            this.checkBoxIceTrays = new System.Windows.Forms.CheckBox();
            this.checkBoxDishwasher = new System.Windows.Forms.CheckBox();
            this.buttonReview = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxPoop = new System.Windows.Forms.CheckBox();
            this.checkBoxSweep = new System.Windows.Forms.CheckBox();
            this.checkBoxMop = new System.Windows.Forms.CheckBox();
            this.checkBoxDustLivingRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxDustRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadDishwasher = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxFill1 = new System.Windows.Forms.TextBox();
            this.textBoxFillCost1 = new System.Windows.Forms.TextBox();
            this.textBoxFill2 = new System.Windows.Forms.TextBox();
            this.textBoxFillCost2 = new System.Windows.Forms.TextBox();
            this.textBoxFill3 = new System.Windows.Forms.TextBox();
            this.textBoxFillCost3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxBathroom
            // 
            this.checkBoxBathroom.AutoSize = true;
            this.checkBoxBathroom.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBathroom.Location = new System.Drawing.Point(9, 13);
            this.checkBoxBathroom.Name = "checkBoxBathroom";
            this.checkBoxBathroom.Size = new System.Drawing.Size(153, 30);
            this.checkBoxBathroom.TabIndex = 0;
            this.checkBoxBathroom.Text = "Clean Bathroom";
            this.checkBoxBathroom.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesk
            // 
            this.checkBoxDesk.AutoSize = true;
            this.checkBoxDesk.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesk.Location = new System.Drawing.Point(9, 40);
            this.checkBoxDesk.Name = "checkBoxDesk";
            this.checkBoxDesk.Size = new System.Drawing.Size(113, 30);
            this.checkBoxDesk.TabIndex = 1;
            this.checkBoxDesk.Text = "Clean Desk";
            this.checkBoxDesk.UseVisualStyleBackColor = true;
            this.checkBoxDesk.CheckedChanged += new System.EventHandler(this.checkBoxDesk_CheckedChanged);
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.AutoSize = true;
            this.checkBoxRoom.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRoom.Location = new System.Drawing.Point(9, 63);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(120, 30);
            this.checkBoxRoom.TabIndex = 2;
            this.checkBoxRoom.Text = "Clean Room";
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            this.checkBoxRoom.CheckedChanged += new System.EventHandler(this.checkBoxRoom_CheckedChanged);
            // 
            // labelBathroomCost
            // 
            this.labelBathroomCost.AutoSize = true;
            this.labelBathroomCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBathroomCost.Location = new System.Drawing.Point(311, 17);
            this.labelBathroomCost.Name = "labelBathroomCost";
            this.labelBathroomCost.Size = new System.Drawing.Size(57, 26);
            this.labelBathroomCost.TabIndex = 3;
            this.labelBathroomCost.Text = "$1.00";
            // 
            // labelDeskCost
            // 
            this.labelDeskCost.AutoSize = true;
            this.labelDeskCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskCost.Location = new System.Drawing.Point(311, 41);
            this.labelDeskCost.Name = "labelDeskCost";
            this.labelDeskCost.Size = new System.Drawing.Size(57, 26);
            this.labelDeskCost.TabIndex = 4;
            this.labelDeskCost.Text = "$0.50";
            // 
            // labelRoomCost
            // 
            this.labelRoomCost.AutoSize = true;
            this.labelRoomCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomCost.Location = new System.Drawing.Point(311, 66);
            this.labelRoomCost.Name = "labelRoomCost";
            this.labelRoomCost.Size = new System.Drawing.Size(57, 26);
            this.labelRoomCost.TabIndex = 5;
            this.labelRoomCost.Text = "$1.00";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(816, 490);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(111, 35);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Chores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tears";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelClothesCost);
            this.panel1.Controls.Add(this.labelLaundryCost);
            this.panel1.Controls.Add(this.labelIceCost);
            this.panel1.Controls.Add(this.labelDishwasherCost);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxClothes);
            this.panel1.Controls.Add(this.checkBoxLaundry);
            this.panel1.Controls.Add(this.checkBoxIceTrays);
            this.panel1.Controls.Add(this.checkBoxDishwasher);
            this.panel1.Controls.Add(this.checkBoxBathroom);
            this.panel1.Controls.Add(this.checkBoxDesk);
            this.panel1.Controls.Add(this.checkBoxRoom);
            this.panel1.Controls.Add(this.labelBathroomCost);
            this.panel1.Controls.Add(this.labelRoomCost);
            this.panel1.Controls.Add(this.labelDeskCost);
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 208);
            this.panel1.TabIndex = 9;
            // 
            // labelClothesCost
            // 
            this.labelClothesCost.AutoSize = true;
            this.labelClothesCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClothesCost.Location = new System.Drawing.Point(311, 166);
            this.labelClothesCost.Name = "labelClothesCost";
            this.labelClothesCost.Size = new System.Drawing.Size(57, 26);
            this.labelClothesCost.TabIndex = 20;
            this.labelClothesCost.Text = "$0.25";
            // 
            // labelLaundryCost
            // 
            this.labelLaundryCost.AutoSize = true;
            this.labelLaundryCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaundryCost.Location = new System.Drawing.Point(311, 142);
            this.labelLaundryCost.Name = "labelLaundryCost";
            this.labelLaundryCost.Size = new System.Drawing.Size(57, 26);
            this.labelLaundryCost.TabIndex = 19;
            this.labelLaundryCost.Text = "$1.25";
            // 
            // labelIceCost
            // 
            this.labelIceCost.AutoSize = true;
            this.labelIceCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIceCost.Location = new System.Drawing.Point(311, 116);
            this.labelIceCost.Name = "labelIceCost";
            this.labelIceCost.Size = new System.Drawing.Size(57, 26);
            this.labelIceCost.TabIndex = 18;
            this.labelIceCost.Text = "$0.25";
            // 
            // labelDishwasherCost
            // 
            this.labelDishwasherCost.AutoSize = true;
            this.labelDishwasherCost.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDishwasherCost.Location = new System.Drawing.Point(311, 89);
            this.labelDishwasherCost.Name = "labelDishwasherCost";
            this.labelDishwasherCost.Size = new System.Drawing.Size(57, 26);
            this.labelDishwasherCost.TabIndex = 17;
            this.labelDishwasherCost.Text = "$0.25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "(D)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "(D)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "(D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "(W)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "(W)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "(W)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "(W)";
            // 
            // checkBoxClothes
            // 
            this.checkBoxClothes.AutoSize = true;
            this.checkBoxClothes.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClothes.Location = new System.Drawing.Point(9, 162);
            this.checkBoxClothes.Name = "checkBoxClothes";
            this.checkBoxClothes.Size = new System.Drawing.Size(149, 30);
            this.checkBoxClothes.TabIndex = 9;
            this.checkBoxClothes.Text = "Pick Up Clothes";
            this.checkBoxClothes.UseVisualStyleBackColor = true;
            this.checkBoxClothes.CheckedChanged += new System.EventHandler(this.checkBoxClothes_CheckedChanged);
            // 
            // checkBoxLaundry
            // 
            this.checkBoxLaundry.AutoSize = true;
            this.checkBoxLaundry.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLaundry.Location = new System.Drawing.Point(9, 138);
            this.checkBoxLaundry.Name = "checkBoxLaundry";
            this.checkBoxLaundry.Size = new System.Drawing.Size(95, 30);
            this.checkBoxLaundry.TabIndex = 8;
            this.checkBoxLaundry.Text = "Laundry";
            this.checkBoxLaundry.UseVisualStyleBackColor = true;
            this.checkBoxLaundry.CheckedChanged += new System.EventHandler(this.checkBoxLaundry_CheckedChanged);
            // 
            // checkBoxIceTrays
            // 
            this.checkBoxIceTrays.AutoSize = true;
            this.checkBoxIceTrays.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIceTrays.Location = new System.Drawing.Point(9, 114);
            this.checkBoxIceTrays.Name = "checkBoxIceTrays";
            this.checkBoxIceTrays.Size = new System.Drawing.Size(100, 30);
            this.checkBoxIceTrays.TabIndex = 7;
            this.checkBoxIceTrays.Text = "Ice Trays";
            this.checkBoxIceTrays.UseVisualStyleBackColor = true;
            this.checkBoxIceTrays.CheckedChanged += new System.EventHandler(this.checkBoxIceTrays_CheckedChanged);
            // 
            // checkBoxDishwasher
            // 
            this.checkBoxDishwasher.AutoSize = true;
            this.checkBoxDishwasher.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDishwasher.Location = new System.Drawing.Point(9, 89);
            this.checkBoxDishwasher.Name = "checkBoxDishwasher";
            this.checkBoxDishwasher.Size = new System.Drawing.Size(172, 30);
            this.checkBoxDishwasher.TabIndex = 6;
            this.checkBoxDishwasher.Text = "Empty Dishwasher";
            this.checkBoxDishwasher.UseVisualStyleBackColor = true;
            this.checkBoxDishwasher.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonReview
            // 
            this.buttonReview.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReview.Location = new System.Drawing.Point(674, 490);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(111, 35);
            this.buttonReview.TabIndex = 10;
            this.buttonReview.Text = "Review";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(745, 556);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 35);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.checkBoxPoop);
            this.panel2.Controls.Add(this.checkBoxSweep);
            this.panel2.Controls.Add(this.checkBoxMop);
            this.panel2.Controls.Add(this.checkBoxDustLivingRoom);
            this.panel2.Controls.Add(this.checkBoxDustRoom);
            this.panel2.Controls.Add(this.checkBoxLoadDishwasher);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(3, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 200);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MadChoresMain.Properties.Resources.bonus__2_;
            this.pictureBox1.Location = new System.Drawing.Point(175, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 83);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "$1.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "$1.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "$1.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(87, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 26);
            this.label15.TabIndex = 15;
            this.label15.Text = "(D)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 26);
            this.label16.TabIndex = 14;
            this.label16.Text = "(W)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(120, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 26);
            this.label17.TabIndex = 13;
            this.label17.Text = "(W)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(164, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 26);
            this.label18.TabIndex = 12;
            this.label18.Text = "(D)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(120, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 26);
            this.label19.TabIndex = 11;
            this.label19.Text = "(W)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(164, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 26);
            this.label20.TabIndex = 10;
            this.label20.Text = "(W)";
            // 
            // checkBoxPoop
            // 
            this.checkBoxPoop.AutoSize = true;
            this.checkBoxPoop.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPoop.Location = new System.Drawing.Point(9, 138);
            this.checkBoxPoop.Name = "checkBoxPoop";
            this.checkBoxPoop.Size = new System.Drawing.Size(118, 30);
            this.checkBoxPoop.TabIndex = 8;
            this.checkBoxPoop.Text = "Scoop Poop";
            this.checkBoxPoop.UseVisualStyleBackColor = true;
            // 
            // checkBoxSweep
            // 
            this.checkBoxSweep.AutoSize = true;
            this.checkBoxSweep.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSweep.Location = new System.Drawing.Point(9, 114);
            this.checkBoxSweep.Name = "checkBoxSweep";
            this.checkBoxSweep.Size = new System.Drawing.Size(80, 30);
            this.checkBoxSweep.TabIndex = 7;
            this.checkBoxSweep.Text = "Sweep";
            this.checkBoxSweep.UseVisualStyleBackColor = true;
            // 
            // checkBoxMop
            // 
            this.checkBoxMop.AutoSize = true;
            this.checkBoxMop.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMop.Location = new System.Drawing.Point(9, 89);
            this.checkBoxMop.Name = "checkBoxMop";
            this.checkBoxMop.Size = new System.Drawing.Size(63, 30);
            this.checkBoxMop.TabIndex = 6;
            this.checkBoxMop.Text = "Mop";
            this.checkBoxMop.UseVisualStyleBackColor = true;
            // 
            // checkBoxDustLivingRoom
            // 
            this.checkBoxDustLivingRoom.AutoSize = true;
            this.checkBoxDustLivingRoom.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDustLivingRoom.Location = new System.Drawing.Point(9, 13);
            this.checkBoxDustLivingRoom.Name = "checkBoxDustLivingRoom";
            this.checkBoxDustLivingRoom.Size = new System.Drawing.Size(163, 30);
            this.checkBoxDustLivingRoom.TabIndex = 0;
            this.checkBoxDustLivingRoom.Text = "Dust Living Room";
            this.checkBoxDustLivingRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxDustRoom
            // 
            this.checkBoxDustRoom.AutoSize = true;
            this.checkBoxDustRoom.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDustRoom.Location = new System.Drawing.Point(9, 40);
            this.checkBoxDustRoom.Name = "checkBoxDustRoom";
            this.checkBoxDustRoom.Size = new System.Drawing.Size(113, 30);
            this.checkBoxDustRoom.TabIndex = 1;
            this.checkBoxDustRoom.Text = "Dust Room";
            this.checkBoxDustRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadDishwasher
            // 
            this.checkBoxLoadDishwasher.AutoSize = true;
            this.checkBoxLoadDishwasher.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoadDishwasher.Location = new System.Drawing.Point(9, 63);
            this.checkBoxLoadDishwasher.Name = "checkBoxLoadDishwasher";
            this.checkBoxLoadDishwasher.Size = new System.Drawing.Size(157, 30);
            this.checkBoxLoadDishwasher.TabIndex = 2;
            this.checkBoxLoadDishwasher.Text = "Load Dishwasher";
            this.checkBoxLoadDishwasher.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(311, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 26);
            this.label21.TabIndex = 3;
            this.label21.Text = "$1.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(311, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 26);
            this.label22.TabIndex = 5;
            this.label22.Text = "$1.00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(311, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 26);
            this.label23.TabIndex = 4;
            this.label23.Text = "$1.00";
            // 
            // textBoxFill1
            // 
            this.textBoxFill1.Location = new System.Drawing.Point(3, 521);
            this.textBoxFill1.Name = "textBoxFill1";
            this.textBoxFill1.Size = new System.Drawing.Size(285, 20);
            this.textBoxFill1.TabIndex = 13;
            // 
            // textBoxFillCost1
            // 
            this.textBoxFillCost1.Location = new System.Drawing.Point(312, 521);
            this.textBoxFillCost1.Name = "textBoxFillCost1";
            this.textBoxFillCost1.Size = new System.Drawing.Size(100, 20);
            this.textBoxFillCost1.TabIndex = 14;
            this.textBoxFillCost1.TextChanged += new System.EventHandler(this.textBoxFillCost1_TextChanged);
            // 
            // textBoxFill2
            // 
            this.textBoxFill2.Location = new System.Drawing.Point(3, 556);
            this.textBoxFill2.Name = "textBoxFill2";
            this.textBoxFill2.Size = new System.Drawing.Size(285, 20);
            this.textBoxFill2.TabIndex = 15;
            // 
            // textBoxFillCost2
            // 
            this.textBoxFillCost2.Location = new System.Drawing.Point(312, 556);
            this.textBoxFillCost2.Name = "textBoxFillCost2";
            this.textBoxFillCost2.Size = new System.Drawing.Size(100, 20);
            this.textBoxFillCost2.TabIndex = 16;
            // 
            // textBoxFill3
            // 
            this.textBoxFill3.Location = new System.Drawing.Point(3, 593);
            this.textBoxFill3.Name = "textBoxFill3";
            this.textBoxFill3.Size = new System.Drawing.Size(285, 20);
            this.textBoxFill3.TabIndex = 17;
            // 
            // textBoxFillCost3
            // 
            this.textBoxFillCost3.Location = new System.Drawing.Point(312, 593);
            this.textBoxFillCost3.Name = "textBoxFillCost3";
            this.textBoxFillCost3.Size = new System.Drawing.Size(100, 20);
            this.textBoxFillCost3.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Add Additional Chores:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(314, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Amount:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(294, 516);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 26);
            this.label24.TabIndex = 21;
            this.label24.Text = "$";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(294, 551);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 26);
            this.label25.TabIndex = 22;
            this.label25.Text = "$";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(294, 588);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 26);
            this.label26.TabIndex = 23;
            this.label26.Text = "$";
            // 
            // AddChoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MadChoresMain.Properties.Resources.clean_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(983, 634);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFillCost3);
            this.Controls.Add(this.textBoxFill3);
            this.Controls.Add(this.textBoxFillCost2);
            this.Controls.Add(this.textBoxFill2);
            this.Controls.Add(this.textBoxFillCost1);
            this.Controls.Add(this.textBoxFill1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddChoresForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChores";
            this.Load += new System.EventHandler(this.AddChoresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBathroom;
        private System.Windows.Forms.CheckBox checkBoxDesk;
        private System.Windows.Forms.CheckBox checkBoxRoom;
        private System.Windows.Forms.Label labelBathroomCost;
        private System.Windows.Forms.Label labelDeskCost;
        private System.Windows.Forms.Label labelRoomCost;
        private System.Windows.Forms.Button buttonSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDishwasher;
        private System.Windows.Forms.CheckBox checkBoxIceTrays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxClothes;
        private System.Windows.Forms.CheckBox checkBoxLaundry;
        private System.Windows.Forms.Label labelClothesCost;
        private System.Windows.Forms.Label labelLaundryCost;
        private System.Windows.Forms.Label labelIceCost;
        private System.Windows.Forms.Label labelDishwasherCost;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBoxPoop;
        private System.Windows.Forms.CheckBox checkBoxSweep;
        private System.Windows.Forms.CheckBox checkBoxMop;
        private System.Windows.Forms.CheckBox checkBoxDustLivingRoom;
        private System.Windows.Forms.CheckBox checkBoxDustRoom;
        private System.Windows.Forms.CheckBox checkBoxLoadDishwasher;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxFill1;
        private System.Windows.Forms.TextBox textBoxFillCost1;
        private System.Windows.Forms.TextBox textBoxFill2;
        private System.Windows.Forms.TextBox textBoxFillCost2;
        private System.Windows.Forms.TextBox textBoxFill3;
        private System.Windows.Forms.TextBox textBoxFillCost3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}