using System;

namespace BookSelf
{
    internal interface ILibrary
    {
        void AddBook(string genre, string title, string author);
        void RemoveBook(string genre, string title);
        void DisplayLibrary();
    }
}
