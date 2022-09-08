namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int number2 = 0;
            Console.WriteLine("Write the first number\n");
            try
            {
                 number = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Exception");
               
            }
           
            Console.WriteLine();
            Console.WriteLine("Write a second number\n");
            try
            {
                 number2 = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Exception");
            }

           
            Console.WriteLine();
            int min = Math.Min(number2, number);
            int max = Math.Max(number2, number);
            int sum = min;
          
            if (min != max)
            {
                for (int i = min; i < max; i++)
                {
                    sum += i;
                }
            } 
            else
            {
                Console.WriteLine($"The numbers are the same \n{number}\n");  
            }
            Console.WriteLine($"The sum of all numbers between constants\n \n{min} and {max}\n");
            Console.WriteLine(sum);
            
            Console.ReadLine();
        }
    }
}