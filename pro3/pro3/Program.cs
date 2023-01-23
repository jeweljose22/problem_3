Console.WriteLine("enter fare");
double fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter time");
double  time = Convert.ToDouble(Console.ReadLine());
if (time >= 6 && time < 9)
{
    fare= fare * 1.1;
    Console.WriteLine(fare);
}
else if (time >=9 && time < 17)
{
    fare = fare * 1.2;
    Console.WriteLine(fare);
}
else if(time >=17 && time <=23)
{
    fare = fare * 1.07;
    Console.WriteLine(fare);
}
else if ((time >=0 && time <= 6))
{
    fare = fare * 1.05;
    Console.WriteLine(fare);
}
else
{
    Console.WriteLine(fare);
}

