namespace design_patterns.StrategyPattern;

public class Social : SharingStrategy
{
    public void share()
    {
        System.Console.WriteLine("Sharing photo via social media");
    }
}
