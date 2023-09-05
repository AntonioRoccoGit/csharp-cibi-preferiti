//variables
string[] favoriteFoods = { "Pasta al forno", "Fettuccine al ragù", "Lasagna", "Pollo allo spiedo", "Bistecca", "Panini"};
int numberOfFoods = favoriteFoods.Length;


//code
Console.WriteLine("Ecco una classifica dei miei " + numberOfFoods + " cibi preferiti");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine((i+1) + ") " + favoriteFoods[i]);
}

Console.WriteLine("Al primo posto: " + favoriteFoods[0]);


//se l'array è dispari, voglio stampare la posizione / 2
if (favoriteFoods.Length % 2 == 0)
{
    Console.WriteLine("Al centro: " + favoriteFoods[(numberOfFoods / 2) - 1] + " e " + favoriteFoods[numberOfFoods / 2]);
}
else
{
Console.WriteLine("Al centro: " + favoriteFoods[numberOfFoods / 2]);

}

Console.WriteLine("In ultima posizione: " + favoriteFoods[numberOfFoods - 1]);

