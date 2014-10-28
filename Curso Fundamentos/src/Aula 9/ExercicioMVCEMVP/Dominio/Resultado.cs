using System;

namespace MBCorpHealth.Dominio
{
    public class Resultado
    {

        public DateTime DataResultado { get; private set; }
        public string Descricao { get; private set; }
        public Medico MedicoResponsavel { get; private set; }


        public Resultado(Medico medicoResponsavel, DateTime dataResultado, string descricao)
        {
            ValidarDadosParaCriacaoDoResultado(medicoResponsavel,dataResultado,descricao);
            MedicoResponsavel = medicoResponsavel;
            DataResultado = dataResultado;
            Descricao = descricao;
        }


        private void ValidarDadosParaCriacaoDoResultado(Medico medicoResponsavel, DateTime data, string descricao)
        {
            if (medicoResponsavel == null) throw new ArgumentNullException("O m�dico respons�vel deve ser informado!");
            if (string.IsNullOrEmpty(descricao )) throw new ArgumentNullException("A descri��o do resultado do exame deve ser informada!");
            if (data == DateTime.MinValue) throw new ArgumentException("� necess�rio informar uma data v�lida para o resultado!");
        }
    }
}