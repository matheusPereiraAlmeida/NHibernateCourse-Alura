using loja.dao;
using loja.Entidades;
using loja.Info;
using NHibernate;
using NHibernate.Cfg;
using System;

namespace loja
{
    class Program
    {
        static void Main(string[] args)
        {
            ISession session = NHibernateHelper.AbreSession();
            UsuarioDao usuario = new UsuarioDao(session);

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = "Patricia";
            usuario.Adiciona(novoUsuario);
            session.Close();

            Console.Read();
        }
    }
}
