using System;

namespace OOPS_DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******DateTime*********");
            string dob = Console.ReadLine();
            DateTime dt = DateTime.Parse(dob);
            Console.WriteLine("Your date of birth is:{0}", dt);
            Console.ReadLine();

             
        }
        
    }
}
