using task13;

public static class Program
{
    public static void Main()
    {
        Song song1 = new Song("Kumralım", "Yaşar", new TimeSpan(00, 03, 30), Genre.Pop);
        Song song2 = new Song("Olmaz olsun", "Sezen Aksu", new TimeSpan(00, 03, 03), Genre.Pop);
        Song song3 = new Song("Gang", "Paster", new TimeSpan(00, 03, 13), Genre.Rap);
        Playlist playlist = new Playlist();
        playlist.AddSong(song1);
        playlist.AddSong(song2);
        playlist.GetAllSongs();
        playlist.GetAllSongsByGenre(Genre.Pop);
    }
}