using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsbPIM.DAL;

namespace tsbPIM.Modelo
{
    public class Controle
    {

        public bool tem;
        public String mensagem = "";
        public bool acessar(String email, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(email, senha);
            if(!loginDao.mensagem.Equals(""));
            {
                this.mensagem = loginDao.mensagem; 
            }
            return tem;
        }

        
        //{
            

           // LoginDaoComandos loginDao = new LoginDaoComandos();
           // mensagem = loginDao.cadFunc(idFunc, nomeFunc, cargo, sexoFunc, estCiv, cpfFunc, rgFunc, dataNascFunc, cepFunc, email, foneFunc);
           // if (!loginDao.mensagem.Equals(" ")) ;
            //{
               // this.mensagem = loginDao.mensagem;
           // }
            //return mensagem;
        //}
    }
}
