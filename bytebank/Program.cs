﻿using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000.0, "546.879.157-20");
            carlos.Nome = "Carlos";
            //carlos.CPF = "546.879.157-20";
            //carlos.Salario = 2000;
            carlos.AumentarSalario();

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000.00,"454.658.148-3");
            roberta.Nome = "Roberta";
            //roberta.CPF = "454.658.148-3";
            //roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }
    }
}