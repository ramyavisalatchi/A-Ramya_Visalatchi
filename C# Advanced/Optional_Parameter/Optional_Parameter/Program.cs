using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter
{
    class Program
    {
        public static void OrderDetails(string Sname,string Pname,int Quantity=1,bool IsReturnable=true)
        {
            Console.WriteLine("Here is the order detail – "+Quantity+" number of "+Pname+" by "+Sname+" is ordered. It’s returnable status is "+IsReturnable);
        }
        static void Main(string[] args)
        {
            OrderDetails("Ram", "Mobile");
            OrderDetails("Raj", "Laptop",5,false);

            Console.Read();
        }
    }
}
