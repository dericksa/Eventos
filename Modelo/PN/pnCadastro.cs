using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnCadastro
    {
        public static bool Inserir(Pessoa p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Pessoa.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
