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
            // viewSetting
            // 
            AccessibleName = "Settings";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(Settings);
            Name = "viewSetting";
            Size = new Size(1090, 639);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Settings;
    }
}
