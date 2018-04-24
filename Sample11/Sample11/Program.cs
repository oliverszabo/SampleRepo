﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes hello world message to the console
            System.Console.WriteLine("Hello World");

            float a = 5.6F;
            float b = 0;
            float c = 11.2F;

            System.Console.WriteLine(a + " / " + b + " = " + "{0}", CoCalc.Div(a, b));
            System.Console.WriteLine(a + " / " + c + " = " + "{0}", CoCalc.Div(a, c));
            System.Console.WriteLine(b + " / " + a + " = " + "{0}", CoCalc.Div(b, a));
            System.Console.WriteLine(b + " / " + c + " = " + "{0}", CoCalc.Div(b, c));
            System.Console.WriteLine(c + " / " + a + " = " + "{0}", CoCalc.Div(c, a));
            System.Console.WriteLine(c + " / " + b + " = " + "{0}", CoCalc.Div(c, b));

            System.Console.ReadKey();
        }
    }

    class CoCalc
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Div(float a, float b)
        {
            float result = 0;
            try
            {
                result = a / b;
                if (b == 0) { System.Console.WriteLine("OOPS: Division by 0 is allowed by " + a.GetType() + " Type variables"); }
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Attempted division by 0 failed. Result set to 0");
            }
            return result;
        }
    }
}
