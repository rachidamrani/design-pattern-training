namespace design_patterns.observerPattern;

public class Observable : IObservable
{
    private int _state = 0;
    List<IObserver> observers = new List<IObserver>();
    public void notifyObserver()
    {
        foreach (IObserver observer in observers)
        {
            observer.update(_state);
        }
    }

    public void subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
        notifyObserver();

    }

    public int getState() => _state;

    public void setState(int state)
    {
        _state = state;
        notifyObserver();
    }

}