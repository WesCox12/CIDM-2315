namespace Homework4;
class Program
{
    
static int largest(int a, int b){

if(a>b){

return a;
}
else if(b>a){

return b;
}
else{

return -1;
}

}

    static void Main(string[] args)
    {
        Console.Write("First Number = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Second Number = ");
        int b = int.Parse(Console.ReadLine());



int lar = largest( a, b);


Console.WriteLine("a = {0}; b = {1}",a,b);
Console.WriteLine("The largest number is : "+lar);

}
    }

