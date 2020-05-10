using loja.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.dao
{
    public class ProdutoDAO
    {
        private ISession session;

        public ProdutoDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Produto usuario)
        {
            ITransaction transation = session.BeginTransaction();
            session.Save(usuario);
            transation.Commit();
        }

        public Produto BuscaPorId(int id)
        {
            return session.Get<Produto>(id);
        }
    }
}
