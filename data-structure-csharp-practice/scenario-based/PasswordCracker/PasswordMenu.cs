using System;

namespace PasswordCracker
{
    internal class PasswordMenu
    {
        public void ShowMenu()
        {
            PasswordUtility utility = new PasswordUtility();

            Console.Write("Enter target password: ");
            string target = Console.ReadLine();

            Console.Write("Enter allowed characters (e.g. abcABC123): ");
            char[] charset = Console.ReadLine().ToCharArray();

            Console.Write("Enter maximum password length to try: ");
            int maxLength = int.Parse(Console.ReadLine());

            utility.CrackPassword(target, charset, maxLength);
        }
    }
}
