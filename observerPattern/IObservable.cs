namespace design_patterns.observerPattern;

public interface IObservable
{
    void subscribe(IObserver observer);
    void unsubscribe(IObserver observer);
    void notifyObserver();


}