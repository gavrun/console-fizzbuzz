namespace console_fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Counting down");

        int count1 = 10;
        while (count1 > 0)
        {
            Console.WriteLine(count1);
            count1 = count1 - 1;
        }

        Console.WriteLine();
        Console.WriteLine("Stepping up");
        var count2 = 1;
        while (count2 <= 20)
        {
            if (count2 == 1)
                Console.WriteLine(count2 + "st step");
            else if (count2 == 2)
                Console.WriteLine(count2 + "nd step");
            else if (count2 == 3)
                Console.WriteLine(count2 + "rd step");
            else
                Console.WriteLine(count2 + "th step");
            count2++;
        }

        Console.WriteLine();
        Console.WriteLine("Counting FizzBuzz 1");
        int number3 = 1;
        while (number3 <= 100)
        {
            if (number3 % 3 == 0 && number3 % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (number3 % 3 == 0)
                Console.WriteLine("Fizz");
            else if (number3 % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number3);
            number3++;
        }

        Console.WriteLine();
        Console.WriteLine("Counting FizzBuzz again 2");
        int number4 = 1;
        while (number4 <= 100)
        {
            bool fizz = number4 % 3 == 0;
            bool buzz = number4 % 5 == 0;
            bool fizzbuzz = fizz && buzz;

            if (fizzbuzz)
                Console.WriteLine("FizzBuzz");
            else if (fizz)
                Console.WriteLine("Fizz");
            else if (buzz)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number4);
            number4++;
        }

        Console.WriteLine();
        Console.WriteLine("Counting FizzBuzz in another way 3");
        for (int number5 = 1; number5 <= 100; number5++)
        {
            bool fizz = number5 % 3 == 0;
            bool buzz = number5 % 5 == 0;
            bool fizzbuzz = fizz && buzz;

            if (fizzbuzz)
                Console.WriteLine("FizzBuzz");
            else if (fizz)
                Console.WriteLine("Fizz");
            else if (buzz)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number5);
        }

        Console.WriteLine();
        Console.WriteLine("Counting FizzBuzz in a way 4");
        var number6 = 100;
        for (int i = 1; i <= number6; i++)
        {
            if (i % 15 == 0)
                Console.Write("FizzBuzz" + " ");
            else if (i % 3 == 0)
                Console.Write("Fizz" + " ");
            else if (i % 5 == 0)
                Console.Write("Buzz" + " ");
            else
                Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Counting FizzBuzz again 5");


    }
}
