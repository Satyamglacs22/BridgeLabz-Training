using System;
using System.Collections.Generic;
using System.Text;

namespace The_History_Manager
{
    internal interface IManager
    {
        void VisitPage(string url);
        void GoBack();
        void GoForward();
        void CloseTab();
        void RestoreTab();
        void ShowCurrentPage();
    }
}
