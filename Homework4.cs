using System.Transactions;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        /*Question 1 code. The code below indicates
        that there will be numbers inputed*/
       int num1, num2, max_num;
       num1= 4;
       num2= 6;
       /*The "if-else" statement below indicates 
       that if number 1 is the larger number, it 
       will  be the output. Otherwise number 2 will 
       be the output*/
        if(num1>num2){
            max_num= num1;
        }
        else{
            max_num= num2;
        }
        Console.WriteLine($"The larger value is: {max_num}");
        
        /*Question 2 code. ChatGPT. 2025, February 17. "Show me an example for
        a c# program that atkes an integer equal to five and takes a shape (left or right)*/
        //sets integer N equal to five
        int N = 5;
        //Asks the user to choose a direction
        Console.WriteLine("Enter direction (left or right):");
        string direction = Console.ReadLine().ToLower();

        //follows condition if selected direction is left
        if(direction == "left")
        {
            for(int i=1; i<= N; i++)
            {
                for (int j = 0; j< i; j++)
                {
                    Console.Write("*");
                } 
                Console.WriteLine();           
            }
        }
        //will run if chosen direction is right
        else if(direction =="right")
        {
            for (int i=1; i<= N; i++)
        }
        for(int j = 0; j<N -i; j++)
        {
            Console.Write(" ")
        }
        for( int j=0; j<i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        {
            //Will appear if input is not direction left or right
            else
            {
                Console.WriteLine("Invalid direction! Please enter 'left' or 'right'.")
            }
        }
    }
}
