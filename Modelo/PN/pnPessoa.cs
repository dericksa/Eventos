using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
   public class pnPessoa
    {
        
        public static bool Inserir(Pessoa p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Pessoas.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Pessoa Pesquisar(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Pessoa p1 = new Pessoa();

                p1 = db.Pessoas.Find(id);

                return p1;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
