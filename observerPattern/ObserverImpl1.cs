namespace design_patterns.observerPattern;

public class ObserverImpl1 : IObserver
{
    public void update(int state)
    {
        System.Console.WriteLine("********** Observer 1 **********");
        System.Console.WriteLine("A new state value received : state = " + state);

    }
}