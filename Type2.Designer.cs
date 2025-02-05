namespace QA_Barcode_Generator
{
    partial class UserControlType2
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
            tbxManualPriceGtin = new TextBox();
            tbxPrice = new TextBox();
            btnUpcaCreateBarcode = new Button();
            pictureBoxType2 = new PictureBox();
            lblType2Screen = new Label();
            tbxEmbeddedPriceGtin = new TextBox();
            btnUpcaSave = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            heightSelectorType2 = new NumericUpDown();
            label4 = new Label();
            widthSelectorType2 = new NumericUpDown();
            saveFile = new SaveFileDialog();
            btnUpcaClear = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxType2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorType2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorType2).BeginInit();
            SuspendLayout();
            // 
            // tbxManualPriceGtin
            // 
            tbxManualPriceGtin.AllowDrop = true;
            tbxManualPriceGtin.BackColor = Color.FromArgb(64, 64, 64);
            tbxManualPriceGtin.BorderStyle = BorderStyle.FixedSingle;
            tbxManualPriceGtin.Font = new Font("Segoe UI", 10.2F);
            tbxManualPriceGtin.ForeColor = Color.White;
            tbxManualPriceGtin.Location = new Point(65, 115);
            tbxManualPriceGtin.Name = "tbxManualPriceGtin";
            tbxManualPriceGtin.PlaceholderText = "Enter Manual Price Gtin";
            tbxManualPriceGtin.Size = new Size(346, 30);
            tbxManualPriceGtin.TabIndex = 21;
            // 
            // tbxPrice
            // 
            tbxPrice.AllowDrop = true;
            tbxPrice.BackColor = Color.FromArgb(64, 64, 64);
            tbxPrice.BorderStyle = BorderStyle.FixedSingle;
            tbxPrice.Font = new Font("Segoe UI", 10.2F);
            tbxPrice.ForeColor = Color.White;
            tbxPrice.Location = new Point(65, 180);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.PlaceholderText = "Enter 4 digit price. e.g 0299 for $2.99";
            tbxPrice.Size = new Size(346, 30);
            tbxPrice.TabIndex = 22;
            // 
            // btnUpcaCreateBarcode
            // 
            btnUpcaCreateBarcode.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaCreateBarcode.FlatAppearance.BorderSize = 0;
            btnUpcaCreateBarcode.FlatStyle = FlatStyle.Flat;
            btnUpcaCreateBarcode.ForeColor = Color.White;
            btnUpcaCreateBarcode.ImeMode = ImeMode.NoControl;
            btnUpcaCreateBarcode.Location = new Point(65, 316);
            btnUpcaCreateBarcode.Name = "btnUpcaCreateBarcode";
            btnUpcaCreateBarcode.Size = new Size(90, 64);
            btnUpcaCreateBarcode.TabIndex = 58;
            btnUpcaCreateBarcode.Text = "Create Barcode";
            btnUpcaCreateBarcode.UseVisualStyleBackColor = false;
            btnUpcaCreateBarcode.Click += btnUpcaCreateBarcode_Click;
            // 
            // pictureBoxType2
            // 
            pictureBoxType2.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxType2.ImeMode = ImeMode.NoControl;
            pictureBoxType2.Location = new Point(65, 439);
            pictureBoxType2.Name = "pictureBoxType2";
            pictureBoxType2.Size = new Size(346, 197);
            pictureBoxType2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxType2.TabIndex = 61;
            pictureBoxType2.TabStop = false;
            // 
            // lblType2Screen
            // 
            lblType2Screen.AutoSize = true;
            lblType2Screen.BackColor = Color.FromArgb(52, 52, 52);
            lblType2Screen.Font = new Font("Segoe UI", 16.2F);
            lblType2Screen.ForeColor = Color.White;
            lblType2Screen.ImeMode = ImeMode.NoControl;
            lblType2Screen.Location = new Point(65, 44);
            lblType2Screen.Name = "lblType2Screen";
            lblType2Screen.Size = new Size(206, 38);
            lblType2Screen.TabIndex = 62;
            lblType2Screen.Text = "Type 2 Barcode";
            // 
            // tbxEmbeddedPriceGtin
            // 
            tbxEmbeddedPriceGtin.AllowDrop = true;
            tbxEmbeddedPriceGtin.BackColor = Color.FromArgb(64, 64, 64);
            tbxEmbeddedPriceGtin.BorderStyle = BorderStyle.FixedSingle;
            tbxEmbeddedPriceGtin.Font = new Font("Segoe UI", 10.2F);
            tbxEmbeddedPriceGtin.ForeColor = Color.White;
            tbxEmbeddedPriceGtin.Location = new Point(65, 250);
            tbxEmbeddedPriceGtin.Name = "tbxEmbeddedPriceGtin";
            tbxEmbeddedPriceGtin.ReadOnly = true;
            tbxEmbeddedPriceGtin.Size = new Size(346, 30);
            tbxEmbeddedPriceGtin.TabIndex = 63;
            // 
            // btnUpcaSave
            // 
            btnUpcaSave.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaSave.FlatAppearance.BorderSize = 0;
            btnUpcaSave.FlatStyle = FlatStyle.Flat;
            btnUpcaSave.ForeColor = Color.White;
            btnUpcaSave.ImeMode = ImeMode.NoControl;
            btnUpcaSave.Location = new Point(172, 316);
            btnUpcaSave.Name = "btnUpcaSave";
            btnUpcaSave.Size = new Size(90, 64);
            btnUpcaSave.TabIndex = 64;
            btnUpcaSave.Text = "Save";
            btnUpcaSave.UseVisualStyleBackColor = false;
            btnUpcaSave.Click += btnUpcaSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(heightSelectorType2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(widthSelectorType2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(462, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(97, 197);
            groupBox2.TabIndex = 76;
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
            // heightSelectorType2
            // 
            heightSelectorType2.Font = new Font("Segoe UI", 9F);
            heightSelectorType2.Location = new Point(21, 151);
            heightSelectorType2.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightSelectorType2.Name = "heightSelectorType2";
            heightSelectorType2.Size = new Size(55, 27);
            heightSelectorType2.TabIndex = 25;
            heightSelectorType2.Value = new decimal(new int[] { 150, 0, 0, 0 });
            heightSelectorType2.ValueChanged += heightSelectorType2_ValueChanged;
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
            // widthSelectorType2
            // 
            widthSelectorType2.Font = new Font("Segoe UI", 9F);
            widthSelectorType2.Location = new Point(21, 67);
            widthSelectorType2.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelectorType2.Name = "widthSelectorType2";
            widthSelectorType2.Size = new Size(58, 27);
            widthSelectorType2.TabIndex = 24;
            widthSelectorType2.Value = new decimal(new int[] { 285, 0, 0, 0 });
            widthSelectorType2.ValueChanged += widthSelectorType2_ValueChanged;
            // 
            // saveFile
            // 
            saveFile.FileName = "barcodes";
            saveFile.Filter = "Jpeg Image|*.jpg";
            saveFile.ValidateNames = false;
            // 
            // btnUpcaClear
            // 
            btnUpcaClear.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaClear.FlatAppearance.BorderSize = 0;
            btnUpcaClear.FlatStyle = FlatStyle.Flat;
            btnUpcaClear.ForeColor = Color.White;
            btnUpcaClear.ImeMode = ImeMode.NoControl;
            btnUpcaClear.Location = new Point(280, 316);
            btnUpcaClear.Name = "btnUpcaClear";
            btnUpcaClear.Size = new Size(90, 64);
            btnUpcaClear.TabIndex = 77;
            btnUpcaClear.Text = "Clear";
            btnUpcaClear.UseVisualStyleBackColor = false;
            btnUpcaClear.Click += btnUpcaClear_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(648, 115);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(389, 209);
            richTextBox1.TabIndex = 79;
            richTextBox1.Text = "SELECT * FROM Item\nWHERE Gtin like '2%00000'\nAND ActivationStatus = 'A'\nAND UnitOfMeasurement = 'LB'";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(52, 52, 52);
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(648, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 80;
            label2.Text = "POSa ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(52, 52, 52);
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(648, 356);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 82;
            label3.Text = "FrontOff";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(648, 427);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(389, 209);
            richTextBox2.TabIndex = 81;
            richTextBox2.Text = "SELECT * FROM Item\nWHERE Gtin like '2%00000'\nAND ActivationStatus = 'A'\nAND UnitOfMeasurement = 'LB'";
            // 
            // UserControlType2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(btnUpcaClear);
            Controls.Add(groupBox2);
            Controls.Add(btnUpcaSave);
            Controls.Add(tbxEmbeddedPriceGtin);
            Controls.Add(lblType2Screen);
            Controls.Add(pictureBoxType2);
            Controls.Add(btnUpcaCreateBarcode);
            Controls.Add(tbxPrice);
            Controls.Add(tbxManualPriceGtin);
            Name = "UserControlType2";
            Size = new Size(1160, 692);
            Load += UserControlType2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxType2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorType2).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorType2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxManualPriceGtin;
        private TextBox tbxPrice;
        private Button btnUpcaCreateBarcode;
        private PictureBox pictureBoxType2;
        public Label lblType2Screen;
        private TextBox tbxEmbeddedPriceGtin;
        private Button btnUpcaSave;
        private GroupBox groupBox2;
        private Label label1;
        public NumericUpDown heightSelectorType2;
        private Label label4;
        public NumericUpDown widthSelectorType2;
        public SaveFileDialog saveFile;
        private Button btnUpcaClear;
        private RichTextBox richTextBox1;
        public Label label2;
        public Label label3;
        private RichTextBox richTextBox2;
    }
}
