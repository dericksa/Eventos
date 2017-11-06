using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Controllers
{
    public class AlunoController
    {
        public static bool Autenticacao (Pessoa login)
        {
             try
            {

                if (pnAluno.Pesquisar(login.Identificacao) != null)
                {
                    Pessoa aluno = new Pessoa();

                    aluno = pnPessoa.Pesquisar(login.Identificacao);

                    if (aluno.Senha == login.Senha)
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


        public static bool Cadastro(Aluno cadastro)
        {
            try
            {
                Aluno novo_aluno = new Aluno();

                novo_aluno.Curso = cadastro.Curso;
                novo_aluno.RA = cadastro.RA;

                pnAluno.Inserir(novo_aluno);
                    
                return true;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
