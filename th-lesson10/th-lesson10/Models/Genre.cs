using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace th_lesson10.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }

        /// <summary>
        /// This constructor takes one paramter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }

        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}