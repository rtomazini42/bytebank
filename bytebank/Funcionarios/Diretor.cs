using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//linha de teste
namespace bytebank.Funcionarios
{
    public class Diretor : Funcionario
    {
        
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}