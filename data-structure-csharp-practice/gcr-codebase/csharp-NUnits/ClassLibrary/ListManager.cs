using System.Collections.Generic;

namespace ClassLibrary
{
    public class ListManager
    {
        public void AddElement(List<int> list, int e) => list.Add(e);
        public void RemoveElement(List<int> list, int e) => list.Remove(e);
        public int GetSize(List<int> list) => list.Count;
    }
}
