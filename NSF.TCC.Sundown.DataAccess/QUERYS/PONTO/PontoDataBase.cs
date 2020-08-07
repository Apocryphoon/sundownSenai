using MySql.Data.MySqlClient;
using NSF.TCC.Sundown.Model;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.DataAccess
{
    public class PontoDataBase
    {
        public void CriarPonto(int id, string data, string status)
        {

            string query = "insert into tb_ponto(id_usuario, ds_status, dt_movimento) value({0},'{1}','{2}')";
            query = string.Format(query, id, status, data);
            ProjetoDataBase db = new ProjetoDataBase();
            db.ExecuteInsert(query);

        }

        public DTOPonto RetornarUltimo(int idUsuario)
        {
            string query = "SELECT  ds_status, dt_movimento FROM tb_ponto WHERE id_usuario = {0} ORDER BY id_ponto DESC LIMIT 1";
            query = string.Format(query,idUsuario);



            ProjetoDataBase db = new ProjetoDataBase();
            MySqlDataReader read = db.ExecuteSelect(query);

            DTOPonto baseDados = new DTOPonto();
            
            if (read.Read())
            {
                baseDados.Movement = read.GetDateTime("dt_movimento").ToString("yyyy-dd-MM HH:mm:ss");
                baseDados.Status = read.GetString("ds_status");
            }
            read.Close();

            return baseDados;
        }
       
        public List<DTOUser> ListarUsuarios()
        {
            string query = "select * from tb_usuario left join tb_demitidos on tb_usuario.id_usuario = tb_demitidos.id_usuario where tb_demitidos.id_usuario is null";
            ProjetoDataBase db = new ProjetoDataBase();
            MySqlDataReader read = db.ExecuteSelect(query);

            List<DTOUser> loop = new List<DTOUser>();

            while (read.Read())
            {
                DTOUser reg = new DTOUser();
                reg.Id = read.GetInt32("id_usuario");
                reg.Nome = read.GetString("nm_nomedoatendente");
                reg.User = read.GetString("nm_usuario");
                loop.Add(reg);
            }
            read.Close();

            return loop;
        }

        public List<DTOPonto> ListarPonto(int id, string data)
        {
            string query = "select dt_movimento, ds_status from tb_ponto where id_usuario = {0} and dt_movimento like '{1}%' order by id_ponto desc;";

            query = string.Format(query, id, data);

            ProjetoDataBase db = new ProjetoDataBase();
            MySqlDataReader read = db.ExecuteSelect(query);

            List<DTOPonto> loop = new List<DTOPonto>();

            while (read.Read())
            {
                DTOPonto reg = new DTOPonto();
                reg.Movement = read.GetString("dt_movimento");
                reg.Status = read.GetString("ds_status");
                loop.Add(reg);
            }

            read.Close();
            return loop;
        }
    }
}
