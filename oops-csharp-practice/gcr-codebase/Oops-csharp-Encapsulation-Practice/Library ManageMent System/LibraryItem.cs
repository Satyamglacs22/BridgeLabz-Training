using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Library_ManageMent_System
{
    

    public abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        public int ItemId
        {
            get { return itemId; }
            set
            {
                if (value > 0)
                    itemId = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    author = value;
            }
        }

        // Abstract method
        public abstract int GetLoanDuration();

        // Concrete method
        public void GetItemDetails()
        {
            Console.WriteLine("Item ID   : " + ItemId);
            Console.WriteLine("Title     : " + Title);
            Console.WriteLine("Author    : " + Author);
            Console.WriteLine("Loan Days : " + GetLoanDuration());
        }
    }


}
