using design_patterns.observerPattern;

var observable = new Observable();

var observer1 = new ObserverImpl1();
var observer2 = new ObserverImpl2();

observable.subscribe(observer1);
observable.subscribe(observer2);

observable.setState(4);
observable.setState(10);


observable.unsubscribe(observer1);

System.Console.WriteLine("Observer 1 is no longer interested in receiving notifications");

observable.setState(3);

