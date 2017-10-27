using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Controllers
{
    public class PessoaController
    {

        public static bool Cadastro(Pessoa cadastro)
        {
            try
            {
                Pessoa nova_pessoa= new Pessoa();

                nova_pessoa.Nome = cadastro.Nome;
                nova_pessoa.Senha = cadastro.Senha;
                nova_pessoa.Identificacao = cadastro.Identificacao;

                pnPessoa.Inserir(nova_pessoa);

                return true;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
