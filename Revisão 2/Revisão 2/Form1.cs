using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão_2
{
    public partial class Form1 : Form
    {

        No noCabeca;

        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            numId.Focus();
        }

        private void Mostrar()
        {
            No no;

            lbxDados.Items.Clear();

            if (noCabeca == null)
            {
                MessageBox.Show("Lista Vazia!");
                return;
            }

            no = noCabeca;

            while (true)
            {
                if (no.Proximo == null)
                {
                    lbxDados.Items.Add(no.Valor.Nome);
                    break;
                }

                lbxDados.Items.Add(no.Valor.Nome);
                no = no.Proximo;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Id = numId.Value;
            aluno.Nome = txtNome.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Telefone = txtTelefone.Text;

            if (noCabeca == null)
            {
                noCabeca = new No();
                noCabeca.Valor = aluno;
                LimparCampos();
                Mostrar();
                return;
            }

            No novoNo = new No();
            No proximoNo = noCabeca;

            while (true)
            {
                if (proximoNo.Proximo == null)
                {
                    novoNo.Valor = aluno;
                    proximoNo.Proximo = novoNo;
                    Mostrar();
                    break;
                }

                proximoNo = proximoNo.Proximo;
            }

            LimparCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            No no;
            decimal cont = 1;

            if (noCabeca == null)
            {
                MessageBox.Show("Lista vazia!");
                return;
            }

            no = noCabeca;

            while (true)
            {
                if (cont == numId.Value)
                {
                    numId.Value = no.Valor.Id;
                    txtNome.Text = no.Valor.Nome;
                    txtEndereco.Text = no.Valor.Endereco;
                    txtTelefone.Text = no.Valor.Telefone;
                    break;
                }

                if (no.Proximo == null)
                {
                    break;
                }

                cont++;
                no = no.Proximo;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            No no;
            decimal Cont = 1;

            if (noCabeca == null)
            {
                MessageBox.Show("ListaVazia");
                return;
            }

            no = noCabeca;

            while (true)
            {
                if (numId.Value == Cont)
                {
                    no.Valor.Nome = txtNome.Text;
                    no.Valor.Endereco = txtEndereco.Text;
                    no.Valor.Telefone = txtTelefone.Text;
                    LimparCampos();
                    Mostrar();
                    break;
                }

                if (no.Proximo == null)
                {
                    break;
                }

                no = no.Proximo;
                Mostrar();
            }
        }
    }
}
