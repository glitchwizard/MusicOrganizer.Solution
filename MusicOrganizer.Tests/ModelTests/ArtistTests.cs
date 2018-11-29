using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void Artist_RetrievesItsName_String()
    {
      string name = "test";
      Artist newArtist = new Artist(name);

      string result = newArtist.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void Artist_RetrievesItsId_Int()
    {
      string name = "test";
      Artist newArtist = new Artist(name);

      int result = newArtist.GetId();

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_RetrievesListOfArtists_List()
    {
      string artistOne = "Boingo";
      string artistTwo = "Wipers";
      Artist newArtistOne = new Artist(artistOne);
      Artist newArtistTwo = new Artist(artistTwo);

      List<Artist> artistList = new List<Artist> { newArtistOne, newArtistTwo };

      List<Artist> result = Artist.GetAll();

      CollectionAssert.AreEqual(artistList, result);
    }
  }
}
