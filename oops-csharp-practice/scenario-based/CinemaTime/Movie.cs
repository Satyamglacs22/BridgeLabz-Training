using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTime
{
    internal class Movie
    {
        private string movieName;
        private string timeStamp;

          public  string MovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }
        public string TimeStamp
        {
            get
            {
                return timeStamp;
            }
            set
            {
                timeStamp = value;
            }
        }
    }
}
