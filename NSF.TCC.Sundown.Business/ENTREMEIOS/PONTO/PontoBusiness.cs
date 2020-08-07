using NSF.TCC.Sundown.DataAccess;
using NSF.TCC.Sundown.Model;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.Business
{

    public class PontoBusiness
    {
        public int Id { get; set; }
        PontoDataBase db = new PontoDataBase();

        public void CriarPonto(string data, string status)
        { 
                db.CriarPonto(this.Id, data, status);
        }

        public List<string> SelectItem()
        {
            DTOPonto baseDados = db.RetornarUltimo(this.Id);
            //string  status = status == "Entrada" && baseDados.Status == "Saida" ? "Entrada" : (status == "Pausa" && (baseDados.Status == "Entrada" || baseDados.Status == "Retorno") ? "Pausa" : (status == "Retorno" && baseDados.Status == "Pausa" ? "Retorno" : (status == "Saída" && baseDados.Status == "Entrada" || baseDados.Status == "Retorno" ? "Saída" : "ERROR")));
            List<string> a = new List<string>();

            if (baseDados.Status == "ENTRADA" || baseDados.Status == "RETORNO")
            {
               
                a.Add("PAUSA");
                a.Add("SAÍDA");
            }
            else if (baseDados.Status == "SAÍDA" || baseDados.Status == "FIM HORA EXTRA")
            {
                
                a.Add("ENTRADA");
                a.Add("INÍCIO HORA EXTRA");

            }
            else if (baseDados.Status == "PAUSA")
            {

                a.Add("RETORNO");

            }
            else if (baseDados.Status == "INÍCIO HORA EXTRA" || baseDados.Status == "RETORNO HORA EXTRA")
            {
                a.Add("PAUSA HORA EXTRA");
                a.Add("FIM HORA EXTRA");

            }
            else if (baseDados.Status == "PAUSA HORA EXTRA")
            {
                a.Add("RETORNO HORA EXTRA");

            }
            else if (baseDados.Status == null)
            {

                a.Add("ENTRADA");
                a.Add("INÍCIO HORA EXTRA");

            }
            return a;
        }


        public List<DTOUser> ListarUsuarios()
        {
            PontoDataBase dados = new PontoDataBase();
            return dados.ListarUsuarios();
        }

        public List<DTOPonto> ListarPonto(int id, string data)
        {
            PontoDataBase dados = new PontoDataBase();
            return dados.ListarPonto(id, data);
        }

    }
}
