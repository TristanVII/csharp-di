using System;
using DependencyInjection.Repositories;

namespace DependencyInjection.Test;

public class TestDi(IGamesRepository gamesDi)
{
    public void PrintGames()
    {
        Console.WriteLine(gamesDi.GetAll());
    }

}
