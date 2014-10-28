using System;

namespace MBCorpHealth.Dominio
{
    public class Exame
    {
        
        public DateTime DataAgendamento { get; private set; }
        public TipoExame TipoExame { get; private set; }
        public Resultado Resultado { get; private set; }
        public double ValorDoExame { get; private set; }

        public Exame(TipoExame tipoExame,DateTime dataDoAgenamento)
        {
            TipoExame = tipoExame;
            DataAgendamento = dataDoAgenamento;
        }

        public void InformarValorDoExame(double valor)
        {
            ValorDoExame = valor;
        }
        

        public void ValidarDadosDoExame(TipoExame tipoExame,DateTime dataDoAgenamento)
        {
            if(tipoExame==null)
                throw new ArgumentNullException("Tipo do exame precisa ser informado!");
            
            if (dataDoAgenamento<DateTime.Today)
                throw new ArgumentException(string.Format("Data de agendamento precisa ser maior que a data de hoje {0}",DateTime.Today));
        }

        public void InformarResultadoDoExame(Resultado resultado)
        {
            ValidarResultadoDoExame(resultado);
            Resultado = resultado;
        }

        private void ValidarResultadoDoExame(Resultado resultado)
        {
            if (resultado == null)
                throw new ArgumentNullException("� necess�rio informar um resultado de exame v�lido!");

            if (string.IsNullOrEmpty(resultado.Descricao))
                throw new ArgumentException("� necess�rio informar uma descri��o v�lida!");

            if (resultado.MedicoResponsavel==null)
                throw new ArgumentNullException("� necess�rio informar um m�dico!");

            if (resultado.Data>DateTime.MinValue)
                throw new ArgumentException(string.Format("� necess�rio informar uma data v�lida {0}!",resultado.Data));
        }
    }
}