using Microsoft.EntityFrameworkCore;
using Migracao.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migracao.Dao
{
    public class ClienteDao
    {
        public bool inserirClientes(Cliente cli)
        {
            try
            {
                using (var db = new ContextoDB())
                {
                    db.Database.Migrate();
                    db.Clientes.Add(cli);
                    db.SaveChanges();
                }
                return true;

            }catch(Exception e)
            {
                return false;
            }
        }

        public List<Cliente> listarClientes(List<Cliente> clientes)
        {
            try
            {
                using (var db = new ContextoDB())
                {
                    db.Database.Migrate();
                    clientes = db.Clientes.ToList();

                    foreach (Cliente cli in clientes)
                    {
                        int id = cli.id;
                        string nome = cli.nome;
                    }

                }
                return clientes;

            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro ao listar os clientes, Erro: " + e.Message);
            }
        }

        public bool alterarClientes(Cliente cli)
        {
            try
            {
                using (var db = new ContextoDB())
                {
                    var cliente = db.Clientes
                        .Where(c => c.id == cli.id)
                        .Single();
                    cliente.nome = cli.nome;
                    db.Database.Migrate();
                    db.SaveChanges();
                }
                return true;

            }catch (Exception e)
            {
                return false;
            }
        }

        public bool excluirClientes(Cliente cli)
        {
            try
            {
                using (var db = new ContextoDB())
                {
                    var cliente = db.Clientes
                        .Where(c => c.id == cli.id);
                    db.Database.Migrate();
                    db.Clientes.RemoveRange(cliente);
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
