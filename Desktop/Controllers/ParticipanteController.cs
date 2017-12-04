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
    public class ParticipanteController
    {
        public static List<Participante> Meus_Convites_Reuniao(int pid)
        {
            try
            {
                /*Pega a lista de eventos (ids) que a pessoa criou*/
                List<Participante> convites_pessoa = pnPesquisar.Pesquisar_Convites(pid);

                foreach(Participante c in convites_pessoa)
                {
                    if (pnPesquisar.Pesquisar_Eventos_Id(c.Id_eventos).Palestra)
                    {
                        convites_pessoa.Remove(c);
                    }
                }


                return convites_pessoa;

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Novo_Participante(int pid, int eid)
        {
            Participante part = new Participante();
            part.confirmacao = false;
            part.Id_eventos = eid;
            part.Id_pessoa = pid;
            pnCadastro.Inserir_Participante(part);
        }

        public static bool Confirmar_Participacao(int id, int id_evento)
        {
            try
            {
                Participante part = new Participante();
                part.Id_pessoa = id;
                part.Id_eventos = id_evento;
                part.confirmacao = true;

                pnEditar.Editar_Participante(part);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Confirmar_Entrada(int id, int id_evento)
        {
            try
            {
                Participante part = new Participante();
                part.Id_pessoa = id;
                part.Id_eventos = id_evento;
                part.confirmacao = true;
                part.entrada = true;

                pnEditar.Editar_Participante(part);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Recusar_Participacao(int id, int id_evento)
        {
            try
            {
                Participante part = new Participante();
                part.Id_pessoa = id;
                part.Id_eventos = id_evento;
                part.confirmacao = false;

                pnApagar.Apagar_Convite(part);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
