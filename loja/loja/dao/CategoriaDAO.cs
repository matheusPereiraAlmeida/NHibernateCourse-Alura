using loja.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.dao
{
    public class CategoriaDAO
    {
        private ISession session;

        public CategoriaDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Categoria usuario)
        {
            ITransaction transation = session.BeginTransaction();
            session.Save(usuario);
            transation.Commit();
        }

        public Categoria BuscaPorId(int id)
        {
            return session.Get<Categoria>(id);
        }
    }
}
