using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    internal class No
    {
        private Aluno valor;
        private No proximo;

        public Aluno Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public No Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
    }
}
