namespace QA_Barcode_Generator
{
    partial class viewSetting
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
            Settings = new Label();
            groupBox1 = new GroupBox();
            cbxSelection = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Settings
            // 
            Settings.AccessibleName = "";
            Settings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Settings.AutoSize = true;
            Settings.Location = new Point(275, 217);
            Settings.Name = "Settings";
            Settings.Size = new Size(66, 20);
            Settings.TabIndex = 0;
            Settings.Text = "Settings ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(cbxSelection);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(422, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 407);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Barcode Type";
            // 
            // cbxSelection
            // 
            cbxSelection.FlatStyle = FlatStyle.Flat;
            cbxSelection.Font = new Font("Segoe UI", 9F);
            cbxSelection.FormattingEnabled = true;
            cbxSelection.Items.AddRange(new object[] { "UPC_A", "Linear 128" });
            cbxSelection.Location = new Point(21, 81);
            cbxSelection.Name = "cbxSelection";
            cbxSelection.Size = new Size(185, 28);
            cbxSelection.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 19;
            label1.Text = "Linear Codes:";
            // 
            // viewSetting
            // 
            AccessibleName = "Settings";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Controls.Add(Settings);
            Name = "viewSetting";
            Size = new Size(1090, 639);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Settings;
        private GroupBox groupBox1;
        private ComboBox cbxSelection;
        private Label label1;
    }
}
