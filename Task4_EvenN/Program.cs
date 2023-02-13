Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());;

int index = 1;

while ( index <= a)
{
    if (index % 2 == 0)  
    {
        Console.Write( index + " " ); 

    }
    index++;
}