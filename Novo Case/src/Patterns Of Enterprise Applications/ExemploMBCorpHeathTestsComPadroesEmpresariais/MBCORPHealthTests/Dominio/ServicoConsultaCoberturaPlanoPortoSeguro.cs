using System;

namespace MBCORPHealthTests
{
    public class ServicoConsultaCoberturaPlanoPortoSeguro:IServicoConsultaCoberturaPlano {
        public ServicoConsultaCoberturaPlanoPortoSeguro()
        {
        }

        public virtual bool ConsultarCoberturaParaOExame(TipoExame tipoExame)
        {
            //Em um caso real, consultar�amos o servi�o disponibilizado pela Porto Seguro
            return true;
        }


    }
}