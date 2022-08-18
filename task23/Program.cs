Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(N == 0)
{
    Console.WriteLine("0");
}
else
{
while(count <= N)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}
}