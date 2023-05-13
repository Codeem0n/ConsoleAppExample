// See https://aka.ms/new-console-template for more information
Console.WriteLine("Here is how to mae a simple console app that uses for loops, while loops, numeric values, strings, list, getting input from the user, and displaying info the console");

Console.WriteLine("How many names are in this list");

string HowManyString = Console.ReadLine(); //This gets input from the user and we set that value (string) to a variable for us to use later

int HowManyInt = Convert.ToInt32(HowManyString); //This is an integer, a numeric whole number

int HowManyIntLoop =HowManyInt;

int x = 0;

List<string> Names = new List<string>();

while(HowManyIntLoop > 0) //This is a boolean statment as in the statment is either true or false. While the statment is true it performs this operation. Once done it checks the statment again until it is false
{
    Console.WriteLine("Add a name to the list");
    string newName = Console.ReadLine();
    Names.Add(newName);
    HowManyIntLoop--;
}

//foreach( string name in Names)//Showing the list
//{
//    Console.WriteLine(Names[x]);
//    x++;
//}

//another way to Show the list

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

Names.Sort();

for(int i = 0; i < HowManyInt; i++)
{
    Console.WriteLine(Names[i]);
}



