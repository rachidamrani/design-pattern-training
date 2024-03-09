namespace design_patterns.AdapterPattern;

public class SuperDrone : DroneInterface
{
    public void beep()
    {
        Console.WriteLine("Beep beep beep!");
    }

    public void spin_rotors()
    {
        Console.WriteLine("Rotors are spinning");
    }

    public void take_off()
    {
        Console.WriteLine("Taking off");
    }
}
