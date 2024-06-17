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

        No noCabeca;
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtId.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.IdAluno = Convert.ToInt32(txtId.Text);
            aluno.NomeAluno = txtNome.Text;
            aluno.EnderecoAluno = txtEndereco.Text;
            aluno.TlefoneAluno = txtTelefone.Text;

            if (noCabeca == null)
            {
                noCabeca = new No();
                noCabeca.Valor = aluno;
                LimparCampos();
                return;
            }

            No novoNo = new No();
            No proximoNo = noCabeca;

            while (true) 
            {
                if (proximoNo.Proximo == null)
                {
                    novoNo.Valor = aluno;
                    LimparCampos();
                    break;
                }

                proximoNo = proximoNo.Proximo;
            }

            LimparCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            No no;

            lbxAlunos.Items.Clear();

            if (noCabeca == null)
            {
                MessageBox.Show("Lista vazia!");
                return;
            }

            no = noCabeca;

            while (true)
            {
                string Aluno = $"Aluno: {no.Valor.NomeAluno} - Código: {no.Valor.IdAluno}";
                
                if (no.Proximo == null)
                {
                    lbxAlunos.Items.Add(Aluno);
                    break;
                }

                lbxAlunos.Items.Add(Aluno);
                no = no.Proximo;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            No no;
            int cont = 1;

            if (noCabeca == null)
            {
                MessageBox.Show("Lista vazia!");
            }

            no = noCabeca;

            while (true)
            {
                if (cont == Convert.ToInt32(txtPesquisar.Text))
                {
                    txtId.Text = no.Valor.IdAluno.ToString();
                    txtNome.Text = no.Valor.NomeAluno;
                    txtEndereco.Text = no.Valor.EnderecoAluno;
                    txtTelefone.Text = no.Valor.TlefoneAluno;
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
            int id = Convert.ToInt32(txtId.Text);

            if (noCabeca == null)
            {
                MessageBox.Show("Lista vazia!");
                return;
            }

            no = noCabeca;

            while (true)
            {
                if (no.Valor.IdAluno == id)
                {
                    no.Valor.NomeAluno = txtNome.Text;
                    no.Valor.EnderecoAluno = txtEndereco.Text;
                    no.Valor.TlefoneAluno = txtTelefone.Text;
                    LimparCampos();
                    break;
                }

                if (no.Proximo == null)
                {
                    break;
                }

                no = no.Proximo;
            }
            
        }
    }
}
