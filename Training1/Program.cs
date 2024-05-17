
namespace Training1
{
    //scope 
    internal class Program
    {
        public static void Main(string[] args)
        {        
            Console.WriteLine("Hey welcome to a small calc");

            bool state = true;

            /*
             *  perform all the arithimetric functions
             *  
             *  convert the string to decimals 
             *  
             *  10.3455 / 673.39849
             *  
             */

            while (state)
            {
                Console.WriteLine("Please input your first number");

                string firstNoString = Console.ReadLine();

                Console.WriteLine("Please input your second number");

                string secondNoString = Console.ReadLine();

                //convert the strings to decimals
                Int32 first = Int32.Parse(firstNoString);

                Int32 second = Int32.Parse(secondNoString);

                Console.WriteLine("what action do you want to take eg + - / * %");
               
                string condition=Console.ReadLine();

                switch (condition)
                {
                    case "+":
                    case "plus":
                        Console.WriteLine("Sum " + (first + second));
                     break;

                    case "-":
                    case "minus":
                        Console.WriteLine("Result " + (first - second));
                        break;

                    default:
                        Console.WriteLine("modulus " + (first + second));
                        break;
                }

                Console.WriteLine("Do you wish to continue (y/n)");

                string resp= Console.ReadLine();

                state =(resp == "y" || resp =="Y");

                // 1 0

                // true or false => true 

                // true and false => false 

                // true and true => true 

                // false and false => false 

            }

           

            

            

        }
    }
}


