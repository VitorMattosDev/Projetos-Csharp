using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {

        private static Usuario[] usuarios =
        {

            new Usuario(){ Nome = "Vitor", Senha = "123"},
            new Usuario(){Nome = "Patricia", Senha = "qwer" },
            new Usuario(){Nome = "Pedro", Senha = "zxcc"}

        };

        private static Usuario _userLogado = null;

        private static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {

            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }

    }
}
