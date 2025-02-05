using QA_Barcode_Generator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;

namespace QA_Barcode_Generator
{
    public partial class ErcUpca : UserControl
    {
        public ErcUpca()
        {
            InitializeComponent();
        }


        Barcode UpcaBarcode = new Barcode();
        Barcode Code128Barcode = new Barcode();
        string name = string.Empty;

        /// <summary>
        /// UPC_A section
        /// </summary>
        private void ErcUpca_Load(object sender, EventArgs e)
        {
            UpcaBarcode.Width = widthSelectorUpca.Value;
            UpcaBarcode.Height = heightSelectorUpca.Value;

            Code128Barcode.Width = widthSelectorCode128.Value;
            Code128Barcode.Height = heightSelectorCode128.Value;


        }

        private void btnUpcaCreateBarcode_Click(object sender, EventArgs e)
        {

            string[] gtins = new string[tbxUpcaGtinsInput.Lines.Count()];

            UpcaBarcode.ClearProperties();


            if (tbxUpcaGtinsInput == null || tbxUpcaGtinsInput.Text == "")
            {
                MessageBox.Show("Gtin List is Empty");
            }
            else
            {
                for (int i = 0; i < tbxUpcaGtinsInput.Lines.Count(); i++)
                {

                    string line = tbxUpcaGtinsInput.Lines[i].TrimStart('0');
                    bool success = long.TryParse(line, out long lineRead);

                    if (success)
                    {
                        if (line.Length > 11)
                        {
                            MessageBox.Show("Please enter a 11 digit number");
                            return;
                        }
                        else
                        {
                            int paddingLength = 11 - line.Length;
                            string paddedGtin = new string('0', paddingLength) + lineRead;

                            gtins[i] = (paddedGtin);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid entry. Gtin list contains an  entry that is not a number");
                        return;
                    }

                }


                UpcaBarcode.CreateBarcodesUpca(tbxUpcaDescription, gtins);

                pictureBoxUpca.Image = UpcaBarcode.Barcodes[0];
            }


            //string upcCode = "004141500163"; //"012345678905"; //Example UPC-A code
            //Bitmap bitmap = new Bitmap(250, 150);
            //using (Graphics graphics = Graphics.FromImage(bitmap))
            //{

            //    graphics.FillRectangle(Brushes.White, 0, 0, bitmap.Width, bitmap.Height);

            //    int x = 10;
            //    int y = 10;
            //    int barWidth = 2;
            //    int barHeight = 100;

            //    // Draw the left guard bars
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, false);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);
            //    x += barWidth;

            //    // Draw the left half of the barcode
            //    for (int i = 0; i < 6; i++)
            //    {
            //        UPC_A.DrawDigit(graphics, x, y, barWidth, barHeight, upcCode[i] - '0', true);
            //        x += 7 * barWidth;
            //    }

            //    // Draw the center guard bars
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, false);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, false);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, false);
            //    x += barWidth;

            //    // Draw the right half of the barcode
            //    for (int i = 6; i < 12; i++)
            //    {
            //        UPC_A.DrawDigit(graphics, x, y, barWidth, barHeight, upcCode[i] - '0', false);
            //        x += 7 * barWidth;
            //    }

            //    // Draw the right guard bars
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, false);
            //    x += barWidth;
            //    UPC_A.DrawBar(graphics, x, y, barWidth, barHeight, true);


            //    pictureBoxUpca.Image = bitmap;
            //    // bitmap.Save("upc-a-barcode.png", System.Drawing.Imaging.ImageFormat.Png);
            //    Console.WriteLine("UPC-A barcode generated successfully!");


        }

        private void btnUpcaClear_Click(object sender, EventArgs e)
        {
            pictureBoxUpca.Image = null;
            tbxUpcaGtinsInput.Clear();
            tbxUpcaDescription.Clear();
            widthSelectorUpca.Value = 285;
            heightSelectorUpca.Value = 150;
        }

        private void widthSelectorUpca_ValueChanged(object sender, EventArgs e)
        {
            if (widthSelectorUpca.Value != UpcaBarcode.Width)
            {
                UpcaBarcode.Width = widthSelectorUpca.Value;
                pictureBoxUpca.Image = null;

            }
        }

        private void heightSelectorUpca_ValueChanged(object sender, EventArgs e)
        {
            if (heightSelectorUpca.Value != UpcaBarcode.Height)
            {
                UpcaBarcode.Height = heightSelectorUpca.Value;
                pictureBoxUpca.Image = null;

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            UpcaBarcode.position++;
            if (UpcaBarcode.Barcodes.Count() == 0)
            {
                pictureBoxUpca.Image = null;
            }
            else if (UpcaBarcode.position >= UpcaBarcode.Barcodes.Count())
            {
                UpcaBarcode.position = UpcaBarcode.Barcodes.Count() - 1;

                pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];
            }
            else
            {
                pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];

            }



        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (UpcaBarcode.position <= 0 || UpcaBarcode.Barcodes.Count() == 0)
            {
                UpcaBarcode.position = 0;
            }
            else
            {
                UpcaBarcode.position--;

                pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];
            }
        }

        private void btnUpcaSave_Click(object sender, EventArgs e)
        {

            if (pictureBoxUpca.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (UpcaBarcode.Description.Count() == 0)
                {
                    saveFile.FileName = UpcaBarcode.Gtins[0].ToString();
                    name = UpcaBarcode.Gtins[0].ToString();
                }
                else
                {
                    saveFile.FileName = UpcaBarcode.Description[0].ToString();
                    name = UpcaBarcode.Description[0].ToString();
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    saveFile.Filter = "Jpeg Image | *.jpg";
                    UpcaBarcode.SaveBarcodes(saveFile, name);

                    MessageBox.Show("Only the first barcode was saved. Use Save to Word if you want to save multiple barcodes");
                }

            }



        }

        private void tbxUpcaGtinsInput_TextChanged(object sender, EventArgs e)
        {
            lblCountGtins.Text = "Count: " + tbxUpcaGtinsInput.Lines.Count().ToString();
        }

        private void tbxUpcaDescription_TextChanged(object sender, EventArgs e)
        {
            lblCountDescription.Text = $"Count: {tbxUpcaDescription.Lines.Count().ToString()}";

        }

        private void btnUpcaSaveToWord_Click(object sender, EventArgs e)
        {
            saveFile.FileName = "Barcode list";
            saveFile.Filter = "Word Documents (*.docx)|*.docx|Word 97-2003 Documents (*.doc)|*.doc";

            if (pictureBoxUpca.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    UpcaBarcode.SaveToWord(saveFile);
                }
            }
        }

        /// <summary>
        /// Code 128 section
        /// </summary>
        private void btnCode128CreateBarcode_Click(object sender, EventArgs e)
        {
            string[] gtins = new string[tbxGtinsCode128.Lines.Count()];

            Code128Barcode.ClearProperties();


            if (tbxGtinsCode128 == null || tbxGtinsCode128.Text == "")
            {
                MessageBox.Show("Gtin List is Empty");
            }
            else
            {
                for (int i = 0; i < tbxGtinsCode128.Lines.Count(); i++)
                {

                    string line = tbxGtinsCode128.Lines[i].TrimStart('0');
                    bool success = long.TryParse(line, out long lineRead);

                    if (success)
                    {
                        if (line.Length < 19 || line.Length > 19)

                        {
                            MessageBox.Show("Please enter a number with 19 digits");
                            return;
                        }
                        else
                        {
                            int paddingLength = 19 - line.Length;
                            string paddedGtin = new string('0', paddingLength) + lineRead;

                            gtins[i] = (paddedGtin);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid entry. Gtin list contains an  entry that is not a number");
                        return;
                    }

                }

                //****This is for Mall GCs
                //for (int i = 0; i < tbxGtinsCode128.Lines.Count(); i++)
                //{
                //    string line = "0" + tbxGtinsCode128.Lines[i];//.TrimStart('0');
                //    //bool success = long.TryParse(line, out long lineRead);
                //    //int paddingLength = 19 - line.Length;
                //    //string paddedGtin = new string('0', paddingLength) + lineRead;

                //    gtins[i] = (line);
                //}
                //double mallNumber = 076750019550006036598839719136;
                //string prefix = "07675001955";
                //string middle = "000603659883971";
                //for (int i = 0; i < 100; i++)
                //{
                //    string counter = i.ToString("D4");
                //    string finalLine = prefix + middle + counter;
                //    gtins[i] = (finalLine);
                //}


                Code128Barcode.CreateBarcodeCode128(tbxCode128Description, gtins);

                pictureBoxCode128.Image = Code128Barcode.Barcodes[0];


            }

        }

        private void btnCode128Clear_Click(object sender, EventArgs e)
        {
            pictureBoxCode128.Image = null;
            tbxGtinsCode128.Clear();
            tbxCode128Description.Clear();
            widthSelectorCode128.Value = 360;
            heightSelectorCode128.Value = 150;
        }

        private void btnNextCode128_Click(object sender, EventArgs e)
        {
            Code128Barcode.position++;
            if (Code128Barcode.Barcodes.Count() == 0)
            {
                pictureBoxCode128.Image = null;
            }
            else if (Code128Barcode.position >= Code128Barcode.Barcodes.Count())
            {
                Code128Barcode.position = Code128Barcode.Barcodes.Count() - 1;

                pictureBoxCode128.Image = Code128Barcode.Barcodes[Code128Barcode.position];
            }
            else
            {
                pictureBoxCode128.Image = Code128Barcode.Barcodes[Code128Barcode.position];

            }
        }

        private void btnPreviousCode128_Click(object sender, EventArgs e)
        {
            if (Code128Barcode.position <= 0)
            {
                Code128Barcode.position = 0;
            }
            else
            {
                Code128Barcode.position--;
            }
            pictureBoxCode128.Image = Code128Barcode.Barcodes[Code128Barcode.position];
        }

        private void widthSelectorCode128_ValueChanged(object sender, EventArgs e)
        {
            if (widthSelectorCode128.Value != Code128Barcode.Width)
            {
                Code128Barcode.Width = widthSelectorCode128.Value;
                pictureBoxCode128.Image = null;

            }
        }

        private void heightSelectorCode128_ValueChanged(object sender, EventArgs e)
        {
            if (heightSelectorCode128.Value != Code128Barcode.Height)
            {
                Code128Barcode.Height = heightSelectorCode128.Value;
                pictureBoxCode128.Image = null;

            }
        }

        private void btnCodeSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxCode128.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    saveFile.Filter = "Jpeg Image | *.jpg";
                    Code128Barcode.SaveBarcodes(saveFile, name);
                }
            }
        }

        private void tbxGtinsCode128_TextChanged(object sender, EventArgs e)
        {
            lblCountCode128Gtins.Text = "Count: " + tbxGtinsCode128.Lines.Count().ToString();
        }

        private void tbxCode128Description_TextChanged(object sender, EventArgs e)
        {
            lblCountCode128Description.Text = "Count: " + tbxCode128Description.Lines.Count().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCode128SaveToWord_Click(object sender, EventArgs e)
        {
            saveFile.FileName = "Barcode list";
            saveFile.Filter = "Word Documents (*.docx)|*.docx|Word 97-2003 Documents (*.doc)|*.doc";

            if (pictureBoxCode128.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Code128Barcode.SaveToWord(saveFile);
                }
            }
        }
    }
}
