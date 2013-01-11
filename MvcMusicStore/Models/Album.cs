using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public Int32 AlbumId { get; set; }
        public Int32 GenreId { get; set; }
        public Int32 ArtistId { get; set; }
        public String Title { get; set; }
        public Decimal Price { get; set; }
        public String AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}