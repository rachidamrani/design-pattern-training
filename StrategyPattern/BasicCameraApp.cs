namespace design_patterns.StrategyPattern;
public class BasicCameraApp : PhoneCameraApp
{
    public override void Edit()
    {
        System.Console.WriteLine("Basic camera app editing the photo.");
    }

}