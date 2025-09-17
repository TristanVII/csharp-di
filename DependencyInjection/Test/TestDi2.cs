using System;
using DependencyInjection.Repositories;

namespace DependencyInjection.Test;

public class TestDi2(IGamesRepository gamesDi)
{
    public void PrintGames()
    {
        Console.WriteLine(gamesDi.GetAll());
    }
}
