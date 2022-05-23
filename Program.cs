// create a welcome message
Console.WriteLine("Welcome to Lab 2\n");

Console.WriteLine("Press 'enter' to continue: ");
Console.ReadLine();

// display the menu and allow user to choose option
int choice = 0;
do
{
    Console.Clear();
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
    Console.WriteLine("\n============ MENU ============");
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Multiplication table");
    Console.WriteLine("3. Memory size of data types");
    Console.WriteLine("4. Five-function calculator");
    Console.WriteLine("0. Exit");
    Console.WriteLine("==============================\n");
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
            Calculator();
            break;
        default:
            Console.WriteLine("Invalid menu choice. Please try again.");
            break;
    }
}

// sum method for question 1
static void AddNumbers()
{
    Console.WriteLine("\n------- Adding Numbers -------");
    Console.WriteLine("Enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    Console.WriteLine("Press 'enter' to continue: ");
    Console.ReadLine();
}

// multiplication table for question 2
static void MultiplicationTable()
{
    Console.WriteLine("\n---- Multiplication Table ----");
    Console.WriteLine("Enter number to multiply: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the maximum number of factors: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= num2; i++)
    {
        Console.WriteLine($"{num1} * {i} = {num1 * i}");
    }

    Console.WriteLine("Press 'enter' to continue: ");
    Console.ReadLine();
}

// memory size of data types for question 3
static void MemorySize()
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Type\t\tByte(s) of Memory\tMin\t\t\t\tMax");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    Console.WriteLine("sbyte\t\t\t" + sizeof(sbyte) + "\t\t" + sbyte.MinValue + "\t\t\t\t" + sbyte.MaxValue);
    Console.WriteLine("byte\t\t\t" + sizeof(byte) + "\t\t" + byte.MinValue + "\t\t\t\t" + byte.MaxValue);
    Console.WriteLine("short\t\t\t" + sizeof(short) + "\t\t" + short.MinValue + "\t\t\t\t" + short.MaxValue);
    Console.WriteLine("ushort\t\t\t" + sizeof(ushort) + "\t\t" + ushort.MinValue + "\t\t\t\t" + ushort.MaxValue);
    Console.WriteLine("int\t\t\t" + sizeof(int) + "\t\t" + int.MinValue + "\t\t\t" + int.MaxValue);
    Console.WriteLine("uint\t\t\t" + sizeof(uint) + "\t\t" + uint.MinValue + "\t\t\t\t" + uint.MaxValue);
    Console.WriteLine("long\t\t\t" + sizeof(long) + "\t\t" + long.MinValue + "\t\t" + long.MaxValue);
    Console.WriteLine("ulong\t\t\t" + sizeof(ulong) + "\t\t" + ulong.MinValue + "\t\t\t\t" + ulong.MaxValue);
    Console.WriteLine("float\t\t\t" + sizeof(float) + "\t\t" + float.MinValue + "\t\t\t" + float.MaxValue);
    Console.WriteLine("double\t\t\t" + sizeof(double) + "\t\t" + double.MinValue + "\t" + double.MaxValue);
    Console.WriteLine("decimal\t\t\t" + sizeof(decimal) + "\t\t" + decimal.MinValue + "\t" + decimal.MaxValue);
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");

    Console.WriteLine("Press 'enter' to continue: ");
    Console.ReadLine();
}

// 5-function calculator for question 4
static void Calculator()
{
    bool exit = false;
    Console.WriteLine("\n-- Five-Function Calculator --");
    Console.WriteLine("Enter the first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    while (exit == false)
    {
        Console.WriteLine("Enter operation: +, -, *, /, %");
        Console.WriteLine("or type 'esc' to exit: ");
        var operation = Console.ReadLine();
        if (operation == "esc")
        {
            exit = true;
        }
        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case "+":
                num1 = num1 + num2;
                break;
            case "-":
                num1 = num1 - num2;
                break;
            case "*":
                num1 = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    num1 = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Divide by zero error.");
                }
                break;
            case "%":
                num1 = num1 % num2;
                break;
            default:
                Console.WriteLine("Not an operation. Please try again.");
                break;
        }
        Console.WriteLine($"Answer: {num1}");
    }
}