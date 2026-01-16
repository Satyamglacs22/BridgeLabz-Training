using System;
using System.Collections.Generic;
using System.Text;


namespace BookSelf
{
    public class Library
    {
        private string title;
        private string author;
        private Library next;

        public Library(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.next = null;
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public Library Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
