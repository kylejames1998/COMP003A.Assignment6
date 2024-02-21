// Author: Kyle James
// Course: COMP003A
// Purpose: Code for Assignment 6
namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Vehicle1");
            // the line below is one way to instantiate a class
            Vehicle vehicle1 = new Car();
            vehicle1.Brand = "Tesla"; // you can access it's properties to get/set its value by using the syntax <variable name>.<property>
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();


            PrintSeparator("Vehicle2");
            // if the class you are instantiating has a constructor that does not take any parameters then you can simplify the value assignment using the syntax below
            Vehicle vehicle2 = new Car()
            {
                Brand = "Toyota", 
                Model = "Supra", 
                NumberOfWheels = 4
            };
            vehicle2.GetInfo();
            Console.WriteLine("But you can still access my Properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");


            PrintSeparator("Vehicle3");
            // if the class you are instantiating has a constructor that takes parameters then you can simpplify the value assignment by passing those values using the syntaax below
            Vehicle vehicle3 = new Truck("Ford", "F-150 1500", 6, 5.5);
            vehicle3.GetInfo();


            PrintSeparator("Vehicle4");
            // alternatively, you may use the syntax below, if for some reason your arguments are not in the specific sequence
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Tesla", truckModel: "Cybertruck", sizeOfTruckBed: 7.8);
            vehicle4.GetInfo();
        }

        /// <summary>
        /// Section Seperator
        /// </summary>
        /// <param name="sectionName">String input for the section name</param>
        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }

        // comment for testing 
    }
}
