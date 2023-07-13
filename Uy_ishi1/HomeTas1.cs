Console.WriteLine("Nechta raqam qtnashsin:");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qancha raqam qatnashsin ");
int raq=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qancha belgi qatnashsin:");
int belgi=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Passwordni   uzunligini kiriting: ");
int passuz=Convert.ToInt32(Console.ReadLine());

Random random=new Random();
Console.WriteLine(random.Next(1,20));
for (int i=0; i<num; i++)
{
    Console.WriteLine(random.Next());
}
for (int i = 0; i < raq; i++) ;
{
    Console.WriteLine(random.Next());
}