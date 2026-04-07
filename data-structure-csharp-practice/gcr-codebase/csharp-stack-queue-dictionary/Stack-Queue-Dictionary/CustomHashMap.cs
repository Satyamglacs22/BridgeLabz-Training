using System;

class CustomHashMap
{
    int[] keys = new int[100];
    int[] values = new int[100];

    public void Put(int key, int value)
    {
        keys[key] = 1;
        values[key] = value;
    }

    public int Get(int key)
    {
        return keys[key] == 1 ? values[key] : -1;
    }

    public void Remove(int key)
    {
        keys[key] = 0;
    }

    static void Main()
    {
        CustomHashMap map = new CustomHashMap();
        map.Put(5, 100);
        Console.WriteLine(map.Get(5));
    }
}
