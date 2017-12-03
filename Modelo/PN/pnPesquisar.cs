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

        /******************************  Pessoa ***************************************/
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

        /******************************  Eventos ***************************************/

        /*Retorna uma lista de ID de Eventos que a pessoa participa*/
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

        /*Retorna um Evento com base em uma id*/
        public static Evento Pesquisar_Eventos_Id(int id_evento)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                Evento evento = db.Evento.Where(r => r.Id == id_evento).FirstOrDefault();

                return evento;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /*Retorna uma lista de IDS de Eventos que a pessoa criou*/
        public static List<int> Pesquisar_Eventos_Pessoa(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                /*Where compara o r( da tabela) com o id por parametro
                 Se for igual, ele seleciona todos os iguais e pega o id e coloca em lista*/
                List<int> Eventos = db.Evento.Where(r => r.Criador == id).Select(x => x.Id).ToList();

                return Eventos;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static int Pesquisar_Ultimo_Evento()
        {
            try
            {
                EventosEntities db = new EventosEntities();
                return db.Evento.Max(r => r.Id);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /******************************  Participante ***************************************/

        public static List<Participante> Pesquisar_Convites(int id)
        {
            try
            {
                EventosEntities db = new EventosEntities();

                /*Where compara o r( da tabela) com o id por parametro
                 Se for igual, ele seleciona todos os iguais e pega o id e coloca em lista*/
                List<Participante> Convites = db.Participante.Where(r => r.Id_pessoa == id).ToList();

                return Convites;
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}
