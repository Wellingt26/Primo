using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo.Modelo
{
    public abstract class AbsPropriedades
    {
        private String mensagem;
        private String numero;
        private int num;

        public int Num { get => num; set => num = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }

        protected AbsPropriedades(int num)
        {
            this.num = num;
        }

        protected AbsPropriedades(string numero)
        {
            this.numero = numero;
        }
    }
}
