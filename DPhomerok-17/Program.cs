using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface IUnit
    {
        string type { get; set; }
    }
    class Solider : IUnit
    {
        public string type { get; set; } = "Solider";
    }
    class Tank : IUnit
    {
        public string type { get; set; } = "Tank";
    }
    class Helicopter : IUnit
    {
        public string type { get; set; } = "Helicopter";
    }
    interface IUnitFactory
    {
        IUnit createUnit();
    }

    interface IStage
    {
        List<IUnit> units { get; set; }
    }

}
