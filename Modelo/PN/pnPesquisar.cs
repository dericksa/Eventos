using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnPesquisar
    {
        public static Pessoa Pesquisar(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Pessoa p1 = new Pessoa();

                p1 = db.Pessoa.Find(id);

                return p1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static List<int> Pesquisar_Eventos(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

               return db.Participante.Where(r => r.Id_pessoa == id).Select(x => x.Id_eventos).ToList();

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static Evento Pesquisar_Eventos_Id(int id_evento)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Evento evento = db.Evento.Where(r => r.Id == id_evento).FirstOrDefault() ;

                return evento;
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public static List<int> Pesquisar_Eventos_Pessoa(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                List<int> Eventos = db.Evento.Where(r => r.Criador == id).Select(x => x.Id).ToList();

                return Eventos;
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}
