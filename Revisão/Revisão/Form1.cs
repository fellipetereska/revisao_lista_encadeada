using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão
{
    public partial class Form1 : Form
    {
        /* Variáveis */
        No noCabeca;

        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.IdAluno = Convert.ToInt32(txtCodigo.Text);
            aluno.NomeAluno = txtNome.Text;
            aluno.EndereçoAluno = txtEndereco.Text;
            aluno.TelefoneAluno = label4.Text;

            if (noCabeca == null)
            {
                noCabeca = new No();
                noCabeca.Valor = aluno;
                LimparCampos();
                txtCodigo.Focus();
            }

            No novoNo = new No();
            No proximoNo = noCabeca;

            while (true)
            {
                if (proximoNo.Proximo == null)
                {
                    novoNo.Valor = aluno;
                    proximoNo.Proximo = novoNo;
                    break;
                }

                proximoNo = proximoNo.Proximo;
            }

            LimparCampos();
            txtCodigo.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            No no;

            lbxDados.Items.Clear();

            if (noCabeca == null)
            {
                MessageBox.Show("Lista Vazia.");
                return;
            }

            no = noCabeca;

            while (true)
            {
                string Aluno = $"Aluno: {no.Valor.NomeAluno} - Código: {no.Valor.IdAluno}";

                if (no.Proximo == null)
                {
                    lbxDados.Items.Add(Aluno);
                    break;
                }

                lbxDados.Items.Add(Aluno);
                no = no.Proximo;
            }
        }
    }
}
