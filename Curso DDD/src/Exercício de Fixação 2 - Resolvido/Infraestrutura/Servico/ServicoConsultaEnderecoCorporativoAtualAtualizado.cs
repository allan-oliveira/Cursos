namespace MBCorpHealth.Dominio
{
    public class ServicoConsultaEnderecoCorporativoAtualAtualizado : ServicoConsultaEndereco
    {
        public override Endereco ConsultarEnderecoPorCep(string cep)
        {
            //consultaria servi�o corporativo atual
            return new Endereco("rua 1", "casa 1", "vila madalena", "S�o Paulo", "SP", "02234143");
        }
    }
}