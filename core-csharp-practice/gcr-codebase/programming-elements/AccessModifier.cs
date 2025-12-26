using System;

class AccessModifier
{
    // public
    public int a = 10;

    // private
    private int b = 20;

    // protected
    protected int c = 30;

    // internal
    internal int d = 40;

    public void ShowPublic()
    {
        Console.WriteLine("Public value: " + a);
    }

    private void ShowPrivate()
    {
        Console.WriteLine("Private value: " + b);
    }

    protected void ShowProtected()
    {
        Console.WriteLine("Protected value: " + c);
    }

    internal void ShowInternal()
    {
        Console.WriteLine("Internal value: " + d);
    }

    

    static void Main()
    {
        AccessModifier obj = new AccessModifier();
        obj.ShowPublic();
		obj.ShowPrivate();
		obj.ShowProtected();
		obj.ShowInternal();
    }
}
