using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
   public class pnAluno
    {
        public static bool Inserir(Aluno p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Alunos.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                //throw;
                return false;
            }
        }

        public static Aluno Pesquisar(int ra)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Aluno a1 = new Aluno();

                a1 = db.Alunos.Find(ra);

                return a1;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
