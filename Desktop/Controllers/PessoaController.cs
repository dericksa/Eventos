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
                if (pnPesquisar.Pesquisar(login.Identificacao) != null)
                {
                    Pessoa cadastrado = new Pessoa();          
                    cadastrado = pnPesquisar.Pesquisar(login.Identificacao);

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

        public static bool is_Admin(int id)
        {
            try
            {
                if (pnPesquisar.Pesquisar(id).Adm == true)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool is_Professor(int id)
        {
            try
            {
                if (pnPesquisar.Pesquisar(id).Grupo.Equals("Professor"))
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool is_Palestrante(int id)
        {
            try
            {
                if (pnPesquisar.Pesquisar(id).Palestrante == true)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Mudar_Permissao(int id, string perm)
        {
            try
            {

                Pessoa pessoa = new Pessoa();
                pessoa = pnPesquisar.Pesquisar(id);

                pessoa.Palestrante = pessoa.Organizador = pessoa.Adm = false;

                if(perm.Equals("Aluno") || perm.Equals("Professor"))
                {
                    pessoa.Grupo = perm;
                }
                else if (perm.Equals("Administrador"))
                {
                    pessoa.Adm = true;
                }
                else if (perm.Equals("Palestrante"))
                {
                    pessoa.Palestrante = true;
                }
                else if (perm.Equals("Organizador"))
                {
                    pessoa.Organizador = true;
                }

                if (pnEditar.Editar_Pessoa(pessoa))
                {
                    Console.WriteLine("Editou\n");
                }

                return true;


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
                nova_pessoa.Palestrante = cadastro.Palestrante;
                nova_pessoa.Adm = cadastro.Adm;

                pnCadastro.Inserir_Pessoa(nova_pessoa);

                return true;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
