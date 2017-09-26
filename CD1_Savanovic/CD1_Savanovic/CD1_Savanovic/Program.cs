using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1_Savanovic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Info
            Console.WriteLine("Temperature Converter | wi15b057 \n \n");

            //Selection of the temperature unit for the input
            Console.WriteLine("Please choose your input unit: \n 1. for Celsius press 'C' \n 2. for Fahrenheit press 'F' \n 3. for Reamur press 'R' \n 4. for Kelvin press 'K'");

            //Storing the temp. unit for the input
            string inputTempUnit = Console.ReadLine();

            //Selection of the temperature unit for the output
            Console.WriteLine("Please choose your output unit: \n");

            //Storing the temp. unit for the output
            string outputTempUnit = Console.ReadLine();

            //Value entry
            Console.WriteLine("Please enter your value: \n");

            //Storing the temp. value
            decimal temp = (decimal.Parse(Console.ReadLine()));

            //Switch statement with all cases for conversion
            switch (inputTempUnit)
            {
                //Celsius to other units
                case "C":
                    if (outputTempUnit == "C")
                    {
                        Console.WriteLine(temp + "C");
                        break;
                    }
                    else if (outputTempUnit == "F")
                    {
                        Console.WriteLine(temp * 9 / 5 + 32 + "F");
                        break;
                    }
                    else if (outputTempUnit == "R")
                    {
                        Console.WriteLine(temp * 4 / 5 + "R");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(temp + (decimal)273.15 + "K");
                        break;
                    }

                //Fahrenheit to other units
                case "F":
                    if (outputTempUnit == "F")
                    {
                        Console.WriteLine(temp + "F");
                        break;
                    }
                    else if (outputTempUnit == "C")
                    {
                        Console.WriteLine(temp / (decimal)0.8000 + "C");
                        break;
                    }
                    else if (outputTempUnit == "R")
                    {
                        Console.WriteLine((temp - 32) * 4 / 9 + "R");
                        break;
                    }
                    else
                    {
                        Console.WriteLine((temp + (decimal)459.67) * 5 / 9 + "K");
                        break;
                    }

                //Reamur to other units
                case "R":
                    if (outputTempUnit == "R")
                    {
                        Console.WriteLine(temp + "R");
                        break;
                    }
                    else if (outputTempUnit == "C")
                    {
                        Console.WriteLine(temp * 5 / 4 + "C");
                        break;
                    }
                    else if (outputTempUnit == "F")
                    {
                        Console.WriteLine(temp * 9 / 4 + 32 + "F");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(temp * 5 / 4 + (decimal)273.15 + "K");
                        break;
                    }

                //Kelvin to other units
                case "K":
                    if (outputTempUnit == "K")
                    {
                        Console.WriteLine(temp + "K");
                        break;
                    }
                    else if (outputTempUnit == "C")
                    {
                        Console.WriteLine(temp - (decimal)273.15 + "C");
                        break;
                    }
                    else if (outputTempUnit == "F")
                    {
                        Console.WriteLine(temp * 9 / 5 - (decimal)459.67 + "F");
                        break;
                    }
                    else
                    {
                        Console.WriteLine((temp - (decimal)273.15) * 4 / 5 + "R");
                        break;
                    }
                default:
                    Console.WriteLine("You inserted an invalid type. \n");
                    break;
            }

            //Closing the program
            Console.WriteLine("Press any key to end the program...");
            Console.ReadLine();
        }
    }
}