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