using System;
namespace _28355
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleInputs(args);
        }

        static void HandleInputs(string[] args) {

            Console.WriteLine("***************");
            Console.WriteLine("Recursion and Iteration");
            Console.WriteLine("Please enter your operation");
            Console.WriteLine("\t1. Find Factorial");
            Console.WriteLine("\t2. Find Fibonacci");
            Console.WriteLine("\t3. Find GCD");
            Console.WriteLine("\t4. Binary Search");
            Console.WriteLine("\t5. Exit");
            //while the input value is not 5, keep running

            string operationInput = Console.ReadLine();
            // switch case handler
            switch (operationInput)
            {
                case "1":
                    //handle factorial
                    HandleFactorial();
                    break;

                case "2":
                    //handle fibonacci
                    HandleFibonacci();
                    break;

                case "3":
                    //handle fibonacci
                    HandleGCD();
                    break;

                case "4":
                    //handle binarysearch
                    HandleBinarySearch();
                    break;

                case "5":
                    Console.WriteLine("Exited");
                    break;
            }
            
        }
        static void HandleFactorial() {

            //Call the FactorialFinder.Factorial method
            //Read the input from the user
            Console.WriteLine("Please input an integer fo find the factorial : ");
            string inputFromUser = Console.ReadLine();
            FactorialFinder factorialFinder = new FactorialFinder();
            long result = factorialFinder.RecursiveFactorial(int.Parse(inputFromUser));
            Console.WriteLine("Recursive Factorial {0} is : {1} ", inputFromUser, result);
            result = factorialFinder.IterativeFactorial(int.Parse(inputFromUser));
            Console.WriteLine("Iterative Factorial {0} is : {1} ", inputFromUser, result);
            Console.WriteLine("***********");
        }

        static void HandleFibonacci()
        {
            Console.WriteLine("Please input an integer fo find the fibonacci : ");
            string inputFromUser = Console.ReadLine();
            FibonacciFinder fibonacciFinder = new FibonacciFinder();
            long result = fibonacciFinder.RecursiveFibonacci(int.Parse(inputFromUser));
            Console.WriteLine("Recursive Fibonacci {0} is : {1} ", inputFromUser, result);
            result = fibonacciFinder.IterativeFibonacci(int.Parse(inputFromUser));
            Console.WriteLine("Iterative Fibonacci {0} is : {1} ", inputFromUser, result);
            Console.WriteLine("***********");

        }

        static void HandleGCD()
        {

            Console.WriteLine("Please input the first integer for GCD :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the second integer for GCD :");
            int b = int.Parse(Console.ReadLine());

            GCDFinder gcdFinder = new GCDFinder();

            int gcdRecursive = gcdFinder.RecursiveGCD(a, b);
            int gcdIterative = gcdFinder.IterationGCD(a, b);

            Console.WriteLine("GCD of (" +a+ "," +b+") - recursive :" +gcdRecursive);
            Console.WriteLine("GCD of (" +a+"," +b+") - iterative :" +gcdIterative);
            Console.WriteLine("***********");

        }

        static void HandleBinarySearch()
        {
            Console.WriteLine("Please input a sorted array of integers separated from commas : ");
            string inputArray = Console.ReadLine();
            int[] array = Array.ConvertAll(inputArray.Split(','), int.Parse);

            Console.WriteLine("Please input the target integer for binary search : ");
            int target = int.Parse(Console.ReadLine());

            BinarySearch binarySearch = new BinarySearch();

            
            int recursiveResult = binarySearch.RecursiveBinarySearch(array, target, 0, array.Length - 1);

            int iterativeResult = binarySearch.IterativeBinarySearch(array, target);

            Console.WriteLine("Binary search (recursive) for "+target+" found at index :"+recursiveResult);
            Console.WriteLine("Binary search (iterative) for "+target+" found at index :"+iterativeResult);
            Console.WriteLine("***********");
        }
    }
}
       