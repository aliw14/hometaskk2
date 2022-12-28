namespace hometaskk2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("ededi daxil et:");
        int number = int.Parse(Console.ReadLine());
        int a, row = 1, sum = 0;
        while (number != 0) 

        {
            a = number % 10;
            number /= 10;
            sum += a * row;
            row++;


        }Console.WriteLine(sum);

    }
}

