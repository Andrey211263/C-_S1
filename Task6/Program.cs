// организован цикл на ввод 3-х чисел с анализо чет/нечет
int count = 0;
while(count < 3 )
{
System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    System.Console.WriteLine(number+": четное ");
}
else
{
System.Console.WriteLine(number+": не четное ");
}
count++;
}