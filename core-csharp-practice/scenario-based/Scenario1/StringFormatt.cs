using System;
using System.Text;
using System.Collections.Generic;

namespace Scenario
{
    public class StringFormatt
    {
        public static void Main()
        {
            // Object created to call non-static method
            StringFormatt obj = new StringFormatt();

            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // Formatting the input paragraph
            string display = obj.FormatString(paragraph);
            Console.WriteLine(display);
        }

        public string FormatString(string s)
        {
            // StringBuilder is used for efficient string construction
            StringBuilder sb = new StringBuilder();

            // Flag to decide whether the next letter should be capital
            bool checkCapital = true;

            int i = 0;

            // Skipping leading spaces manually (no Trim used)
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            for (; i < s.Length; i++)
            {
                char current = s[i];

                // Capitalizing first letter of sentence
                if (char.IsLetter(current))
                {
                    sb.Append(checkCapital ? char.ToUpper(current) : current);
                    checkCapital = false;
                }
                // Handling sentence-ending punctuation
                else if (current == '.' || current == '!' || current == '?')
                {
                    sb.Append(current);
                    sb.Append(' ');
                    checkCapital = true;

                    // Skipping extra spaces after punctuation
                    while (i + 1 < s.Length && s[i + 1] == ' ')
                    {
                        i++;
                    }
                }
                // Avoiding multiple spaces in output
                else if (current == ' ')
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != ' ')
                    {
                        sb.Append(' ');
                    }
                }
                else
                {
                    sb.Append(current);
                }
            }

            // Removing trailing space 
            if (sb.Length > 0 && sb[sb.Length - 1] == ' ')
            {
                sb.Length--;
            }

            return sb.ToString();
        }
    }
}
