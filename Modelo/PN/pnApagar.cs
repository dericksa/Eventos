using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.PN;

namespace Modelo.PN
{
    public class pnApagar
    {
        public static bool Apagar_Convite(Participante p)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                Participante p_apagar = new Participante();
                p_apagar = db.Participante.Find(p.Id_pessoa, p.Id_eventos);

                db.Participante.Remove(p_apagar);
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
