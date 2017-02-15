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
      Post["/"] = _ => {
        string player1Input = Request.Form["player1"];
        string player2Input = Request.Form["player2"];
        RPS newRPS = new RPS(player1Input, player2Input);
        List<string> newResults = newRPS.GameMethod();
        return View["index.cshtml", newResults];
      };
    }
  }
}
