using System.Collections.Generic;

namespace MBCorpHealth.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T>
    {

        //server como atualiza��o ou inclus�o
        bool Gravar(T entidade);

        bool Excluir(T entidade);

        IList<T> ConsultarPorID(int identificador);

        IList<T> ConsultarPorTrechoNome(string nome);

        //   IList<T> retornarPorCPF(string CPF);             
    }
}