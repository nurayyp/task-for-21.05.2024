namespace task13
{
    internal class Playlist
    {
        public Song[] songs = new Song[0];

        public void AddSong(Song song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
        }
        public void GetAllSongs()
        {
            foreach (var song in songs)
            {
                song.GetDetails(song);
            }
        }
        public void GetAllSongsByGenre(Genre genre)
        {
            foreach (var song in songs)
            {
                if (genre == song.Genre)
                {
                    song.GetDetails(song);
                }
            }
        }
    }
}
