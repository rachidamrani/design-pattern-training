namespace design_patterns.StrategyPattern;

public class Text : SharingStrategy
{
    public void share()
    {
        System.Console.WriteLine("Sharing photo via text");
    }
}
