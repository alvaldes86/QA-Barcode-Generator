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
    public partial class BarcodeGenerator : UserControl
    {
        public string[] Gtins { get; set; }

        string savedFilePath = "C:\\Users\\p1268221\\Documents\\Code\\Current Learning\\Projects\\QA Barcode Generator\\Barcodes Generated\\";

        Bitmap barcode;

        List<Bitmap> barcodes = new List<Bitmap>();

        int position = 0;

        public BarcodeGenerator()
        {
            InitializeComponent();
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxUserInput.Clear();
            pictureBoxBarcodeCreated.Image = null;
            Gtins = null;
            barcodes.Clear();
        }


        private void btnCreateBarcode_Click(object sender, EventArgs e)
        {  
            Gtins = new string[tbxUserInput.Lines.Count()];

            for (int i = 0; i < tbxUserInput.Lines.Count(); i++)
            {
                string lineRead = tbxUserInput.Lines[i].Trim().TrimStart('0'); 
                if(lineRead.Length >= 12)
                {
                    MessageBox.Show("Please enter only 11 digits number.");
                }
                else
                {
                    int paddingLength = 11 - lineRead.Length;
                    string paddedLine = new string('0', paddingLength) + lineRead;
                    Gtins[i] = paddedLine;
                }
                
            }


            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.UPC_A,
                Options = { Width = 250, Height = 190 }
            };

            for (int i = 0; i < Gtins.Length; i++)
            {
                barcode = writer.Write(Gtins[i]);               
                barcodes.Add(writer.Write(Gtins[i]));
                //barcode.Save($"{savedFilePath}\\{i}.png", ImageFormat.Png);
            }

            
            pictureBoxBarcodeCreated.Image = barcodes[position];
            

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
          
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < Gtins.Length; i++)
                {
                    saveFile.Title = $"{i.ToString()}";
                    barcode.Save($"{saveFile.FileName}\\{i.ToString()}.png", ImageFormat.Png);
                }
                
            }
        }




        
        private void btnNext_Click(object sender, EventArgs e)
        {
            position++;
            if (position >= barcodes.Count)
            {
                position = barcodes.Count -1;
            }
            pictureBoxBarcodeCreated.Image = barcodes[position];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            position--;
            if (position < 0)
            {
                position = 0;
            }
            pictureBoxBarcodeCreated.Image = barcodes[position];
        }
    }
}
