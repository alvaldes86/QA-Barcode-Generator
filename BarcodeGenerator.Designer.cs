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
            btnClear = new Button();
            btnCreateBarcode = new Button();
            tbxUserInput = new TextBox();
            buttonsMenuContainer = new Panel();
            saveFile = new SaveFileDialog();
            btnNext = new Button();
            btnPrevious = new Button();
            widthSelector = new NumericUpDown();
            lengthSelector = new NumericUpDown();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tbxDescription = new TextBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcodeCreated).BeginInit();
            buttonsMenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)widthSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lengthSelector).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBarcodeCreated
            // 
            pictureBoxBarcodeCreated.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxBarcodeCreated.Location = new Point(687, 75);
            pictureBoxBarcodeCreated.Name = "pictureBoxBarcodeCreated";
            pictureBoxBarcodeCreated.Size = new Size(384, 240);
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
            btnSave.Location = new Point(193, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 67);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(98, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 67);
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
            btnCreateBarcode.Location = new Point(3, 3);
            btnCreateBarcode.Name = "btnCreateBarcode";
            btnCreateBarcode.Size = new Size(89, 67);
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
            tbxUserInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserInput.ForeColor = Color.White;
            tbxUserInput.Location = new Point(6, 29);
            tbxUserInput.Multiline = true;
            tbxUserInput.Name = "tbxUserInput";
            tbxUserInput.Size = new Size(234, 378);
            tbxUserInput.TabIndex = 10;
            // 
            // buttonsMenuContainer
            // 
            buttonsMenuContainer.BackColor = Color.FromArgb(64, 64, 64);
            buttonsMenuContainer.Controls.Add(btnCreateBarcode);
            buttonsMenuContainer.Controls.Add(btnClear);
            buttonsMenuContainer.Controls.Add(btnSave);
            buttonsMenuContainer.Dock = DockStyle.Bottom;
            buttonsMenuContainer.Location = new Point(0, 567);
            buttonsMenuContainer.Margin = new Padding(0);
            buttonsMenuContainer.Name = "buttonsMenuContainer";
            buttonsMenuContainer.Size = new Size(1115, 72);
            buttonsMenuContainer.TabIndex = 20;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(64, 64, 64);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1046, 120);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(25, 144);
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
            btnPrevious.Location = new Point(687, 120);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(27, 144);
            btnPrevious.TabIndex = 23;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // widthSelector
            // 
            widthSelector.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            widthSelector.Location = new Point(36, 76);
            widthSelector.Margin = new Padding(3, 4, 3, 4);
            widthSelector.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            widthSelector.Name = "widthSelector";
            widthSelector.Size = new Size(66, 27);
            widthSelector.TabIndex = 24;
            widthSelector.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // lengthSelector
            // 
            lengthSelector.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lengthSelector.Location = new Point(140, 76);
            lengthSelector.Margin = new Padding(3, 4, 3, 4);
            lengthSelector.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            lengthSelector.Name = "lengthSelector";
            lengthSelector.Size = new Size(63, 27);
            lengthSelector.TabIndex = 25;
            lengthSelector.Value = new decimal(new int[] { 190, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 42);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 26;
            label2.Text = "Width";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lengthSelector);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(widthSelector);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(687, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 136);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Barcode Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(140, 42);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 27;
            label3.Text = "Length";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(tbxDescription);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(65, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 407);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item description";
            // 
            // tbxDescription
            // 
            tbxDescription.AllowDrop = true;
            tbxDescription.BackColor = Color.FromArgb(64, 64, 64);
            tbxDescription.BorderStyle = BorderStyle.None;
            tbxDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDescription.ForeColor = Color.White;
            tbxDescription.Location = new Point(6, 29);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(234, 372);
            tbxDescription.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(64, 64, 64);
            groupBox3.Controls.Add(tbxUserInput);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.2F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(378, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 407);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gtins";
            // 
            // BarcodeGenerator
            // 
            AccessibleName = "MenuUserControls";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(52, 52, 52);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(buttonsMenuContainer);
            Controls.Add(pictureBoxBarcodeCreated);
            Name = "BarcodeGenerator";
            Size = new Size(1115, 639);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcodeCreated).EndInit();
            buttonsMenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)widthSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)lengthSelector).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBarcodeCreated;
        private Button btnSave;
        private Button btnClear;
        private Button btnCreateBarcode;
        private TextBox tbxUserInput;
        private Panel buttonsMenuContainer;
        private SaveFileDialog saveFile;
        private Button btnNext;
        private Button btnPrevious;
        private NumericUpDown widthSelector;
        private NumericUpDown lengthSelector;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox tbxDescription;
        private GroupBox groupBox3;
    }
}
