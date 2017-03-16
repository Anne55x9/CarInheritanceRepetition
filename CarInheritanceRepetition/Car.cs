using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritanceRepetition
{
    public class Car
    {
        /// <summary>
        /// Properties of the public class car.
        /// </summary>
        /// 
        public string Brand { get; set; }
        public int PriceOfCar { get; set; }
        public int YearOfPurchase { get; set; }
        public string RegistrationNo { get; set; }
        public int KmLiter { get; set; }

        public int RegPay { get; set; }

        /// <summary>
        /// Included an overloaded constructor with 5 parameters of the public class car's properties.
        /// </summary>

        public Car(string brand, int priceOfCar, int yearOfPurchase, string registrationNo, int kmLiter)
        {
            this.Brand = brand;
            this.PriceOfCar = priceOfCar;
            this.YearOfPurchase = yearOfPurchase;
            this.RegistrationNo = registrationNo;
            this.KmLiter = kmLiter; 
        }
        
        /// <summary>
        /// Public metode RegstrationPayment that returns an int.
        /// </summary>
        /// 

        public int RegistrationPayment()
        {
            if (YearOfPurchase <= 2014)
            {
                if (PriceOfCar <= 80500)
                {
                    RegPay = PriceOfCar * (105 / 100);
                }
                else
                {
                    RegPay = (80500 * (105 / 100)) + ((PriceOfCar - 80500) * (180/100));
                }
            }
            else
                if (PriceOfCar <= 81700)
                {
                RegPay = PriceOfCar * (105 / 100);
                }
                else
                {
                    RegPay = (81700 * (105 / 100)) + ((PriceOfCar - 81700) * (180 / 100));
                }
           return RegPay;
        }

        /// <summary>
        /// Public metode SemiAnnualTax that returns an int.
        /// </summary>
        /// 

        public int SemiAnnualTax()
        {
            return 1000;
        }

    }
}
