using System;

public class Medico
{
    public Medico(string crm, string nome, string estado)
    {
        ValidarMedico(crm, nome, estado);
        CRM = crm;
        Nome = nome;
        Estado = estado;
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

    public string CRM { get; private set; }//Identificador
    public string Nome { get; private set; }
    public string Estado { get; private set; }


}