﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoPOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public int adicionarouremoverEstoque(int qtd)
        {
            return Quantidade += qtd;
        }
    }
}
