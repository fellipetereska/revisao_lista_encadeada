using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_2
{
    internal class Aluno
    {
        private decimal id;
        private string nome;
        private string endereco;
        private string telefone;

        public decimal Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
