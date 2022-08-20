// Вывод четных от 1 до n
System.Console.Write("Enter number a: ");
int numbera = Convert.ToInt32(Console.ReadLine());

if( numbera > 0 )
{
int count = 0;
Console.Write( "Четные числа:" );

if( numbera % 2 != 0)
 {
    numbera = numbera - 1;
 }
 {
while(count < numbera)
{
    count +=2;
    Console.Write( " , "+count );
}
 }
}
else
{
    if( numbera % 2 != 0 )
    {
        numbera = numbera + 1;
    }
    Console.Write("Четные отрицательные: ");
    while( numbera < 0)
    {
        Console.Write(" ,"+numbera);
        numbera +=2;
    }
}