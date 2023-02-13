Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());;

if ( b > a) 
{
   Console.WriteLine("min = " + a); 
   Console.WriteLine("max = " + b);
}
else
    {
     Console.WriteLine("min = " + b);
     Console.WriteLine("max = " + a);
    }