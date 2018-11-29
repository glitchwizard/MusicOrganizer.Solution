using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name { get; set;}
    private static List<Artist> _artists = new List<Artist> {};
    private int _artistId;

    public Artist (string name)
    {
      this.Name = name;
      _artists.Add(this);
      _artistId = _artists.Count;
    }

    public int GetId()
    {
      return _artistId;
    }

    public static List<Artist> GetAll()
    {

      return _artists;
    }

    public static void ClearAll()
    {
      _artists.Clear();
    }

  }
}
