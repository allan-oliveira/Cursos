﻿using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.EventosDeDominio;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Exame
    {
        public Exame(TipoExame tipoExame)
        {
            TipoExame = tipoExame;
        }

        protected Exame()
        {
        }

        public TipoExame TipoExame { get; protected set; }
        public Laudo Laudo { get; protected set; }

        public void EmitirLaudo(Laudo laudo)
        {
            Laudo = laudo;
            EventosDoDominio.Disparar(new LaudoEmitido(this));
        }
    }
}