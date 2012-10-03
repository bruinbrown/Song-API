using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SongAPI.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
    }
}