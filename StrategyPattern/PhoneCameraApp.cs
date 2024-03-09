namespace design_patterns.StrategyPattern;

abstract public class PhoneCameraApp
{
    SharingStrategy sharingBehavior = null!;

    public void setSharingBehavior(SharingStrategy sharingStrategy)
    {
        this.sharingBehavior = sharingStrategy;
    }

    public void Take()
    {
        System.Console.WriteLine("Taking the photo");
    }
    public void Save()
    {
        System.Console.WriteLine("Saving the photo");
    }

    public void Share()
    {
        sharingBehavior.share();
    }

    abstract public void Edit();
}
