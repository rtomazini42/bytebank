using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//linha de teste
namespace bytebank.Funcionarios
{
    public class Diretor : Autenticavel
    {

        public Diretor(string cpf) : base(cpf)
        {

        }

        

        public string V { get; }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            //return Salario + base.GetBonificacao();
            return Salario * 0.5;
        } 
    }
}