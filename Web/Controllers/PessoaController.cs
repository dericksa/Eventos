using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class PessoaController : Controller
    {
        private EventosEntities db = new EventosEntities();

        // GET: Pessoa
        [HttpPost]
        public ActionResult Autenticar(Pessoa login)
        {
            try
            {

                if (pnPessoa.Pesquisar(login.Identificacao) != null)
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
                return RedirectToAction("Contact", "Home");
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
        public ActionResult cadastroAluno([Bind(Include = "Nome,Identificacao,Curso,Senha")] Pessoa cadastro)
        {

            if (pnCadastro.Inserir(cadastro))
            {
                return RedirectToAction("Index", "Home");
            }


            else
            {
                return RedirectToAction("FalhaCadastro", "Aluno");
                //return View();
            }
        }
    }
}
