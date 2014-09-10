using System;

namespace MBCORPHealthTests
{
    public class Atendente
    {
        public  Atendente(string nome, string cpf)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("nome inv�lido");
            if (string.IsNullOrEmpty(cpf)) throw new Exception("cpf inv�lido");

            Nome = nome;
            CPF = cpf;
        }

        public Atendente()
        {
        }

        public virtual string Nome { get; protected set; }
        public virtual string CPF { get; protected set; }
    }
}