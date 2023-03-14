namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        //public static void PrintThousand()
        //{
        //    for (int i = 1000; i >= -1000; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        //public static void PrintByThree()
        //{
        //    for (int i = 3; i <= 999; i += 3)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        //public static void EqualTo(int num1, int num2)
        //{
        //    if (num1 == num2)
        //    {
        //        Console.WriteLine("Equal");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Equal");

        //    } 
        //}


        //Write a method to check whether a given number is even or odd
        //public static void EvenOdd(int num1)
        //{
        //    if (num1 % 2 == 0)
        //    {
        //        Console.WriteLine($"Your number {num1} number is even");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Your number {num1} is odd");
        //    }
        //}

        ////Write a method to check whether a given number is positive or negative
        //public static void PosNeg(int num1)
        //{
        //    if (num1 > 0)
        //    {
        //        Console.WriteLine($"{num1} is positive.");
        //    }
        //    else if (num1 < 0)
        //    {
        //        Console.WriteLine($"{num1} is negative.");
        //    }
        //    else (0 = 0)
        //    {
        //        Console.WriteLine($"{num1} is zero!");
        //    }
        //}

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //public static void votingAge()
        //{
        //    bool userAge;
        //    int result;

        //    do
        //    {
        //        Console.WriteLine("Please enter your age:");
        //        userAge = int.TryParse(Console.ReadLine(), out result);

        //    } while (!userAge);

        //    if (result < 18)
        //    {
        //        Console.WriteLine("You don't have this right....yet!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yay, you can vote!");
        //    }
        //}

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        //public static void BetweenTen()
        //{
        //    bool userResponse;
        //    int result;

        //    do
        //    {
        //        Console.WriteLine("Enter an integer");

        //        userResponse = int.TryParse(Console.ReadLine(), out result);

        //    } while (!userResponse);

        //    if (result <= 10 && result >= -10)
        //    {
        //        Console.WriteLine($"{result} is between -10 & 10");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"{result} is not between -10 & 10");
        //    }
        //}




        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void ProductTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an integer");

                cont = int.TryParse(Console.ReadLine(), out userInput);

            } while (!cont);

            for (var num = 1; num <= 12; num++)
            {
                Console.WriteLine($"{num} x {userInput} = {num * userInput}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintThousand();

            //PrintByThree();


            //EqualTo(5,5);
            //Console.WriteLine(EqualTo);

            //EvenOdd(5);
            //Console.WriteLine(EvenOdd);

            //PosNeg(16);
            //Console.WriteLine(PosNeg);


            //votingAge();


            //BetweenTen();

            ProductTable();




        }
    }
}
