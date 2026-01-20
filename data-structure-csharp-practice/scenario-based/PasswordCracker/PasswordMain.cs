using System;

namespace PasswordCracker
{
    internal class PasswordMain
    {
        static void Main(string[] args)
        {
            PasswordMenu menu = new PasswordMenu();
            menu.ShowMenu();
        }
    }
}
