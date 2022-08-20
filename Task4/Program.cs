System.Console.Write("Enter number a: ");
int numbera = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number b: ");
int numberb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number c: ");
int numberc = Convert.ToInt32(Console.ReadLine());
int max = numbera;
int min = numbera;

if( numbera > max )
    {
            max = numbera;
    }
    else
    if( numbera < min ) min = numbera;
    
if( numberb > max )
     {
            max = numberb;
     }
     else
     if( numberb < min ) min = numberb;
   
if( numberc > max )
    {
            max = numberc;
    }
    else 
    if( numbera < min ) min = numberc;
    
 Console.WriteLine( "max = "+ max+": min = "+ min);
 