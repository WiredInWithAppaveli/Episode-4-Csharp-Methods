using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode4
{
    class Program
    {
        static int ReturnInt()
        {
            int x = 5;
            Console.WriteLine(x);
            return x;
        }
        static double UnemploymentRate(double laborForce, double numUnemployed)
        {
            return laborForce / numUnemployed;
        }
        void RowsAndColumns()
        {
            String s1 = "*";
            String s2 = "*";
            String s3 = "*";
            String s4 = "*";
            String s5 = "*";
            String s6 = "*";

            String rowOne = s1 + "\t" + s2 + "\t" + s3;
            String rowTwo = s4 + "\t" + s5 + "\t" + s6;
            String rowsAndColumns = rowOne + "\n" + rowTwo;

            // 2x3 columns
            Console.WriteLine(rowsAndColumns);
        }
        String GetInput()
        {
            string input = Console.ReadLine();
            Console.WriteLine("You are " + input);
            return input;
        }
        static void Main(string[] args)
        {
            ReturnInt();
            Console.WriteLine(UnemploymentRate(4.0, 444.0));
            Program program = new Program();
            program.RowsAndColumns();
            Console.Write("Who are you? ");
            string myInput = program.GetInput(); 

        }
    }
}
