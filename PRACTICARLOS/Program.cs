double Progra, mat , phys , Adm , cali=0 ;
Console.WriteLine("Welcome to the school offices \n \n Do you want to know if you are eligible for an Achievement Scholarship? \n ");

Console.Write("Please enter the Programming qualification:  ");
Progra = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter the Administration qualification:  ");
Adm = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Mathematics qualification:  ");
mat = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Physics qualification:  ");
phys = Convert.ToDouble(Console.ReadLine());

cali= (Adm + mat + Progra + phys)/4;

Console.WriteLine("Your average is " + cali);

if (cali >= 90 )
{
    Console.WriteLine("Your average is a creditor for a scholarship");

}
else
{ Console.WriteLine("Your average is not a creditor for a scholarship"); }


Console.ReadKey();