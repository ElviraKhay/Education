Console.Write("Введите первое число:  ");
string inputvalue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputvalue1);
Console.Write("Введите второе число:  ");
string inputevalue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputevalue2);
Console.Write("Введите третье число:  ");
string inputvalue3 = Console.ReadLine();
int value3 = Convert.ToInt32(inputvalue3);
int max = value1;
if (value2 > max) 

{

    Console.WriteLine("Максимальное число  = " + value2); 

}

if (value3 > max)

{

    Console.WriteLine("Максимальное число  = " + value3); 

}

else 
{

    Console.WriteLine("Максимальное число  = " + value1);  
}