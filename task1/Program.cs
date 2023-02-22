// программа принимает координаты двух точек и находит расстояние между ними в трехмерном пространстве
Console.Write("введите координату Х первой точки: ");
double x1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Y первой точки: ");
double y1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Z первой точки: ");
double z1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Х второй точки: ");
double x2=Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Y первой точки: ");
double y2=Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Z первой точки: ");
double z2=Convert.ToInt32(Console.ReadLine());
double A= x2 - x1;
double B= y2 - y1;
double C= z1 - z2;
double distance = Math.Sqrt(A*A+B*B+C*C);
Console.WriteLine(distance);