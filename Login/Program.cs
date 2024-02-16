using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public  class Program
    {
        static void Main(string[] args)
        {
        }
        public static string FirstAccess()
        {
            return "Succesfull";
        }
        public static bool Log(string Userid, string Pass) =>
            Userid == "prueba1" && Pass == "prueba123@" ? true : false;
       
    }
}
