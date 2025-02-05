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
    public partial class SolutranMallGC : UserControl
    {
        public SolutranMallGC()
        {
            InitializeComponent();
        }

        Barcode solutranMallGC = new Barcode();
        string name = string.Empty;


        private void SolutranMallGC_Load(object sender, EventArgs e)
        {
            solutranMallGC.Width = widthSelectorSolutran.Value;
            solutranMallGC.Height = heightSelectorSolutran.Value;
        }

        private void btnSolutranCreateBarcode_Click(object sender, EventArgs e)
        {
            string[] gtins = new string[tbxGtinsSolutran.Lines.Count()];

            solutranMallGC.ClearProperties();


            if (tbxGtinsSolutran == null || tbxGtinsSolutran.Text == "")
            {
                MessageBox.Show("Gtin List is Empty");
            }
            else
            {
                for (int i = 0; i < tbxGtinsSolutran.Lines.Count(); i++)
                {

                    string line = tbxGtinsSolutran.Lines[i].TrimStart('0').Trim();
                    bool success = long.TryParse(line, out long lineRead);

                    if (success)
                    {
                        if (line.Length < 17 || line.Length > 17)
                        {

                            MessageBox.Show("Please enter a 17 digit number");
                            return;
                        }
                        else
                        {
                            gtins[i] = (lineRead.ToString());
                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid entry. Gtin list contains an entry that is not a number");
                        return;
                    }

                }

                solutranMallGC.CreateBarcodeCode128(tbxSolutranDescription, gtins);

                pictureBoxSolutran.Image = solutranMallGC.Barcodes[0];
            }

        }

        private void btnNextSolutran_Click(object sender, EventArgs e)
        {
            solutranMallGC.position++;
            if (solutranMallGC.Barcodes.Count() == 0)
            {
                pictureBoxSolutran.Image = null;
            }
            else if (solutranMallGC.position >= solutranMallGC.Barcodes.Count())
            {
                solutranMallGC.position = solutranMallGC.Barcodes.Count() - 1;

                pictureBoxSolutran.Image = solutranMallGC.Barcodes[solutranMallGC.position];
            }
            else
            {
                pictureBoxSolutran.Image = solutranMallGC.Barcodes[solutranMallGC.position];

            }
        }

        private void btnPreviousSolutran_Click(object sender, EventArgs e)
        {
            if (solutranMallGC.position <= 0 || solutranMallGC.Barcodes.Count() == 0)
            {
                solutranMallGC.position = 0;
            }
            else
            {
                solutranMallGC.position--;

                pictureBoxSolutran.Image = solutranMallGC.Barcodes[solutranMallGC.position];
            }
        }

        private void btnSolutranClear_Click(object sender, EventArgs e)
        {
            pictureBoxSolutran.Image = null;
            tbxGtinsSolutran.Clear();
            tbxSolutranDescription.Clear();
            widthSelectorSolutran.Value = 285;
            heightSelectorSolutran.Value = 150;
        }

        private void btnSolutranSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxSolutran.Image == null)
            {
                MessageBox.Show("There are no barcodes created");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    solutranMallGC.SaveBarcodes(saveFile, name);
                }
            }
        }

        


        ///// <summary>
        ///// UPC_A section
        ///// </summary>
        //private void ErcUpca_Load(object sender, EventArgs e)
        //{
        //    UpcaBarcode.Width = widthSelectorUpca.Value;
        //    UpcaBarcode.Height = heightSelectorUpca.Value;

        //    Code128Barcode.Width = widthSelectorCode128.Value;
        //    Code128Barcode.Height = heightSelectorCode128.Value;


        //}


        ////*******For learning to draw the barcode
        ////private static readonly string[] UPC_A_PATTERNS = {
        ////"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"
        //// };

        ////private static void DrawDigit(Graphics graphics, int x, int y, int barWidth, int barHeight, int digit, bool leftSide)
        ////{
        ////    string pattern = UPC_A_PATTERNS[digit];
        ////    if (!leftSide)
        ////    {
        ////        pattern = InvertPattern(pattern);
        ////    }

        ////    foreach (char c in pattern)
        ////    {
        ////        bool isBar = c == '1';
        ////        DrawBar(graphics, x, y, barWidth, barHeight, isBar);
        ////        x += barWidth;
        ////    }
        ////}

        ////private static void DrawBar(Graphics graphics, int x, int y, int barWidth, int barHeight, bool isBar)
        ////{
        ////    Brush brush = isBar ? Brushes.Black : Brushes.White;
        ////    graphics.FillRectangle(brush, x, y, barWidth, barHeight);
        ////}

        ////private static string InvertPattern(string pattern)
        ////{
        ////    char[] inverted = new char[pattern.Length];
        ////    for (int i = 0; i < pattern.Length; i++)
        ////    {
        ////        inverted[i] = pattern[i] == '1' ? '0' : '1';
        ////    }
        ////    return new string(inverted);
        ////}


        ////***** end of learning to draw barcode

        //private void btnUpcaClear_Click(object sender, EventArgs e)
        //{
        //    pictureBoxUpca.Image = null;
        //    tbxUpcaGtinsInput.Clear();
        //    tbxUpcaDescription.Clear();
        //    widthSelectorUpca.Value = 285;
        //    heightSelectorUpca.Value = 150;
        //}

        //private void widthSelectorUpca_ValueChanged(object sender, EventArgs e)
        //{
        //    if (widthSelectorUpca.Value != UpcaBarcode.Width)
        //    {
        //        UpcaBarcode.Width = widthSelectorUpca.Value;
        //        pictureBoxUpca.Image = null;

        //    }
        //}

        //private void heightSelectorUpca_ValueChanged(object sender, EventArgs e)
        //{
        //    if (heightSelectorUpca.Value != UpcaBarcode.Height)
        //    {
        //        UpcaBarcode.Height = heightSelectorUpca.Value;
        //        pictureBoxUpca.Image = null;

        //    }
        //}

        //private void btnNext_Click(object sender, EventArgs e)
        //{

        //    UpcaBarcode.position++;
        //    if (UpcaBarcode.Barcodes.Count() == 0)
        //    {
        //        pictureBoxUpca.Image = null;
        //    }
        //    else if (UpcaBarcode.position >= UpcaBarcode.Barcodes.Count())
        //    {
        //        UpcaBarcode.position = UpcaBarcode.Barcodes.Count() - 1;

        //        pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];
        //    }
        //    else
        //    {
        //        pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];

        //    }



        //}

        //private void btnPrevious_Click(object sender, EventArgs e)
        //{
        //    if (UpcaBarcode.position <= 0 || UpcaBarcode.Barcodes.Count() == 0)
        //    {
        //        UpcaBarcode.position = 0;
        //    }
        //    else
        //    {
        //        UpcaBarcode.position--;

        //        pictureBoxUpca.Image = UpcaBarcode.Barcodes[UpcaBarcode.position];
        //    }
        //}

        //private void btnUpcaSave_Click(object sender, EventArgs e)
        //{
        //    if (pictureBoxUpca.Image == null)
        //    {
        //        MessageBox.Show("There are no barcodes created");
        //    }
        //    else
        //    {
        //        if (saveFile.ShowDialog() == DialogResult.OK)
        //        {
        //            UpcaBarcode.SaveBarcodes(saveFile);
        //        }
        //    }
        //}

        //private void tbxUpcaGtinsInput_TextChanged(object sender, EventArgs e)
        //{
        //    lblCountGtins.Text = "Count: " + tbxUpcaGtinsInput.Lines.Count().ToString();
        //}

        //private void tbxUpcaDescription_TextChanged(object sender, EventArgs e)
        //{
        //    lblCountDescription.Text = $"Count: {tbxUpcaDescription.Lines.Count().ToString()}";
        //}

        //private void btnUpcaSaveToWord_Click(object sender, EventArgs e)
        //{


        //    if (pictureBoxUpca.Image == null)
        //    {
        //        MessageBox.Show("There are no barcodes created");
        //    }
        //    else
        //    {
        //        if (saveFile.ShowDialog() == DialogResult.OK)
        //        {
        //            UpcaBarcode.SaveToWord(saveFile);
        //        }
        //    }
        //}

    }
}
