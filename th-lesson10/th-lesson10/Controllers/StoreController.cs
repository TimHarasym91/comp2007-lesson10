using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using th_lesson10.Models;

namespace th_lesson10.Controllers
{

    
    public class StoreController : Controller
    {
        MusicStoreContext storeDB = new MusicStoreContext();
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}