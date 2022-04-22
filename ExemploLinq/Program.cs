using System;
using System.Linq;
using ExemploLinq;

namespace ExemploLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fonte de dados
            var listaProdutos = new List<Produto>()
            {
                new Produto {Id = 9, CategoriaId = 2, Nome = "Playstation 5", Status = true, Valor = 5000},
                new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
                new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
                new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
                new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
                new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
                new Produto {Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
                new Produto {Id = 7, CategoriaId = 4, Nome = "Samsung A1", Status = true, Valor = 800},
                new Produto {Id = 7, CategoriaId = 4, Nome = "Iphone 13", Status = true, Valor = 5650},
                new Produto {Id = 7, CategoriaId = 4, Nome = "Iphone X", Status = true, Valor = 4000},
                new Produto {Id = 7, CategoriaId = 4, Nome = "Xiomi Redmi Note 10s", Status = true, Valor = 2000}
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vesturario"},
                new Categoria{Id = 4, Status = true, Nome = "Celulares"}
            };

            // Criar consulta LINQ
            var resultadoProdutos = from produto in listaProdutos where produto.Valor > 50 select produto;

            // Executar a consulta
            foreach (var result in resultadoProdutos)
            {
                Console.WriteLine($"{result.Id} | {result.Nome} | {result.Valor} | {result.CategoriaId}");
            }
            
        }
    }
}