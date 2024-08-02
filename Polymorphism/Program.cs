//Ingredient ingredient = new Cheddar(2, 12);

//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredient is " + randomIngredient);

//Console.WriteLine("is object? " + (ingredient is object));
//Console.WriteLine("is ingredient? " + (ingredient is Ingredient));
//Console.WriteLine("is cheddar? " + (ingredient is Cheddar));
//Console.WriteLine("is mozzarella? " + (ingredient is Mozzarella));
//Console.WriteLine("is tomato sauce? " + (ingredient is TomatoSauce));

//if (randomIngredient is Cheddar cheddar)
//{
//    Console.WriteLine("cheddar object: " + cheddar);
//}

Ingredient ingredient = new Ingredient(1);


Console.ReadKey();

//Ingredient GenerateRandomIngredient()
//{
//    var random = new Random();
//    var number = random.Next(1, 4);
//    if (number == 1) { return new Cheddar(2, 12); }
//    if (number == 2) { return new TomatoSauce(1); }
//    else return new Mozzarella(2);
//}


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some Ingredient";
    public abstract void Prepare();
    public string PublicMethod() => "This is a public method";
}

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}

public class ItalianFoodItem
{

}

public class Cheddar : Cheese
{

    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from Cheddar class:");
    }

    public override string Name => $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public override void Prepare() => Console.WriteLine("Grated on top of the pizza");
}

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }

    public override void Prepare() => Console.WriteLine("Sliced thinly and place on top of the pizza");
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoIn100Grams { get; }

    public override void Prepare() => Console.WriteLine("Cooked with basil and garlic" + "Spread on pizza");
}