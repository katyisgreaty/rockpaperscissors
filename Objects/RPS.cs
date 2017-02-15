using Nancy;
using System;
using System.Collections.Generic;

namespace RPSGame.Objects
{
  public class RPS
  {
    private string _player1Input;
    private string _player2Input;
    private List<string> _inputList = new List<string>();
    private List<string> _computerPlay = new List<string> { "rock", "paper", "scissors" };

    public RPS (string player1Input)
    {
      _player1Input = player1Input;
      Random comp = new Random();
      int index = comp.Next(0, 3);
      _player2Input = _computerPlay[index];
    }

    public List<string> GameMethod()
    {
      _inputList.Add(_player1Input);
      _inputList.Add(_player2Input);
      if(_player1Input == _player2Input)
      {
        _inputList.Add("It's a tie");
      }
      else if (((_player1Input == "rock") && (_player2Input == "scissors")) || ((_player1Input == "scissors") && (_player2Input == "paper")) || ((_player1Input == "paper") && (_player2Input == "rock")))
      {
        _inputList.Add("Player 1 wins!");
      }
      else if (((_player2Input == "rock") && (_player1Input == "scissors")) || ((_player2Input == "scissors") && (_player1Input == "paper")) || ((_player2Input == "paper") && (_player1Input == "rock")))
      {
        _inputList.Add("Player 2 wins!");
      }
      return _inputList;
    }


  }
}
