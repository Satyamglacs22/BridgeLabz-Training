using System;

namespace SmartWarehouse
{
    class Electronics : WarehouseItem
    {
        private int warrantyYears;

        public void SetWarrantyYears(int years)
        {
            warrantyYears = years;
        }

        public int GetWarrantyYears()
        {
            return warrantyYears;
        }

        public override void DisplayItem()
        {
            Console.WriteLine(
                "Electronics -> ID: " + GetItemId() +
                ", Name: " + GetItemName() +
                ", Warranty: " + warrantyYears + " years"
            );
        }
    }
}
