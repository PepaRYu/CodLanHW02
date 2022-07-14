// See https://aka.ms/new-console-template for more information
string number = Console.ReadLine();


try
{   
    Console.WriteLine(number[2]);
}
catch (System.Exception)
{
    Console.WriteLine("Третьей цифры нет");
    throw;
}