using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string drivername { get; set; }
        public Boolean onduty { get; set; }
        public int numpass { get; set; }

        public void info()
        {
            Console.WriteLine("\n Taxi Information \n");
            Console.WriteLine("Nama Driver : {0}", drivername);

            if (onduty == true)
            {
                Console.WriteLine("On Work : Yes", onduty);
                Console.WriteLine("Nomor Pelanggan : {0}", numpass);
            }
            else
            {
                Console.WriteLine("On Work : No", onduty);
                Console.WriteLine("Nomor Pelanggan : {0}", numpass);
            }



        }

        public void ongoing()
        {
            Console.WriteLine("{0} Sedang Membawa Penumpang", drivername);
        }

        public void done()
        {
            Console.WriteLine("{0} Tidak Membawa Penumpang\n\n", drivername);
        }
    }
}