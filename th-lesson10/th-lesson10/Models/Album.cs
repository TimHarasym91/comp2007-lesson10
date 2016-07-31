using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace th_lesson10.Models
{
    public class Album
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Album()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public Album(string Title)
        {
            this.Title = Title;
        }

        public int AlbumID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}