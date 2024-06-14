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


        public Main()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            viewSetting1.Visible = true;
            barcodeGenerator1.Visible = false;
        }

        private void barcodeGenerator_Click(object sender, EventArgs e)
        {
            viewSetting1.Visible = false;
            barcodeGenerator1.Visible = true;
        }

        private void barcodeGenerator1_Load(object sender, EventArgs e)
        {

        }
    }

}
