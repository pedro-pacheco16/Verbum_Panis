using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbum_Panis.model_repository
{
    public class Imagem : Produto
    {
        private float tamanho;
        private string estilo, material, cor;
        
        public Imagem(int id, int tipo, string nome, decimal preco, string estilo, string material, string cor,float tamanho) : base(id, tipo, nome, preco)
        {
            this.material = material;
            this.tamanho = tamanho;
            this.estilo = estilo;
            this.cor = cor;

        }
        public string GetMaterial()
        {
            return material;
        }
        public void SetMaterial(string material)
        {
            this.material = material;
        }
        public float GetTamanho()
        {
            return tamanho;
        }
        public void SetTamanho(float tamanho)
        {
            this.tamanho = tamanho;
        }
        public string GetEstilo()
        {
            return estilo;
        }
        public void SetEstilo(string estilo)
        {
            this.estilo = estilo;
        }
        public string GetCor()
        {
            return cor;
        }
        public void SetCor(string cor)
        {
            this.cor = cor;
        }
        public override void visualizar()
        {
            base.visualizar();
            Console.WriteLine($"Tamanho da imagem:{this.tamanho}");
            Console.WriteLine($"Estilo:{this.estilo}");
            Console.WriteLine($"Material:{this.material}");
            Console.WriteLine($"cor:{this.cor}");
        }
    }
}
