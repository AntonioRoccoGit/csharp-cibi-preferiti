//variables
string[] favoriteFoods = { "Pasta al forno", "Fettuccine al ragù", "Lasagna", "Pollo allo spiedo", "Bistecca", "Panini" };
int numberOfFoods = favoriteFoods.Length;
var message = $"Al centro: ";

//code
Console.WriteLine($"Ecco una classifica dei miei {numberOfFoods} cibi preferiti");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"{i + 1}) {favoriteFoods[i]}");
    if (i == favoriteFoods.Length - 1)
    {
        Console.WriteLine();
    }
}

if (favoriteFoods.Length % 2 == 0)
{
    message = $"{message}{favoriteFoods[(numberOfFoods / 2) - 1]} e {favoriteFoods[numberOfFoods / 2]}";
}
else
{
    message = message + favoriteFoods[numberOfFoods / 2];
}

Console.WriteLine($"Al primo posto: {favoriteFoods[0]}");
Console.WriteLine(message);
Console.WriteLine($"In ultima posizione: {favoriteFoods[numberOfFoods - 1]}");
