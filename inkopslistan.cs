//Lista som sparar namnet på varje vara
List names = new List();

//Lisa som sparar priset på varje vara
List prices = new List();

while (true)
{
    Console.WriteLine("InköpsLista");


    // visar alla varor i listan
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    }
    //Räknar ut totalsumman
    int total = 0;
    for (int i = 0; i < prices.Count; i++)
    {
        total += prices[i];
    }
    Console.WriteLine($"Totalt: {total} kr");

    //Frågan till användaren kommer senare
    Console.WriteLine("Skriv en vara eller ett nummer.");

    //Sparar användarens inmatning som text
    string input = Console.ReadLine()!;

    //Kontrollerar om användaren skrev ett nummer
    if (int.TryParse(input, out int nummer))
    {
        if (nummer >= 1 && nummer <= names.Count)
        {
            //Gör om användarens nummer till index
            int index = nummer - 1;

            //Ta bort namnet
            names.RemoveAt(index);

            //Ta bort priset på samma plats
            prices.RemoveAt(index);

            Console.WriteLine("Varan har tagits bort.");
        }
        else
        {
            Console.WriteLine("Det numret finns inte i listan.");
        }
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