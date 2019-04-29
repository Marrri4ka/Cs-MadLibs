using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/allforms")]//annotation
    public ActionResult Allforms()
    {
      return View();
    }

    [Route("/formhp")]//annotation
    public ActionResult Formhp()
    {
      return View();
    }
    [Route ("/storyhp")]
    public ActionResult Storyhp(string name, string noun, string secondnoun, string adjective, string options)
    {
      Variable myVariable = new Variable();
      myVariable.SetName(name);
      myVariable.SetNoun(noun);
      myVariable.SetSecondNoun(secondnoun);
      myVariable.SetAdjective(adjective);
      myVariable.SetColor(options);
      return View(myVariable);
    }

    [Route("/formlotr")]
    public ActionResult Formlotr()
    {
      return View();
    }

    [Route("/storylotr")]
    public ActionResult Storylotr(string noun, string secondnoun, string verb, string adjective)
    {
      VariablesLotr newVaribleLotr = new VariablesLotr();
      newVaribleLotr.SetNoun(noun);
      newVaribleLotr.SetSecondNoun(secondnoun);
      newVaribleLotr.SetVerb(verb);
      newVaribleLotr.SetAdjective(adjective);
      return View(newVaribleLotr);

    }
  }
}
