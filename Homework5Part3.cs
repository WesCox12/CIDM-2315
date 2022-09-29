namespace Week5HW;
class Program
{

    static void Main(string[] args)
    {
        makeAccount();
Console.ReadKey(true);
    }
    public static bool checkAge(int birth_Year)
{
int age=2022-birth_Year;
if(age>=18)
return true;
else
return false;
}
public static void makeAccount()
{
String userName,password,passwordAgain;
int birthYear;

Console.WriteLine("Enter Your Username:");

userName=Console.ReadLine();

Console.WriteLine("Enter Your Password:");

password=Console.ReadLine();

Console.WriteLine("Enter Your Password Again:");

passwordAgain=Console.ReadLine();

Console.WriteLine("Enter Your Birth Year:");

birthYear=Convert.ToInt32(Console.ReadLine());

if(checkAge(birthYear))
{
if(password==passwordAgain)
Console.WriteLine("Account is created successfully");
else
Console.WriteLine("Wrong password");
}

else
Console.WriteLine("Could not create an account.");

}
}
