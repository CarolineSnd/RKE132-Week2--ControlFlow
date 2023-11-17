// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are to young to use Instagram"
//muul juhul kuvatakse "Welcome to Instagram!"
//boolean - true/false


Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");


if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Intagram!");
    }
    else
    {
        Console.WriteLine("You are to young to use Instagram.");
    }
}
else
    {
    Console.WriteLine("Could not read your age.");
}