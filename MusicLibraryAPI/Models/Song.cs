﻿namespace MusicLibraryAPI.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set;}
        public string Album { get; set; }
        public string ReleaseDate { get; set;}
        public string Genre { get; set;}
        public int Likes { get ; set; }
    }
}
