using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_lojinha
{
    public class class_controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            class_login clogin = new class_login();
            tem = clogin.verificar_login(login,senha);
            if (!clogin.mensagem.Equals(""))
            {
                this.mensagem = clogin.mensagem;
            }
            return tem;

        }
    }
}
