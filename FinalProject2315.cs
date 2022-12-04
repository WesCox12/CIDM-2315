namespace Project1;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("-----CIDM 2315 Final Project: Wesley Cox------");
        Console.WriteLine("-----Welcome to Buff Kitchen------");

        string username;
        string password;
        int choice;
        int menu;
        int index;
        float total;

        Console.WriteLine("Please input username:");
        username = Console.ReadLine();
        Console.WriteLine("Please input password:");
        password = Console.ReadLine();

        if(username=="Alice" && password=="123")
{
        Console.WriteLine("Login Successfull.");
        Console.WriteLine("\n** Hello Cashier: {0} **",username);

        string[] entree={"Chicken Sandwich","Chicken Nuggets","Chicken Strips","Beef Burger"};
        float[] entree_price={5.99f,8.99f,9.99f,6.99f};
        string[] drink={"Iced Tea", "Soda","Lemonade","Coffee"};
        float[] drink_price={2.99f,1.99f,2.99f,3.99f};
        string[] side={"Potato Fries","Salad","Fruit Cup","Potato Chips"};
        float[] side_price={3.99f,4.99f,9.99f,2.99f};
        string[] order_item=new string[3];
        float[] order_price=new float[3];

        ArrayList customer=new ArrayList();
        ArrayList price=new ArrayList();

         do{
            index = 0;
            total = 0;

        Console.WriteLine("***************************");
        Console.WriteLine("Please select");
        Console.WriteLine("1. Start new order");
        Console.WriteLine("2. Check submitted orders");
        Console.WriteLine("3. Remove finished orders");
        Console.WriteLine("4. Log out system");
        Console.WriteLine("****************************");

        choice=Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
        case 1:
            Console.WriteLine("-->Customer Name: ");
            customer.Add(Console.ReadLine());
            Console.WriteLine("-->Select Entree: ");

        for(int i=0;i<4;i++)
            {
            Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,entree[i],entree_price[i]);
            }
            menu=Convert.ToInt32(Console.ReadLine());
            order_item[index]=entree[menu];
            order_price[index]=entree_price[menu];
            total=total+entree_price[menu];
            index++;

            Console.WriteLine("-->Select Drink:");
        for(int i=0;i<4;i++)
            {
            Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,drink[i],drink_price[i]);
            }
            menu=Convert.ToInt32(Console.ReadLine());
            order_item[index]=drink[menu];
            order_price[index]=drink_price[menu];
            total=total+drink_price[menu];
            index++;
            
            Console.WriteLine("-->Select Side:");
        for(int i=0;i<4;i++)
            {
            Console.WriteLine("{0} - Food: {1}\tPrice: {2}",i,side[i],side_price[i]);
            }
            menu=Convert.ToInt32(Console.ReadLine());
            order_item[index]=side[menu];
            order_price[index]=side_price[menu];
            total=total+side_price[menu];

            Console.WriteLine("-----Order Summary-----");
        for(int i=0;i<3;i++)
            Console.WriteLine("Food: {0}\tPrice: {1}",order_item[i],order_price[i]);
            Console.WriteLine("-----Total: {0}-----",total);
            price.Add(total);
            break;
        case 2:
            Console.WriteLine("-----Number of Orders: {0}-----",customer.Count);
            
        for(int i=0;i<customer.Count;i++)
            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            break;
        case 3:
            Console.WriteLine("-----Number of Orders: {0}-----",customer.Count);
            
        for(int i=0;i<customer.Count;i++)
            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Input order ID to remove a finished order:");

            menu=Convert.ToInt32(Console.ReadLine());
            customer.RemoveAt(menu);
            price.RemoveAt(menu);

            Console.WriteLine("-----Number of Orders: {0}-----",customer.Count);

            for(int i=0;i<customer.Count;i++)

            Console.WriteLine("-->{0} - Customer: {1}\t Total: {2}",i,customer[i],price[i]);
            Console.WriteLine("----------------------------------");
            break;
        
        case 4:
            break;

            }
            }
            while(choice!=4);
            }
            else
            Console.WriteLine("Error: Try Again");
            }
    }

