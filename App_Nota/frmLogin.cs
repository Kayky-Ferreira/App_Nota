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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string nomeuser = "Kayky";
            string senha = "1234";
            //puxando um var do Programa apenas para testar e puxar para o Form1
            Program.user1 = nomeuser;
            Program.senha_user1 = senha;
            
            //Verificando Senhas
            if (txt_Nome_login.Text == "" && txt_Senha_Login.Text == "")
            {
                MessageBox.Show("Digite seu nome e senha nos campos");
                return;
            }
            //Diferentes possibilidades de erro de login
            else if (txt_Nome_login.Text != nomeuser && txt_Senha_Login.Text != senha || txt_Nome_login.Text == nomeuser && txt_Senha_Login.Text != senha || txt_Nome_login.Text != nomeuser && txt_Senha_Login.Text == senha)
            {
                MessageBox.Show("Nome ou senha incorretos!!");
                return;
            }
            //Nome e senha certo
            else if (txt_Nome_login.Text == nomeuser && txt_Senha_Login.Text == senha)
            {
                //Abrir segunda tela
                FrmPrincipal frm = new FrmPrincipal();
                frm.ShowDialog();

                //Fechar tela de login

                this.Close();
                return;

            }

             


        }
    }
}
