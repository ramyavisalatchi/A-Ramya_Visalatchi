using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder child = new ConcreteChildPackage();
            Builder adult = new ConcreteAdultPackage();

            director.Construct(child);
            director.Construct(adult);

            Product p1 = adult.GetResult();
            Product p2 = child.GetResult();

            Console.WriteLine("\n------- Packages of assorted sweets and savories for festive season -------\n");
            Console.WriteLine("Adult Package\n");
            p1.Show();

            Console.WriteLine("Child Package");
            p2.Show();
            Console.ReadKey();
        }
    }
}
