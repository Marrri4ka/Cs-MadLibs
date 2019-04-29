using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/formhp")]//annotation
    public ActionResult Formhp()
    {
      return View();
    }
    [Route ("/storyhp")]
    public ActionResult Storyhp(string name, string noun, string secondnoun, string adjective)
    {
      Variable myVariable = new Variable();
      myVariable.SetName(name);
      myVariable.SetNoun(noun);
      myVariable.SetSecondNoun(secondnoun);
      myVariable.SetAdjective(adjective);
      return View(myVariable);
    }
  }
}
