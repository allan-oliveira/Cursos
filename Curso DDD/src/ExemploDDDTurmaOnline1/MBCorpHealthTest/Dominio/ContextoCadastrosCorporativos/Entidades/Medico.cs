using System;

namespace MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades
{
    public class Medico
    {
        public Medico(string crm, string nome, string estado)
        {
            ValidarMedico(crm, nome, estado);
            CRM = crm;
            Nome = nome;
            Estado = estado;
        }

        protected Medico()
        {
        }

        private void ValidarMedico(string crm, string nome, string estado)
        {
            if (String.IsNullOrEmpty(crm))
                throw new Exception("CRM inv�lido");

            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome inv�lido");

            if (String.IsNullOrEmpty(estado))
                throw new Exception("Estado inv�lido");
        }

        public string CRM { get; protected set; }//Identificador
        public string Nome { get; protected set; }
        public string Estado { get; protected set; }


    }
}