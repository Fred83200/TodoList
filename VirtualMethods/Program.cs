var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = false;

NumberSumCalculator calculator =
    shallAddPositiveOnly ?
    new PositiveNumberSumCalculator() :
    new NumberSumCalculator();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is: " + sum);
Console.ReadKey();

public class NumberSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}

public class PositiveNumberSumCalculator : NumberSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}
