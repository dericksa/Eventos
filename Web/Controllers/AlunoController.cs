using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class AlunoController : Controller
    {
        private EventosEntities db = new EventosEntities();

        // GET: Aluno
        [HttpPost]
        public ActionResult Autenticar(Pessoa login)
        {
            try
            {

                if (pnAluno.Pesquisar(login.Identificacao) != null)
                {
                    Pessoa aluno = new Pessoa();

                    aluno = pnPessoa.Pesquisar(login.Identificacao);

                    if (aluno.Senha == login.Senha)
                    {
                        ViewBag.aluno = aluno.Nome;
                        return View();
                    }

                }
            }
            catch (Exception)
            {
                return RedirectToAction("Contact","Home");
                throw;
            }

            return View();
        }
        
        public ActionResult loginAluno()
        {
            return View();
        }

        public ActionResult telaCadastroAluno()
        {
            return View();
        }
        public ActionResult falhaCadastro(string e)
        {
            ViewBag.mensagem = e;
            return View();
        }

        public JsonResult Test()
        {
            return Json("teste", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult cadastroAluno(Aluno cadastro)
        {
            ViewBag.alunoNome = cadastro.Nome;  
            ViewBag.alunoRA = cadastro.RA;
            ViewBag.alunoSenha = cadastro.Senha;
            ViewBag.alunoCurso = cadastro.Curso;

            try
            {
                Aluno novo_aluno = new Aluno();

                novo_aluno.Nome = cadastro.Nome;
                novo_aluno.Curso = cadastro.Curso;
                novo_aluno.RA = cadastro.RA;

                pnAluno.Inserir(novo_aluno);
                return RedirectToAction("Index", "Home");
            }
            catch(Exception e)
            {
                ViewBag.mensagem = e;
                Console.Write(e);
                //return RedirectToAction("FalhaCadastro", "Aluno", e);
                return View();
            }
        }
    }    
}
