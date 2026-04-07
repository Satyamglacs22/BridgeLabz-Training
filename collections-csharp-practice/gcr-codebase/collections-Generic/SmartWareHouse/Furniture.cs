using System;

namespace SmartWarehouse
{
    class Furniture : WarehouseItem
    {
        private string material;

        public void SetMaterial(string mat)
        {
            material = mat;
        }

        public string GetMaterial()
        {
            return material;
        }

        public override void DisplayItem()
        {
            Console.WriteLine(
                "Furniture -> ID: " + GetItemId() +
                ", Name: " + GetItemName() +
                ", Material: " + material
            );
        }
    }
}
