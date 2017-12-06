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
                evento_alterado.Aprovada = evt.Aprovada;

                db.SaveChanges();

                return true;

            }
            catch (Exception)
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

                pessoa_alt.Adm = p.Adm;
                pessoa_alt.Curso = p.Curso;
                pessoa_alt.Departamento = p.Departamento;
                pessoa_alt.Email = p.Email;
                pessoa_alt.Grupo = p.Grupo;
                pessoa_alt.Nome = p.Nome;
                pessoa_alt.Senha = p.Senha;
                pessoa_alt.Palestrante = p.Palestrante;
                pessoa_alt.Identificacao = p.Identificacao;
                pessoa_alt.Organizador = p.Organizador;

                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool Editar_Participante(Participante p)
        {
            try
            {
                EventosEntities db = new EventosEntities();
                Participante participante_alt = new Participante();
                participante_alt = db.Participante.Find(p.Id_pessoa, p.Id_eventos);

                participante_alt.Id_eventos = p.Id_eventos;
                participante_alt.Id_pessoa = p.Id_pessoa;
                participante_alt.confirmacao = p.confirmacao;

                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
