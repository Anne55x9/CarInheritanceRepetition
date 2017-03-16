using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarInheritanceRepetition
{
    public class DieselCar : Car
    {
        /// <summary>
        /// DieselCar bool property returning true/false.
        /// </summary>

        public bool Filter { get; set; }
        public int DieselTax { get; set; }

        /// <summary>
        /// DieselCar constructor with inheritance from the class car.
        /// </summary>

        public DieselCar(string brand, int priceOfCar, int yearOfPurchase, string registrationNo, int kmLiter, bool filter) 
            : base(brand, priceOfCar, yearOfPurchase, registrationNo, kmLiter)
        {
            this.Filter = filter;
        }

        /// <summary>
        /// DieselCar constructor with inheritance from the class car and Filter parameter.
        /// </summary>
        /// 
        public DieselCar(string brand, int priceOfCar, int yearOfPurchase, string registrationNo, int kmLiter)
            :this(brand, priceOfCar, yearOfPurchase, registrationNo, kmLiter, true) 
        {
                
        }

        /// <summary>
        /// Public metode override of SemiAnnualTax.
        /// </summary>
        /// 

        public override int SemiAnnualTax()
        {
            if (Filter == false)
            {
               DieselTax = base.SemiAnnualTax() + 500;
            }
            else
            {
                DieselTax = base.SemiAnnualTax();
            }
            return DieselTax;
        }


        //Override af Tostring metode.

        public override string ToString()
        {
            return $"Car brand: {Brand}, price in kr: {PriceOfCar}, year of purchase: {YearOfPurchase}, Km per liter: {KmLiter}, particle filter: {Filter}";
        }

    }
}
