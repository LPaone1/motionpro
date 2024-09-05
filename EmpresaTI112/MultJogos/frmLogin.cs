using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultJogos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            //Criando variáveis
            string usuario, senha;

            //Incializar as variáveis!
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("senac") && senha.Equals("senac"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuários ou senha inválidos.",
                "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
