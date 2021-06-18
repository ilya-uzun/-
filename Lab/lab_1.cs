using System;
using System.Collections;

namespace lab_1
{
class MainClass
{
public static void Main(string[] args)
{
Console.WriteLine("Task 1");
chexked{
try {
string buf_n;
string buf_m;
Console.WriteLine("intut variable");
buf_n = Console.ReadLine();
buf_m = Console.ReadLine();
int n = int.Parse(buf_n);
int m = int.Parse(buf_m);

Console.WriteLine("m={0}, n={1}, m - ++n{3}", m, n, m - ++n);
Console.WriteLine("m={0}, n={1}, m++ > --n{3}", m, n, m++ > --n);
Console.WriteLine("m={0}, n={1}, m-- < -++n{3}", m, n, m-- < -++n);
}
catch(Exception e){
Console.WriteLine("Warning intut");
}
}


Console.WriteLine("Task 1.1");

chexked{
try {
string buf_size;
string buf_range;
Console.WriteLine("intut variable");
size = Console.ReadLine();
range = Console.ReadLine();
int size = int.Parse(buf_size);
int range = int.Parse(buf_range);

int[] arrayRond = new int[size];

Console.WriteLine("25*Pow(x,2)-Sqrt(Pow(x,2)*x) = {0}", x);

}
catch(Exception e){
Console.WriteLine("Warning intut");
}
}


Console.WriteLine("Task 3");

float a = 100;
float b = 0.001;

float summa = ((a-Pow(b,3))-(Pow(a,3)+3*a*Pow(b,2)))/((-3)*Pow(a,2)*b-Pow(b,3));

}
}
}
