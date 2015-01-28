using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1DV406_Labb1.Model
{
    public class TextAnalyzer
    {
        public static int Versaler(string text)// Funktion som tar i mot en string variabel med  text 
        {
            int UpperCase = 0;//

            foreach (char c in text)//Löper igenom texten 
            {
                if (Char.IsUpper(c))// kontrollerar om bokstav i text är versal 
                {
                    UpperCase++;
                }
            }
            return UpperCase;// Returnerar antal versaler 
        }
    }
}