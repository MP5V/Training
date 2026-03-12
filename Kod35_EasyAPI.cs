//Задача 35: Top - level statements + Hello World
//Создай новый проект .NET 8/9 и напиши минимальный Program.cs без класса и Main

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from top-level statements!");

app.Run();
