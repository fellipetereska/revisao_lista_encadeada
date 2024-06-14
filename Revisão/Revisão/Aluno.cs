using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    internal class Aluno
    {
        private int idAluno;
        private string nomeAluno;
        private string enderecoAluno;
        private string telefoneAluno;

        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public string NomeAluno
        {
            get { return nomeAluno; }
            set { nomeAluno = value; }
        }

        public string EndereçoAluno
        {
            get { return enderecoAluno; }
            set { enderecoAluno = value; }
        }

        public string TelefoneAluno
        {
            get { return telefoneAluno; }
            set { telefoneAluno = value; }
        }
    }
}
