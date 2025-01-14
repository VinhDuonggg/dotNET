using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Models;

namespace VideoGameManagement.Repositories;

internal class GameRepository
{
    public List<Game> _data = [
        new Game { Name = "The Legend of Zelda: Breath of the Wild", Genre = "Action-adventure", Year = 2017, Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game developed and published by Nintendo. An entry in the longrunning The Legend of Zelda series, it was released for the Nintendo Switch and Wii U consoles on March 3, 2017." },
        new Game { Name = "The Witcher 3: Wild Hunt", Genre = "Action role-playing", Year = 2015, Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. Based on The Witcher series of fantasy novels by Polish author Andrzej Sapkowski, it is the sequel to the 2011 game The Witcher 2: Assassins of Kings." },
        new Game { Name = "Red Dead Redemption 2", Genre = "Action-adventure", Year = 2018, Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and is a prequel to the 2010 game Red Dead Redemption." },
        new Game { Name = "God of War", Genre = "Action-adventure", Year = 2018, Description = "God of War is a 2018 action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III." },
        ];
    public void Create(Game game)
    {
        _data.Add(game);
    }
    public void Create(string name, string genre, int year, string description)
    {
        _data.Add(new Game { Name = name, Genre = genre, Year = year, Description = description });
    }
    public Game[] Retrieve()
    {
        return _data.ToArray();
    }
    public Game Retrieve(string name)
    {
        Game found = null;
        foreach (Game b in _data)
        {
            if (b.Name == name) { found = b; break; }
        }
        return found;
    }
    public void Update(string name, Game game)
    {
        Game found = null;
        foreach (Game b in _data)
        {
            if (b.Name == name) { found = b; break; }
        }
        if (found != null)
        {
            found.Name = game.Name;
            found.Genre = game.Genre;
            found.Year = game.Year;
            found.Description = game.Description;
        }
    }
    public void Delete(string name)
    {
        Game found = null;
        foreach (Game b in _data)
        {
            if (b.Name == name) { found = b; break; }
        }
        if (found != null) { _data.Remove(found); }
    }
}
