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
            btnGS1DataExpanded = new Button();
            btnType2 = new Button();
            btnUpcaCode128 = new Button();
            saveFile = new SaveFileDialog();
            bodyContainer = new Panel();
            userControlType21 = new UserControlType2();
            gS1Coupon1 = new GS1Coupon();
            ercUpca1 = new ErcUpca();
            btnSolutranMallGC = new Button();
            solutranMallgc1 = new SolutranMallGC();
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
            navContainer.Controls.Add(btnSolutranMallGC);
            navContainer.Controls.Add(btnGS1DataExpanded);
            navContainer.Controls.Add(btnType2);
            navContainer.Controls.Add(btnUpcaCode128);
            navContainer.Location = new Point(0, 0);
            navContainer.Name = "navContainer";
            navContainer.Size = new Size(178, 765);
            navContainer.TabIndex = 3;
            // 
            // btnGS1DataExpanded
            // 
            btnGS1DataExpanded.BackColor = Color.FromArgb(10, 1, 169);
            btnGS1DataExpanded.FlatAppearance.BorderSize = 0;
            btnGS1DataExpanded.FlatStyle = FlatStyle.Flat;
            btnGS1DataExpanded.ForeColor = Color.White;
            btnGS1DataExpanded.Location = new Point(0, 54);
            btnGS1DataExpanded.Name = "btnGS1DataExpanded";
            btnGS1DataExpanded.Size = new Size(175, 60);
            btnGS1DataExpanded.TabIndex = 6;
            btnGS1DataExpanded.Text = "Manufacturer Coupon";
            btnGS1DataExpanded.UseVisualStyleBackColor = false;
            btnGS1DataExpanded.Click += btnGS1DataExpanded_Click;
            // 
            // btnType2
            // 
            btnType2.BackColor = Color.FromArgb(10, 1, 169);
            btnType2.FlatAppearance.BorderSize = 0;
            btnType2.FlatStyle = FlatStyle.Flat;
            btnType2.ForeColor = Color.White;
            btnType2.Location = new Point(0, 114);
            btnType2.Name = "btnType2";
            btnType2.Size = new Size(175, 54);
            btnType2.TabIndex = 5;
            btnType2.Text = "Type 2 UPC_A";
            btnType2.UseVisualStyleBackColor = false;
            btnType2.Click += btnType2_Click;
            // 
            // btnUpcaCode128
            // 
            btnUpcaCode128.BackColor = Color.FromArgb(64, 64, 64);
            btnUpcaCode128.FlatAppearance.BorderSize = 0;
            btnUpcaCode128.FlatStyle = FlatStyle.Flat;
            btnUpcaCode128.ForeColor = Color.White;
            btnUpcaCode128.Location = new Point(0, 0);
            btnUpcaCode128.Name = "btnUpcaCode128";
            btnUpcaCode128.Size = new Size(175, 54);
            btnUpcaCode128.TabIndex = 4;
            btnUpcaCode128.Text = "UPC_A/ ERC";
            btnUpcaCode128.UseVisualStyleBackColor = false;
            btnUpcaCode128.Click += btnUpcaCode128_Click;
            // 
            // saveFile
            // 
            saveFile.FileName = "Don't change";
            // 
            // bodyContainer
            // 
            bodyContainer.BackColor = Color.FromArgb(52, 52, 52);
            bodyContainer.Controls.Add(solutranMallgc1);
            bodyContainer.Controls.Add(userControlType21);
            bodyContainer.Controls.Add(gS1Coupon1);
            bodyContainer.Controls.Add(ercUpca1);
            bodyContainer.Location = new Point(175, 0);
            bodyContainer.Name = "bodyContainer";
            bodyContainer.Size = new Size(1160, 692);
            bodyContainer.TabIndex = 4;
            // 
            // userControlType21
            // 
            userControlType21.BackColor = Color.FromArgb(54, 54, 54);
            userControlType21.Dock = DockStyle.Fill;
            userControlType21.Location = new Point(0, 0);
            userControlType21.Name = "userControlType21";
            userControlType21.Size = new Size(1160, 692);
            userControlType21.TabIndex = 7;
            userControlType21.Visible = false;
            // 
            // gS1Coupon1
            // 
            gS1Coupon1.BackColor = Color.FromArgb(54, 54, 54);
            gS1Coupon1.Dock = DockStyle.Fill;
            gS1Coupon1.Location = new Point(0, 0);
            gS1Coupon1.Margin = new Padding(3, 2, 3, 2);
            gS1Coupon1.Name = "gS1Coupon1";
            gS1Coupon1.Size = new Size(1160, 692);
            gS1Coupon1.TabIndex = 7;
            gS1Coupon1.Visible = false;
            // 
            // ercUpca1
            // 
            ercUpca1.BackColor = Color.FromArgb(54, 54, 54);
            ercUpca1.Dock = DockStyle.Fill;
            ercUpca1.Location = new Point(0, 0);
            ercUpca1.Margin = new Padding(3, 2, 3, 2);
            ercUpca1.Name = "ercUpca1";
            ercUpca1.Size = new Size(1160, 692);
            ercUpca1.TabIndex = 0;
            // 
            // btnSolutranMallGC
            // 
            btnSolutranMallGC.BackColor = Color.FromArgb(10, 1, 169);
            btnSolutranMallGC.FlatAppearance.BorderSize = 0;
            btnSolutranMallGC.FlatStyle = FlatStyle.Flat;
            btnSolutranMallGC.ForeColor = Color.White;
            btnSolutranMallGC.Location = new Point(0, 168);
            btnSolutranMallGC.Name = "btnSolutranMallGC";
            btnSolutranMallGC.Size = new Size(175, 54);
            btnSolutranMallGC.TabIndex = 7;
            btnSolutranMallGC.Text = "Solutran/ Mall GC";
            btnSolutranMallGC.UseVisualStyleBackColor = false;
            btnSolutranMallGC.Click += btnSolutranMallGC_Click;
            // 
            // solutranMallgc1
            // 
            solutranMallgc1.BackColor = Color.FromArgb(54, 54, 54);
            solutranMallgc1.Dock = DockStyle.Fill;
            solutranMallgc1.Location = new Point(0, 0);
            solutranMallgc1.Name = "solutranMallgc1";
            solutranMallgc1.Size = new Size(1160, 692);
            solutranMallgc1.TabIndex = 8;
            solutranMallgc1.Visible = false;
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1338, 696);
            Controls.Add(bodyContainer);
            Controls.Add(navContainer);
            Font = new Font("Segoe UI", 10.2F);
            Name = "Main";
            Text = "Barcode Generator";
            navContainer.ResumeLayout(false);
            bodyContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PrintDialog printDialog;
        private Panel navContainer;
        public Button btnUpcaCode128;
        public Button btnType2;
        private SaveFileDialog saveFile;
        private Panel bodyContainer;
        private ErcUpca ercUpca1;
        public Button btnGS1DataExpanded;
        public GS1Coupon gS1Coupon1;
        private UserControlType2 userControlType21;
        public Button btnSolutranMallGC;
        private SolutranMallGC solutranMallgc1;
    }
}
