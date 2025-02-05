using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_Barcode_Generator
{
    public partial class UserControlType2 : UserControl
    {
        public UserControlType2()
        {
            InitializeComponent();
        }
        Barcode barcode = new Barcode();

        private void UserControlType2_Load(object sender, EventArgs e)
        {
            barcode.Width = widthSelectorType2.Value;
            barcode.Height = heightSelectorType2.Value;
        }

        private void btnUpcaCreateBarcode_Click(object sender, EventArgs e)
        {
            pictureBoxType2.Image = null;

            string manualPriceGtin = tbxManualPriceGtin.Text.TrimStart('0');

            if (manualPriceGtin.Length == 11)
            {
                if (tbxPrice.Text.Length == 4)
                {
                    string manufacturerSection = manualPriceGtin.Substring(0, 6);
                    string checkDigit = "0";

                    tbxEmbeddedPriceGtin.Text = manufacturerSection + calculateCheckDigit(tbxPrice) + tbxPrice.Text;

                    barcode.CreateType2Barcode(tbxEmbeddedPriceGtin.Text);

                    pictureBoxType2.Image = barcode.Type2Bitmap;
                }
                else
                {

                    MessageBox.Show("Please enter a 4 digit for the price");
                }
            }
            else
            {
                MessageBox.Show("Please check you input. Manual price Gtin must be 11 digits long and price must be 4 digits long");

            }


        }



        public string calculateCheckDigit(TextBox price)
        {


            string digit1 = price.Text[0].ToString();
            string digit2 = price.Text[1].ToString();
            string digit3 = price.Text[2].ToString();
            string digit4 = price.Text[3].ToString();

            int[] digits = new int[4];

            Dictionary<string, int> weightingFactor2 = new Dictionary<string, int>
                {
                    {"0", 0 },
                    {"1", 2},
                    {"2", 4},
                    {"3", 6},
                    {"4", 8},
                    {"5", 9},
                    {"6", 1},
                    {"7", 3},
                    {"8", 5},
                    {"9", 7},
                };

            Dictionary<string, int> weightingFactor3 = new Dictionary<string, int>
                {
                    {"0", 0},
                    {"1", 3},
                    {"2", 6},
                    {"3", 9},
                    {"4", 2},
                    {"5", 5},
                    {"6", 8},
                    {"7", 1},
                    {"8", 4},
                    {"9", 7},
                };

            Dictionary<string, int> weightingFactor5 = new Dictionary<string, int>
                {
                    {"0", 0},
                    {"1", 5},
                    {"2", 9},
                    {"3", 4},
                    {"4", 8},
                    {"5", 3},
                    {"6", 7},
                    {"7", 2},
                    {"8", 6},
                    {"9", 1},
                };

            if (weightingFactor2.TryGetValue(digit1, out int factor2))
            {
                digits[0] = factor2;
            }

            if (weightingFactor2.TryGetValue(digit2, out int factor22))
            {
                digits[1] = factor22;
            }

            if (weightingFactor3.TryGetValue(digit3, out int factor3))
            {
                digits[2] = factor3;
            }

            if (weightingFactor5.TryGetValue(digit4, out int factor5))
            {
                digits[3] = factor5;
            }


            int total = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                total += digits[i];
            }

            total = total * 3;
            string checkDigit = total.ToString().Substring(1);

            return checkDigit;

        }

        private void btnUpcaSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxType2.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    barcode.SaveType2Barcode(saveFile);
                }
            }
        }

        private void btnUpcaClear_Click(object sender, EventArgs e)
        {
            pictureBoxType2.Image = null;
            barcode.Type2Bitmap = null;
            tbxEmbeddedPriceGtin.Clear();
            tbxManualPriceGtin.Clear();
            tbxPrice.Clear();
        }

        private void widthSelectorType2_ValueChanged(object sender, EventArgs e)
        {
            if (widthSelectorType2.Value != barcode.Width)
            {
                barcode.Width = widthSelectorType2.Value;
                pictureBoxType2.Image = null;

            }
        }

        private void heightSelectorType2_ValueChanged(object sender, EventArgs e)
        {
            if (heightSelectorType2.Value != barcode.Height)
            {
                barcode.Height = heightSelectorType2.Value;
                pictureBoxType2.Image = null;

            }
        }

        
    }
}
