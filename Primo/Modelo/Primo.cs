using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo.Modelo
{
    class Primo : AbsPropriedades
    {
        public Primo(int num) : base(num)
        {
            Verificar();
        }
        private void Verificar()
        {
            this.Mensagem = "É primo";
            for (int i = 2; i < this.Num; i++)
            {
                if (Num % i == 0)
                {
                    this.Mensagem = "Não é Primo";
                    break;
                }
            }
        }
    }
}
