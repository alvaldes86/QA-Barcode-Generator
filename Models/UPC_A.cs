using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Barcode_Generator.Models
{
    internal static class UPC_A
    {
        //*******For learning to draw the barcode
        private static readonly string[] UPC_A_PATTERNS = {
        "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"
         };

        public static void DrawDigit(Graphics graphics, int x, int y, int barWidth, int barHeight, int digit, bool leftSide)
        {
            string pattern = UPC_A_PATTERNS[digit];
            if (!leftSide)
            {
                pattern = InvertPattern(pattern);
            }

            foreach (char c in pattern)
            {
                bool isBar = c == '1';
                DrawBar(graphics, x, y, barWidth, barHeight, isBar);
                x += barWidth;
            }
        }

        public static void DrawBar(Graphics graphics, int x, int y, int barWidth, int barHeight, bool isBar)
        {
            Brush brush = isBar ? Brushes.Black : Brushes.White;
            graphics.FillRectangle(brush, x, y, barWidth, barHeight);
        }

        private static string InvertPattern(string pattern)
        {
            char[] inverted = new char[pattern.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                inverted[i] = pattern[i] == '1' ? '0' : '1';
            }
            return new string(inverted);
        }
    }
}
