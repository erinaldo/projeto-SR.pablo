using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareGerenciador
{
    public class TesteConexao
    {
        //public  int inserirModulo()
        //{

        //    using (t2tierpEntities bd = new t2tierpEntities())
        //    {
        //        adm_modulo obj = new adm_modulo()
        //        {
        //            DESCRICAO = "bla bla anblça"
        //        };
        //        bd.adm_modulo.Add(obj);
        //        bd.SaveChanges();

        //        return obj.ID;
        //    }
        //}
        //public void Atualizar(adm_modulo cliente)
        //{
        //    using (t2tierpEntities bd = new t2tierpEntities())
        //    {
        //        var cli = bd.adm_modulo.Find(cliente.adm_moduloId);

        //        cli.NomeRazaoSocial = cliente.NomeRazaoSocial;
        //        cli.ApelidoNomeFantasia = cliente.ApelidoNomeFantasia;
        //        cli.TipoPessoa = cliente.TipoPessoa;
        //        cli.Sexo = cliente.Sexo;
              

        //        bd.SaveChanges();
        //    }
        //}

        //public adm_modulo Consultar(adm_modulo cliente)
        //{
        //    try
        //    {
        //        using (t2tierpEntities db = new t2tierpEntities())
        //        {
        //            var clientes = db.adm_modulo.ToList();
        //            cliente = clientes.
        //                Where(e =>
        //                    e.adm_moduloId == cliente.adm_moduloId 
        //                    || e.CpfCnpj == cliente.CpfCnpj)
        //                    .FirstOrDefault();
        //        }
        //        return cliente;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void Excluir(int id)
        //{

        //    using (t2tierpEntities db = new t2tierpEntities())
        //    {
        //        adm_modulo cliente = new adm_modulo() { adm_moduloId = id };
        //        cliente = Consultar(cliente);
        //        db.Entry(cliente).State = EntityState.Deleted;
        //        db.SaveChanges();

        //        cliente = null;
        //    }
        //}

        //public List<adm_modulo> Listar(adm_modulo cliente = null)
        //{
        //    try
        //    {
        //        using (t2tierpEntities db = new t2tierpEntities())
        //            return db.adm_modulo.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<P_LISTARCLIENTE_Result> Listar(Nullable<int> clienteId)
        //{
        //    List<P_LISTARCLIENTE_Result> clientes;
        //    try
        //    {
        //        using (t2tierpEntities db = new t2tierpEntities())
        //            clientes = db.P_LISTARCLIENTE(clienteId).ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return clientes;
        //}

    }
}
