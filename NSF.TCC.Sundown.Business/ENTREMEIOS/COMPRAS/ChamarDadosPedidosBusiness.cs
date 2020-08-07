using NSF.TCC.Sundown.DataAccess;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.Business
{
    public class ChamarDadosPedidosBusiness
    {
        public List<DTOPedidoItem2> ListAll(int id)
        {
            ChamarDadosPedidos db = new ChamarDadosPedidos();
            List<DTOPedidoItem2> dados = db.ListarPedidos(id);

            return dados;
        }
    }
}
