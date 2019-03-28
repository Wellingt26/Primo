using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo.Modelo
{
    class Validacao : AbsPropriedades
    {
        public Validacao(string numero) : base(numero)
        {

            validar();
        }

        private void validar()
        {
            this.Mensagem = "";
            try
            {
                this.Num = Convert.ToInt32(Numero);
            }
            catch (Exception)
            {
                this.Mensagem = "Número Inválido";
            }

        }
    }
}
