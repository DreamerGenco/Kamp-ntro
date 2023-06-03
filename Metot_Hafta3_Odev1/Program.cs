// See https://aka.ms/new-console-template for more information

Add();
Add();
Console.WriteLine(Add2(2, 4));

int number1 = 20;
int number2 = 100;
int result = Add3( number1, number2);
Console.WriteLine(result);
Console.WriteLine(number1);
Console.ReadLine();
static void Add()
{
    Console.WriteLine("Added!");
}
static int Add2(int num1, int num2 = 30) //Varsayılan değer alabiliyor. 
{
    return num1 + num2;
}
static int Add3(  int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}