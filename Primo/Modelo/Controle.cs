using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo.Modelo
{
    class Controle : AbsPropriedades
    {
        public Controle(string numero) : base(numero)
        {
            executar();
        }

        private void executar()
        {
            Validacao validacao = new Validacao(this.Numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.Num);
                this.Mensagem = primo.Mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
