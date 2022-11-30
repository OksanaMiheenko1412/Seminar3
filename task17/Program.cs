//task17 на вход(координаты точки(X,Y)), на выход номер четверти плоскости,
//в которой находится точка с соответствующими координатами

Console.Clear();
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if(x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else  
    Console.WriteLine("IV");

     


