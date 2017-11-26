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



                }

                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
