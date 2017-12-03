using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.PN;
using System.Windows.Forms;

namespace Desktop.Controllers
{
    class EventoController
    {

        public static bool Criar_Reuniao(Evento ev, int participante)
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

                    if(participante > 0)
                    {
                        ParticipanteController.Novo_Participante(participante, pnPesquisar.Pesquisar_Ultimo_Evento());
                        
                    }


                    return true;
                }

                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static bool Criar_Palestra(Evento ev)
        {
            try
            {
                if (ev != null)
                {
                    Evento novo_evento = new Evento();
                    novo_evento.Criador = ev.Criador;
                    novo_evento.Cancelado = false;
                    novo_evento.Reuniao = false;
                    novo_evento.Palestra = true;
                    novo_evento.Local = ev.Local;
                    novo_evento.Descricao = ev.Descricao;
                    novo_evento.Data = ev.Data;
                    pnCadastro.Inserir_Evento(novo_evento);

                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Editar_Palestra(Evento ev)
        {
            try
            {
                if (ev != null)
                {
                    Evento evento_alterado = new Evento();
                    evento_alterado = pnPesquisar.Pesquisar_Eventos_Id(ev.Id);
                    if(ev.Criador != 0)
                        evento_alterado.Criador = ev.Criador;

                    evento_alterado.Cancelado = false;
                    evento_alterado.Reuniao = false;
                    evento_alterado.Palestra = true;
                    if(ev.Local != null)
                        evento_alterado.Local = ev.Local;
                    if (ev.Descricao != null)
                        evento_alterado.Descricao = ev.Descricao;
                    evento_alterado.Data = ev.Data;

                    pnEditar.Editar_Evento(evento_alterado);

                    return true;
                }

                return false;
            }
            catch (Exception e)
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
                    if (evento.Reuniao)
                    {
                        if(DateTime.Compare(DateTime.Now, evento.Data) <= 0)
                            meus_eventos.Add(evento);
                    }
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
