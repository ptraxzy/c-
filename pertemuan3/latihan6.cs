using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan3
{
    internal class latihan6
    {
        static void Main(string[] args)
        { 

            bool isOnline = true;
            bool isVerifed = true;

            Console.WriteLine("is Online: " + isOnline); //true
            Console.WriteLine("is Verified: " + isVerifed); //false

            //operasi boolean
            bool canAccess = isOnline && isVerifed;
            Console.WriteLine("can Access: " + canAccess); //false
        }
    }
}
