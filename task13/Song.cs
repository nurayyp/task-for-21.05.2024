namespace task13
{
    internal class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public TimeSpan Time { get; set; }
        public Genre Genre { get; set; }

        public Song(string name, string artist, TimeSpan time, Genre genre)
        {
            Name = name;
            Artist = artist;
            Time = time;
            Genre = genre;
        }
        internal void GetDetails(Song song)
        {
            Console.WriteLine($"{song.Name} {song.Artist} {song.Genre} - {song.Time}");
        }
    }
    public enum Genre
    {
        Pop,
        Rap,
        Jazz,
        Classic
    }
}
