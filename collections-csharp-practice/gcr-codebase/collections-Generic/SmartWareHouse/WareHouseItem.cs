using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWarehouse
{
    abstract class WarehouseItem
    {
        private int itemId;
        private string itemName;

        public void SetItemId(int id)
        {
            itemId = id;
        }

        public int GetItemId()
        {
            return itemId;
        }

        public void SetItemName(string name)
        {
            itemName = name;
        }

        public string GetItemName()
        {
            return itemName;
        }

        public abstract void DisplayItem();
    }
}
