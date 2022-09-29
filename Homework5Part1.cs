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
    static void Main(string[] args)
    {
         Console.Write("a = ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
    }
}
