using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing.Rendering;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using ZXing.Windows.Compatibility;




namespace QA_Barcode_Generator
{
    public class Barcode : Utilities
    {
        public List<string> Description { get; set; } = new List<string>();

        public List<string> Gtins = new List<string>();

        public List<Bitmap> Barcodes = new List<Bitmap>();

        public Bitmap Type2Bitmap { get; set; }

        public string Type2Gtin { get; set; } = string.Empty;

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public int position = 0;


        public Barcode()
        {
        }

        //*******CORE METHODS**********//
        public void CreateBarcodesUpca(TextBox description, string[] gtins)
        {
            BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>
            {
                Format = BarcodeFormat.UPC_A,
                Options = { Width = (int)Width, Height = (int)Height },
                Renderer = new BitmapRenderer()
            };

            PopulateBarcodesAndDescriptions(description, gtins, writer);

            

        }

        public void CreateBarcodeCode128(TextBox description, string[] gtins)
        {
            BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>
            {
                Format = BarcodeFormat.CODE_128,
                Options = { Width = (int)Width, Height = (int)Height },
                Renderer = new BitmapRenderer()
            };


            for (int i = 0; i < gtins.Length; i++)

            {
                Barcodes.Add(writer.Write(gtins[i]));
                Gtins.Add(gtins[i]);
            }

            if (description != null)
            {
                for (int i = 0; i < description.Lines.Count(); i++)
                {
                    Description.Add(description.Lines[i]);
                }
            }

        }

        public void SaveBarcodes(SaveFileDialog saveFile, string name)
        {
            string saveDirectory = Path.GetDirectoryName(saveFile.FileName);


            // Create the directory if it doesn't exist
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            string filePath = Path.Combine(saveDirectory, $"{SanitizeFileName(name)}.png");

            // Save the barcode image
            Barcodes[0].Save(filePath, ImageFormat.Png);

            
        }

        public void SaveToWord(SaveFileDialog savePath)
        {
            string saveDirectory = "C:\\TEMP\\tempBarcodes";//Path.GetDirectoryName(savePath.FileName) + "\\temp";
            string filePath = null;


            // Create a new Word application and document
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add();

                for (int i = 0; i < Barcodes.Count; i++)
                {

                    // Create the directory if it doesn't exist
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }


                    //create a function in the future to handle this if 
                    if (Description == null || Description.Count == 0)
                    {
                        filePath = Path.Combine(saveDirectory, $"{Gtins[i]}.png");
                    }
                    else
                    {
                        // Construct the full file path
                        filePath = Path.Combine(saveDirectory, $"{SanitizeFileName(Description[i].ToString())}.png");
                    }

                    // Save the barcode image
                    Barcodes[i].Save(filePath, ImageFormat.Png);


                    
                    // Add a paragraph and insert the image
                    Word.Paragraph para = wordDoc.Paragraphs.Add();
                    para.Range.InlineShapes.AddPicture(filePath);
                    para.Range.InsertParagraphAfter();


                    if (Description.Count() != 0)
                    {
                    para.Range.InsertAfter(Description[i]);
                        
                    }


                }


            // Save and close the Word document
            wordDoc.SaveAs2(savePath.FileName, WdSaveFormat.wdFormatXMLDocument);
                wordDoc.Close();
                wordApp.Quit();

            //Can't delete the file because of access
           //File.Delete(saveDirectory);
            
        }

        public void ClearProperties()
        {
            Description.Clear();
            Gtins.Clear();
            Barcodes.Clear();
        }

        public string SanitizeFileName(string fileName)
        {
            foreach(char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }

        public void CreateType2Barcode(string gtin)
        {
            BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>
            {
                Format = BarcodeFormat.UPC_A,
                Options = { Width = (int)Width, Height = (int)Height },
                Renderer = new BitmapRenderer()
            };

            Type2Bitmap = writer.Write(gtin);
        }

        public void SaveType2Barcode(SaveFileDialog saveFile)
        {
            string saveDirectory = Path.GetDirectoryName(saveFile.FileName);
            string filePath = null;


            
                // Create the directory if it doesn't exist
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }
                
                filePath = Path.Combine(saveDirectory, $"{saveFile.FileName}");
                
                // Save the barcode image
                Type2Bitmap.Save(filePath, ImageFormat.Png);


            


        }


        //*******UTILITY METHODS*********//
        public void PopulateBarcodesAndDescriptions(TextBox description, string[] gtins, BarcodeWriter<Bitmap> writer)
        {
            for (int i = 0; i < gtins.Length; i++)

            {
                Barcodes.Add(writer.Write(gtins[i]));
                Gtins.Add(gtins[i]);
            }

            if (description != null)
            {
                for (int i = 0; i < description.Lines.Count(); i++)
                {
                    Description.Add(description.Lines[i]);
                }
            }
        }
    }

}
