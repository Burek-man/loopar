// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("hur många kurac får Alvin idag");
int tal = int.Parse(Console.ReadLine())+1;
while(tal<= 100)
{
Console.WriteLine(tal);
tal++;

}
*/
int antalTal;
double summa = 0, input;
Console.Write("antal kurac som ska matas in i Alvin");
antalTal = Convert.ToInt32 (Console.ReadLine());
for (int i=1; i <=antalTal; i++)

{
    Console.Write("skriv värde" + i + ":");
    input = Convert.ToDouble(Console.ReadLine());
    summa = summa + input;
}
Console.WriteLine("medelvärdet är:" + ( summa / antalTal));
  Console.WriteLine("minsta värdet är:" + (SmalestValue ));
Console.WriteLine("högsta värdet är:" + ( BiggestValue ));
