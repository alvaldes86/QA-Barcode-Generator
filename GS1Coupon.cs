using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Net.Http;
using Aspose.BarCode.Generation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;




namespace QA_Barcode_Generator
{
    delegate void MyDelegate(string str);

    delegate int MyDelegate2(int a, int b);

    public partial class GS1Coupon : UserControl
    {
        public GS1Coupon()
        {
            InitializeComponent();
        }

        //Use the following Gtin to create a coupon for Milk and Cheerios 811010041415654321312211022210110822100160003241231
        //barcode image is on the working dat folder
        private void btnCreateGs1_Click_1(object sender, EventArgs e)
        {
            pictureboxgs1.Image = null;
            string couponNumber = "";

            if (tbxGS1CompanyPrefix == null || tbxGS1CompanyPrefix.Text == "" || tbxSaveValue == null || tbxSaveValue.Text == ""
                || tbxPrimaryPurchaseReq == null || tbxPrimaryPurchaseReq.Text == "")
            {
                MessageBox.Show("One or more of the fields is empty");
            }
            else
            {

                couponNumber = tbxApplicationIdentifier.Text.ToString().Trim() + "1" + "00" + tbxGS1CompanyPrefix.Text.ToString().Trim() + tbxOfferCode.Text.ToString().Trim() + tbxSaveValue.TextLength.ToString().Trim()
                + tbxSaveValue.Text.ToString().Trim() + "1" + tbxPrimaryPurchaseReq.Text.ToString().Trim() + cbxPrimaryPurchaseReqCode.SelectedIndex.ToString().Trim() + tbxPrimaryPurchaseFamilyCode.Text.ToString().Trim();


                BarcodeGenerator generateBarcode = new BarcodeGenerator(EncodeTypes.DatabarExpanded, "");
                generateBarcode.Parameters.Barcode.DataBar.IsAllowOnlyGS1Encoding = true;
                generateBarcode.CodeText = couponNumber;

                generateBarcode.GenerateBarCodeImage();

                string path = Path.GetTempPath();
                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}

                generateBarcode.Save($"{path}DatabarGS1RightEncoding.png", BarCodeImageFormat.Png);

                pictureboxgs1.ImageLocation = $"{path}DatabarGS1RightEncoding.png";

                tbxGS1Output.Text = couponNumber.ToString();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureboxgs1.Image = null;

              }

        private void GS1Coupon_Load(object sender, EventArgs e)
        {
            pictureboxgs1.Image = null;
        }

        private void tbxGS1CompanyPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(tbxGS1CompanyPrefix.Text.Length > )
            //e.Handled = true;
            //this is a test
        }
    }
}

