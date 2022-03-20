using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA
{
    public static class GenerateRandomText
    {
        
        public static string GenerateText(int countSimbols)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string text = "";
            Random rand = new Random();
            for(int i = 0; i < countSimbols; i++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                text += letters[letter_num];
            }

            return text;
        }
    }
}
