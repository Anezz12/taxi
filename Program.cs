using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class program
    {
        static void Main(string[] args)
        {


            Taxi taxi = new Taxi();
            Taxi taxi1 = new Taxi();

            taxi.drivername = "Harsena";
            taxi.onduty = true;
            taxi.numpass = 2211;

            taxi1.drivername = "Argretya";
            taxi1.onduty = true;
            taxi1.numpass = 4958;

            taxi.info();
            taxi.ongoing();
            taxi.done();

            taxi1.info();
            taxi1.ongoing();
            taxi1.done();

            Console.ReadKey();
        }
    }
}