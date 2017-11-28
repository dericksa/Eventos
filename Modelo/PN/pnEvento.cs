using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public class pnEvento
    {
        /*Muda o status do evento para cancelado*/
        public static bool Cancelar(Evento evt)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                db.Evento.Find(evt.Id).Cancelado = evt.Cancelado;

                db.SaveChanges();

                return true;

            }
            catch(Exception e)
            {
                return false;
            }

        }

        public static bool Cancelar(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                db.Evento.Find(id).Cancelado = true;

                db.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
