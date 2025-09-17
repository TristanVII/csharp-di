using System;
using DependencyInjection.Repositories;

namespace DependencyInjection.Endpoints;

public static class GamesEndpoint
{

    public static void CreateGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games");

        // Will be injected with DI from AddSingleton
        group.MapGet("/", (IGamesRepository games) => games.GetAll());
    }
}
