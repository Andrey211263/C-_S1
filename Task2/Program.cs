// Организуем небольшой цикл с выводом результата сравнения
int count = 0;
while(count < 3)
{
System.Console.Write("Enter number a: ");
int numbera = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number b: ");
int numberb = Convert.ToInt32(Console.ReadLine());

if(numbera > numberb)
    {
    Console.WriteLine( "max = "+numbera+", min ="+numberb );
    }
    else
    {
    Console.WriteLine( "max = "+numberb+", min = "+numbera );
    }
count++;
}
    