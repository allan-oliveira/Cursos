using System;
using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Infraestrutura.Servico;

namespace MBCorpHealth.Dominio
{
    public class Agendamento
    {

        public int Identificador { get; private set; }
        public Paciente Paciente { get; private set; }
        public Medico MedicoSolicitante { get; private set; }
        public ISet<Exame> Exames { get; private set; }             

        public void CriarAgendamento(Paciente paciente, Medico medicoSolicitante)
        {

            if (string.IsNullOrEmpty(paciente.CPF))
                throw new ArgumentNullException("Paciente inv�lido");

            if (string.IsNullOrEmpty(medicoSolicitante.CRM))
                throw new ArgumentException("M�dico Inv�lido");

            Paciente = paciente;
            MedicoSolicitante = medicoSolicitante;
        }

        public void AdicionarExame(Exame exame)
        {
            if (Exames == null)
                Exames = new HashSet<Exame>();

            if (String.IsNullOrEmpty(exame.TipoExame.NomeExame))
                throw new ArgumentException("Exame Inv�lido");

            if (Paciente.PlanoDeSaude.VerificarCobertura(exame) == true)
                exame.InformarValorDoExame(0);
            
            Exames.Add(exame);
        }
           
        public double RetornarValorTotalDoAgendamento()
        {
            return double.MinValue + Exames.Sum(exame => exame.ValorDoExame);
        }

     
    }

    public enum TipoServicoDeConsulta
    {
        ServicoCorporativo,
        ServicoCorreios
    }
}