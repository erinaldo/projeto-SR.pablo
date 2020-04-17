using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dados
{
    public interface IMetodos<T> where T : class
    {
        int Adicionar(T modelo);
        void Atualizar(T modelo);
        void Excluir(int codigo);
        T Consultar(int modelo);
        List<T> Listar(T modelo);
        T Todos(T modelo);
    }
}
