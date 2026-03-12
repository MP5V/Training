/*Задача 36:Minimal API с GET и POST
Напиши минимальный API:

GET /hello → "Hello World"
GET /users/{id} → "Пользователь {id}"
POST /users → принимает JSON { "name": "Anna" } и возвращает "Создан пользователь Anna"*/



using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/hello", () => "Hello World!");

app.MapGet("/users/{id}", (int id) => $"Пользователь с ID: {id}");

app.MapPost("/users", ([FromBody] User user) =>
    Results.Created($"/users/{user.Id}", user));

app.Run();

record User(int Id, string Name);
