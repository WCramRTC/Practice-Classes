using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    internal class SpiritedAway
    {
        //FIELDS 
        
        string _title;
        string _movieName;
        string _dateTime;
        string _synopsis;

        //how do i make a list w/in the fields area? Cast: List<Actor> 

        public SpiritedAway(string title, string movieName, string dateTime, string synopsis)
        {
            Title = title;
            MovieName = movieName;
            DateTime = dateTime;
            Synopsis = synopsis;
        }

        public string Title { get => _title; set => _title = value; }
        public string MovieName { get => _movieName; set => _movieName = value; }
        public string DateTime { get => _dateTime; set => _dateTime = value; }
        public string Synopsis { get => _synopsis; set => _synopsis = value; }

        public override string ToString()
        {
            return $"The movie: \n Original Title: {_title} \n Movie Name: {_movieName} \n Release Date & Running Time: {_dateTime} \n Synopsis: {_synopsis}"; //The format when data prompts and when tostring is called. 
        }
    }
}
