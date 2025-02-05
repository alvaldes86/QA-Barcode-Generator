using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Barcode_Generator
{
    public class Utilities
    {

        public string Name { get; set; }
        public string Description { get; set; }


        public Utilities()
        {
            
        }

        public void assignFileName(Barcode barcode, SaveFileDialog saveFile)
        {
            saveFile.Filter = "Jpeg Image | *.jpg";
            if (barcode.Description.Count() == 0)
            {
                saveFile.FileName = barcode.Gtins[0].ToString();
                Name = barcode.Gtins[0].ToString();
            }
            else
            {
                saveFile.FileName = barcode.Description[0].ToString();
                Name = barcode.Description[0].ToString();
            }

            
        }


    }
}
