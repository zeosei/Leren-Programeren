string gebrNaam = "";

string clientName = "";
string clientNumer = "";
string clientMail = "";
string clientContract = "";

Console.WriteLine ("Hello User");
Console.WriteLine ("What is your name?");
gebrNaam = Console.ReadLine();
Console.Clear ();
Console.WriteLine ("Hello " +  gebrNaam);
Console.WriteLine("");
Console.WriteLine("What option do you want to use?");
Console.WriteLine("Option 1: Add a client");
Console.WriteLine("Option 2: Edit a client");
Console.WriteLine("Option 3: Delete a client");
string Choise = Console.ReadLine();

if (Choise == ("1") || Choise == ("Option 1"))
{
    Console.WriteLine("Option 1 Chosen.");
}
else if (Choise == ("2") || Choise == ("Option 2"))
{
    Console.WriteLine("Option 2 Chosen.");
}
else if (Choise == ("3") || Choise == ("Option 3"))
{
    Console.WriteLine("Option 3 Chosen.");
}
else
{
    Console.WriteLine("Please make a choise of presented options.");
}