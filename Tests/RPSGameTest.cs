using Xunit;
using RPSGame.Objects;
using System;
using System.Collections.Generic;

namespace RPSGame
{
  public class RPSGameTest
  {
    // [Fact]
    // public void ReturnInput_ForTwoEntries_TwoEntries()
    // {
    //   //arrange
    //   string player1Input = "rock";
    //   string player2Input = "scissors";
    //
    //   RPS testRPS = new RPS(player1Input, player2Input);
    //
    //   //act
    //   List<string> output = testRPS.GameMethod();
    //
    //   //assert
    //   List<string> newRPS = new List<string>{};
    //   newRPS.Add("rock");
    //   newRPS.Add("scissors");
    //
    //   Assert.Equal(newRPS, output);
    // }

    [Fact]
    public void ReturnTie_ForTwoEntriesSame_Tie()
    {
      //arrange
      string player1Input = "rock";
      string player2Input = "rock";

      RPS testRPS = new RPS(player1Input, player2Input);

      //act
      List<string> output = testRPS.GameMethod();

      //assert
      List<string> newRPS = new List<string>{};
      newRPS.Add("rock");
      newRPS.Add("rock");
      newRPS.Add("It's a tie");

      Assert.Equal(newRPS, output);
    }

    [Fact]
    public void ReturnPlayerOneWins_ForTwoEntriesDiff_PlayerOneWins()
    {
      //arrange
      string player1Input = "rock";
      string player2Input = "scissors";

      RPS testRPS = new RPS(player1Input, player2Input);

      //act
      List<string> output = testRPS.GameMethod();

      //assert
      List<string> newRPS = new List<string>{};
      newRPS.Add("rock");
      newRPS.Add("scissors");
      newRPS.Add("Player 1 wins!");

      Assert.Equal(newRPS, output);
    }

    [Fact]
    public void ReturnPlayerTwoWins_ForTwoEntriesDiff_PlayerTwoWins()
    {
      //arrange
      string player1Input = "scissors";
      string player2Input = "rock";

      RPS testRPS = new RPS(player1Input, player2Input);

      //act
      List<string> output = testRPS.GameMethod();

      //assert
      List<string> newRPS = new List<string>{};
      newRPS.Add("scissors");
      newRPS.Add("rock");
      newRPS.Add("Player 2 wins!");

      Assert.Equal(newRPS, output);
    }
  }
}
