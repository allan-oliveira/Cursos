using System;

namespace HomeBrokerMBCorp.Dominio
{
    public class Ordem
    {
        public Ordem(Acao acao, double valor, int quantidade, Usuario usuario, TipoOperacao tipoOperacao)
        {

            if (Acao == null)
                throw new ArgumentNullException("Favor informar uma a��o");

            if (Valor <= 0)
                throw new ArgumentNullException("Valor da a��o n�o pode ser zero ou menor");

            if (Quantidade <= 0)
                throw new ArgumentNullException("Quantidade n�o pode ser zero ou menor");

            if (Usuario == null)
                throw new ArgumentNullException("Favor informar o usu�rio");

            if (TipoOperacao == null)
                throw new ArgumentNullException("Favor informar o Tipo de Operacao");

            Acao = acao;
            Valor = valor;
            Quantidade = quantidade;
            Usuario = usuario;
            TipoOperacao = tipoOperacao;
        }

        public Acao Acao { get; private set; }
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }
        public Usuario Usuario { get; private set; }
        public TipoOperacao TipoOperacao {get; private set; }
    }
}