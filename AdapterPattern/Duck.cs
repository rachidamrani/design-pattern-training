namespace design_patterns.AdapterPattern;

public class Duck : DuckInterface
{
    public void fly()
    {
        System.Console.WriteLine("Flying ..");
    }

    public void quack()
    {
        System.Console.WriteLine("Quack quack!");
    }
}
