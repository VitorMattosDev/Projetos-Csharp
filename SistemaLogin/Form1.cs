using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while(CadastroUsuarios.UsuarioLogado == null)
            {
                this.Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar)
                {
                    Application.Exit();
                    return; //Ainda que a aplicação seja fechada com o método Application.Exit(), é necessário esse return para que o while não continue executando em segundo plano
                }
            }

            string userFormatado = CadastroUsuarios.UsuarioLogado.Nome.Substring(0, 1).ToUpper() + CadastroUsuarios.UsuarioLogado.Nome.Substring(1);
            label_BoasVindas.Text = "Bem vindo(a)\n" + userFormatado;
            this.Visible = true;
        }
    }
}
