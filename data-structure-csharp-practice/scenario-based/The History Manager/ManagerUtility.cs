using System;
using System.Collections.Generic;
using System.Text;

namespace The_History_Manager
{
    internal class ManagerUtility : IManager
    {
        private Manager current;
        private Stack<Manager> closedTabs;

        public ManagerUtility()
        {
            current = null;
            closedTabs = new Stack<Manager>();
        }

        public void VisitPage(string url)
        {
            Manager newPage = new Manager(url);

            if (current != null)
            {
                current.SetNext(null);
                newPage.SetPrevious(current);
                current.SetNext(newPage);
            }

            current = newPage;
            Console.WriteLine("Visited Page: " + url);
        }

        public void GoBack()
        {
            if (current != null && current.GetPrevious() != null)
            {
                current = current.GetPrevious();
                Console.WriteLine("Back to: " + current.GetUrl());
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void GoForward()
        {
            if (current != null && current.GetNext() != null)
            {
                current = current.GetNext();
                Console.WriteLine("Forward to: " + current.GetUrl());
            }
            else
            {
                Console.WriteLine("No next page.");
            }
        }

        public void CloseTab()
        {
            if (current == null)
            {
                Console.WriteLine("No tab to close.");
                return;
            }

            closedTabs.Push(current);
            Console.WriteLine("Closed Tab: " + current.GetUrl());

            if (current.GetPrevious() != null)
                current = current.GetPrevious();
            else
                current = null;
        }

        public void RestoreTab()
        {
            if (closedTabs.Count == 0)
            {
                Console.WriteLine("No closed tabs available.");
                return;
            }

            current = closedTabs.Pop();
            Console.WriteLine("Restored Tab: " + current.GetUrl());
        }

        public void ShowCurrentPage()
        {
            if (current != null)
                Console.WriteLine("Current Page: " + current.GetUrl());
            else
                Console.WriteLine("No active page.");
        }
    }
}
