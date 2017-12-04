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
        public static bool Inserir_Pessoa(Pessoa p)
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
                return false;
            }
        }

        public static bool Inserir_Evento(Evento ev)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Evento.Add(ev);
                db.SaveChanges();

                return true;

            }
            catch(Exception e)
            {
                return false;
            }

        }

        public static bool Inserir_Participante(Participante p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Participante.Add(p);
                db.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool Inserir_Palestrante(Palestrante p)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Palestrante.Add(p);
                db.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool Inserir_Horario(Horario h)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Horario.Add(h);
                db.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool Inserir_Certificado(Certificado c)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                db.Certificado.Add(c);
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
