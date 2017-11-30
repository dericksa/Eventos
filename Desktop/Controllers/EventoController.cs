using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.PN;

namespace Desktop.Controllers
{
    class EventoController
    {

        public static bool Criar_Reuniao(Evento ev)
        {
            try
            {
                if(ev != null)
                {
                    Evento novo_evento = new Evento();
                    novo_evento.Criador = ev.Criador;
                    novo_evento.Cancelado = false;
                    novo_evento.Reuniao = true;
                    novo_evento.Palestra = false;
                    novo_evento.Local = ev.Local;
                    novo_evento.Descricao = ev.Descricao;
                    novo_evento.Data = ev.Data;

                    pnCadastro.Inserir_Evento(novo_evento);


                    return true;
                }

                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static bool Cancelar_Evento(int id)
        {

            try
            {
 
            Evento evt = new Evento();

            evt = pnPesquisar.Pesquisar_Eventos_Id(id);
            evt.Cancelado = true;
            if (pnEditar.Editar_Evento(evt))
            {
                return true;
            }
                return false;

            }
            catch(Exception e)
            {
                return false;
            }

        }

        /*Função lista os Eventos da Pessoa (Criador)*/
        public static List<Evento> Minhas_Reunioes(int pid)
        {
            try
            {
                /*Pega a lista de eventos (ids) que a pessoa criou*/
                List<int> eventos_pessoa = pnPesquisar.Pesquisar_Eventos_Pessoa(pid);
                List<Evento> meus_eventos = new List<Evento>();

                foreach (int id in eventos_pessoa)
                {
                    Evento evento = new Evento();
                    evento = pnPesquisar.Pesquisar_Eventos_Id(id);
                    if(evento.Reuniao)
                        meus_eventos.Add(evento);
                }

                return meus_eventos;
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
