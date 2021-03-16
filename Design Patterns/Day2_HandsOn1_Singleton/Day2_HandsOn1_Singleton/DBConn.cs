using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_HandsOn1_Singleton
{
    public sealed class DBConn
    {
        private static DBConn _instance;
        private DBConn()
        {
            Console.WriteLine("Instance is being Called");
        }
        public static DBConn getInstance()
        {
            if (_instance == null)
                _instance = new DBConn();
            return _instance;
        }
    }
}
