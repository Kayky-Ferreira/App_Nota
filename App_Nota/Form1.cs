using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Nota
{
    public partial class FrmPrincipal : Form
    {
        //variáveis global
        float nota1, nota2, nota3, nota4, media;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Informações da tela
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dData.Text = DateTime.Today.ToString();
            lblNome.Text = Program.user1;
        }

        //Método para os calculos
        public void calcular()
        {
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            lblMedia.Text = media.ToString();

        }

        //comando do botão Executar
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            calcular();
        }

        //Comando do Botão "Situaçao do Aluno"
        private void btn_Situação_aluno_Click(object sender, EventArgs e)
        {
            if (media >= 6)
            {
                lbl_Situacao.Text = "Parabéns, você está aprovado!!";
            }
            else
            {
                lbl_Situacao.Text = "Sinto muito, Você está reprovado!!";
            }
        }


    }
}
