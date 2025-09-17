using System;
using DependencyInjection.Endpoints;
using DependencyInjection.Repositories;
using DependencyInjection.Test;

var builder = WebApplication.CreateBuilder(args);

// When need IgamesRepository, inject InMempryGamesRepository
builder.Services.AddSingleton<IGamesRepository, InMemoryGamesRepository>();

// Let Di create the class
// Transient means that it re-creates the instance everytime it is created
builder.Services.AddTransient<TestDi2>();

var app = builder.Build();

// injects GamesRepo into Map endpoints
app.CreateGamesEndpoints();

// using DI manually
TestDi test = new(new InMemoryGamesRepository());
test.PrintGames();

// using scope to grab the InMemoryGamesRepo
using var scope = app.Services.CreateScope();
var gamesRepo = scope.ServiceProvider.GetRequiredService<IGamesRepository>();
gamesRepo.GetAll();

// using Di to create the class that has IGamesRepositoryDi
var testDi2 = scope.ServiceProvider.GetRequiredService<TestDi2>();
testDi2.PrintGames();