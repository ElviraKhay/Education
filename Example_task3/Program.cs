Console.Write("Введите число:  ");
string inputvalue1 = Console.ReadLine();
int value = Convert.ToInt32(inputvalue1);
if (value%2==0)
{

   Console.WriteLine(value + "  четное число"); 

}

else 
{

    Console.WriteLine(value + "  нечетное число"); 

}