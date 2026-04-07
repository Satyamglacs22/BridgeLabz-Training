using System;

namespace Scenario
{
    public class Paragraph
    {

        public static void Main()
        {
            //Creating object of Paragraph class
            //because all methods are non-static
            Paragraph obj = new Paragraph();

            // Taking paragraph input from the user
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // This flag is used to check whether the paragraph
            // contains at least one non-space character
            bool hasCharacter = false;

            // Loop to scan each character of the paragraph
            for (int i = 0; i < paragraph.Length; i++)
            {
                // If any character is not a space,
                // then paragraph is considered valid
                if (paragraph[i] != ' ')
                {
                    hasCharacter = true;
                    break;
                }
            }

            // If paragraph has no valid characters, exit the program
            if (!hasCharacter)
            {
                Console.WriteLine("Paragraph is empty or contains only spaces.");
                return;
            }

            // This boolean controls the menu loop
            bool check = true;

            // Menu will keep running until user chooses Exit
            while (check)
            {
                // Displaying menu options
                Console.WriteLine("Press 1 to count number of words");
                Console.WriteLine("Press 2 to find longest word");
                Console.WriteLine("Press 3 to replace a word");
                Console.WriteLine("Press 4 to exit");

                // Reading user's choice
                int choice = int.Parse(Console.ReadLine());

                // Switch case to execute user selected operation
                switch (choice)
                {
                    case 1:
                        // Calling CountWords method using object
                        Console.WriteLine("Word Count: " + obj.CountWords(paragraph));
                        break;

                    case 2:
                        // Calling FindLongestWord method using object
                        Console.WriteLine("Longest Word: " + obj.FindLongestWord(paragraph));
                        break;

                    case 3:
                        // Taking the word that needs to be replaced
                        Console.Write("Enter word to replace: ");
                        string oldWord = Console.ReadLine();

                        // Taking the new word from the user
                        Console.Write("Enter new word: ");
                        string newWord = Console.ReadLine();

                        // Replacing the word and updating paragraph
                        paragraph = obj.ReplaceWord(paragraph, oldWord, newWord);

                        // Displaying updated paragraph
                        Console.WriteLine("Updated Paragraph:");
                        Console.WriteLine(paragraph);
                        break;

                    case 4:
                        // Exit option selected
                        Console.WriteLine("Program terminated.");
                        check = false; // Stops the while loop
                        break;

                    default:
                        // Handles invalid menu input
                        Console.WriteLine("Invalid input! Please try again.");
                        break;
                }
            }
        }

        // Method to count number of words in a paragraph
        public int CountWords(string text)
        {
            int count = 0;

            // This flag checks whether we are inside a word
            bool insideWord = false;

            // Loop through each character of the string
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] != ' ' && !insideWord)
                {
                    count++;           // New word found
                    insideWord = true;
                }
                // If space is found, word has ended
                else if (text[i] == ' ')
                {
                    insideWord = false;
                }
            }
            return count;
        }

        // Method to find the longest word in the paragraph
        public string FindLongestWord(string text)
        {
            string longest = "";
            string current = "";

            // Loop through each character of the paragraph
            for (int i = 0; i < text.Length; i++)
            {
                // Build current word character by character
                if (text[i] != ' ')
                {
                    current += text[i];
                }
                else
                {
                    // When space is found, compare word lengths
                    if (current.Length > longest.Length)
                        longest = current;

                    // Reset current word
                    current = "";
                }
            }

            // Final comparison for the last word
            if (current.Length > longest.Length)
                longest = current;

            return longest;
        }

        // Method to replace a word without using Split, Trim or ToLower
        public string ReplaceWord(string text, string oldWord, string newWord)
        {
            string result = "";       // Final updated paragraph
            string currentWord = "";  // Stores one word at a time

            // Loop runs one extra time to process last word
            for (int i = 0; i <= text.Length; i++)
            {
                // Build current word until space is found
                if (i < text.Length && text[i] != ' ')
                {
                    currentWord += text[i];
                }
                else
                {
                    // Compare current word with old word
                    if (WordsEqual(currentWord, oldWord))
                        result += newWord;   // Replace word
                    else
                        result += currentWord;

                    // Add space if not end of string
                    if (i < text.Length)
                        result += " ";

                    // Reset for next word
                    currentWord = "";
                }
            }

            // Remove extra space at the end manually
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        // Method to compare two words ignoring case
        // without using any inbuilt case-conversion method
        public bool WordsEqual(string a, string b)
        {
            // If lengths are different, words cannot be equal
            if (a.Length != b.Length)
                return false;

            // Compare each character using ASCII conversion
            for (int i = 0; i < a.Length; i++)
            {
                char c1 = a[i];
                char c2 = b[i];

                // Convert uppercase to lowercase manually
                if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
                if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

                // If any character does not match, return false
                if (c1 != c2)
                    return false;
            }
            return true;
        }
    }
}
