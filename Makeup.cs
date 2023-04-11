using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    internal class Makeup
    {
      //FIELDS 
        string _favoritebrand; //string b/c name of brand 
        int _mostexpensiveitem; //int b/c price of item
        int _leastexpensiveitem; // int b/c price of item
        string _reasonforhobby; //string for information of reasoning. 
     //CONSTRUCTORS 
        public Makeup(string favoritebrand, int mostexpensiveitem, int leastexpensiveitem, string reasonforhobby) // Will be called in parameters in main window, will then placed data. 
        {
            Favoritebrand = favoritebrand;
            Mostexpensiveitem = mostexpensiveitem;
            Leastexpensiveitem = leastexpensiveitem;
            Reasonforhobby = reasonforhobby;
        }
        //PROPERTIES 
        public string Favoritebrand { get => _favoritebrand; set => _favoritebrand = value; }
        public int Mostexpensiveitem { get => _mostexpensiveitem; set => _mostexpensiveitem = value; }
        public int Leastexpensiveitem { get => _leastexpensiveitem; set => _leastexpensiveitem = value; }
        public string Reasonforhobby { get => _reasonforhobby; set => _reasonforhobby = value; }

        public override string ToString()
        {
            return $"Her Time: \n Favorite Makeup Brand: {_favoritebrand} \n Most Expensive Makeup Item: {Mostexpensiveitem} \n Least Expensive Item: {Leastexpensiveitem} \n Why makeup?:{_reasonforhobby}";//Format for TOSTRING. 
        }
    }
}
