using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbum_Panis.model_repository
{
    public class Livro : Produto
    {
        string autor;
        int NumeroDePg;
        public Livro(int id, int tipo, string nome, decimal preco, string autor, int NumeroDePg) : base(id, tipo, nome, preco)
        {
            this.autor = autor;
            this.NumeroDePg = NumeroDePg;
        }

        public string Getautor()
        {
            return autor;
        }
        public void Setautor(string autor)
        {
            this.autor = autor;
        }
        public int GetNumeroDePg()
        {
            return NumeroDePg;
        }
        public void SetNumeroDePg(int NumeroDePg)
        {
            this.NumeroDePg = NumeroDePg;
        }
        public override void visualizar()
        {
            base.visualizar();
            Console.WriteLine($"Autor do livro:{this.autor}");
            Console.WriteLine($"Número de páginas:{this.NumeroDePg}");
        }

    }
}
    

