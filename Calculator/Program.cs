Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract number");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if(EqualsCaseInsensitive(choice, "A"))
{
    var sum = number1 + number2;
    printFinalEquation(number1, number2, sum, " + ");
}
else if(EqualsCaseInsensitive(choice, "S"))
{ 
    var difference = number1 - number2;
    printFinalEquation(number1, number2, difference, " - ");
}
else if(EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = number1 * number2;
    printFinalEquation(number1, number2, multiplied, " * ");
}
else
{
    Console.WriteLine("Invalid Choice");
}

void printFinalEquation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine(
       number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper().Equals(right.ToUpper());
}


Console.WriteLine("Press any key to close the application");
Console.ReadKey();
