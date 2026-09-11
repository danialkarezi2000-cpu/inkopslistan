//Lista som sparar namnet på varje vara
List<string> names = new List<string>();

//Lisa som sparar priset på varje vara
List<int> prices = new List<int>();

while (true)
{
    Console.WriteLine("InköpsLista");


    // visar alla varor i listan
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    }
    Console.Write("Skriv en vara eller ett nummer:");

    //Sparar användarens inmatning som text
    string input = Console.ReadLine()!;
    //Kontrollerar om användaren skrev ett nummer
    if (int.TryParse(input, out int nummer))
    {
        Console.WriteLine("Du skrev ett nummer.");
    }
    else
    {
        //Användaren skrev ett varunamn
        Console.Write("Skriv priset:");
        string priceInput = Console.ReadLine()!;
        if (int.TryParse(priceInput, out int price))
        {
            names.Add(input);
            prices.Add(price);

            Console.WriteLine("Varan har lagts till.");

        }
        else
        {
            Console.WriteLine("Priset måste vara ett heltal.");
        }
    }
}