using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
   public class pnAluno
    {
        public static bool Inserir(Aluno aluno)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Aluno.Add(aluno);     
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Aluno Pesquisar(int ra)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Aluno a1 = new Aluno();

                a1 = db.Aluno.Find(ra);

                return a1;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
