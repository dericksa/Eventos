﻿using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
   public class pnPessoa
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

    }
}
