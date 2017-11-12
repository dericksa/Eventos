using Modelo.DAO;
using Modelo.PN;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Controllers
{
    public class PessoaController
    {

        public static bool Autenticacao(Pessoa login)
        {
            try
            {
                if (pnPessoa.Pesquisar(login.Identificacao) != null)
                {
                    Pessoa cadastrado = new Pessoa();          
                    cadastrado = pnPessoa.Pesquisar(login.Identificacao);

                    if(login.Senha == cadastrado.Senha)
                    {
                        return true;
                    }
                }

                return false;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool Cadastro(Pessoa cadastro)
        {
            try
            {
                Pessoa nova_pessoa= new Pessoa();

                nova_pessoa.Nome = cadastro.Nome;
                nova_pessoa.Senha = cadastro.Senha;
                nova_pessoa.Identificacao = cadastro.Identificacao;
                nova_pessoa.Grupo = cadastro.Grupo;
                nova_pessoa.Curso = cadastro.Curso;
                nova_pessoa.Departamento = cadastro.Departamento;

                pnCadastro.Inserir(nova_pessoa);

                return true;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
