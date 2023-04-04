namespace Fizzbuzz_
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Please input a number");
            
            int userInput = int.Parse(Console.ReadLine());
            
            FizzBuzz(userInput);

            Console.WriteLine(FizzBuzz(userInput));


        }

            public static string FizzBuzz(int userInput)
            {

                if (userInput == null || userInput == 0)
                {
                    return "Invalid input";
                }

                if (userInput % 3 == 0 && userInput % 5 == 0)
                {
                    return "fizbuzz";
                }

                if (userInput % 3 == 0)
                {
                    return "fizz";
                }

                if (userInput % 5 == 0)
                {
                    return "buzz";
                }


                else
                {
                    return "No fizzbuzz for you :(";
                }

            }


    }
}


















