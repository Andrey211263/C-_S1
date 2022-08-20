// Цикл на ввод 3-х пар чисел с выводо max/min
int count = 0;
while( count < 3 )
{
System.Console.Write("Enter number a: ");
int numbera = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number b: ");
int numberb = Convert.ToInt32(Console.ReadLine());

if(numbera > numberb)
 {
 Console.Write( "max = "+numbera );
 Console.WriteLine( ": min = "+numberb);
 }
 else
 {
 Console.Write( "max = "+numberb );
Console.WriteLine( ": min = "+numbera);
 }
 count++;
}