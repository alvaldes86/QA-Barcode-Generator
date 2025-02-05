namespace QA_Barcode_Generator
{
    partial class GS1Coupon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GS1Coupon));
            lblSelectedButton = new Label();
            btnCreateGs1 = new Button();
            groupBox5 = new GroupBox();
            label11 = new Label();
            tbxPrimaryPurchaseReq = new TextBox();
            tbxSaveValue = new TextBox();
            tbxPrimaryPurchaseFamilyCode = new TextBox();
            tbxOfferCode = new TextBox();
            tbxApplicationIdentifier = new TextBox();
            cbxPrimaryPurchaseReqCode = new ComboBox();
            tbxGS1CompanyPrefix = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblPurchaseRuleCode = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label10 = new Label();
            pictureboxgs1 = new PictureBox();
            groupBox6 = new GroupBox();
            label8 = new Label();
            heightSelectorCode128 = new NumericUpDown();
            label9 = new Label();
            widthSelectorCode128 = new NumericUpDown();
            label12 = new Label();
            tbxCouponDescription = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            tbxGS1Output = new TextBox();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxgs1).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorCode128).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorCode128).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedButton
            // 
            lblSelectedButton.AutoSize = true;
            lblSelectedButton.BackColor = Color.FromArgb(52, 52, 52);
            lblSelectedButton.Font = new Font("Segoe UI", 16.2F);
            lblSelectedButton.ForeColor = Color.White;
            lblSelectedButton.ImeMode = ImeMode.NoControl;
            lblSelectedButton.Location = new Point(23, 22);
            lblSelectedButton.Name = "lblSelectedButton";
            lblSelectedButton.Size = new Size(289, 38);
            lblSelectedButton.TabIndex = 87;
            lblSelectedButton.Text = "Manufacturer Coupon";
            // 
            // btnCreateGs1
            // 
            btnCreateGs1.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateGs1.FlatAppearance.BorderSize = 0;
            btnCreateGs1.FlatStyle = FlatStyle.Flat;
            btnCreateGs1.ForeColor = Color.White;
            btnCreateGs1.ImeMode = ImeMode.NoControl;
            btnCreateGs1.Location = new Point(23, 305);
            btnCreateGs1.Name = "btnCreateGs1";
            btnCreateGs1.Size = new Size(90, 64);
            btnCreateGs1.TabIndex = 97;
            btnCreateGs1.Text = "Create Barcode";
            btnCreateGs1.UseVisualStyleBackColor = false;
            btnCreateGs1.Click += btnCreateGs1_Click_1;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(64, 64, 64);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(tbxPrimaryPurchaseReq);
            groupBox5.Controls.Add(tbxSaveValue);
            groupBox5.Controls.Add(tbxPrimaryPurchaseFamilyCode);
            groupBox5.Controls.Add(tbxOfferCode);
            groupBox5.Controls.Add(tbxApplicationIdentifier);
            groupBox5.Controls.Add(cbxPrimaryPurchaseReqCode);
            groupBox5.Controls.Add(tbxGS1CompanyPrefix);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label1);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 10.2F);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(630, 302);
            groupBox5.TabIndex = 101;
            groupBox5.TabStop = false;
            groupBox5.Text = "Required Fields ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(88, 72);
            label11.Name = "label11";
            label11.Size = new Size(165, 23);
            label11.TabIndex = 105;
            label11.Text = "GS1 Company Prefix";
            // 
            // tbxPrimaryPurchaseReq
            // 
            tbxPrimaryPurchaseReq.AllowDrop = true;
            tbxPrimaryPurchaseReq.BackColor = Color.FromArgb(64, 64, 64);
            tbxPrimaryPurchaseReq.BorderStyle = BorderStyle.FixedSingle;
            tbxPrimaryPurchaseReq.Font = new Font("Segoe UI", 10.2F);
            tbxPrimaryPurchaseReq.ForeColor = Color.White;
            tbxPrimaryPurchaseReq.Location = new Point(278, 180);
            tbxPrimaryPurchaseReq.Name = "tbxPrimaryPurchaseReq";
            tbxPrimaryPurchaseReq.PlaceholderText = "Number of items require for the coupon";
            tbxPrimaryPurchaseReq.Size = new Size(346, 30);
            tbxPrimaryPurchaseReq.TabIndex = 22;
            // 
            // tbxSaveValue
            // 
            tbxSaveValue.AllowDrop = true;
            tbxSaveValue.BackColor = Color.FromArgb(64, 64, 64);
            tbxSaveValue.BorderStyle = BorderStyle.FixedSingle;
            tbxSaveValue.Font = new Font("Segoe UI", 10.2F);
            tbxSaveValue.ForeColor = Color.White;
            tbxSaveValue.Location = new Point(278, 144);
            tbxSaveValue.Name = "tbxSaveValue";
            tbxSaveValue.PlaceholderText = "Type coupon save value e.g 100 = $1";
            tbxSaveValue.Size = new Size(346, 30);
            tbxSaveValue.TabIndex = 21;
            // 
            // tbxPrimaryPurchaseFamilyCode
            // 
            tbxPrimaryPurchaseFamilyCode.AllowDrop = true;
            tbxPrimaryPurchaseFamilyCode.BackColor = Color.Gray;
            tbxPrimaryPurchaseFamilyCode.BorderStyle = BorderStyle.FixedSingle;
            tbxPrimaryPurchaseFamilyCode.Font = new Font("Segoe UI", 10.2F);
            tbxPrimaryPurchaseFamilyCode.ForeColor = Color.White;
            tbxPrimaryPurchaseFamilyCode.Location = new Point(276, 255);
            tbxPrimaryPurchaseFamilyCode.Margin = new Padding(9, 3, 3, 3);
            tbxPrimaryPurchaseFamilyCode.Name = "tbxPrimaryPurchaseFamilyCode";
            tbxPrimaryPurchaseFamilyCode.ReadOnly = true;
            tbxPrimaryPurchaseFamilyCode.Size = new Size(346, 30);
            tbxPrimaryPurchaseFamilyCode.TabIndex = 104;
            tbxPrimaryPurchaseFamilyCode.Text = "222";
            // 
            // tbxOfferCode
            // 
            tbxOfferCode.AllowDrop = true;
            tbxOfferCode.BackColor = Color.Gray;
            tbxOfferCode.BorderStyle = BorderStyle.FixedSingle;
            tbxOfferCode.Font = new Font("Segoe UI", 10.2F);
            tbxOfferCode.ForeColor = Color.White;
            tbxOfferCode.Location = new Point(275, 108);
            tbxOfferCode.Margin = new Padding(9, 3, 3, 3);
            tbxOfferCode.Name = "tbxOfferCode";
            tbxOfferCode.ReadOnly = true;
            tbxOfferCode.Size = new Size(346, 30);
            tbxOfferCode.TabIndex = 104;
            tbxOfferCode.Text = "654321";
            // 
            // tbxApplicationIdentifier
            // 
            tbxApplicationIdentifier.AllowDrop = true;
            tbxApplicationIdentifier.BackColor = Color.Gray;
            tbxApplicationIdentifier.BorderStyle = BorderStyle.FixedSingle;
            tbxApplicationIdentifier.Font = new Font("Segoe UI", 10.2F);
            tbxApplicationIdentifier.ForeColor = Color.White;
            tbxApplicationIdentifier.Location = new Point(275, 34);
            tbxApplicationIdentifier.Margin = new Padding(9, 3, 3, 3);
            tbxApplicationIdentifier.Name = "tbxApplicationIdentifier";
            tbxApplicationIdentifier.ReadOnly = true;
            tbxApplicationIdentifier.Size = new Size(346, 30);
            tbxApplicationIdentifier.TabIndex = 103;
            tbxApplicationIdentifier.Text = "(8110)";
            // 
            // cbxPrimaryPurchaseReqCode
            // 
            cbxPrimaryPurchaseReqCode.BackColor = Color.FromArgb(64, 64, 64);
            cbxPrimaryPurchaseReqCode.FlatStyle = FlatStyle.Flat;
            cbxPrimaryPurchaseReqCode.ForeColor = Color.White;
            cbxPrimaryPurchaseReqCode.FormattingEnabled = true;
            cbxPrimaryPurchaseReqCode.Items.AddRange(new object[] { "Number of units", "Value of qualifiying items", "Value of total transaction", "Number of pounds", "Number of kilograms", "Cashier intervention required " });
            cbxPrimaryPurchaseReqCode.Location = new Point(275, 217);
            cbxPrimaryPurchaseReqCode.Margin = new Padding(0);
            cbxPrimaryPurchaseReqCode.Name = "cbxPrimaryPurchaseReqCode";
            cbxPrimaryPurchaseReqCode.Size = new Size(346, 31);
            cbxPrimaryPurchaseReqCode.TabIndex = 12;
            cbxPrimaryPurchaseReqCode.Text = "Choose one:";
            // 
            // tbxGS1CompanyPrefix
            // 
            tbxGS1CompanyPrefix.AllowDrop = true;
            tbxGS1CompanyPrefix.BackColor = Color.FromArgb(64, 64, 64);
            tbxGS1CompanyPrefix.BorderStyle = BorderStyle.FixedSingle;
            tbxGS1CompanyPrefix.Font = new Font("Segoe UI", 10.2F);
            tbxGS1CompanyPrefix.ForeColor = Color.White;
            tbxGS1CompanyPrefix.Location = new Point(275, 70);
            tbxGS1CompanyPrefix.Name = "tbxGS1CompanyPrefix";
            tbxGS1CompanyPrefix.PlaceholderText = "Type first 5 digits of the item e.g. 41415";
            tbxGS1CompanyPrefix.Size = new Size(346, 30);
            tbxGS1CompanyPrefix.TabIndex = 20;
            tbxGS1CompanyPrefix.KeyPress += tbxGS1CompanyPrefix_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 257);
            label7.Name = "label7";
            label7.Size = new Size(239, 23);
            label7.TabIndex = 19;
            label7.Text = "Primary Purchase Family Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 220);
            label6.Name = "label6";
            label6.Size = new Size(225, 23);
            label6.TabIndex = 18;
            label6.Text = "Primary Purchase Req. Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 182);
            label5.Name = "label5";
            label5.Size = new Size(252, 23);
            label5.TabIndex = 17;
            label5.Text = "Primary Purchase Requirements";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 146);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 16;
            label4.Text = "Save Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 110);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 15;
            label3.Text = "Offer Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 36);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 12;
            label1.Text = "Application Identifier";
            // 
            // lblPurchaseRuleCode
            // 
            lblPurchaseRuleCode.AutoSize = true;
            lblPurchaseRuleCode.Location = new Point(57, 40);
            lblPurchaseRuleCode.Name = "lblPurchaseRuleCode";
            lblPurchaseRuleCode.Size = new Size(205, 23);
            lblPurchaseRuleCode.TabIndex = 14;
            lblPurchaseRuleCode.Text = "Add Purchase Rules Code";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox5);
            panel1.Location = new Point(479, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 671);
            panel1.TabIndex = 102;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(64, 64, 64);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.2F);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 778);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(630, 238);
            groupBox4.TabIndex = 105;
            groupBox4.TabStop = false;
            groupBox4.Text = "Item description";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(64, 64, 64);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.2F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 1032);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(630, 175);
            groupBox3.TabIndex = 104;
            groupBox3.TabStop = false;
            groupBox3.Text = "Item description";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(lblPurchaseRuleCode);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 214);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Field 1 (Optional)";
            // 
            // textBox6
            // 
            textBox6.AllowDrop = true;
            textBox6.BackColor = Color.FromArgb(64, 64, 64);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 10.2F);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(275, 143);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Choose one:";
            textBox6.Size = new Size(346, 30);
            textBox6.TabIndex = 30;
            // 
            // textBox5
            // 
            textBox5.AllowDrop = true;
            textBox5.BackColor = Color.FromArgb(64, 64, 64);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 10.2F);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(275, 105);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Choose one:";
            textBox5.Size = new Size(346, 30);
            textBox5.TabIndex = 29;
            // 
            // textBox4
            // 
            textBox4.AllowDrop = true;
            textBox4.BackColor = Color.FromArgb(64, 64, 64);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10.2F);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(275, 69);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Choose one:";
            textBox4.Size = new Size(346, 30);
            textBox4.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(97, 143);
            label15.Name = "label15";
            label15.Size = new Size(165, 23);
            label15.TabIndex = 26;
            label15.Text = "GS1 Company Prefix";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(97, 107);
            label14.Name = "label14";
            label14.Size = new Size(165, 23);
            label14.TabIndex = 24;
            label14.Text = "GS1 Company Prefix";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(97, 71);
            label13.Name = "label13";
            label13.Size = new Size(165, 23);
            label13.TabIndex = 22;
            label13.Text = "GS1 Company Prefix";
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.BackColor = Color.FromArgb(64, 64, 64);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(275, 33);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Choose one:";
            textBox3.Size = new Size(346, 30);
            textBox3.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 554);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 85);
            groupBox1.TabIndex = 102;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Field 3 (Optional)";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.2F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(275, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 30);
            textBox1.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 33);
            label10.Name = "label10";
            label10.Size = new Size(214, 23);
            label10.TabIndex = 13;
            label10.Text = "Expiration Date (YYMMDD)";
            // 
            // pictureboxgs1
            // 
            pictureboxgs1.BackColor = Color.FromArgb(64, 64, 64);
            pictureboxgs1.Image = (Image)resources.GetObject("pictureboxgs1.Image");
            pictureboxgs1.ImeMode = ImeMode.NoControl;
            pictureboxgs1.InitialImage = null;
            pictureboxgs1.Location = new Point(23, 149);
            pictureboxgs1.Name = "pictureboxgs1";
            pictureboxgs1.Size = new Size(439, 92);
            pictureboxgs1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxgs1.TabIndex = 103;
            pictureboxgs1.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(64, 64, 64);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(heightSelectorCode128);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(widthSelectorCode128);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Segoe UI", 10.2F);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(366, 305);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(96, 176);
            groupBox6.TabIndex = 104;
            groupBox6.TabStop = false;
            groupBox6.Text = "Format";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.White;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(29, 94);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 27;
            label8.Text = "Height";
            // 
            // heightSelectorCode128
            // 
            heightSelectorCode128.Font = new Font("Segoe UI", 9F);
            heightSelectorCode128.Location = new Point(29, 121);
            heightSelectorCode128.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightSelectorCode128.Name = "heightSelectorCode128";
            heightSelectorCode128.Size = new Size(55, 27);
            heightSelectorCode128.TabIndex = 25;
            heightSelectorCode128.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(29, 26);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 26;
            label9.Text = "Width";
            // 
            // widthSelectorCode128
            // 
            widthSelectorCode128.Font = new Font("Segoe UI", 9F);
            widthSelectorCode128.Location = new Point(29, 54);
            widthSelectorCode128.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelectorCode128.Name = "widthSelectorCode128";
            widthSelectorCode128.Size = new Size(58, 27);
            widthSelectorCode128.TabIndex = 24;
            widthSelectorCode128.Value = new decimal(new int[] { 350, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(23, 70);
            label12.Name = "label12";
            label12.Size = new Size(216, 25);
            label12.TabIndex = 105;
            label12.Text = "Enter Coupon Description";
            // 
            // tbxCouponDescription
            // 
            tbxCouponDescription.AllowDrop = true;
            tbxCouponDescription.BackColor = Color.FromArgb(64, 64, 64);
            tbxCouponDescription.BorderStyle = BorderStyle.FixedSingle;
            tbxCouponDescription.Font = new Font("Segoe UI", 10.2F);
            tbxCouponDescription.ForeColor = Color.White;
            tbxCouponDescription.Location = new Point(23, 100);
            tbxCouponDescription.Name = "tbxCouponDescription";
            tbxCouponDescription.PlaceholderText = "Publix items $5 off";
            tbxCouponDescription.Size = new Size(439, 30);
            tbxCouponDescription.TabIndex = 106;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(257, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 64);
            btnClear.TabIndex = 107;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.ImeMode = ImeMode.NoControl;
            btnSave.Location = new Point(138, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 64);
            btnSave.TabIndex = 108;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbxGS1Output
            // 
            tbxGS1Output.AllowDrop = true;
            tbxGS1Output.BackColor = Color.FromArgb(64, 64, 64);
            tbxGS1Output.BorderStyle = BorderStyle.FixedSingle;
            tbxGS1Output.Font = new Font("Segoe UI", 10.2F);
            tbxGS1Output.ForeColor = Color.White;
            tbxGS1Output.Location = new Point(23, 256);
            tbxGS1Output.Name = "tbxGS1Output";
            tbxGS1Output.ReadOnly = true;
            tbxGS1Output.Size = new Size(439, 30);
            tbxGS1Output.TabIndex = 109;
            // 
            // GS1Coupon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(tbxGS1Output);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(tbxCouponDescription);
            Controls.Add(label12);
            Controls.Add(groupBox6);
            Controls.Add(pictureboxgs1);
            Controls.Add(panel1);
            Controls.Add(btnCreateGs1);
            Controls.Add(lblSelectedButton);
            Name = "GS1Coupon";
            Size = new Size(1160, 692);
            Load += GS1Coupon_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxgs1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorCode128).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorCode128).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblSelectedButton;
        private Button btnCreateGs1;
        private GroupBox groupBox5;
        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblPurchaseRuleCode;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbxGS1CompanyPrefix;
        private ComboBox cbxPrimaryPurchaseReqCode;
        private TextBox tbxOfferCode;
        private TextBox tbxPrimaryPurchaseFamilyCode;
        private TextBox tbxSaveValue;
        private TextBox tbxPrimaryPurchaseReq;
        private PictureBox pictureboxgs1;
        public TextBox tbxApplicationIdentifier;
        private GroupBox groupBox6;
        private Label label8;
        public NumericUpDown heightSelectorCode128;
        private Label label9;
        public NumericUpDown widthSelectorCode128;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbxCouponDescription;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox textBox3;
        private Button btnClear;
        private Button btnSave;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox tbxGS1Output;
    }
}
