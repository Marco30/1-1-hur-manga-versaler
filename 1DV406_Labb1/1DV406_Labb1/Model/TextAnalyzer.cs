using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1DV406_Labb1.Model
{
    public class TextAnalyzer
    {
        public static int Versaler(string text)
        {
            int UpperCase = 0;

            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                {
                    UpperCase++;
                }
            }
            return UpperCase;
        }
    }
}