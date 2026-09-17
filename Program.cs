/*
Console.Write("How many gummy bears? ");
// int gummyBears = Convert.ToInt32(Console.ReadLine());
string input = Console.ReadLine();

// int gummyBears; //we can get rid of this line if we declare the variable in line 7
//the bool and variable is saving the input to a variable
bool isNumber = int.TryParse(input, out int gummyBears);

// Console.WriteLine(isNumber);
if (isNumber)
{
    Console.WriteLine("You have " + gummyBears + " gummy bears");

}
else
{
    Console.WriteLine(input + " is not a number.");
}


//we can put the int.TryParse INSIDE the if statement
Console.Write("How many chips?");
if (int.TryParse(Console.ReadLine(), out int chips))
{
    Console.WriteLine("You have " + chips + " chips.");
}
else
{
    Console.WriteLine("That was not a real number. So no chips for you.");
}

Console.Write("For how many people?");
int people;


//we can use int.TryParse as a condition in a while loop instead of creating a bool variable
while(!int.TryParse(Console.ReadLine(), out people))
{
    Console.WriteLine("That is not a number. How many people?");
}

Console.WriteLine("Splitting between " + people + " people.");


Console.WriteLine(int.TryParse("42", out int a)); //true
Console.WriteLine(int.TryParse(" 42 ", out int b)); //true
Console.WriteLine(int.TryParse("42abc", out int c)); //false
Console.WriteLine(int.TryParse("3.5", out int d)); //false
Console.WriteLine(int.TryParse("-5", out int e)); //true
Console.WriteLine(int.TryParse("", out int f)); //false
Console.WriteLine(int.TryParse("1,000", out int g)); //false
Console.WriteLine(int.TryParse("007", out int h)); //true

Console.WriteLine(double.TryParse("3.5", out double doub));
*/
SayHi(); //we can call the methods beforehand too

static void SayHi()
{
    Console.WriteLine("Hi.");
}

static void SayHiTo(string name) //inside parentheses is a parameter
{
    Console.WriteLine("Hello " + name);
}

SayHiTo("Bob"); //inside parentheses is argument

//argument gives value to parameter

static int Add(int num1, int num2)
{
    return num1 + num2; //this doesnt print to console, so we save it to variable int sum below
}

int sum = Add(2,3);

Console.WriteLine(sum);

int gummyWorms = 5;

static void ShowGummyWorms(int gummyWorms)
{
    Console.WriteLine("You have " + gummyWorms + " gummy worms.");
}

ShowGummyWorms(gummyWorms);

//------------------------

/*Console.Write("For how many people?");
int people;


while(!int.TryParse(Console.ReadLine(), out people))
{
    Console.WriteLine("That is not a number. How many people?");
}
*/

//this how to validate as well
static int AskForNumber(string question)
{
    Console.Write(question);
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("That is not a number. " + question);
    }

    return number;
}

int firstNum = AskForNumber("Enter your first number: ");
int secondNum = AskForNumber("Enter your second number: ");
int thirdNum = AskForNumber("Enter your third number: ");
int fourthNum = AskForNumber("Enter your fourth number: ");