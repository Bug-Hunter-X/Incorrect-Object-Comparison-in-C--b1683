public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(20);

        // Incorrect comparison
        if (obj1 == obj2)
        {
            Console.WriteLine("Objects are equal");
        }
        else
        {
            Console.WriteLine("Objects are not equal");
        }
    }
}