namespace QA_Barcode_Generator
{
    partial class ErcUpca
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
            groupBox6 = new GroupBox();
            label6 = new Label();
            heightSelectorCode128 = new NumericUpDown();
            label7 = new Label();
            widthSelectorCode128 = new NumericUpDown();
            groupBox2 = new GroupBox();
            label1 = new Label();
            heightSelectorUpca = new NumericUpDown();
            label4 = new Label();
            widthSelectorUpca = new NumericUpDown();
            btnCodeSave = new Button();
            btnCode128Clear = new Button();
            btnCode128CreateBarcode = new Button();
            btnUpcaSave = new Button();
            btnUpcaClear = new Button();
            btnUpcaCreateBarcode = new Button();
            label5 = new Label();
            groupBox4 = new GroupBox();
            tbxGtinsCode128 = new TextBox();
            groupBox5 = new GroupBox();
            tbxCode128Description = new TextBox();
            btnPreviousCode128 = new Button();
            btnNextCode128 = new Button();
            pictureBoxCode128 = new PictureBox();
            lblSelectedButton = new Label();
            groupBox3 = new GroupBox();
            tbxUpcaGtinsInput = new TextBox();
            groupBox1 = new GroupBox();
            tbxUpcaDescription = new TextBox();
            btnPreviousUpca = new Button();
            btnNextUpca = new Button();
            pictureBoxUpca = new PictureBox();
            saveFile = new SaveFileDialog();
            lblCountDescription = new Label();
            lblCountGtins = new Label();
            lblCountCode128Gtins = new Label();
            lblCountCode128Description = new Label();
            lblItemName = new Label();
            btnUpcaSaveToWord = new Button();
            btnCode128SaveToWord = new Button();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorCode128).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorCode128).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorUpca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorUpca).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCode128).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpca).BeginInit();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(64, 64, 64);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(heightSelectorCode128);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(widthSelectorCode128);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Segoe UI", 10.2F);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(1007, 309);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(97, 197);
            groupBox6.TabIndex = 76;
            groupBox6.TabStop = false;
            groupBox6.Text = "Format";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.White;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(21, 124);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 27;
            label6.Text = "Height";
            // 
            // heightSelectorCode128
            // 
            heightSelectorCode128.Font = new Font("Segoe UI", 9F);
            heightSelectorCode128.Location = new Point(21, 151);
            heightSelectorCode128.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightSelectorCode128.Name = "heightSelectorCode128";
            heightSelectorCode128.Size = new Size(55, 27);
            heightSelectorCode128.TabIndex = 25;
            heightSelectorCode128.Value = new decimal(new int[] { 150, 0, 0, 0 });
            heightSelectorCode128.ValueChanged += heightSelectorCode128_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.White;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(21, 39);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 26;
            label7.Text = "Width";
            // 
            // widthSelectorCode128
            // 
            widthSelectorCode128.Font = new Font("Segoe UI", 9F);
            widthSelectorCode128.Location = new Point(21, 67);
            widthSelectorCode128.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelectorCode128.Name = "widthSelectorCode128";
            widthSelectorCode128.Size = new Size(58, 27);
            widthSelectorCode128.TabIndex = 24;
            widthSelectorCode128.Value = new decimal(new int[] { 360, 0, 0, 0 });
            widthSelectorCode128.ValueChanged += widthSelectorCode128_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(heightSelectorUpca);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(widthSelectorUpca);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(419, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(97, 197);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Format";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(21, 124);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 27;
            label1.Text = "Height";
            // 
            // heightSelectorUpca
            // 
            heightSelectorUpca.Font = new Font("Segoe UI", 9F);
            heightSelectorUpca.Location = new Point(21, 151);
            heightSelectorUpca.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightSelectorUpca.Name = "heightSelectorUpca";
            heightSelectorUpca.Size = new Size(55, 27);
            heightSelectorUpca.TabIndex = 25;
            heightSelectorUpca.Value = new decimal(new int[] { 150, 0, 0, 0 });
            heightSelectorUpca.ValueChanged += heightSelectorUpca_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(21, 39);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 26;
            label4.Text = "Width";
            // 
            // widthSelectorUpca
            // 
            widthSelectorUpca.Font = new Font("Segoe UI", 9F);
            widthSelectorUpca.Location = new Point(21, 67);
            widthSelectorUpca.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelectorUpca.Name = "widthSelectorUpca";
            widthSelectorUpca.Size = new Size(58, 27);
            widthSelectorUpca.TabIndex = 24;
            widthSelectorUpca.Value = new decimal(new int[] { 285, 0, 0, 0 });
            widthSelectorUpca.ValueChanged += widthSelectorUpca_ValueChanged;
            // 
            // btnCodeSave
            // 
            btnCodeSave.BackColor = Color.FromArgb(64, 64, 64);
            btnCodeSave.FlatAppearance.BorderSize = 0;
            btnCodeSave.FlatStyle = FlatStyle.Flat;
            btnCodeSave.ForeColor = Color.White;
            btnCodeSave.ImeMode = ImeMode.NoControl;
            btnCodeSave.Location = new Point(687, 573);
            btnCodeSave.Name = "btnCodeSave";
            btnCodeSave.Size = new Size(90, 64);
            btnCodeSave.TabIndex = 74;
            btnCodeSave.Text = "Save";
            btnCodeSave.UseVisualStyleBackColor = false;
            btnCodeSave.Click += btnCodeSave_Click;
            // 
            // btnCode128Clear
            // 
            btnCode128Clear.BackColor = Color.FromArgb(64, 64, 64);
            btnCode128Clear.FlatAppearance.BorderSize = 0;
            btnCode128Clear.FlatStyle = FlatStyle.Flat;
            btnCode128Clear.ForeColor = Color.White;
            btnCode128Clear.ImeMode = ImeMode.NoControl;
            btnCode128Clear.Location = new Point(1012, 573);
            btnCode128Clear.Name = "btnCode128Clear";
            btnCode128Clear.Size = new Size(90, 64);
            btnCode128Clear.TabIndex = 73;
            btnCode128Clear.Text = "Clear";
            btnCode128Clear.UseVisualStyleBackColor = false;
            btnCode128Clear.Click += btnCode128Clear_Click;
            // 
            // btnCode128CreateBarcode
            // 
            btnCode128CreateBarcode.BackColor = Color.FromArgb(64, 64, 64);
            btnCode128CreateBarcode.FlatAppearance.BorderSize = 0;
            btnCode128CreateBarcode.FlatStyle = FlatStyle.Flat;
            btnCode128CreateBarcode.ForeColor = Color.White;
            btnCode128CreateBarcode.ImeMode = ImeMode.NoControl;
            btnCode128CreateBarcode.Location = new Point(581, 573);
            btnCode128CreateBarcode.Name = "btnCode128CreateBarcode";
            btnCode128CreateBarcode.Size = new Size(90, 64);
            btnCode128CreateBarcode.TabIndex = 72;
            btnCode128CreateBarcode.Text = "Create Barcode";
            btnCode128CreateBarcode.UseVisualStyleBackColor = false;
            btnCode128CreateBarcode.Click += btnCode128CreateBarcode_Click;
            // 
            // btnUpcaSave
            // 
            btnUpcaSave.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaSave.FlatAppearance.BorderSize = 0;
            btnUpcaSave.FlatStyle = FlatStyle.Flat;
            btnUpcaSave.ForeColor = Color.White;
            btnUpcaSave.ImeMode = ImeMode.NoControl;
            btnUpcaSave.Location = new Point(155, 573);
            btnUpcaSave.Name = "btnUpcaSave";
            btnUpcaSave.Size = new Size(90, 64);
            btnUpcaSave.TabIndex = 59;
            btnUpcaSave.Text = "Save";
            btnUpcaSave.UseVisualStyleBackColor = false;
            btnUpcaSave.Click += btnUpcaSave_Click;
            // 
            // btnUpcaClear
            // 
            btnUpcaClear.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaClear.FlatAppearance.BorderSize = 0;
            btnUpcaClear.FlatStyle = FlatStyle.Flat;
            btnUpcaClear.ForeColor = Color.White;
            btnUpcaClear.ImeMode = ImeMode.NoControl;
            btnUpcaClear.Location = new Point(419, 573);
            btnUpcaClear.Name = "btnUpcaClear";
            btnUpcaClear.Size = new Size(90, 64);
            btnUpcaClear.TabIndex = 58;
            btnUpcaClear.Text = "Clear";
            btnUpcaClear.UseVisualStyleBackColor = false;
            btnUpcaClear.Click += btnUpcaClear_Click;
            // 
            // btnUpcaCreateBarcode
            // 
            btnUpcaCreateBarcode.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaCreateBarcode.FlatAppearance.BorderSize = 0;
            btnUpcaCreateBarcode.FlatStyle = FlatStyle.Flat;
            btnUpcaCreateBarcode.ForeColor = Color.White;
            btnUpcaCreateBarcode.ImeMode = ImeMode.NoControl;
            btnUpcaCreateBarcode.Location = new Point(49, 573);
            btnUpcaCreateBarcode.Name = "btnUpcaCreateBarcode";
            btnUpcaCreateBarcode.Size = new Size(90, 64);
            btnUpcaCreateBarcode.TabIndex = 57;
            btnUpcaCreateBarcode.Text = "Create Barcode";
            btnUpcaCreateBarcode.UseVisualStyleBackColor = false;
            btnUpcaCreateBarcode.Click += btnUpcaCreateBarcode_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(52, 52, 52);
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.ForeColor = Color.White;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(581, 24);
            label5.Name = "label5";
            label5.Size = new Size(282, 38);
            label5.TabIndex = 71;
            label5.Text = "Electronic Rain Check";
            label5.Click += label5_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(64, 64, 64);
            groupBox4.Controls.Add(tbxGtinsCode128);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.2F);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(856, 95);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(246, 173);
            groupBox4.TabIndex = 70;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gtin List";
            // 
            // tbxGtinsCode128
            // 
            tbxGtinsCode128.AllowDrop = true;
            tbxGtinsCode128.BackColor = Color.FromArgb(64, 64, 64);
            tbxGtinsCode128.BorderStyle = BorderStyle.None;
            tbxGtinsCode128.Font = new Font("Segoe UI", 10.2F);
            tbxGtinsCode128.ForeColor = Color.White;
            tbxGtinsCode128.Location = new Point(6, 21);
            tbxGtinsCode128.Multiline = true;
            tbxGtinsCode128.Name = "tbxGtinsCode128";
            tbxGtinsCode128.Size = new Size(233, 147);
            tbxGtinsCode128.TabIndex = 10;
            tbxGtinsCode128.TextChanged += tbxGtinsCode128_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(64, 64, 64);
            groupBox5.Controls.Add(tbxCode128Description);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 10.2F);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(581, 95);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(246, 173);
            groupBox5.TabIndex = 69;
            groupBox5.TabStop = false;
            groupBox5.Text = "Item description";
            // 
            // tbxCode128Description
            // 
            tbxCode128Description.AllowDrop = true;
            tbxCode128Description.BackColor = Color.FromArgb(64, 64, 64);
            tbxCode128Description.BorderStyle = BorderStyle.None;
            tbxCode128Description.Font = new Font("Segoe UI", 10.2F);
            tbxCode128Description.ForeColor = Color.White;
            tbxCode128Description.Location = new Point(6, 21);
            tbxCode128Description.Multiline = true;
            tbxCode128Description.Name = "tbxCode128Description";
            tbxCode128Description.Size = new Size(234, 147);
            tbxCode128Description.TabIndex = 11;
            tbxCode128Description.TextChanged += tbxCode128Description_TextChanged;
            // 
            // btnPreviousCode128
            // 
            btnPreviousCode128.BackColor = Color.FromArgb(64, 64, 64);
            btnPreviousCode128.FlatAppearance.BorderSize = 0;
            btnPreviousCode128.FlatStyle = FlatStyle.Flat;
            btnPreviousCode128.Font = new Font("Segoe UI", 18F);
            btnPreviousCode128.ForeColor = Color.White;
            btnPreviousCode128.ImeMode = ImeMode.NoControl;
            btnPreviousCode128.Location = new Point(581, 360);
            btnPreviousCode128.Name = "btnPreviousCode128";
            btnPreviousCode128.Size = new Size(23, 95);
            btnPreviousCode128.TabIndex = 68;
            btnPreviousCode128.Text = "<";
            btnPreviousCode128.UseVisualStyleBackColor = false;
            btnPreviousCode128.Click += btnPreviousCode128_Click;
            // 
            // btnNextCode128
            // 
            btnNextCode128.BackColor = Color.FromArgb(64, 64, 64);
            btnNextCode128.FlatAppearance.BorderSize = 0;
            btnNextCode128.FlatStyle = FlatStyle.Flat;
            btnNextCode128.Font = new Font("Segoe UI", 18F);
            btnNextCode128.ForeColor = Color.White;
            btnNextCode128.ImeMode = ImeMode.NoControl;
            btnNextCode128.Location = new Point(955, 360);
            btnNextCode128.Name = "btnNextCode128";
            btnNextCode128.Size = new Size(24, 95);
            btnNextCode128.TabIndex = 67;
            btnNextCode128.Text = ">";
            btnNextCode128.UseVisualStyleBackColor = false;
            btnNextCode128.Click += btnNextCode128_Click;
            // 
            // pictureBoxCode128
            // 
            pictureBoxCode128.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxCode128.ImeMode = ImeMode.NoControl;
            pictureBoxCode128.Location = new Point(581, 309);
            pictureBoxCode128.Name = "pictureBoxCode128";
            pictureBoxCode128.Size = new Size(398, 197);
            pictureBoxCode128.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCode128.TabIndex = 66;
            pictureBoxCode128.TabStop = false;
            // 
            // lblSelectedButton
            // 
            lblSelectedButton.AutoSize = true;
            lblSelectedButton.BackColor = Color.FromArgb(52, 52, 52);
            lblSelectedButton.Font = new Font("Segoe UI", 16.2F);
            lblSelectedButton.ForeColor = Color.White;
            lblSelectedButton.ImeMode = ImeMode.NoControl;
            lblSelectedButton.Location = new Point(49, 24);
            lblSelectedButton.Name = "lblSelectedButton";
            lblSelectedButton.Size = new Size(99, 38);
            lblSelectedButton.TabIndex = 61;
            lblSelectedButton.Text = "UPC_A";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(64, 64, 64);
            groupBox3.Controls.Add(tbxUpcaGtinsInput);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.2F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(301, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 173);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gtin List";
            // 
            // tbxUpcaGtinsInput
            // 
            tbxUpcaGtinsInput.AllowDrop = true;
            tbxUpcaGtinsInput.BackColor = Color.FromArgb(64, 64, 64);
            tbxUpcaGtinsInput.BorderStyle = BorderStyle.None;
            tbxUpcaGtinsInput.Font = new Font("Segoe UI", 10.2F);
            tbxUpcaGtinsInput.ForeColor = Color.White;
            tbxUpcaGtinsInput.Location = new Point(6, 21);
            tbxUpcaGtinsInput.Multiline = true;
            tbxUpcaGtinsInput.Name = "tbxUpcaGtinsInput";
            tbxUpcaGtinsInput.Size = new Size(205, 147);
            tbxUpcaGtinsInput.TabIndex = 10;
            tbxUpcaGtinsInput.TextChanged += tbxUpcaGtinsInput_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(tbxUpcaDescription);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(49, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 173);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item description";
            // 
            // tbxUpcaDescription
            // 
            tbxUpcaDescription.AllowDrop = true;
            tbxUpcaDescription.BackColor = Color.FromArgb(64, 64, 64);
            tbxUpcaDescription.BorderStyle = BorderStyle.None;
            tbxUpcaDescription.Font = new Font("Segoe UI", 10.2F);
            tbxUpcaDescription.ForeColor = Color.White;
            tbxUpcaDescription.Location = new Point(5, 21);
            tbxUpcaDescription.Multiline = true;
            tbxUpcaDescription.Name = "tbxUpcaDescription";
            tbxUpcaDescription.Size = new Size(205, 141);
            tbxUpcaDescription.TabIndex = 11;
            tbxUpcaDescription.TextChanged += tbxUpcaDescription_TextChanged;
            // 
            // btnPreviousUpca
            // 
            btnPreviousUpca.BackColor = Color.FromArgb(64, 64, 64);
            btnPreviousUpca.FlatAppearance.BorderSize = 0;
            btnPreviousUpca.FlatStyle = FlatStyle.Flat;
            btnPreviousUpca.Font = new Font("Segoe UI", 18F);
            btnPreviousUpca.ForeColor = Color.White;
            btnPreviousUpca.ImeMode = ImeMode.NoControl;
            btnPreviousUpca.Location = new Point(54, 360);
            btnPreviousUpca.Name = "btnPreviousUpca";
            btnPreviousUpca.Size = new Size(23, 95);
            btnPreviousUpca.TabIndex = 63;
            btnPreviousUpca.Text = "<";
            btnPreviousUpca.UseVisualStyleBackColor = false;
            btnPreviousUpca.Click += btnPrevious_Click;
            // 
            // btnNextUpca
            // 
            btnNextUpca.BackColor = Color.FromArgb(64, 64, 64);
            btnNextUpca.FlatAppearance.BorderSize = 0;
            btnNextUpca.FlatStyle = FlatStyle.Flat;
            btnNextUpca.Font = new Font("Segoe UI", 18F);
            btnNextUpca.ForeColor = Color.White;
            btnNextUpca.ImeMode = ImeMode.NoControl;
            btnNextUpca.Location = new Point(366, 360);
            btnNextUpca.Name = "btnNextUpca";
            btnNextUpca.Size = new Size(24, 95);
            btnNextUpca.TabIndex = 62;
            btnNextUpca.Text = ">";
            btnNextUpca.UseVisualStyleBackColor = false;
            btnNextUpca.Click += btnNext_Click;
            // 
            // pictureBoxUpca
            // 
            pictureBoxUpca.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxUpca.ImeMode = ImeMode.NoControl;
            pictureBoxUpca.Location = new Point(54, 309);
            pictureBoxUpca.Name = "pictureBoxUpca";
            pictureBoxUpca.Size = new Size(336, 197);
            pictureBoxUpca.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxUpca.TabIndex = 60;
            pictureBoxUpca.TabStop = false;
            // 
            // saveFile
            // 
            saveFile.ValidateNames = false;
            // 
            // lblCountDescription
            // 
            lblCountDescription.ForeColor = Color.White;
            lblCountDescription.Location = new Point(49, 271);
            lblCountDescription.Name = "lblCountDescription";
            lblCountDescription.Size = new Size(117, 25);
            lblCountDescription.TabIndex = 77;
            lblCountDescription.Text = "Count:";
            // 
            // lblCountGtins
            // 
            lblCountGtins.ForeColor = Color.White;
            lblCountGtins.Location = new Point(296, 271);
            lblCountGtins.Name = "lblCountGtins";
            lblCountGtins.Size = new Size(123, 25);
            lblCountGtins.TabIndex = 78;
            lblCountGtins.Text = "Count: ";
            // 
            // lblCountCode128Gtins
            // 
            lblCountCode128Gtins.ForeColor = Color.White;
            lblCountCode128Gtins.Location = new Point(856, 271);
            lblCountCode128Gtins.Name = "lblCountCode128Gtins";
            lblCountCode128Gtins.Size = new Size(123, 25);
            lblCountCode128Gtins.TabIndex = 81;
            lblCountCode128Gtins.Text = "Count: ";
            // 
            // lblCountCode128Description
            // 
            lblCountCode128Description.ForeColor = Color.White;
            lblCountCode128Description.Location = new Point(581, 271);
            lblCountCode128Description.Name = "lblCountCode128Description";
            lblCountCode128Description.Size = new Size(117, 25);
            lblCountCode128Description.TabIndex = 80;
            lblCountCode128Description.Text = "Count:";
            // 
            // lblItemName
            // 
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(54, 509);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(123, 25);
            lblItemName.TabIndex = 82;
            // 
            // btnUpcaSaveToWord
            // 
            btnUpcaSaveToWord.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaSaveToWord.FlatAppearance.BorderSize = 0;
            btnUpcaSaveToWord.FlatStyle = FlatStyle.Flat;
            btnUpcaSaveToWord.ForeColor = Color.White;
            btnUpcaSaveToWord.ImeMode = ImeMode.NoControl;
            btnUpcaSaveToWord.Location = new Point(260, 573);
            btnUpcaSaveToWord.Name = "btnUpcaSaveToWord";
            btnUpcaSaveToWord.Size = new Size(90, 64);
            btnUpcaSaveToWord.TabIndex = 83;
            btnUpcaSaveToWord.Text = "Save to Word";
            btnUpcaSaveToWord.UseVisualStyleBackColor = false;
            btnUpcaSaveToWord.Click += btnUpcaSaveToWord_Click;
            // 
            // btnCode128SaveToWord
            // 
            btnCode128SaveToWord.BackColor = Color.FromArgb(64, 64, 64);
            btnCode128SaveToWord.FlatAppearance.BorderSize = 0;
            btnCode128SaveToWord.FlatStyle = FlatStyle.Flat;
            btnCode128SaveToWord.ForeColor = Color.White;
            btnCode128SaveToWord.ImeMode = ImeMode.NoControl;
            btnCode128SaveToWord.Location = new Point(793, 573);
            btnCode128SaveToWord.Name = "btnCode128SaveToWord";
            btnCode128SaveToWord.Size = new Size(90, 64);
            btnCode128SaveToWord.TabIndex = 84;
            btnCode128SaveToWord.Text = "Save to Word";
            btnCode128SaveToWord.UseVisualStyleBackColor = false;
            btnCode128SaveToWord.Click += btnCode128SaveToWord_Click;
            // 
            // ErcUpca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(btnCode128SaveToWord);
            Controls.Add(btnUpcaSaveToWord);
            Controls.Add(lblItemName);
            Controls.Add(lblCountCode128Gtins);
            Controls.Add(lblCountCode128Description);
            Controls.Add(lblCountGtins);
            Controls.Add(lblCountDescription);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(btnCodeSave);
            Controls.Add(btnCode128Clear);
            Controls.Add(btnCode128CreateBarcode);
            Controls.Add(btnUpcaSave);
            Controls.Add(btnUpcaClear);
            Controls.Add(btnUpcaCreateBarcode);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(btnPreviousCode128);
            Controls.Add(btnNextCode128);
            Controls.Add(pictureBoxCode128);
            Controls.Add(lblSelectedButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnPreviousUpca);
            Controls.Add(btnNextUpca);
            Controls.Add(pictureBoxUpca);
            Name = "ErcUpca";
            Size = new Size(1160, 692);
            Load += ErcUpca_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorCode128).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorCode128).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorUpca).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorUpca).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCode128).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox6;
        private Label label6;
        public NumericUpDown heightSelectorCode128;
        private Label label7;
        public NumericUpDown widthSelectorCode128;
        private GroupBox groupBox2;
        private Label label1;
        public NumericUpDown heightSelectorUpca;
        private Label label4;
        public NumericUpDown widthSelectorUpca;
        private Button btnCodeSave;
        private Button btnCode128Clear;
        private Button btnCode128CreateBarcode;
        private Button btnUpcaSave;
        private Button btnUpcaClear;
        private Button btnUpcaCreateBarcode;
        public Label label5;
        private GroupBox groupBox4;
        private TextBox tbxGtinsCode128;
        private GroupBox groupBox5;
        private TextBox tbxCode128Description;
        private Button btnPreviousCode128;
        private Button btnNextCode128;
        private PictureBox pictureBoxCode128;
        public Label lblSelectedButton;
        private GroupBox groupBox3;
        private TextBox tbxUpcaGtinsInput;
        private GroupBox groupBox1;
        private Button btnPreviousUpca;
        private Button btnNextUpca;
        private PictureBox pictureBoxUpca;
        public TextBox tbxUpcaDescription;
        public Label lblCountGtins;
        public Label lblCountDescription;
        public Label lblCountCode128Gtins;
        public Label lblCountCode128Description;
        public Label lblItemName;
        private Button btnUpcaSaveToWord;
        public SaveFileDialog saveFile;
        private Button btnCode128SaveToWord;
    }
}
