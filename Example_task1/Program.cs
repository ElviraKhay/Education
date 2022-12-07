
Console.Write("Введите первое число:  ");
string inputvalue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputvalue1);
Console.Write("Введите число 2:  ");
string inputevalue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputevalue2);

if (value1 > value2)

{
  Console.WriteLine("Максимальное число  = " + value1);  
}
else 
{

Console.WriteLine("Минимальное число  = " + value1); 

}
