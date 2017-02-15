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

    public RPS (string player1Input, string player2Input)
    {
      _player1Input = player1Input;
      _player2Input = player2Input;
    }

    public List<string> GameMethod()
    {
      _inputList.Add(_player1Input);
      _inputList.Add(_player2Input);
      if(_player1Input == _player2Input)
      {
        _inputList.Add("It's a tie");
      }
      return _inputList;
    }


  }
}
