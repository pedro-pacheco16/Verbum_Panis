using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbum_Panis.model_repository
{
    public interface IProduto
    {
        public void Cadastrar(Produto produto);
        public void ListarProdutos();
        public void ConsultarProduto(int id);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
