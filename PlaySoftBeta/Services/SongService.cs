using PlaySoftBeta.Models;

namespace PlaySoftBeta.Services;

public static class SongService
{
    static List<Song> Songs { get; }
    static int nextId = 1;

    public static List<Song> GetAll() => Songs;

    public static Song? Get(int id) => Songs.FirstOrDefault(p => p.songID == id);

    public static void Add(Song song)
    {
        song.songID = nextId++;
        Songs.Add(song);
    }

    public static void Delete(int id)
    {
        var song = Get(id);
        if(song is null)
            return;

        Songs.Remove(song);
    }

    public static void Update(Song song)
    {
        var index = Songs.FindIndex(p => p.songID == song.songID);
        if(index == -1)
            return;

        Songs[index] = song;
    }
}