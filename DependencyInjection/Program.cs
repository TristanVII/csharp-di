using System;
using DependencyInjection.Endpoints;
using DependencyInjection.Repositories;
using DependencyInjection.Test;

var builder = WebApplication.CreateBuilder(args);

// When need IgamesRepository, inject InMempryGamesRepository
builder.Services.AddSingleton<IGamesRepository, InMemoryGamesRepository>();

var app = builder.Build();

// injects GamesRepo into Map endpoints
app.CreateGamesEndpoints();

// using DI manually
TestDi test = new(new InMemoryGamesRepository());
test.PrintGames();

// using scope
using var scope = app.Services.CreateScope();
var gamesRepo = scope.ServiceProvider.GetRequiredService<IGamesRepository>();
gamesRepo.GetAll();