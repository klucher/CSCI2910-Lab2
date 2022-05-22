// create a welcome message
Console.WriteLine("Welcome to Lab 2\n");

// display the menu and allow user to choose option
int choice = 0;
do
{
    DisplayMenu();
    Console.WriteLine("Please enter your selection: ");
    choice = Convert.ToInt32(Console.ReadLine());
    MenuOption(choice);
} while (choice != 0);

// display a goodbye message
Console.WriteLine("Thank you for using the program. Goodbye.");

// display a menu
static void DisplayMenu()
{
    Console.WriteLine("============ MENU ============");
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Multiplication table");
    Console.WriteLine("3. Memory size of data types");
    Console.WriteLine("4. Five-function calculator");
    Console.WriteLine("0. Exit");
    Console.WriteLine("==============================");
}

// choose from menu
static void MenuOption(int option)
{
    switch(option)
    {
        case 0:
            break;
        case 1:
            AddNumbers();
            break;
        case 2:
            MultiplicationTable();
            break;
        case 3:
            MemorySize();
            break;
        case 4:
            break;
        default:
            Console.WriteLine("Invalid menu choice. Please try again.");
            break;
    }
}

// sum method for question 1
static void AddNumbers()
{
    Console.WriteLine("------- Adding Numbers -------");
    Console.WriteLine("Enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

}

// multiplication table for question 2
static void MultiplicationTable()
{
    Console.WriteLine("---- Multiplication Table ----");
    Console.WriteLine("Enter number to multiply: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the maximum number of factors: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= num2; i++)
    {
        Console.WriteLine($"{num1} * {i} = {num1 * i}");
    }
}

static void MemorySize()
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Type\t\tByte(s) of Memory\t\tMin\t\t\tMax");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    Console.WriteLine("sbyte\t\t" + sizeof(sbyte) + "\t\t\t" + sbyte.MinValue + "\t\t\t\t" + sbyte.MaxValue);
    Console.WriteLine("byte\t\t" + sizeof(byte) + "\t\t\t" + byte.MinValue + "\t\t\t\t" + byte.MaxValue);
    Console.WriteLine("short\t\t" + sizeof(short) + "\t\t\t" + short.MinValue + "\t\t\t\t" + short.MaxValue);
    Console.WriteLine("ushort\t\t" + sizeof(ushort) + "\t\t\t" + ushort.MinValue + "\t\t\t\t" + ushort.MaxValue);
    Console.WriteLine("int\t\t" + sizeof(int) + "\t\t\t" + int.MinValue + "\t\t\t" + int.MaxValue);
    Console.WriteLine("uint\t\t" + sizeof(uint) + "\t\t\t" + uint.MinValue + "\t\t\t\t" + uint.MaxValue);
    Console.WriteLine("long\t\t" + sizeof(long) + "\t\t\t" + long.MinValue + "\t\t" + long.MaxValue);
    Console.WriteLine("ulong\t\t" + sizeof(ulong) + "\t\t\t" + ulong.MinValue + "\t\t\t\t" + ulong.MaxValue);
    Console.WriteLine("float\t\t" + sizeof(float) + "\t\t\t" + float.MinValue + "\t\t\t" + float.MaxValue);
    Console.WriteLine("double\t\t" + sizeof(double) + "\t\t\t" + double.MinValue + "\t" + double.MaxValue);
    Console.WriteLine("decimal\t\t" + sizeof(decimal) + "\t\t\t" + decimal.MinValue + "\t" + decimal.MaxValue);
}