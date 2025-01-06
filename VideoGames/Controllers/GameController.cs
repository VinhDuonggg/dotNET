using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Views;
using VideoGameManagement.Repositories;

namespace VideoGameManagement.Controllers;

internal class GameController
{
    GameRepository _repository = new();
    GameView _gameView = new();

    public void ListGames()
    {
        var games = _repository.Retrieve();
        _gameView.ListView(games);
    }

    public void SingleGame(string name)
    {
        var game = _repository.Retrieve(name);
        _gameView.SingleView(game);
    }
}
