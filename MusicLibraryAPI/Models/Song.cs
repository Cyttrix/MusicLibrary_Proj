namespace MusicLibraryAPI.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string SongTitle { get; set; }
        public string SongArtist { get; set;}
        public int SongYear { get; set; }
        public string SongLength { get; set;}

    }
}
