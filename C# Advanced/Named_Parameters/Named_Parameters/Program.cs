using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    class Program
    {
        public void GetCohortDetails(string CohortName,int count,string mode,string track,string CurrentModuel)
        {
            Console.WriteLine("It is " + CohortName + " with " + count + " GenCs undergoing training for " + track + " thru " + mode + ". The current module of training is " + CurrentModuel);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetCohortDetails("ADM20DF003", 21, ".Net", "PARC", "Stage 3");
            //Named parameter
            p.GetCohortDetails(CurrentModuel: "Stage 2", track: "JAVA", mode: "OBL", count: 20, CohortName: "ADM20JA002");
            Console.Read();
        }
    }
}
