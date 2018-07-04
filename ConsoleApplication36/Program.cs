using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 153;

            string valuestringcommas = "";
            double sum = 0;
            string valuestring = value.ToString();
            for (int i = 0; i < valuestring.Length; i++)
            {
                valuestringcommas = valuestringcommas + valuestring[i] + ",";
            }
            valuestringcommas = valuestringcommas.Remove(valuestringcommas.Length - 1);
            double[] numberArray = valuestringcommas.Split(',').Select(double.Parse).ToArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                double converted = numberArray[i];
                double exponent = Math.Pow(converted, numberArray.Length);
                sum = sum + exponent;
            }

            int finalanswer = (int)sum;

            if (finalanswer ==value)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }

        }
    }
}
