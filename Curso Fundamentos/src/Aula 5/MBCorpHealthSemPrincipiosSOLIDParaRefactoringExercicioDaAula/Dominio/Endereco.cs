namespace MBCorpHealth.Dominio
{
    public class Endereco
    {
        public  Endereco() { }

        public Endereco(string logradouro, string complemento, string bairro, string municipio, string estado, string cep)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            CEP = cep;
        }

        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }



        public Endereco ConsultarEnderecoNosCorreios(string cep, TipoServicoDeConsulta tipoServicoDeConsulta)
        {
            if (tipoServicoDeConsulta == TipoServicoDeConsulta.ServicoCorreios)
                //consultaria servi�o web dos correios
                return new Endereco("rua 1", "casa 1", "vila madalena", "S�o Paulo", "SP", "02234143");
            else
            {
                if (tipoServicoDeConsulta == TipoServicoDeConsulta.ServicoCorporativo)
                    //consultaria servi�o corporativo da empresa
                    return new Endereco("rua 1", "casa 1", "vila madalena", "S�o Paulo", "SP", "02234143");
            }
            return null;
        }
    }
}