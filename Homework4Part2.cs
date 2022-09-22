namespace HW4PT2;
class Program
{
    static void pattern(int N,string shape){
    int i,j,k;
    if(shape=="left"){
       for(i=1;i<=N;i++)
       {
        for(j=1;j<=i;j++)
    	Console.Write("*");
    	Console.Write("\n"); 
       }
      }
    else if(shape=="right"){
     for (i = 1; i <= N; i++) 
         {  
            for (j = 1; j <= N-i; j++)  
            {Console.Write(" ");}  
            for (k = 1; k <= i; k++)  
            {  Console.Write("*");}  
            Console.WriteLine(""); 
            }  
        Console.ReadLine();
        }
    }
    public static void Main() {
   int N; 
   string shape;
   Console.Write("Input N: ");
   N= Convert.ToInt32(Console.ReadLine());
   Console.Write("Input shape: ");
   shape= Console.ReadLine();
   Console.Write("N is: "+N+"; shape is "+shape+"\n");
   pattern(N,shape);
}}