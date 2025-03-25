namespace Homework7;
/*Source cited: ChatGPT.(2025, 03, 24).
 "Show me an example of a C# console project
  with the following instructions:"*/
class Program
{
    static void Main(string[] args)
    {
        //Creates two customer objects
        Customer customer1 = new Customer(110, "ALice" , 28);
        Customer customer2 = new Customer(111, "Bob", 30);
    
        // Printing customer information
        Console.WriteLine("Initial Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Updating customer IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

         // Printing updated customer information
        Console.WriteLine("\nUpdated Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

                // Comparing customer ages
        Console.WriteLine("\nComparing Ages:");
        customer1.CompareAge(customer2);
    }
}
class Customer
{
        private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    } 

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
            Console.WriteLine($"Older Customer: {this.cus_name}");
        else if (this.cus_age < objCustomer.cus_age)
            Console.WriteLine($"Older Customer: {objCustomer.cus_name}");
        else
            Console.WriteLine("Both customers are of the same age.");
    }
}


