// 12/6/22 C#
// Complete the Add() method so that it will calculate the sum of two numbers given as arguments.
// Overload it in order to do the same operation with double type values.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));
        }
        //complete the method to sum
        static int Add(int x, int y)
        {
            return x+y;
        }
        //overload it for double type
        static double Add(double x, double y)
        {
            return x+y;
        }
    }
}

// 12/9/22 C#
// What is the output of this code?
static void Print(int a) {
  Console.WriteLine(a*a);
}
static void Print(double a) {
  Console.WriteLine(a+a);
}
static void Main(string[] args) {
  Print(3);
}
9

// 12/10/22 C#
// Write a program to take N number as input and recursively calculate the sum of all numbers from 1 to N.
// Sample Input
// 5
// Sample Output
// 15
// Explanation
// 5+4+3+2+1 = 15.
// Don't forget about base case.
// C#
// 123456789101112131415161718192021222324


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(number));
        }
        static int Sum(int num)
        {
            if (num == 1) {
            	return 1;
            }
            else {
            	return num + Sum(num - 1);
            }
        }
    }
}


// Write a program to take N number as input and recursively calculate the sum of all numbers from 1 to N.

// Sample Input
// 5

// Sample Output
// 15

// Explanation
// 5+4+3+2+1 = 15.
// Don't forget about base case.
// 12/13/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(number));
        }
        
        static int Sum(int num)
        {
            if (num == 1) {
                return 1;
            }
            else {
                return num + Sum (num - 1);
            }
        }
    }
}


// Recursion
// Write a program to take N number as input and recursively calculate the sum of all numbers from 1 to N.
// Sample Input
// 5
// Sample Output
// 15
// Explanation
// 5+4+3+2+1 = 15.
// Don't forget about base case.
// 12/14/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(number));
        }
        static int Sum(int num)
        {
            if (num == 1) {
            	return 1;
            }
            else {
            	return num + Sum(num - 1);
            }
        }
    }
}
  
