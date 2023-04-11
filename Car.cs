using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    public class Car
    {
        //Fields 

        string _make; // string for make of car 
        string _model; // string for model of car
        int _year; // integer for the year 
        string _color; // string for the color 
        int _mileage; // int for miles  

        //Constructors 
        public Car(string make, string model, int year, string color, int mileage) 
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
        }

        //Properties 
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public override string ToString()
        {
            return $"Her Car: \n Make: {_make} \n Model: {_model} \n Year: {_year} \n Color of car: {_color} \n Mileage: {_mileage}.";  // Format when TO STRING is called. 
        }
    }
}
