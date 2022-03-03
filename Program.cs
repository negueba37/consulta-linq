using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static List<Produto> listaProdutos = new List<Produto>();
        static List<Categoria> listaCategorias = new List<Categoria>();
        static void Main(string[] args)
        {
            CreateRepository();

            //FirsConsulta();
            //Filter("BerMuda");
            Order();

        }
        public static void Order() {
            var resultado = from produto in listaProdutos
                            orderby produto.Nome descending
                            select produto;


            Console.WriteLine($"");
            Console.WriteLine($"Resultado da consulta usando filtro");
            Console.WriteLine($"------------------------------------");
            foreach (var item in resultado)
            {
                Console.WriteLine($"Produto {item.Nome} - Valor {item.Valor}");
            }


        }
        public static void Filter(string aproduto) {

            //var resultado = from produto in listaProdutos
            //                where produto.Nome.ToLower() == aproduto.ToLower()
            //                select produto;

            //var resultado = from produto in listaProdutos
            //                where produto.Nome.ToLower().Substring(0,1) == "B".ToLower()
            //                select produto;

            //var resultado = from produto in listaProdutos
            //                where ! produto.Nome.ToLower().Contains("A".ToLower())&&
            //                produto.Status == true
            //                select produto;

        }
        static public void FirsConsulta() {
        
            var resultado = from produto in listaProdutos
                            where produto.Valor < 50
                            select produto;

            foreach (var item in resultado)
            {
                Console.WriteLine($"Produto {item.Nome} - Valor {item.Valor}");
            }
        }
        static public void CreateRepository() {
            listaProdutos.Add(new Produto { Id = 1, CategoriaId = 1, Nome = "Camiseta", Status = true, Valor = 92 });
            listaProdutos.Add(new Produto { Id = 2, CategoriaId = 2, Nome = "Shorts", Status = true, Valor = 17 });
            listaProdutos.Add(new Produto { Id = 3, CategoriaId = 3, Nome = "Vestido", Status = true, Valor = 98 });
            listaProdutos.Add(new Produto { Id = 4, CategoriaId = 4, Nome = "Tenis", Status = false, Valor = 160 });
            listaProdutos.Add(new Produto { Id = 5, CategoriaId = 4, Nome = "Regata", Status = true, Valor = 70 });
            listaProdutos.Add(new Produto { Id = 6, CategoriaId = 3, Nome = "Meia", Status = true, Valor = 198 });
            listaProdutos.Add(new Produto { Id = 7, CategoriaId = 3, Nome = "Bermuda", Status = true, Valor = 161 });
            listaProdutos.Add(new Produto { Id = 8, CategoriaId = 2, Nome = "Camisa", Status = false, Valor = 184 });

            listaCategorias.Add(new Categoria { Id = 1, Nome = "Camiseta" });
            listaCategorias.Add(new Categoria { Id = 2, Nome = "Camiseta 1" });
            listaCategorias.Add(new Categoria { Id = 3, Nome = "Camiseta" });
            listaCategorias.Add(new Categoria { Id = 4, Nome = "Camiseta" });
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
