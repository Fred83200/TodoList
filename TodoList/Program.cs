using System;

var todos = new List<string>();


Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "s":
        case "S":
            SeeAllTodos();
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
}

Console.ReadKey();

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMethod();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        description = Console.ReadLine();

    }
    while (!IsDescriptionValid(description));

    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("The desciption must be unique");
        return false;
    }
    return true;
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMethod();
        return;
    }
    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove");
        SeeAllTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out index) && 
        index >= 1 && 
        index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

static void ShowNoTodosMethod()
{
    Console.WriteLine("No TODOs have been added yet");
}












//List<string> words = new List<string>()
//{
//    "one",
//    "two",
//    "three",
//};

//words.AddRange(new[] {"four", "five" });
//Console.WriteLine("Index of Element 'four' is " + words.IndexOf("four"));
//Console.WriteLine(words.Count);

//Console.WriteLine("Contains 'five?': " + words.Contains("five"));

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}





//char[,] letters = new char[2, 3];

//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';


//var height = letters.GetLength(0);
//var width = letters.GetLength(1);
//Console.WriteLine("Height is: " + height);
//Console.WriteLine("Width is: " + width);
//for (var i= 0; i < height; i++)
//{
//    Console.WriteLine("i is: " + i);
//    for(var j= 0; j < width; j++)
//    {
//        Console.WriteLine("j is: " + j);
//        Console.WriteLine("Element is: " + letters[i,j]);
//    }
//}

//var letters2 = new char[,]
//{
//    { 'A', 'B', 'C' },
//    { 'D', 'E', 'F' },
//};




//int[] numbers = new int[] {2, 6, 8, 10, 12};
//Console.WriteLine("Element at index 0 is " + numbers[0]);
//Console.WriteLine("Element at index 1 is " + numbers[1]);
//Console.WriteLine("Element at index 2 is " + numbers[2]);
//Console.WriteLine();

//Console.WriteLine("Element at index 0 is " + numbers[0]);
//Console.WriteLine("Element at index 1 is " + numbers[1]);
//Console.WriteLine("Element at index 2 is " + numbers[2]);

//Console.WriteLine();
//var firstNumberFromEnd = numbers[numbers.Length - 1];
//var secondNumberFromEnd = numbers[^2];
//Console.WriteLine(secondNumberFromEnd);
//Console.WriteLine(firstNumberFromEnd);

//var sum = 0;
//for(var i = 0; i < numbers.Length; ++i)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);


//for (int i = 0; i < 5; ++i)
//{
//    Console.WriteLine("hello");
//}

//string word;
//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while(word.Length <= 10);
//Console.WriteLine("Loops is finished");
//Console.WriteLine("Provide a number");
//string userInput = Console.ReadLine();
//int number = int.Parse(userInput);
//Console.WriteLine(number);

//int a = 4, b = 2, c = 10;
//Console.WriteLine($"First is: {a}, second is: {b}, third is: {c}");

//Console.WriteLine("Hello!");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");
//var userChoice = Console.ReadLine();

//switch(userChoice)
//{
//    case "s":
//    case "S":
//        printSelectedOption("See all TODOs");
//        break;
//    case "a":
//    case "A":
//        printSelectedOption("Add a TODO");
//        break;
//    case "r":
//    case "R":
//        printSelectedOption("Remove a TODO");
//        break;
//    case "e":
//    case "E":
//        printSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("Invalid Choice");
//        break;
//}



////var userChoice = Console.ReadLine();

////bool isLong = IsLong(userChoice);

////bool IsLong(string input)
////{
////    return input.Length > 10;
////}
////if(userchoice == "s")
////{
////    printselectedoption("see all todos");
////}
////else if(userchoice == "a")
////{
////    printselectedoption("add a todo");
////}
////else if(userchoice == "r")
////{
////    printselectedoption("remove a todo");
////}
////else if (userchoice == "e")
////{
////    printselectedoption("exit");
////}

//void printSelectedOption(string selectedoption)
//{
//    Console.WriteLine("selected option: " + selectedoption);
//}

//int Add(int a, int b)
//{
//    return a + b;
//}
