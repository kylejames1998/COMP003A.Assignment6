using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Truck extends the Vehicle class
    /// </summary>
    internal class Truck : Vehicle
    {
        /**** Fields Section ****/
        private double _sizeOftruckBed;

        /**** Constructors Section ****/
        /// <summary>
        /// Constructor that takes 4 parameters: truckBrand, truckModel, truckNumberOfWheels, and sizeOfTruckBed
        /// It reuses the base class (Vehicle)'s constructor that takes 3 parameters: Brand, Model, numberOfWheels
        /// </summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckNumberOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        /***** Properties Section *****/
        public double SizeOfTruckBed
        {
            get { return _sizeOftruckBed;}
            set { _sizeOftruckBed = value;}
        }

        /***** Methods Section *****/
        /// <summary>
        /// Overrides the base Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }

    }
}
