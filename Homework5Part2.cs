namespace Week5HW;
class Program
{
public static int largest(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static int largest(int a, int b, int c, int d)
    {
        return largest(largest(a, b), largest(c, d));
    }
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("c= ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("d= ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}
