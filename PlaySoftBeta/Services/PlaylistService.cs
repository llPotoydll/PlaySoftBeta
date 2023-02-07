using PlaySoftBeta.Models;

namespace PlaySoftBeta.Services;

public static class PlaylistService
{
    static List<Playlist> Playlists { get; }

    static PlaylistService()
    {
        Playlists = new List<Playlist>
        {
            new Playlist { playlistID = 0, playListName = "PPlaylist", privacity = true }
        };
    }
    static int nextId = 1;

    public static List<Playlist> GetAll() => Playlists;

    public static Playlist? Get(int id) => Playlists.FirstOrDefault(p => p.playlistID == id);

    public static void Add(Playlist playlist)
    {
        playlist.playlistID = nextId++;
        Playlists.Add(playlist);
    }

    public static void Delete(int id)
    {
        var playlist = Get(id);
        if(playlist is null)
            return;

        Playlists.Remove(playlist);
    }

    public static void Update(Playlist playlist)
    {
        var index = Playlists.FindIndex(p => p.playlistID == playlist.playlistID);
        if(index == -1)
            return;

        Playlists[index] = playlist;
    }
}