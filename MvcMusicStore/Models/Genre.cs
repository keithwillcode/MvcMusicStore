using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public partial class Genre
    {
        public Int32 GenreId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}