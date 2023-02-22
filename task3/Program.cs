// 19 программа проверяет пятизначное число на полиндром
Console.WriteLine("введите число");
 string a = Console.ReadLine();
 int b = a.Length;
 if (b==5)
 {
    if (a[0]==a[4] && a[1]==a[3])
    {
        Console.WriteLine ("полиндром");
    }
    else
    {
      Console.WriteLine ("не полиндром"); 
    }
     }
     else
     {
      Console.WriteLine ("ошибка");  
     }
