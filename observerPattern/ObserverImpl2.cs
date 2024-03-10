
namespace design_patterns.observerPattern;

public class ObserverImpl2 : IObserver
{
    private List<int> integersHistory = new List<int>();
    public void update(int state)
    {
        System.Console.WriteLine("********** Observer 2 **********");

        integersHistory.Add(state);

        int sum = 0;

        foreach (var intNumber in integersHistory)
        {
            sum += intNumber;
        }

        double avg = (double)sum / integersHistory.Count();

        System.Console.WriteLine("La nouvelle moyenne est : ");
        System.Console.WriteLine(avg);


    }
}