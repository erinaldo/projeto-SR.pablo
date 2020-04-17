using Model;
using System;

namespace Dados
{
    public class Sessao
    {
        public LoginUsuario Usuario;
        private Sessao()
        {
        }

        private static Sessao instance;

        public static Sessao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sessao();
                }
                return instance;
            }
        }

        public void SalvaUsuarioSessao(LoginUsuario usuario)
        {
            try
            {
                Usuario = usuario;
            }
            catch (Exception eError)
            {
                throw eError;
            }
        }
       
    }
}
