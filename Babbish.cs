using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    public class Babbish
    {
        string _name;
        string _story;
        string _Datetime;
        double servings;

        //uncertain how implement list in fields area. :( 

        public Babbish(string name, string story, string datetime, double servings)
        {
            Name = name;
            Story = story;
            Datetime = datetime;
            this.Servings = servings;
        }

        public string Name { get => _name; set => _name = value; }
        public string Story { get => _story; set => _story = value; }
        public string Datetime { get => _Datetime; set => _Datetime = value; }
        public double Servings { get => servings; set => servings = value; }

        public override string ToString()
        {
            return $"The Soup: \n Name of Soup: {_name} \n The story behind the soup: {_story} \n Cooking Time:{_Datetime} \n Serving Size: {servings}"; 
        }
    }
}
