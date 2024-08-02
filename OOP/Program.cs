


Console.ReadKey();

//class MedicalAppoitmentPrinter
//{
//    public void Print(MedicalAppoitment medicalAppoitment)
//    {
//        Console.WriteLine("Appoitment will take place on " + medicalAppoitment.GetDate());
//    }
//}

//class MedicalAppoitment
//{
//    private string _patientName;
//    private DateTime _date;

//    public MedicalAppoitment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    public DateTime GetDate() => _date;

//public MedicalAppoitment(string patientName) :
//    this(patientName, 7)
//{
//}
//    public MedicalAppoitment(string patientName, int daysFromNow = 7)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }

//    public void Reschedule(DateTime date)
//    {
//        _date = date;
//        var printer = new MedicalAppoitmentPrinter();
//        printer.Print(this);
//    }

//    public void OverWriteMonthAndDay(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(
//            _date.Year,
//            _date.Month + monthsToAdd,
//            _date.Day + daysToAdd);
//    }
//}

//var rectangle1 = new Rectangle(5, 10);
//var calculator = new ShapesMeasurementsCalculator();

//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.Height);
//Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
//Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));


//var rectangle2 = new Rectangle(3, 6);

//Console.WriteLine();
//Console.WriteLine("Width is " + rectangle2.Width);
//Console.WriteLine("Height is " + rectangle2.Height);
//Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle2));
//Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle2));



//Console.ReadKey();

//class Rectangle
//{
//    public int Width;
//    public int Height;

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }
//}

//class ShapesMeasurementsCalculator
//{
//    public int CalculateRectangleCircumference(Rectangle rectangle)
//    {
//        return 2 * rectangle.Width + 2 * rectangle.Height;
//    }

//    public int CalculateRectangleArea(Rectangle rectangle)
//    {
//        return rectangle.Width * rectangle.Height;
//    }
//}



//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

//Console.WriteLine("year is " + internationalPizzaDay23.Year);
//Console.WriteLine("month is " + internationalPizzaDay23.Month);
//Console.WriteLine("day is " + internationalPizzaDay23.Day);
//Console.WriteLine("day of the week is " + internationalPizzaDay23.DayOfWeek);

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine();
//Console.WriteLine("year is " + internationalPizzaDay24.Year);
//Console.WriteLine("month is " + internationalPizzaDay24.Month);
//Console.WriteLine("day is " + internationalPizzaDay24.Day);
//Console.WriteLine("day of the week is " + internationalPizzaDay24.DayOfWeek);

//Console.ReadKey();

//var rectangle1 = new Rectangle(5, 10);

//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Area is " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

//class Rectangle
//{
//    public readonly int Width;
//    private int _height;

//    public Rectangle(int width, int height)
//    {
//        Width = GetLengthOrDefault(width, nameof(Width));
//        _height = GetLengthOrDefault(height, nameof(_height));
//    }

//    public int GetHeight() => _height;

//    public void SetHeight(int value)
//    {
//        if(value > 0)
//        {
//            _height = value;
//        }
//    }

//    private int GetLengthOrDefault(int length, string name)
//    {
//        const int defaultValueIfNotPositive = 1;
//        if (length <= 0)
//        {
//            Console.WriteLine($"{name} must be a positive number.");
//            return defaultValueIfNotPositive;
//        }
//        return length;
//    }

//    public int CalculateCircumference() => 2 * Width + 2 * _height;

//    public int CalculateArea() => Width * _height;
//}

var person = new Person
{
    Name = "Jhon",
    YearOfBirth = 1981
};

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}
