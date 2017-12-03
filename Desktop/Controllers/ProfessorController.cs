using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.PN;

namespace Desktop.Controllers
{
    public class ProfessorController
    {
        public static bool Cadastrar_Horario(int id_professor, DateTime horario)
        {
            try
            {
                Horario h = new Horario();
                h.Identificacao = id_professor;
                h.Horario1 = horario;

                pnCadastro.Inserir_Horario(h);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
