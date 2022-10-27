namespace Homework8;
class Program
{
    public static void ArraySum(int[] int_array){
        int sum = 0;
        foreach (int item in int_array) {
            sum += item;
        }
        Console.WriteLine($"The Sum of int-array is: {sum}");
    }
    
    public static void Main(string[] args)
    {
        int[] array = { 11, 23, 31, 42, 53 };
        ArraySum(array);
        
    }
    
    
}
