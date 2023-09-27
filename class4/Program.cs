using System;

namespace class4
{
    internal class Program
    {

        //Method to add 2 numbers
        public static void Add(int a, int b)
        {
            int methodResult = a + b;
            Console.WriteLine("Addition Result" + methodResult);
        }
        
        public static void Subtract(int a, int b)
        {
            int methodResult = a - b;
            Console.WriteLine("Subtraction Result" + methodResult);

        }

        public static void Divide(int a, int b)
        {
            int methodResult = a / b;
            Console.WriteLine("Divide Result" + methodResult);

        }
        
        
        public static void Mulitply(int a, int b)
        {
            int methodResult = a * b;
            Console.WriteLine("Multiply Result" + methodResult);

        }
        
        public static void Calculate(int a,int b , string sign)
        {

            if (sign == "+")
            {
                Add(a,b);
            }

            if (sign == "-")
            {
                Subtract(a,b);
            }

            if (sign == "/")
            {
                Divide(a,b);
            }

            if (sign == "*")
            {
                Mulitply(a,b);
            }
        }
        

        
        
        

        public static void Main(string[] args)
        {
            Calculate(4,6,"*");
            Calculate(7,3,"-");
            Calculate(10,5,"/");
            Calculate(5,5 ,"+");
        
        }
    }
}