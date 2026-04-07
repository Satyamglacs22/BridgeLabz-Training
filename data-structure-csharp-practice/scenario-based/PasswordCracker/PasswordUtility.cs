using System;

namespace PasswordCracker
{
    internal class PasswordUtility : IPassword
    {
        private bool isFound = false;

        // PUBLIC METHOD
        public void CrackPassword(string target, char[] charset, int maxLength)
        {
            // Try increasing lengths: 1 → maxLength
            for (int length = 1; length <= maxLength; length++)
            {
                char[] current = new char[length];
                Backtrack(0, length, current, target, charset);

                if (isFound)
                    return;
            }

            Console.WriteLine("Password not found within given length limit.");
        }

        // BACKTRACKING FUNCTION
        private void Backtrack(int index, int length, char[] current, string target, char[] charset)
        {
            // Pruning: stop if already found
            if (isFound)
                return;

            // Base Case
            if (index == length)
            {
                string attempt = new string(current);
                Console.Write("\rTrying: " + attempt);

                if (attempt.Equals(target))
                {
                    Console.WriteLine(" Password Cracked: " + attempt);
                    isFound = true;
                }
                return;
            }

            // Try all characters
            for (int i = 0; i < charset.Length; i++)
            {
                current[index] = charset[i];
                Backtrack(index + 1, length, current, target, charset);
            }
        }
    }
}
