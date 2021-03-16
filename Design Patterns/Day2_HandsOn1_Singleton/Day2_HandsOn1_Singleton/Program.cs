using System;

namespace Day2_HandsOn1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn object1 = DBConn.getInstance();
            DBConn object2 = DBConn.getInstance();

            if(object1.Equals(object2))
            {
                Console.WriteLine("Objects are same");
            }
            Console.WriteLine(object1.GetHashCode() + "  " + object2.GetHashCode());
            Console.ReadLine();
        }
    }
}
