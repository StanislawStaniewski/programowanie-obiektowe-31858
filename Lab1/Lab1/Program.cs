// Example 1

/*
 
const int requiredAge = 18;
const string accessDenied = "Musisz mieć 18 lat.";
const string accessAllowed = "Witamy w naszym sklepie";

int age = 19;

do
{
    Console.WriteLine("Podaj swój wiek: ");

    string input = Console.ReadLine();

    bool success = int.TryParse(input, out age);

    if (!success)
    {
        Console.WriteLine("Podaj poprawną wartość!");
    }
    else
    {
        if (age < requiredAge)
        {
            Console.WriteLine(accessDenied);
        }
        else
        {
            Console.WriteLine(accessAllowed);
        }
    }
} while (age < requiredAge);

// Example 2

// var names = new[] { "Artur", "Alicja", "Michał", "Gosia" };
//
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }
//
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

// DODANE – prosty wybór bez ponownego pytania o wiek

Console.WriteLine("Proszę wybrać: alkohol lub bron");
string wybor = Console.ReadLine();

if (wybor == "alkohol")
{
    if (age >= 18)
    {
        Console.WriteLine("Możesz kupić alkohol.");
    }
    else
    {
        Console.WriteLine("Nie możesz kupić alkoholu. Musisz mieć co najmniej 18 lat.");
    }
}
else if (wybor == "bron")
{
    if (age >= 21)
    {
        Console.WriteLine("Możesz kupić broń.");
    }
    else
    {
        Console.WriteLine("Nie możesz kupić broni. Musisz mieć co najmniej 21 lat.");
    }
}
else
{
    Console.WriteLine("Niepoprawny wybór. Proszę wybrać 'alkohol' lub 'bron'.");
}

*/

//////////////////////////////////////ZADANIE 1/////////////////////////////////////////////

/*

int count = 0;
string password = "";

while (password != "admin123")
{
    Console.WriteLine("Podaj hasło:");
    password = Console.ReadLine();

    if (password != "admin123")
    {
        Console.WriteLine("Błędne hasło, spróbuj ponownie.");
    }
}

Console.WriteLine("Zalogowano pomyślnie!");

string password;
do
{
    Console.Write("Podaj hasło: ");
    password = Console.ReadLine();
}
while (password != "admin123");
Console.WriteLine("Zalogowano pomyślnie!");


////////////////////////ZADANIE 2////////////////////////////

int number;

do
{
    Console.Write("Podaj liczbę większą od zera: ");
    string input = Console.ReadLine();
    int.TryParse(input, out number);

    if (number <= 0)
    {
        Console.WriteLine("Liczba musi być większa od zera. Spróbuj ponownie.");
    }

} while (number <= 0);

Console.WriteLine("Dziękuję! Podałeś liczbę większą od zera.");
*/
///////////////////////////////////////Zadanie 3/////////////////////////////////////


string[] cities = { "Warszawa", "Kraków", "Gdańsk", "Poznań", "Wrocł`aw" };

foreach (string city in cities)
{
    Console.WriteLine($"Miasto: {city}");
}
