// Adapt a drone to a duck
// Create an adapter for the drone so we can use the drone in a duck simulator
// the duck simulator simulate just objects that implements duck interface

using design_patterns.AdapterPattern;

public class Program
{
    private static void Main(string[] args)
    {
        // code goes here
        // Duck duck = new Duck();
        // testDuck(duck);

        SuperDrone drone = new SuperDrone();
        DuckInterface droneAdapter = new DroneAdapter(drone);
        testDuck(droneAdapter); // now we can pass a drone to a duck simulator client
    }

    private static void testDuck(DuckInterface duck)
    {
        duck.quack();
        duck.fly();
    }
}





