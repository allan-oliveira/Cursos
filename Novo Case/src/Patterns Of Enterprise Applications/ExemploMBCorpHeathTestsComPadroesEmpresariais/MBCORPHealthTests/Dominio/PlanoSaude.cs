using System;
using System.Security.Cryptography.X509Certificates;

namespace MBCORPHealthTests
{
    public class PlanoSaude
    {
        public PlanoSaude()
        {
        }

        public virtual string RazaoSocial { get; protected set; }
        public virtual string CNPJ { get; protected set; }


        public PlanoSaude(string nome, string cnpj)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("RazaoSocial inv�lido");
            if (string.IsNullOrEmpty(cnpj)) throw new Exception("CNPJ inv�lido");

            RazaoSocial = nome;
            CNPJ = cnpj;
        }

        //Consultar� os servi�os dos planos de sa�de
        public virtual bool ConsultarCobertura(TipoExame tipoExame)
        {            
            ServicoConsultaCoberturaPlanoPortoSeguro servicoConsultaCoberturaPlanoPortoSeguro = new ServicoConsultaCoberturaPlanoPortoSeguro();
            return servicoConsultaCoberturaPlanoPortoSeguro.ConsultarCoberturaParaOExame(tipoExame);
        }

    }
}
