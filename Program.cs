Console.WriteLine("Please input a number");
int Clock = Convert.ToInt32(Console.ReadLine());
Clock = Clock % 2;
if (Clock == 0)
{
    Console.WriteLine("Tick");  
}
else
{
    Console.WriteLine("Tock");
}
// basically displays "Tick" if the number is even and "Tock" if its odd.