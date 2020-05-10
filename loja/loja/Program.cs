using loja.dao;
using loja.Entidades;
using loja.Info;
using MySqlX.XDevAPI;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace loja
{
    class Program
    {
        static void Main(string[] args)
        {
            ISession session = NHibernateHelper.AbreSession();
            //String hql = "from Produto p order by p.Nome";
            String hql = "from Produto p where p.Preco > :minimo and p.Categoria.Nome = :categoria"; 

            IQuery query = session.CreateQuery(hql);
            query.SetParameter("minimo", 0);
            query.SetParameter("categoria", "categoria1");
            IList<Produto> produtos = query.List<Produto>();

            foreach(Produto produto in produtos)
            {
                Console.WriteLine(produto.Nome);
            }

            session.Close();

            Console.Read();
        }
        public void aula01()
        {
            NHibernateHelper.GeraSchema();

            Categoria novaCategoria = new Categoria();
            novaCategoria.Nome = "categoria1";

            Produto novoProduto = new Produto();
            novoProduto.Nome = "camiseta";
            novoProduto.Preco = 10;
            novoProduto.Categoria = novaCategoria;

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = "Patricia";



            ISession session = NHibernateHelper.AbreSession();

            CategoriaDAO categoria = new CategoriaDAO(session);
            categoria.Adiciona(novaCategoria);

            UsuarioDAO usuario = new UsuarioDAO(session);
            usuario.Adiciona(novoUsuario);

            ProdutoDAO produto = new ProdutoDAO(session);
            produto.Adiciona(novoProduto);

            session.Close();

        }
    }
}
