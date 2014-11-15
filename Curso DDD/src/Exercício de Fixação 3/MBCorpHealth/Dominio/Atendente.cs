using System;

namespace MBCorpHealth.Dominio
{
    public class Atendente:Pessoa
    {
        public int NumeroMatricula { get; private set; }    

        public Atendente(string nome, string cpf,int numeroDeMatricula) : base(nome, cpf)
        {
            ValidarDadosDoAtendente(numeroDeMatricula);
            NumeroMatricula = numeroDeMatricula;
        }

        private void ValidarDadosDoAtendente(int  numeroDaatricula)
        {
            if (numeroDaatricula>int.MinValue) throw new ArgumentException("� necess�rio informar um n�mero de matr�cula!");
        }                      
    }
}