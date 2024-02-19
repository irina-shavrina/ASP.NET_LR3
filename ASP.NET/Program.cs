using System;
using ASP.NET.interfaces;
using ASP.NET.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IInfoCalculator, InfoCalculator>().AddTransient<ITimeAnalyzer, TimeAnalyzer>();
var app = builder.Build();

app.MapGet("/first/", () =>
{
    var infoCalculator = app.Services.GetService<IInfoCalculator>();
    return $"Add result of numbers 5;6 = {infoCalculator?.Add(5, 6)}\n" +
    $"Mult result of numbers 3f;4f = {infoCalculator?.Multiply(3f, 4f)}\n" +
    $"Sub result of numbers 5;6 = {infoCalculator?.Subtract(5, 6)}\n" +
    $"Div result of numbers 3.0;4.0 = {infoCalculator?.Divide(3.0, 4.0)}\n";
});

app.MapGet("/second/", () =>
{
    var dayTimeService = app.Services.GetService<ITimeAnalyzer>();
    return $"{dayTimeService?.GetTime(DateTime.Now)}";
});

app.Run();