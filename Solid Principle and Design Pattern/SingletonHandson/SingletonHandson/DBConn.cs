using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonHandson
{
    public class DBConn
    {
        private static DBConn instance;
        private DBConn()
        {
            Console.WriteLine("Hi");
    
        }
        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();
            }
            return instance;
        }
        public void PrintDetail(string name)
        {
            Console.WriteLine("Welcome " + name +"to my Course");
        }
    }
}
