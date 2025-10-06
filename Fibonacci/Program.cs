// int n = 0;
int zbroj = 0;
Console.WriteLine("uneite broj n:");
n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    zbroj = i;
}
while (zbroj <= 15)
{
    z++;
    zbroj += z;
    Console.WriteLine("Broj {0} : , ", zbroj);

}
           
                
Console.WriteLine("Ukupni Fibonnacijev broj je :{0}", zbroj);