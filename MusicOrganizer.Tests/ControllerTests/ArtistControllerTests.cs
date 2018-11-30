using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Controllers;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistControllerTest
  {
    [TestMethod]
    public void Index_ReturnsAViewResult_True()
    {
        //Arrange
      ArtistController controller = new ArtistController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_RedirectsToCorrectAction_Index()
    {
        //Arrange
        ArtistController controller = new ArtistController();
        var viewResult = controller.Index() as ViewResult;

        //Act
        var result = viewResult.ViewName;
        // Console.WriteLine("This is viewResult.Viewname: " + viewResult.ViewName);
        //Assert
        Assert.AreEqual(result, "Index");
    }

    [TestMethod]
    public void Index_HasCorrectModelType_ArtistsList()
    {
        //Arrange
        ViewResult indexView = new ArtistController().Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Artist>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      ArtistController controller = new ArtistController();

      ActionResult createView = controller.Create("QOTSA");

      Assert.IsInstanceOfType(createView, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        //Arrange
        ArtistController controller = new ArtistController();
        RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
    }

    [TestMethod]
    public void Create_HasCorrectModelType_ArtistObject()
    {
        //Arrange
        ArtistController createView = new ArtistController();
        ViewResult createObject = createView.Create("QOTSA") as ViewResult;

        //Act
        var result = createView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(Artist));
    }
  }
}
