using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;

namespace Web.Controllers
{
    public class ReunioesController : Controller
    {
        private EventosEntities db = new EventosEntities();

        // GET: Reunioes
        public ActionResult Index()
        {
            var reuniao = db.Reuniao.Include(r => r.Pessoa);
            return View(reuniao.ToList());
        }

        public ActionResult TelaEventos()
        {
            return View();
        }

        public ActionResult ReunioesAgendadas()
        {
            return View();
        }

        public ActionResult TelaCancelarPresenca()
        {
            return View();
        }

        // POST: Reunioes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Criador,Cancelado,Local,Data")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                db.Reuniao.Add(reuniao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Criador = new SelectList(db.Pessoa, "Identificacao", "Nome", reuniao.Criador);
            return View(reuniao);
        }

        // GET: Reunioes/Edit/5
        public ActionResult MarcarReuniao()
        {
            return View();
        }

        // POST: Reunioes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Criador,Cancelado,Local,Data")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reuniao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Criador = new SelectList(db.Pessoa, "Identificacao", "Nome", reuniao.Criador);
            return View(reuniao);
        }

        // GET: Reunioes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reuniao reuniao = db.Reuniao.Find(id);
            if (reuniao == null)
            {
                return HttpNotFound();
            }
            return View(reuniao);
        }

        // POST: Reunioes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reuniao reuniao = db.Reuniao.Find(id);
            db.Reuniao.Remove(reuniao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
