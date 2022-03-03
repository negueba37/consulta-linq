using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProdutos = new List<Produto>() {
            new Produto{ Id = 1, CategoriaId = 1,Nome = "Camiseta", Status=true,Valor = 92},
            new Produto{ Id = 2, CategoriaId = 2,Nome = "Shorts", Status=true,Valor = 17},
            new Produto{ Id = 3, CategoriaId = 3,Nome = "Vestido", Status=true,Valor = 98},
            new Produto{ Id = 4, CategoriaId = 4,Nome = "Tenis", Status=true,Valor = 160},
            new Produto{ Id = 5, CategoriaId = 4,Nome = "Regata", Status=true,Valor = 70},
            new Produto{ Id = 6, CategoriaId = 3,Nome = "Meia", Status=true,Valor = 198},
            new Produto{ Id = 7, CategoriaId = 3,Nome = "Bermuda", Status=true,Valor = 161},
            new Produto{ Id = 8, CategoriaId = 2,Nome = "Camisa", Status=true,Valor = 184},

            };

            var listaCategorias = new List<Categoria>() {
            new Categoria{ Id = 1, Nome = "Camiseta" },
            new Categoria{ Id = 2, Nome = "Camiseta 1"},
            new Categoria{ Id = 3, Nome = "Camiseta"},
            new Categoria{ Id = 4, Nome = "Camiseta"},           
            };

            // Criando consulta linq
            var resultado = from produto in listaProdutos
                            where produto.Valor < 50
                            select produto;

            foreach (var item in resultado)
            {
                Console.WriteLine($"Produto {item.Nome} - Valor {item.Valor}");
            }

        }
    }
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Boolean Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }

    }
    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
