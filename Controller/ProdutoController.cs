using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verbum_Panis.model_repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Verbum_Panis.Controller
{
    internal class ProdutoController : IProduto
    {
        private readonly List<Produto> produtosLista = new();

        int id = 0;
        public void Atualizar(Produto produto)
        {
            var buscarProduto = BuscarNalista(produto.Getid());

            if (buscarProduto is not null)
            {
                var index = produtosLista.IndexOf(buscarProduto);

                produtosLista[index] = produto;

                Console.WriteLine($"O Produto de número {produto.Getid()} foi atualizado com sucesso ");

            }
            else
            {
                Console.WriteLine($"O Produto de número {id} não foi encontrado!");
                id = Convert.ToInt32(Console.ReadLine());

            }
        }

        public void Cadastrar(Produto produto)
        {
            produtosLista.Add(produto);
            Console.WriteLine($"Produto de número {produto.Getid()} foi cadastrado com sucesso!");

        }

        public void ConsultarProduto(int id)
        {
            var consultar = BuscarNalista(id);

            if (consultar is not null)
            {
                consultar.visualizar();
            }
            else
            {
                Console.WriteLine($"O Produto de número {id} não foi encontrado!");

            }

        }

        public void Deletar(int id)
        {
            var produto = BuscarNalista(id);

            if (produto is not null)
            {
                if (produtosLista.Remove(produto) == true)
                {
                    Console.WriteLine($"O cProduto de número {id} foi apagado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine($"O Produto de número {id} não foi encontrado!");
                id = Convert.ToInt32(Console.ReadLine());

            }
        }

        public void ListarProdutos()
        {
            foreach (var produto in produtosLista)
            {
                produto.visualizar();
            }
        }

        public int GerarNumeros()
        {
            return ++id;
        }
        public Produto? BuscarNalista(int id)
            {
                foreach (var produto in produtosLista)
                {
                    if (produto.Getid() == id)
                    {
                        return produto;
                    }

                }
                return null;
            }


        }
    }
