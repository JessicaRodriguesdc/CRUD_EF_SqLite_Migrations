using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Migracao.Modal;
using Migracao.Dao;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TesteMigracao.TesteMigracao
{

    [TestClass]
    public class TesteCliente
    {
        

        [TestMethod]
        public void inserir()
        { 
            try
            {
                Cliente cli = new Cliente();
                ClienteDao cliDao = new ClienteDao();
                cli.nome = "teste";
                cli.email = "teste@gmail.com";
                bool foiSalvo = cliDao.inserirClientes(cli);

                Assert.IsTrue(foiSalvo);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void listar()
        {
            try
            {
                ClienteDao cliDao = new ClienteDao();
                List<Cliente> clientes = new List<Cliente>();
                cliDao.listarClientes(clientes);
                
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

    }
}
