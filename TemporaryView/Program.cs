using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using  Model;
namespace TemporaryView
{
    class Program
    {
        public static void showGeoZones()
        {
            var b = DbHelper.getGeozones();
            foreach (var geozone in b)
            {
                Console.WriteLine(geozone.Geozone_id+" "+geozone.Name);
            }
        }
        public static void showTripInDuration()
        {
            var b = DbHelper.getRoute(1);
            foreach (var bb in b)
            {
                Console.WriteLine(bb[0]+" "+bb[1]);
            }
        }

        public static void showTripInDuration(long p)
        {
            var b = DbHelper.getRoute();
            foreach (var bb in b)
            {
                
                Console.WriteLine(bb[0] + " " + bb[1]+bb[2]);
            }
        }


        private static void Main(string[] args)
        {
            var b = DbHelper.Recursive();
            foreach (var bb in b)
            {
                Console.WriteLine(bb);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            showTripInDuration(3);
            showGeoZones();
            Console.ReadKey();
        }
    }
}
