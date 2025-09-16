using API.Models;

Console.Clear();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Notebook Dell", Quantidade = 15, Preco = 3500.50 },
    new Produto { Nome = "Smartphone Samsung", Quantidade = 30, Preco = 2200.00 },
    new Produto { Nome = "Monitor LG 24\"", Quantidade = 20, Preco = 800.99 },
    new Produto { Nome = "Teclado Mecânico", Quantidade = 50, Preco = 150.75 },
    new Produto { Nome = "Mouse Gamer", Quantidade = 40, Preco = 120.00 },
    new Produto { Nome = "Cadeira Gamer", Quantidade = 10, Preco = 950.00 },
    new Produto { Nome = "Webcam 1080p", Quantidade = 25, Preco = 300.00 },
    new Produto { Nome = "Fone de Ouvido Bluetooth", Quantidade = 35, Preco = 220.40 },
    new Produto { Nome = "SSD 1TB", Quantidade = 18, Preco = 900.00 },
    new Produto { Nome = "Fonte 650W", Quantidade = 12, Preco = 350.00 }
};

//Funcionalidades - Requisições
// - URL/Caminho/Endereço
// - Um metodo HTTP


app.MapGet("/", () => "API  de produtos");

app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});

app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);
});


app.Run();
