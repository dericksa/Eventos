using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;


namespace Modelo.PN
{
    public class pnEditar
    {

        public static bool Editar_Evento(Evento evt)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                Evento evento_alterado = new Evento();
                evento_alterado = db.Evento.Find(evt.Id);

                evento_alterado.Local = evt.Local;
                evento_alterado.Palestra = evt.Palestra;
                evento_alterado.Reuniao = evt.Reuniao;
                evento_alterado.Descricao = evt.Descricao;
                evento_alterado.Data = evt.Data;
                evento_alterado.Criador = evt.Criador;
                evento_alterado.Cancelado = evt.Cancelado;

                db.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool Editar_Pessoa(Pessoa p)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                Pessoa pessoa_alt = new Pessoa();
                pessoa_alt = db.Pessoa.Find(p.Identificacao);

                pessoa_alt = p;

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
