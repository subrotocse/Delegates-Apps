using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethodApp
{
   public delegate void GetNameDelegate(string name);

    public class Program
    {
        static void Main(string[] args)
        {
            GetNameDelegate gd = delegate (string name)
            {
              Console.WriteLine("Name = " + name);
            };

            gd("subroto");
            Console.ReadLine();
        }                
    }
}
