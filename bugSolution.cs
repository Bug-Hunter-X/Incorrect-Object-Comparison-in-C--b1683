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
        MyClass obj2 = new MyClass(10);

        // Correct comparison using Equals()
        if (obj1.Equals(obj2))
        {
            Console.WriteLine("Objects are equal");
        }
        else
        {
            Console.WriteLine("Objects are not equal");
        }

        //Correct comparison comparing properties
        if (obj1.MyProperty == obj2.MyProperty)
        {
            Console.WriteLine("Objects have equal properties");
        }
        else
        {
            Console.WriteLine("Objects have different properties");
        }
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        MyClass other = (MyClass)obj;
        return MyProperty == other.MyProperty;
    }
    public override int GetHashCode()
    {
        return MyProperty.GetHashCode();
    }
} 