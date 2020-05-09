using LojaWeb.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class UsuariosDAO
    {
        private ISession session;

        public UsuariosDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Usuario usuario)
        {
            //ITransaction transation = session.BeginTransaction();
            session.Save(usuario);
            //transation.Commit();
        }

        public void Remove(Usuario usuario)
        {
            //ITransaction transation = session.BeginTransaction();
            session.Delete(usuario);
            //transation.Commit();
        }

        public void Atualiza(Usuario usuario)
        {
            //ITransaction transation = session.BeginTransaction();
            session.Merge(usuario);
            //transation.Commit();
        }

        public Usuario BuscaPorId(int id)
        {
            return session.Get<Usuario>(id);
        }

        public IList<Usuario> Lista()
        {
            return new List<Usuario>();
        }
    }
}