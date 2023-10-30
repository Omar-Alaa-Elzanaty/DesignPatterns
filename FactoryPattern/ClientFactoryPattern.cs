using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AirLine;
using FactoryPattern.EnemyShips;

namespace FactoryPattern
{
    public class ClientFactoryPattern
    {
        public void RunEnemyShapSenario()
        {
            ShipsFactory factory = new ShipsFactory();

            Console.WriteLine("Enter D / A");
            char x = Console.ReadLine().ToCharArray()[0];

            var ship = factory.MakeFactory(x);

            if (ship != null)
            {
                ship.Attack();
                ship.Defence();
            }
        }
        public void RunFlyingCompanySenario()
        {
            FlyingCompany company;
            Console.WriteLine("Enter  EMA / CAIRO");
            var companyName = Console.ReadLine();
            if (companyName == "EMA")
            {
                company=new EMAFlyingCompany();
            }
            else
            {
                company = new CairoFlyingCompany();
            }
            
            company.StartTrip();
        }
    }
}
