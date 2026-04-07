using System;
using System.Collections.Generic;
using System.Text;

namespace The_History_Manager
{
    internal class Manager
    {
        private string url;
        private Manager previous;
        private Manager next;

        public Manager(string url)
        {
            this.url = url;
            this.previous = null;
            this.next = null;
        }

        public string GetUrl()
        {
            return url;
        }

        public void SetUrl(string url)
        {
            this.url = url;
        }

        public Manager GetPrevious()
        {
            return previous;
        }

        public void SetPrevious(Manager previous)
        {
            this.previous = previous;
        }

        public Manager GetNext()
        {
            return next;
        }

        public void SetNext(Manager next)
        {
            this.next = next;
        }
    }
}
