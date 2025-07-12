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

            new Usuario(){ Nome = "vitor", Senha = "123"},
            new Usuario(){Nome = "patricia", Senha = "qwer" },
            new Usuario(){Nome = "pedro", Senha = "zxcc"}

        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
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
