using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    public class bank
    {
        public int acc = 2000;

        public int number
        {
            set
            {
                acc = value;
            }
            get
            {
                return acc;
            }
        }

    }
    //public class bank
    //{
    //    int accblnc = 250000;
    //    string name = "wajiha";
    //    int accno = 123456;
    //    public void SetBlnc(int name, int account ,int accountNO)
    //    {
    //        name = name;
    //        accblnc = account;
    //        accno = accountNO;

    //    }
    //    public void GetBlnc()
    //    {
    //        Console.WriteLine($"your ACCOUNT NAME is {name}");
    //        Console.WriteLine($"your ACCOUNT NO is {accno}");
    //        Console.WriteLine($"your ACCOUNT blnc is {accblnc}");

    //    }
    //}
    public class encapsulation
    {
        static void Main(string[] args)
        {
            bank acc2 = new bank();
            acc2.acc = 12000;
            Console.WriteLine(acc2.number);
            //bank acc = new();

            ////acc.SetBlnc(1000);
            //acc.GetBlnc();
        }

    }
}

