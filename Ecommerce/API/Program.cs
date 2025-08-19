var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Funcionalidades - Requisições
// - URL/Caminho/Endereço
// - Um metodo HTTP


app.MapGet("/", () => "Minha segunda API em C#");

app.MapGet("/endereco", () => "Outra funcionalidade!");

app.MapPost("/endereco", () => "Funcionalidade!");




app.Run();
