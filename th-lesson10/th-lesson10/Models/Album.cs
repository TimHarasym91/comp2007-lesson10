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
        /// This constructor takes two parameters - Title, Description
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Description"></param>
        public Album(string Title)
        {
            this.Title = Title;
        }

        public virtual int AlbumID { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}