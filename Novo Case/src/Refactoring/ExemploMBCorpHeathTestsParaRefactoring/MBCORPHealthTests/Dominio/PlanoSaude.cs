using System;
using System.Security.Cryptography.X509Certificates;

namespace MBCORPHealthTests
{
    public class PlanoSaude
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }


        public PlanoSaude(string nome, string cnpj)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("RazaoSocial inv�lido");
            if (string.IsNullOrEmpty(CNPJ)) throw new Exception("CNPJ inv�lido");

            RazaoSocial = nome;
            CNPJ = cnpj;
        }

        //Consultar� os servi�os dos planos de sa�de
        public bool ConsultarCobertura(TipoExame tipoExame)
        {            
            ServicoConsultaCoberturaPlanoPortoSeguro servicoConsultaCoberturaPlanoPortoSeguro = new ServicoConsultaCoberturaPlanoPortoSeguro();
            return servicoConsultaCoberturaPlanoPortoSeguro.ConsultarCoberturaParaOExame(tipoExame);
        }

    }
}
