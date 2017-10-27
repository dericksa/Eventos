using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnProfessor
    {


        public static bool Inserir(Professor p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Professores.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Professor Pesquisar(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Professor p1 = new Professor();

                p1 = db.Professores.Find(id);

                return p1;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
