using MusicPlayerLive;
using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DatabaseReader r1 = new DatabaseReader();
        r1.ReadData();


        //using (SqliteConnection connection = new SqliteConnection(connectionString))
        //{


        //TODO: 2.commit: "Alle Songs abrufen und den Alben zuweisen"
        //     HINWEIS:
        //    Song song = new Song(songId, title, artist, duration);
        //    albums[albumId].AddSong(song);
        //    cmd.CommandText = "SELECT * FROM songs";
        //    using (var reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Song song = new Song(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
        //            albums[reader.GetInt32(4)].AddSong(song);
        //        }
        //    }

        //TODO: 3.commit: "Alle PlayLists aus DB lesen und die Songs zuweisen"
        //     HINWEIS: du kannst die category aus der DB mit "Enum.Parse" parsen: https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-7.0
        //    List<PlayList> playlists = new List<PlayList>();
        //    cmd.CommandText = "SELECT * FROM playlists";
        //    using (var reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            playlists.Add(new PlayList(reader.GetString(1), (Category)Enum.Parse(typeof(Category), reader.GetString(2))));
        //        }
        //    }
        //    cmd.CommandText = "SELECT * FROM playlist_songs";
        //    using (var reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            if (reader.GetInt32(0) == 1)
        //            {
        //                playlists[0].AddSong(FindSongById(reader.GetInt32(1), albums));
        //            }
        //            else if (reader.GetInt32(0) == 2)
        //            {
        //                playlists[1].AddSong(FindSongById(reader.GetInt32(1), albums));
        //            }
        //        }
        //    }


        //    MusicPlayer player = new MusicPlayer();
        //    foreach (Album album in albums.Values)
        //    {
        //        player.AddAlbum(album);
        //    }
        //    foreach (PlayList playlist in playlists)
        //    {
        //        player.AddPlayList(playlist);
        //    }

        //    Console.WriteLine(player);
        //}
    }

    // Hilfsmethode zum Suchen eines Songs anhand der ID
    static Song FindSongById(int id, Dictionary<int, Album> albums)
    {
        foreach (Album album in albums.Values)
        {
            foreach (Song song in album.Songs)
            {
                if (song.Id == id)
                {
                    return song;
                }
            }
        }
        return null;
    }
}




