namespace QA_Barcode_Generator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            printDialog = new PrintDialog();
            navContainer = new Panel();
            button2 = new Button();
            btnSettings = new Button();
            barcodeGenerator = new Button();
            viewSetting1 = new viewSetting();
            bodyContainer = new Panel();
            barcodeGenerator1 = new BarcodeGenerator();
            navContainer.SuspendLayout();
            bodyContainer.SuspendLayout();
            SuspendLayout();
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // navContainer
            // 
            navContainer.BackColor = Color.FromArgb(1, 1, 50);
            navContainer.Controls.Add(button2);
            navContainer.Controls.Add(btnSettings);
            navContainer.Controls.Add(barcodeGenerator);
            navContainer.Location = new Point(0, 0);
            navContainer.Name = "navContainer";
            navContainer.Size = new Size(199, 639);
            navContainer.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 1, 169);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 108);
            button2.Name = "button2";
            button2.Size = new Size(199, 54);
            button2.TabIndex = 6;
            button2.Text = "Barcode Generator";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(10, 1, 169);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 54);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(199, 54);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // barcodeGenerator
            // 
            barcodeGenerator.BackColor = Color.FromArgb(10, 1, 169);
            barcodeGenerator.FlatAppearance.BorderSize = 0;
            barcodeGenerator.FlatStyle = FlatStyle.Flat;
            barcodeGenerator.ForeColor = Color.White;
            barcodeGenerator.Location = new Point(0, 0);
            barcodeGenerator.Name = "barcodeGenerator";
            barcodeGenerator.Size = new Size(199, 54);
            barcodeGenerator.TabIndex = 4;
            barcodeGenerator.Text = "Barcode Generator";
            barcodeGenerator.UseVisualStyleBackColor = false;
            barcodeGenerator.Click += barcodeGenerator_Click;
            // 
            // viewSetting1
            // 
            viewSetting1.AccessibleName = "Settings";
            viewSetting1.AutoSize = true;
            viewSetting1.Dock = DockStyle.Fill;
            viewSetting1.Location = new Point(0, 0);
            viewSetting1.Name = "viewSetting1";
            viewSetting1.Size = new Size(1116, 639);
            viewSetting1.TabIndex = 7;
            viewSetting1.Visible = false;
            // 
            // bodyContainer
            // 
            bodyContainer.BackColor = Color.DimGray;
            bodyContainer.Controls.Add(barcodeGenerator1);
            bodyContainer.Controls.Add(viewSetting1);
            bodyContainer.Location = new Point(199, 0);
            bodyContainer.Name = "bodyContainer";
            bodyContainer.Size = new Size(1116, 639);
            bodyContainer.TabIndex = 4;
            // 
            // barcodeGenerator1
            // 
            barcodeGenerator1.AccessibleName = "MenuUserControls";
            barcodeGenerator1.AutoSize = true;
            barcodeGenerator1.BackColor = Color.FromArgb(52, 52, 52);
            barcodeGenerator1.Dock = DockStyle.Fill;
            barcodeGenerator1.Gtins = null;
            barcodeGenerator1.Location = new Point(0, 0);
            barcodeGenerator1.Name = "barcodeGenerator1";
            barcodeGenerator1.Size = new Size(1116, 639);
            barcodeGenerator1.TabIndex = 8;
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1315, 639);
            Controls.Add(bodyContainer);
            Controls.Add(navContainer);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Main";
            Text = "Barcode Generator";
            navContainer.ResumeLayout(false);
            bodyContainer.ResumeLayout(false);
            bodyContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PrintDialog printDialog;
        private Panel navContainer;
        private Button barcodeGenerator;
        private Panel bodyContainer;
        private Button button2;
        private Button btnSettings;
        private viewSetting viewSetting1;
        private BarcodeGenerator barcodeGenerator1;
    }
}
