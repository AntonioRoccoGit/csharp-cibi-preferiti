//variables
string[] favoriteFoods = { "Pasta al forno", "Fettuccine al ragù", "Lasagna", "Pizza", "Pollo allo spiedo", "Bistecca", "Panini"};
//code
Console.WriteLine("Ecco una classifica dei miei " + favoriteFoods.Length + " cibi preferiti");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine((i+1) + ") " + favoriteFoods[i]);
}

Console.WriteLine("Al primo posto: " + favoriteFoods[0]);
Console.WriteLine("In ultima posizione: " + favoriteFoods[favoriteFoods.Length - 1]);

