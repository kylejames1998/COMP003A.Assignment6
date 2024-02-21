using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstracts describe a contract but does not provide a full implementation of the contract.
    /// Read: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        /***** Fields Section *****/
        // Note: In almost all programming languages, you would typically pair a field with a property
        // This is not a requirement in C# becuase it offers auto-property
        private string _brand;
        private string _model;
        private int _numberofwheels;


        /***** constructors section *****/
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor that takes 3 parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name="brand">String input for brand name</param>
        /// <param name="model">String input for model name</param>
        /// <param name="numberOfWheels">Integer input for number of wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        /***** Properties Section *****/
        /// <summary>
        /// Retrieve/Store Brand Information
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/store Model information
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retieve/Store Number of Wheels Information
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberofwheels; }
            set { _numberofwheels = value; }
        }

        /**** Methods Section *****/
        /// <summary>
        /// Prints the Brand, Model, and numner of wheels information
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of wheels: {NumberOfWheels}");
        }
    }
}
