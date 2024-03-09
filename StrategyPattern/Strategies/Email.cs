namespace design_patterns.StrategyPattern;

public class Email : SharingStrategy
{
    public void share()
    {
        System.Console.WriteLine("Sharing photo via email");
    }
}
