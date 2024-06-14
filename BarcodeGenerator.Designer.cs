namespace QA_Barcode_Generator
{
    partial class BarcodeGenerator
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
            pictureBoxBarcodeCreated = new PictureBox();
            btnSave = new Button();
            cbxSelection = new ComboBox();
            btnClear = new Button();
            btnCreateBarcode = new Button();
            tbxUserInput = new TextBox();
            label1 = new Label();
            buttonsMenuContainer = new Panel();
            groupBox1 = new GroupBox();
            saveFile = new SaveFileDialog();
            btnNext = new Button();
            btnPrevious = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcodeCreated).BeginInit();
            buttonsMenuContainer.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBarcodeCreated
            // 
            pictureBoxBarcodeCreated.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxBarcodeCreated.Location = new Point(616, 39);
            pictureBoxBarcodeCreated.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBarcodeCreated.Name = "pictureBoxBarcodeCreated";
            pictureBoxBarcodeCreated.Size = new Size(336, 279);
            pictureBoxBarcodeCreated.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBarcodeCreated.TabIndex = 18;
            pictureBoxBarcodeCreated.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(169, 2);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 50);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // cbxSelection
            // 
            cbxSelection.FlatStyle = FlatStyle.Flat;
            cbxSelection.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxSelection.FormattingEnabled = true;
            cbxSelection.Items.AddRange(new object[] { "UPC_A", "Linear 128" });
            cbxSelection.Location = new Point(18, 61);
            cbxSelection.Margin = new Padding(3, 2, 3, 2);
            cbxSelection.Name = "cbxSelection";
            cbxSelection.Size = new Size(162, 27);
            cbxSelection.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(86, 2);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 50);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreateBarcode
            // 
            btnCreateBarcode.BackColor = Color.FromArgb(64, 64, 64);
            btnCreateBarcode.FlatAppearance.BorderSize = 0;
            btnCreateBarcode.FlatStyle = FlatStyle.Flat;
            btnCreateBarcode.ForeColor = Color.White;
            btnCreateBarcode.Location = new Point(3, 2);
            btnCreateBarcode.Margin = new Padding(3, 2, 3, 2);
            btnCreateBarcode.Name = "btnCreateBarcode";
            btnCreateBarcode.Size = new Size(78, 50);
            btnCreateBarcode.TabIndex = 11;
            btnCreateBarcode.Text = "Create Barcode";
            btnCreateBarcode.UseVisualStyleBackColor = false;
            btnCreateBarcode.Click += btnCreateBarcode_Click;
            // 
            // tbxUserInput
            // 
            tbxUserInput.AllowDrop = true;
            tbxUserInput.BackColor = Color.FromArgb(64, 64, 64);
            tbxUserInput.BorderStyle = BorderStyle.None;
            tbxUserInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserInput.ForeColor = Color.White;
            tbxUserInput.Location = new Point(355, 39);
            tbxUserInput.Margin = new Padding(3, 2, 3, 2);
            tbxUserInput.Multiline = true;
            tbxUserInput.Name = "tbxUserInput";
            tbxUserInput.Size = new Size(192, 279);
            tbxUserInput.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 19;
            label1.Text = "Linear Codes:";
            // 
            // buttonsMenuContainer
            // 
            buttonsMenuContainer.BackColor = Color.FromArgb(64, 64, 64);
            buttonsMenuContainer.Controls.Add(btnCreateBarcode);
            buttonsMenuContainer.Controls.Add(btnClear);
            buttonsMenuContainer.Controls.Add(btnSave);
            buttonsMenuContainer.Dock = DockStyle.Bottom;
            buttonsMenuContainer.Location = new Point(0, 425);
            buttonsMenuContainer.Margin = new Padding(0);
            buttonsMenuContainer.Name = "buttonsMenuContainer";
            buttonsMenuContainer.Size = new Size(976, 54);
            buttonsMenuContainer.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(cbxSelection);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(46, 29);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(215, 289);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Barcode Type";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(64, 64, 64);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(930, 117);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(22, 108);
            btnNext.TabIndex = 22;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(64, 64, 64);
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(616, 117);
            btnPrevious.Margin = new Padding(3, 2, 3, 2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(24, 108);
            btnPrevious.TabIndex = 23;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // BarcodeGenerator
            // 
            AccessibleName = "MenuUserControls";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(52, 52, 52);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(groupBox1);
            Controls.Add(buttonsMenuContainer);
            Controls.Add(pictureBoxBarcodeCreated);
            Controls.Add(tbxUserInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BarcodeGenerator";
            Size = new Size(976, 479);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcodeCreated).EndInit();
            buttonsMenuContainer.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBarcodeCreated;
        private Button btnSave;
        private ComboBox cbxSelection;
        private Button btnClear;
        private Button btnCreateBarcode;
        private TextBox tbxUserInput;
        private Label label1;
        private Panel buttonsMenuContainer;
        private GroupBox groupBox1;
        private SaveFileDialog saveFile;
        private Button btnNext;
        private Button btnPrevious;
    }
}
