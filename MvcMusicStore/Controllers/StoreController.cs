using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = storeDB.Genres.OrderBy(g => g.Name).ToList();
            return View(genres);
        }

        public ActionResult Browse(String genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }

        public ActionResult Details(Int32 id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}
