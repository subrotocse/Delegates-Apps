using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegatesApp
{
   public class Program
    {
        public delegate double AddNumberDelegate(int x,double y,int z);
        public delegate void AddNumber1Delegate(int x, double y, int z);
        public delegate bool CheckLengthDelegate(string name);

        static void Main(string[] args)
        {
            //Using  Delegate
            //AddNumberDelegate addNumberDelegate = new AddNumberDelegate(AddNumber);       
            //double result= addNumberDelegate(3, 6.7, 8);
            //Console.WriteLine("Add Number = "+result);

            //Using Func<> Generic Delegate
            //Func<int, double, int, double> funcDelegate = new Func<int, double, int, double>(AddNumber);
            //double result = funcDelegate(3, 6.7, 8);
            //Console.WriteLine("Add Number = " + result);

            //Using Lambda Expression
            Func<int, double, int, double> funcDelegate = (x, y, z) => x + y + z;           
            double result = funcDelegate(3, 6.7, 8);
            Console.WriteLine("Add Number = " + result);

            //Using  Delegate
            //AddNumber1Delegate addNumber1Delegate = new AddNumber1Delegate(AddNumber1);
            //addNumber1Delegate(5, 5, 5);

            //Using Action<> Generic Delegate
            Action<int, double, int> actionDelegate = new Action<int, double, int>(AddNumber1);
            actionDelegate(5, 5, 5);

            //Using  Delegate 
            //CheckLengthDelegate checkLengthDelegate = new CheckLengthDelegate(CheckLength);
            //bool status = checkLengthDelegate("subroto");
            //Console.WriteLine(status);

            //Using Predegate<> Generic Delagate 
            Predicate<string> predegateDelagate = new Predicate<string>(CheckLength);
            bool status = predegateDelagate("subroto");
            Console.WriteLine(status);

            Console.ReadLine();
        }
        public static double AddNumber(int x,double y, int z)
        {
            return x + y + z;
        }
        public static void AddNumber1(int x, double y, int z)
        {
            Console.WriteLine("Add Number1 = "+(x+y+z));
        }
        public static bool CheckLength(string name)
        {
            if(name.Length>4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
