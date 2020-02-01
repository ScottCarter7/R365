using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant365CodeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int newNum = 0;

            //user input
            Console.WriteLine("Enter numbers to add: ");
            string userNums = Console.ReadLine();

            //split the entered string by every comma and \n
            string[] values = userNums.Split(new String[] { ",", "\\n" }, StringSplitOptions.None);

            //for loop to add up the new numbers
            for (int i = 0; i < values.Length; i++)
            {
                newNum = newNum + Convert.ToInt32(values[i]);
            }

            //Prints solution to the user
            Console.WriteLine("Calculation complete. Number is: " + newNum);
            Console.ReadLine();
        }
    }
}

