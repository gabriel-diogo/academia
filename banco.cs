using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace academia
{
     class banco
    {
        public static SQLiteConnection cx;

        public static SQLiteConnection cxbanco()
        {
            cx = new SQLiteConnection("DATA Source =C:\\Users\\biel\\Desktop\\c#modografico\\apk academia\\academia\\db\\ak.db ");
            cx.Open();

            return cx;
        }

        public static DataTable obteruser()
        {
            SQLiteDataAdapter da = null;

            DataTable dt=new DataTable();

            try
            {
                using (var cmd = cxbanco().CreateCommand())
                {
                    cmd.CommandText = "Select from * tb_user";

                    da=new SQLiteDataAdapter(cmd.CommandText,cxbanco());

                    da.Fill(dt);

                    cxbanco().Close();

                    return dt;
                }

            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;

            DataTable dt = new DataTable();

            try
            {
                using (var cmd = cxbanco().CreateCommand())
                {

                    cmd.CommandText = sql;

                    da = new SQLiteDataAdapter(cmd.CommandText,cxbanco());

                    da.Fill(dt);

                    cxbanco().Close();

                    return dt;
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }


        //verifica usuario

        public static bool exuser(novouser u)
        {
            bool res;
            SQLiteDataAdapter da = null;

            DataTable dt =new DataTable();

            var cmd = cxbanco().CreateCommand();

            cmd.CommandText = "SELECT t_usename  FROM tb_user WHERE t_usename='" + u.username + "'";

            da=new SQLiteDataAdapter(cmd.CommandText, cxbanco());
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public static void n_user(novouser u)
        {
            if (exuser(u))
            {
                MessageBox.Show("ja exister");return;
            }
            

        
            
            
          
            try
            {
                var cmd=cxbanco().CreateCommand();

                cmd.CommandText = "INSERT INTO tb_user (t_nome,t_usename,t_senha,t_status,n_nivel)VALUES (@nome,@usern,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("nome", u.name);
                cmd.Parameters.AddWithValue("usern", u.username);
                cmd.Parameters.AddWithValue("senha", u.password);
                cmd.Parameters.AddWithValue("status", u.status);
                cmd.Parameters.AddWithValue("nivel", u.nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("adicionado");

                cxbanco().Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show("eroo");

                MessageBox.Show(ex.Message);

                cxbanco().Close();
                }
            }

        public static DataTable obid()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon=cxbanco();

                var cmd=vcon.CreateCommand();

                cmd.CommandText = "SELECT n_id as 'id' ,t_nome as 'nome' FROM tb_user";

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);

                vcon.Close();

                return dt;


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable obtdados(string id)
        {
            SQLiteDataAdapter da =null;

            DataTable dt = new DataTable();

            try
            {
                var vcon =cxbanco();

                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT *FROM tb_user WHERE n_id =" + id;

                da=new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Clone();

                return dt;


            }
            catch (Exception ez)
            {
                throw ez;
            }
        }

        public static void atualizauser(novouser u)
        {
            SQLiteDataAdapter da = null;

            DataTable dt =new DataTable();

            try
            {
                var vco =cxbanco();

                var cmd =vco.CreateCommand();

                cmd.CommandText="UPDATE tb_user SET t_nome='"+u.name + "',t_usename='"+u.username+ "',t_senha='"+u.password+ "',t_status='"+u.status+ "',n_nivel="+u.nivel+" WHERE n_id="+u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vco);
                
                cmd.ExecuteNonQuery();

                dt.Clone();
                
            }
            catch(Exception ez)
            {
                throw ez;
            }
        }

        public static void deleteuser(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = cxbanco();
                var cmd=vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_user WHERE n_id=" + id;

                da=new SQLiteDataAdapter(cmd.CommandText, vcon);

                cmd.ExecuteNonQuery();
                vcon.Clone();


            }catch(Exception es)
            {
                throw es;
            }
        }
        



    }
}
