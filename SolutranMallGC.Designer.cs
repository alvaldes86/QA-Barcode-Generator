namespace QA_Barcode_Generator
{
    partial class SolutranMallGC
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
            lblType2Screen = new Label();
            lblCountCode128Gtins = new Label();
            lblCountCode128Description = new Label();
            groupBox6 = new GroupBox();
            label6 = new Label();
            heightSelectorSolutran = new NumericUpDown();
            label7 = new Label();
            widthSelectorSolutran = new NumericUpDown();
            btnSolutranSave = new Button();
            btnSolutranClear = new Button();
            btnSolutranCreateBarcode = new Button();
            groupBox4 = new GroupBox();
            tbxGtinsSolutran = new TextBox();
            groupBox5 = new GroupBox();
            tbxSolutranDescription = new TextBox();
            btnPreviousSolutran = new Button();
            btnNextSolutran = new Button();
            pictureBoxSolutran = new PictureBox();
            saveFile = new SaveFileDialog();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorSolutran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorSolutran).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSolutran).BeginInit();
            SuspendLayout();
            // 
            // lblType2Screen
            // 
            lblType2Screen.AutoSize = true;
            lblType2Screen.BackColor = Color.FromArgb(52, 52, 52);
            lblType2Screen.Font = new Font("Segoe UI", 16.2F);
            lblType2Screen.ForeColor = Color.White;
            lblType2Screen.ImeMode = ImeMode.NoControl;
            lblType2Screen.Location = new Point(76, 41);
            lblType2Screen.Name = "lblType2Screen";
            lblType2Screen.Size = new Size(321, 38);
            lblType2Screen.TabIndex = 82;
            lblType2Screen.Text = "Solutran/ Mall Gift Cards";
            // 
            // lblCountCode128Gtins
            // 
            lblCountCode128Gtins.ForeColor = Color.White;
            lblCountCode128Gtins.Location = new Point(351, 278);
            lblCountCode128Gtins.Name = "lblCountCode128Gtins";
            lblCountCode128Gtins.Size = new Size(123, 25);
            lblCountCode128Gtins.TabIndex = 94;
            lblCountCode128Gtins.Text = "Count: ";
            // 
            // lblCountCode128Description
            // 
            lblCountCode128Description.ForeColor = Color.White;
            lblCountCode128Description.Location = new Point(76, 278);
            lblCountCode128Description.Name = "lblCountCode128Description";
            lblCountCode128Description.Size = new Size(117, 25);
            lblCountCode128Description.TabIndex = 93;
            lblCountCode128Description.Text = "Count:";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(64, 64, 64);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(heightSelectorSolutran);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(widthSelectorSolutran);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Segoe UI", 10.2F);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(502, 316);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(97, 197);
            groupBox6.TabIndex = 92;
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
            // heightSelectorSolutran
            // 
            heightSelectorSolutran.Font = new Font("Segoe UI", 9F);
            heightSelectorSolutran.Location = new Point(21, 151);
            heightSelectorSolutran.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightSelectorSolutran.Name = "heightSelectorSolutran";
            heightSelectorSolutran.Size = new Size(55, 27);
            heightSelectorSolutran.TabIndex = 25;
            heightSelectorSolutran.Value = new decimal(new int[] { 150, 0, 0, 0 });
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
            // widthSelectorSolutran
            // 
            widthSelectorSolutran.Font = new Font("Segoe UI", 9F);
            widthSelectorSolutran.Location = new Point(21, 67);
            widthSelectorSolutran.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelectorSolutran.Name = "widthSelectorSolutran";
            widthSelectorSolutran.Size = new Size(58, 27);
            widthSelectorSolutran.TabIndex = 24;
            widthSelectorSolutran.Value = new decimal(new int[] { 350, 0, 0, 0 });
            // 
            // btnSolutranSave
            // 
            btnSolutranSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSolutranSave.FlatAppearance.BorderSize = 0;
            btnSolutranSave.FlatStyle = FlatStyle.Flat;
            btnSolutranSave.ForeColor = Color.White;
            btnSolutranSave.ImeMode = ImeMode.NoControl;
            btnSolutranSave.Location = new Point(182, 580);
            btnSolutranSave.Name = "btnSolutranSave";
            btnSolutranSave.Size = new Size(90, 64);
            btnSolutranSave.TabIndex = 91;
            btnSolutranSave.Text = "Save";
            btnSolutranSave.UseVisualStyleBackColor = false;
            btnSolutranSave.Click += btnSolutranSave_Click;
            // 
            // btnSolutranClear
            // 
            btnSolutranClear.BackColor = Color.FromArgb(64, 64, 64);
            btnSolutranClear.FlatAppearance.BorderSize = 0;
            btnSolutranClear.FlatStyle = FlatStyle.Flat;
            btnSolutranClear.ForeColor = Color.White;
            btnSolutranClear.ImeMode = ImeMode.NoControl;
            btnSolutranClear.Location = new Point(507, 580);
            btnSolutranClear.Name = "btnSolutranClear";
            btnSolutranClear.Size = new Size(90, 64);
            btnSolutranClear.TabIndex = 90;
            btnSolutranClear.Text = "Clear";
            btnSolutranClear.UseVisualStyleBackColor = false;
            btnSolutranClear.Click += btnSolutranClear_Click;
            // 
            // btnSolutranCreateBarcode
            // 
            btnSolutranCreateBarcode.BackColor = Color.FromArgb(64, 64, 64);
            btnSolutranCreateBarcode.FlatAppearance.BorderSize = 0;
            btnSolutranCreateBarcode.FlatStyle = FlatStyle.Flat;
            btnSolutranCreateBarcode.ForeColor = Color.White;
            btnSolutranCreateBarcode.ImeMode = ImeMode.NoControl;
            btnSolutranCreateBarcode.Location = new Point(76, 580);
            btnSolutranCreateBarcode.Name = "btnSolutranCreateBarcode";
            btnSolutranCreateBarcode.Size = new Size(90, 64);
            btnSolutranCreateBarcode.TabIndex = 89;
            btnSolutranCreateBarcode.Text = "Create Barcode";
            btnSolutranCreateBarcode.UseVisualStyleBackColor = false;
            btnSolutranCreateBarcode.Click += btnSolutranCreateBarcode_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(64, 64, 64);
            groupBox4.Controls.Add(tbxGtinsSolutran);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.2F);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(351, 102);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(246, 173);
            groupBox4.TabIndex = 87;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gtin List";
            // 
            // tbxGtinsSolutran
            // 
            tbxGtinsSolutran.AllowDrop = true;
            tbxGtinsSolutran.BackColor = Color.FromArgb(64, 64, 64);
            tbxGtinsSolutran.BorderStyle = BorderStyle.None;
            tbxGtinsSolutran.Font = new Font("Segoe UI", 10.2F);
            tbxGtinsSolutran.ForeColor = Color.White;
            tbxGtinsSolutran.Location = new Point(7, 20);
            tbxGtinsSolutran.Multiline = true;
            tbxGtinsSolutran.Name = "tbxGtinsSolutran";
            tbxGtinsSolutran.Size = new Size(233, 147);
            tbxGtinsSolutran.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(64, 64, 64);
            groupBox5.Controls.Add(tbxSolutranDescription);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 10.2F);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(76, 102);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(246, 173);
            groupBox5.TabIndex = 86;
            groupBox5.TabStop = false;
            groupBox5.Text = "Item description";
            // 
            // tbxSolutranDescription
            // 
            tbxSolutranDescription.AllowDrop = true;
            tbxSolutranDescription.BackColor = Color.FromArgb(64, 64, 64);
            tbxSolutranDescription.BorderStyle = BorderStyle.None;
            tbxSolutranDescription.Font = new Font("Segoe UI", 10.2F);
            tbxSolutranDescription.ForeColor = Color.White;
            tbxSolutranDescription.Location = new Point(6, 21);
            tbxSolutranDescription.Multiline = true;
            tbxSolutranDescription.Name = "tbxSolutranDescription";
            tbxSolutranDescription.Size = new Size(234, 147);
            tbxSolutranDescription.TabIndex = 11;
            // 
            // btnPreviousSolutran
            // 
            btnPreviousSolutran.BackColor = Color.FromArgb(64, 64, 64);
            btnPreviousSolutran.FlatAppearance.BorderSize = 0;
            btnPreviousSolutran.FlatStyle = FlatStyle.Flat;
            btnPreviousSolutran.Font = new Font("Segoe UI", 18F);
            btnPreviousSolutran.ForeColor = Color.White;
            btnPreviousSolutran.ImeMode = ImeMode.NoControl;
            btnPreviousSolutran.Location = new Point(76, 367);
            btnPreviousSolutran.Name = "btnPreviousSolutran";
            btnPreviousSolutran.Size = new Size(23, 95);
            btnPreviousSolutran.TabIndex = 85;
            btnPreviousSolutran.Text = "<";
            btnPreviousSolutran.UseVisualStyleBackColor = false;
            btnPreviousSolutran.Click += btnPreviousSolutran_Click;
            // 
            // btnNextSolutran
            // 
            btnNextSolutran.BackColor = Color.FromArgb(64, 64, 64);
            btnNextSolutran.FlatAppearance.BorderSize = 0;
            btnNextSolutran.FlatStyle = FlatStyle.Flat;
            btnNextSolutran.Font = new Font("Segoe UI", 18F);
            btnNextSolutran.ForeColor = Color.White;
            btnNextSolutran.ImeMode = ImeMode.NoControl;
            btnNextSolutran.Location = new Point(450, 367);
            btnNextSolutran.Name = "btnNextSolutran";
            btnNextSolutran.Size = new Size(24, 95);
            btnNextSolutran.TabIndex = 84;
            btnNextSolutran.Text = ">";
            btnNextSolutran.UseVisualStyleBackColor = false;
            btnNextSolutran.Click += btnNextSolutran_Click;
            // 
            // pictureBoxSolutran
            // 
            pictureBoxSolutran.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxSolutran.ImeMode = ImeMode.NoControl;
            pictureBoxSolutran.Location = new Point(76, 316);
            pictureBoxSolutran.Name = "pictureBoxSolutran";
            pictureBoxSolutran.Size = new Size(398, 197);
            pictureBoxSolutran.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSolutran.TabIndex = 83;
            pictureBoxSolutran.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(52, 52, 52);
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(687, 367);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 98;
            label3.Text = "FrontOff";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(687, 438);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(389, 209);
            richTextBox2.TabIndex = 97;
            richTextBox2.Text = "SELECT * FROMItem\nWHERE Gtin like '2%00000'\nAND ActivationStatus = 'A'\nAND UnitOfMeasurement = 'LB'";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(52, 52, 52);
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(687, 41);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 96;
            label2.Text = "POSa ";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(687, 112);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(389, 209);
            richTextBox1.TabIndex = 95;
            richTextBox1.Text = "SELECT * FROMItem\nWHERE Gtin like '2%00000'\nAND ActivationStatus = 'A'\nAND UnitOfMeasurement = 'LB'";
            // 
            // SolutranMallGC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(lblCountCode128Gtins);
            Controls.Add(lblCountCode128Description);
            Controls.Add(groupBox6);
            Controls.Add(btnSolutranSave);
            Controls.Add(btnSolutranClear);
            Controls.Add(btnSolutranCreateBarcode);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(btnPreviousSolutran);
            Controls.Add(btnNextSolutran);
            Controls.Add(pictureBoxSolutran);
            Controls.Add(lblType2Screen);
            Name = "SolutranMallGC";
            Size = new Size(1160, 692);
            Load += SolutranMallGC_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightSelectorSolutran).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthSelectorSolutran).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSolutran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblType2Screen;
        public Label lblCountCode128Gtins;
        public Label lblCountCode128Description;
        private GroupBox groupBox6;
        private Label label6;
        public NumericUpDown heightSelectorSolutran;
        private Label label7;
        public NumericUpDown widthSelectorSolutran;
        private Button btnSolutranSave;
        private Button btnSolutranClear;
        private Button btnSolutranCreateBarcode;
        private GroupBox groupBox4;
        private TextBox tbxGtinsSolutran;
        private GroupBox groupBox5;
        private TextBox tbxSolutranDescription;
        private Button btnPreviousSolutran;
        private Button btnNextSolutran;
        private PictureBox pictureBoxSolutran;
        private SaveFileDialog saveFile;
        public Label label3;
        private RichTextBox richTextBox2;
        public Label label2;
        private RichTextBox richTextBox1;
    }
}
