namespace design_patterns.AdapterPattern;

public class DroneAdapter : DuckInterface
{

    private DroneInterface _droneInterface;
    public DroneAdapter(DroneInterface droneInterface)
    {
        _droneInterface = droneInterface;
    }
    public void fly()
    {
        _droneInterface.spin_rotors();
        _droneInterface.take_off();
    }

    public void quack()
    {
        _droneInterface.beep();
    }

}
