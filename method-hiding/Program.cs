Base foo = new Base();
foo.Method();

Derived bah = new Derived();
bah.Method();

Base bar = new Derived();
bar.Method();


public class Base
{
    public virtual void Method()
    {
        Console.WriteLine("Hello, World");
    }
}

public class Derived : Base
{
    public override void Method()
    {
        Console.WriteLine("Goodbye, World");
    }
}
