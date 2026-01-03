using System;

class Order
{
    public int orderId;
}

class ShippedOrder : Order
{
    public string trackingNo;
}

class DeliveredOrder : ShippedOrder
{
    public string deliveryDate;

    public void GetOrderStatus()
    {
        Console.WriteLine("Order Delivered on " + deliveryDate);
    }
}

class Order1
{
    static void Main()
    {
        DeliveredOrder d = new DeliveredOrder();
        d.orderId = 1;
        d.trackingNo = "TR123";
        d.deliveryDate = "10-Oct";

        d.GetOrderStatus();
    }
}
