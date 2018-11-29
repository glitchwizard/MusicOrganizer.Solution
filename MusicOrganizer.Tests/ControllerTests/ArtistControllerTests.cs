using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Controllers;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
        //Arrange
      ArtistController controller = new ArtistController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_ArtistsList()
    {
        //Arrange
        // ArtistController controller = new ArtistController();
        ViewResult indexView = new ArtistController().Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Artist>));
    }
  }
}
