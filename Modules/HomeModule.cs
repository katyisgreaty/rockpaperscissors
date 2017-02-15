using Nancy;
using RPSGame.Objects;
using System;
using System.Collections.Generic;

namespace RPSGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
