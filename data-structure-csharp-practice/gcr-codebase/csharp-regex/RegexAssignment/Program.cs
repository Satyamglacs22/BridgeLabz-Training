using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidateUsername();
            ValidateLicensePlate();
            ValidateHexColor();
            ExtractEmails();
            ExtractCapitalizedWords();
            ExtractDates();
            ExtractLinks();
            ReplaceMultipleSpaces();
            CensorBadWords();
            ValidateIPAddress();
            ValidateCreditCard();
            ExtractProgrammingLanguages();
            ExtractCurrencyValues();
            FindRepeatingWords();
            ValidateSSN();
        }

        // 1. Validate Username
        static void ValidateUsername()
        {
            string username = "user_123";
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            Console.WriteLine("1. Username Valid: " + Regex.IsMatch(username, pattern));
        }

        // 2. Validate License Plate
        static void ValidateLicensePlate()
        {
            string plate = "AB1234";
            string pattern = @"^[A-Z]{2}\d{4}$";

            Console.WriteLine("2. License Plate Valid: " + Regex.IsMatch(plate, pattern));
        }

        // 3. Validate Hex Color Code
        static void ValidateHexColor()
        {
            string color = "#FFA500";
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            Console.WriteLine("3. Hex Color Valid: " + Regex.IsMatch(color, pattern));
        }

        // 4. Extract Emails
        static void ExtractEmails()
        {
            string text = "Contact us at support@example.com and info@company.org";
            string pattern = @"[\w\.-]+@[\w\.-]+\.\w+";

            Console.WriteLine("4. Emails:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }

        // 5. Extract Capitalized Words
        static void ExtractCapitalizedWords()
        {
            string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            string pattern = @"\b[A-Z][a-z]*\b";

            Console.WriteLine("5. Capitalized Words:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }

        // 6. Extract Dates
        static void ExtractDates()
        {
            string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            Console.WriteLine("6. Dates:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }

        // 7. Extract Links
        static void ExtractLinks()
        {
            string text = "Visit https://www.google.com and http://example.org for more info.";
            string pattern = @"https?://\S+";

            Console.WriteLine("7. Links:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }

        // 8. Replace Multiple Spaces
        static void ReplaceMultipleSpaces()
        {
            string text = "This   is    an example   with   multiple spaces.";
            string result = Regex.Replace(text, @"\s+", " ");

            Console.WriteLine("8. After Space Replace:");
            Console.WriteLine(result);
        }

        // 9. Censor Bad Words
        static void CensorBadWords()
        {
            string text = "This is a damn bad example with some stupid words.";
            string pattern = @"\b(damn|stupid)\b";

            string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

            Console.WriteLine("9. Censored Text:");
            Console.WriteLine(result);
        }

        // 10. Validate IP Address
        static void ValidateIPAddress()
        {
            string ip = "192.168.1.1";
            string pattern = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

            Console.WriteLine("10. IP Valid: " + Regex.IsMatch(ip, pattern));
        }

        // 11. Validate Credit Card
        static void ValidateCreditCard()
        {
            string visa = "4123456789012345";
            string master = "5123456789012345";

            string visaPattern = @"^4\d{15}$";
            string masterPattern = @"^5\d{15}$";

            Console.WriteLine("11. Visa Valid: " + Regex.IsMatch(visa, visaPattern));
            Console.WriteLine("11. MasterCard Valid: " + Regex.IsMatch(master, masterPattern));
        }

        // 12. Extract Programming Languages
        static void ExtractProgrammingLanguages()
        {
            string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            string pattern = @"\b(Java|Python|JavaScript|Go)\b";

            Console.WriteLine("12. Programming Languages:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }

        // 13. Extract Currency Values
        static void ExtractCurrencyValues()
        {
            string text = "The price is $45.99, and the discount is $ 10.50.";
            string pattern = @"\$?\s?\d+\.\d{2}";

            Console.WriteLine("13. Currency Values:");
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value.Trim());
            }
        }

        // 14. Find Repeating Words
        static void FindRepeatingWords()
        {
            string text = "This is is a repeated repeated word test.";
            string pattern = @"\b(\w+)\s+\1\b";

            Console.WriteLine("14. Repeating Words:");
            foreach (Match m in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine(m.Groups[1].Value);
            }
        }

        // 15. Validate SSN
        static void ValidateSSN()
        {
            string ssn = "123-45-6789";
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            Console.WriteLine("15. SSN Valid: " + Regex.IsMatch(ssn, pattern));
        }
    }
}
