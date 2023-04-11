using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    public class Bike
    {
        public string brand; // string for brand of bike
        public string typeOfbike; // string for type of bike 
        public string color; // string for color of bike 
        public int numOfwheels; // integer for number of wheels 

        //Constructors
        public Bike(string brand, string kindOfbike, string color, int numOfwheels) //Parameters will be requested in main window, will disclose data from there. 
        {
            Brand = brand;
            typeOfbike = kindOfbike;
            Color = color;
            NumOfwheels = numOfwheels;
        }

        public string Brand { get => brand; set => brand = value; }
        public string MountainBike { get => typeOfbike; set => typeOfbike = value; }
        public string Color { get => color; set => color = value; }
        public int NumOfwheels { get => numOfwheels; set => numOfwheels = value; }

        public override string ToString()
        {
            return $"Her Bike: \n Bike Brand - {brand} \n Type of Bike- {typeOfbike} \n Color of bike- {color}\n Number of Wheels- {numOfwheels}";  // Format for when tostring is powered. 
        }
    }
}
