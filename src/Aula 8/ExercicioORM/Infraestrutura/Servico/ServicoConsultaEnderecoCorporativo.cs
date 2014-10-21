using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Dominio
{
    public class ServicoConsultaEnderecoCorporativo : ServicoConsultaEndereco
    {
        public override Endereco ConsultarEnderecoPorCep(string cep)
        {
            //consultaria servi�o corporativo
            return new Endereco("rua 1", "casa 1", "vila madalena", "S�o Paulo", "SP", "02234143");
        }
    }
}