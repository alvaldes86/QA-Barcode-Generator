
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection.Emit;
using ZXing;
using ZXing.QrCode.Internal;

namespace QA_Barcode_Generator
{
    public partial class Main : Form
    {


        public int position = 0;



        public Main()
        {
            InitializeComponent();
        }

        private void btnUpcaCode128_Click(object sender, EventArgs e)
        {
            ercUpca1.Visible = true;
            gS1Coupon1.Visible = false;
            userControlType21.Visible = false;
            solutranMallgc1.Visible = false;


            btnUpcaCode128.BackColor = Color.FromArgb(64, 64, 64);
            btnGS1DataExpanded.BackColor = Color.FromArgb(10, 1, 169);
            btnType2.BackColor = Color.FromArgb(10, 1, 169);
            btnSolutranMallGC.BackColor = Color.FromArgb(10, 1, 169);

        }

        private void btnGS1DataExpanded_Click(object sender, EventArgs e)
        {
            ercUpca1.Visible = false;
            gS1Coupon1.Visible = true;
            userControlType21.Visible = false;
            solutranMallgc1.Visible = false;


            btnUpcaCode128.BackColor = Color.FromArgb(10, 1, 169);
            btnGS1DataExpanded.BackColor = Color.FromArgb(64, 64, 64);
            btnType2.BackColor = Color.FromArgb(10, 1, 169);
            btnSolutranMallGC.BackColor = Color.FromArgb(10, 1, 169);
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            ercUpca1.Visible = false;
            gS1Coupon1.Visible = false;
            solutranMallgc1.Visible = false;
            userControlType21.Visible = true;



            btnUpcaCode128.BackColor = Color.FromArgb(10, 1, 169);
            btnGS1DataExpanded.BackColor = Color.FromArgb(10, 1, 169);
            btnSolutranMallGC.BackColor = Color.FromArgb(10, 1, 169);
            btnType2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnSolutranMallGC_Click(object sender, EventArgs e)
        {
            ercUpca1.Visible = false;
            gS1Coupon1.Visible = false;
            userControlType21.Visible = false;
            solutranMallgc1.Visible = true;



            btnUpcaCode128.BackColor = Color.FromArgb(10, 1, 169);
            btnGS1DataExpanded.BackColor = Color.FromArgb(10, 1, 169);
            btnType2.BackColor = Color.FromArgb(10, 1, 169);
            btnSolutranMallGC.BackColor = Color.FromArgb(64, 64, 64);

        }
    }

}
