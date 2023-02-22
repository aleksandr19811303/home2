// программа принимает число N и выдает таблицу кубов ичсел от 1 до N
Console.Write("введите число  ");
int N = Convert.ToInt32(Console.ReadLine());
int i =1;
while (i<=N)
{
   Console.WriteLine (i*i*i);
   i++;
}
