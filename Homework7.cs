namespace Homework7;

class Customer{ 
 private int cus_id;
 public string cus_name;
 public int cus_age;
 public Customer(int id, string name, int age) {
     cus_id = id;
     cus_name = name;
     cus_age = age;
 }
 public void ChangeID(int new_id) {
     cus_id = new_id;
 }


 public void PrintCusInfo(){
     Console.WriteLine("Customer : "+cus_id+", name : "+cus_name+", age : "+cus_age);
 }

}
class PrintCustomerInfo {
  static void Main() {
    Customer custOne = new Customer(110, "Alice", 28);
    custOne.PrintCusInfo();
    Customer custTwo = new Customer(111, "Bob", 30);
    custTwo.PrintCusInfo();
    custOne.ChangeID(220);
    custTwo.ChangeID(221);
    custOne.PrintCusInfo();
    custTwo.PrintCusInfo();

    if (custOne.cus_age > custTwo.cus_age){
        Console.WriteLine("Alice is older");
    }
    else{
        Console.WriteLine("Bob is older");
    }

  }
}

