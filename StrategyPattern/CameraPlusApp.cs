namespace design_patterns.StrategyPattern;
public class CameraPlusApp : PhoneCameraApp
{
    public override void Edit()
    {
        System.Console.WriteLine("Camera plus app is editing the photo");
    }
}
