using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yield_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var theGalaxy in new Galaxies().NextGalaxy)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears.ToString());
            }
            Console.ReadKey();
        }
    }

    public class Galaxies
    {
        public Galaxies()
        {

        }
        public System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
        {
            get
            {
                yield return new Galaxy { Name = "Tadpole", MegaLightYears = 400 };
                yield return new Galaxy { Name = "Pinwheel", MegaLightYears = 25 };
                yield return new Galaxy { Name = "Milky Way", MegaLightYears = 0 };
                yield return new Galaxy { Name = "Andromeda", MegaLightYears = 3 };
            }
        }

    }

    public class Galaxy
    {
        public String Name { get; set; }
        public int MegaLightYears { get; set; }
    }
}
