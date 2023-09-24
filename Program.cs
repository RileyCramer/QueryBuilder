// See https://aka.ms/new-console-template for more information
string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
string filePath = projectFolder + Path.DirectorySeparatorChar + "AllPokemon.csv";
string filePath2 = projectFolder + Path.DirectorySeparatorChar + "BannedGames.csv";
 

Console.WriteLine( "for the create method woudl you like to start with? (Read, Read All, Update, Delete, Delete All, Dispose, Create)");
string answer  = Console.ReadLine();

if (answer == "Read ")
{

}

if (answer == "Read All")
{ 

}
if (answer == "Update")
{

}
if (answer == "Delete")
{

}
if (answer == "Delete All")
{

}
if(answer == "Dispose")
{

}
if (answer == "Create")
{

}





    if (answer == "pokemon")
    {
        Console.WriteLine("what is the ID of the pokemon?");
        Console.WriteLine("what is the mindex number of the pokemon? has to be over 898");
        Console.WriteLine("what is the name of the pokemon?");
        Console.WriteLine("What form of the pokemon is this?");
        Console.WriteLine("What is type of pokemon is this(fire, water, grass)");
        Console.WriteLine("If there is a second type please input it here and if there isnt please just press enter");
        Console.WriteLine("");
        Console.WriteLine("what is the HP of the pokemon");
        Console.WriteLine("what is the attack of the pokemon");
        Console.WriteLine("what is the defense of the pokemon");
        Console.WriteLine("What is the special attack of hte pokemon");
        Console.WriteLine("what is the special defense of the pokemon");
        Console.WriteLine("");
        Console.WriteLine("");
    }

