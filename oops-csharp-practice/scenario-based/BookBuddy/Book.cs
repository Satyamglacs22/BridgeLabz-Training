using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy
{
    internal class Book
    {
        private string authorName;
        private string bookName;
        //public Book(string bookName, string authorName)
        //{
        //    this.bookName = bookName;
        //    this.authorName = authorName;
        //}

        public string AuthorName
        {
            get
            {
                return authorName;
            }
            set
            {
                authorName = value;
            }

            
        }
        public string BookName
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }
        //public override string ToString()
        //{
        //    return bookName + "-" + authorName;
        //}
    }
}
