using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritanceRepetition
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Liste a diselbiler.

            //List<DieselCar> ListDiesel = new List<DieselCar>();

            //3 Dieslebiler alle købt før eller lig 2014 med partikel filter.

            DieselCar Dcar1 = new DieselCar("Volvo", 80000, 2010, "AD55300", 30);
            DieselCar Dcar2 = new DieselCar("Peugot", 80500, 2013, "FD66400", 20);
            DieselCar Dcar3 = new DieselCar("Ford", 100000, 2014, "PL88333", 25);

            DieselCar Dcar4 = new DieselCar("Volvo", 80500, 2015, "KL55333", 20, false);
            DieselCar Dcar5 = new DieselCar("Ford", 100000, 2016, "HJ66222", 30, false);

            List<DieselCar> ListDiesel = new List<DieselCar>() { Dcar1, Dcar2, Dcar3, Dcar4, Dcar5 };

            foreach (var item in ListDiesel)
            {
                Console.WriteLine($"{item.ToString()},\n Registration payment: {item.RegistrationPayment()}, SemiAnnualTax: {item.SemiAnnualTax()}");
            }

            Console.ReadLine();

        }
    }
}
