using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  //By adding : Controller to our HomeController class, we tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class
  public class HomeController : Controller
  {
    //route decorator. instead of visitng /home/hello it will be /hello
    [Route("/hello")]
    // (route) method
    public string Hello() { return "Hello friend!"; } //This Hello() method represents a route in our application. That is, a certain area of our application a user can visit.
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")] //This is to make it the homepage("Homepage" Routes invoked like this are called root paths.)
    //his is a class built into the MVC library meant to handle rendering views. Method returns built-in method View() It specifies that when invoked, this route should now return a view in the server's response to the client.
    public ActionResult Letter()
    {
      //instance of our LetterVariable class, and provide it to the view
      LetterVariable myLetterVariable = new LetterVariable();//object
      myLetterVariable.SetRecipient("Lina");
      myLetterVariable.SetSender("John");
      return View(myLetterVariable);
     }

    [Route("/journal")]
    public ActionResult Journal() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
     {
       LetterVariable myLetterVariable = new LetterVariable();
       myLetterVariable.SetRecipient(recipient);
       myLetterVariable.SetSender(sender);
       return View(myLetterVariable);
     }

  }
}
