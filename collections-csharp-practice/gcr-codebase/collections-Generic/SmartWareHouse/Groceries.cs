using System;

namespace SmartWarehouse
{
    class Groceries : WarehouseItem
    {
        private string expiryDate;

        public void SetExpiryDate(string date)
        {
            expiryDate = date;
        }

        public string GetExpiryDate()
        {
            return expiryDate;
        }

        public override void DisplayItem()
        {
            Console.WriteLine(
                "Groceries -> ID: " + GetItemId() +
                ", Name: " + GetItemName() +
                ", Expiry Date: " + expiryDate
            );
        }
    }
}
