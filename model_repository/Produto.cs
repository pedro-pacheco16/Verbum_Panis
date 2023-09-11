using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbum_Panis.model_repository
{
    public abstract class Produto
    {
       
            int id;
            int tipo;
            string nome;
            decimal preco;

            public Produto(int id, int tipo, string nome, decimal preco)
            {
                this.id = id;
                this.nome = nome;
                this.tipo = tipo;
                this.preco = preco;
            }

            public int Getid()
            {
                return id;
            }
            public void Setid(int id)
            {
                this.id = id;
            }
            public string GetNome()
            {
                return nome;
            }
            public void SetNome(string nome)
            {
                this.nome = nome;
            }
            public int GetTipo()
            {
                return tipo;
            }
            public void SetTipo(int tipo)
            {
                this.tipo = tipo;
            }
            public decimal GetPreco()
            {
                return preco;
            }
            public void SetPreco(decimal preco)
            {
                this.preco = preco;
            }
            public virtual void visualizar()
            {
                string tipo = string.Empty;

                switch (this.tipo)
                {
                    case 1:
                        tipo = "livro";
                        break;
                    case 2:
                        tipo = "imagem";
                        break;
                }
                Console.WriteLine("\n\n*********************************************************************");
                Console.WriteLine("Dados do Produto:");
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("Numero do produto: " + this.id);
                Console.WriteLine("Tipo do Produto: " + this.tipo);
                Console.WriteLine("Nome do produto: " + this.nome);
                Console.WriteLine("Preço do Produto: " + this.preco);
            }
    }
}


