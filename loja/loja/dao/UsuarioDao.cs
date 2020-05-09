using loja.Entidades;
using loja.Info;
using MySqlX.XDevAPI;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.dao
{
    public class UsuarioDao
    {
        private ISession session;

        public UsuarioDao(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Usuario usuario)
        {
            ITransaction transation = session.BeginTransaction();
            session.Save(usuario);
            transation.Commit();
        }

        public Usuario BuscaPorId(int id)
        {
            return session.Get<Usuario>(id);
        }
    }
}
