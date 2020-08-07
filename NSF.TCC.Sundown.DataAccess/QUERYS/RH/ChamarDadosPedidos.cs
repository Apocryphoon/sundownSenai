using MySql.Data.MySqlClient;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.DataAccess
{
    public class ChamarDadosPedidos
    {
        
        public List<DTOPedidoItem2> ListarPedidos(int id)
        {
            string query = "Select nm_pedido,vl_produto,nr_quantidade from tb_pedido_item where id_pedido = @id_pedido";

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("id_pedido", id));
            ProjetoDataBase database = new ProjetoDataBase();
            MySqlDataReader reader = database.ExecuteSelectParamters(query, parameters);

            List<DTOPedidoItem2> itens = new List<DTOPedidoItem2>();



            while (reader.Read())
            {
                DTOPedidoItem2 Pedido = new DTOPedidoItem2();

               
                Pedido.NomeProduto = reader.GetString("nm_pedido");
                Pedido.ValorProduto = reader.GetDecimal("vl_produto");
                Pedido.Quantidade = reader.GetInt32("nr_quantidade");

                itens.Add(Pedido);

            }
            reader.Close();

            return itens;
        }
    }
}
