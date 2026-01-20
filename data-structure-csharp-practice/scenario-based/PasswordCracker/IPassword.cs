using System;

namespace PasswordCracker
{
    internal interface IPassword
    {
        void CrackPassword(string target, char[] charset, int maxLength);
    }
}
