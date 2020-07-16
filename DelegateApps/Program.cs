using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApps
{
    public delegate void CalculatorDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            CalculatorDelegate calculatorDelegate = new CalculatorDelegate(program.GetSum);
            calculatorDelegate += program.GetSub;
            calculatorDelegate += program.GetMul;

            calculatorDelegate(20, 10);
            //calculatorDelegate(40, 7);
            program.GetSum(20,10);
            program.GetSub(40, 7);
            Console.ReadLine();
        }

        private void GetMul(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Mul = " + result);
        }

        public void GetSum(int x,int y)
        {
            int result = x + y;
            Console.WriteLine("Sum = "+result);
        }
        public void GetSub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Sub = " + result);
        }
    }
}
