﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCorpHealth.Dominio
{
    public class Cartao
    {
        public Cartao(string numeroDoCartao, string nomeConformeEscritoNoCartao, string codigoDeSeguranca)
        {
            NumeroDoCartao = numeroDoCartao;
            NomeConformeEscritoNoCartao = nomeConformeEscritoNoCartao;
            CodigoDeSeguranca = codigoDeSeguranca;
        }

        public string NumeroDoCartao { get; private set; }
        public string NomeConformeEscritoNoCartao { get;private set; }
        public string CodigoDeSeguranca { get; private set; }        
    }



}
