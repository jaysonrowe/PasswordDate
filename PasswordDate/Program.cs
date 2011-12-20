using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime newPass = DateTime.Now.AddDays(120);
            Console.WriteLine(newPass.ToShortDateString());
            Console.ReadLine();
        }
    }
}
