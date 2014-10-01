using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using MBCorpHealth.Dominio.Contratos;
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
            ValidarDadosDoAgendamento(paciente,medicoSolicitante);

            Paciente = paciente;
            MedicoSolicitante = medicoSolicitante;
        }

        private void ValidarDadosDoAgendamento(Paciente paciente, Medico medicoSolicitante)
        {
            if (paciente ==null)
                throw new ArgumentNullException("Paciente inv�lido");

            if (medicoSolicitante == null)
                throw new ArgumentException("M�dico Inv�lido");
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
        ServicoCorreios,
        ServicoCorporativoAtual,
        ServicoCorporativoAtualAtualizado
    }
}