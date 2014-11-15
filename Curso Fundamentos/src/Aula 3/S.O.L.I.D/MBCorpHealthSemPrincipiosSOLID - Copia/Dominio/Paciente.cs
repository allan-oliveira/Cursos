using System;

namespace MBCorpHealth.Dominio
{
    public class Paciente:Pessoa
    {
        public Paciente(string nome, string cpf) : base(nome, cpf)
        {
        }

        public  PlanoDeSaudeBase PlanoDeSaude { get; private set; }

        public void DefinirPlanoDeSaude(PlanoDeSaudeBase planoDeSaude)
        {
            PlanoDeSaude = planoDeSaude;
        }

        private void ValidarPlanoDeSaude(PlanoDeSaudeBase planoDeSaude)
        {
            if (planoDeSaude == null) throw new ArgumentNullException("� necess�rio informar o plano de sa�de!");

        }
    }
}