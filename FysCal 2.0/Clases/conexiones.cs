using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FysCal_2._0.Clases
{
    class conexiones
    {
        public static MySqlConnection conection()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = "localhost";
            db.UserID = "root";
            db.Password = "rootroot";
            db.Database = "fyscal";
            db.SslMode = MySqlSslMode.None;
            MySqlConnection con = new MySqlConnection(db.ToString());
            con.Open();
            return con;

        }
        public static void addCliente(String pnombre,String pcurp, String prfc, String pregimen,String pdomicilio)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into clientes(nombre, curp, rfc, domicilioFiscal, regimenFiscal) values ('{0}', '{1}', '{2}', '{3}', '{4}'  )", pnombre, pcurp, prfc, pdomicilio, pregimen), con);
            comando.ExecuteNonQuery();

        }
        public static void login(String pusuario, String ppassword)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(String.Format("select usuario, contrasenia from usuarios where usuario='" + pusuario + "' and contrasenia='" + ppassword + "';"), con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            adaptador.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                new Formularios.errorAcceder().Show();

            }
            else
            {
                new Formularios.Inicio().Show();
            }
        }
        public static DataTable obtenerCliente()
        {
                MySqlConnection con = conexiones.conection();
                DataTable dt = new DataTable();
                MySqlCommand com = new MySqlCommand(string.Format("select nombre,id_cliente from clientes"), con);
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                adap.Fill(dt);

                return dt;

        }
        public static void  InfoCliete(String ppnombre)
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select curp,rfc,domicilioFiscal,regimenFiscal from clientes where nombre='"+ppnombre+"' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string curp, rfc, domicilioFiscal, regimenFiscal;                   
                reader.Read();
                curp = reader["curp"].ToString();
                rfc = reader["rfc"].ToString();
                domicilioFiscal = reader["domicilioFiscal"].ToString();
                regimenFiscal = reader["regimenFiscal"].ToString();
            Formularios.Datos.curpDatos = curp;
            Formularios.Datos.rfcDatos = rfc;
            Formularios.Datos.domFiscalDatos = domicilioFiscal;
            Formularios.Datos.regFiscalDatos = regimenFiscal;
        }
        public static void ingresos16(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresos16 where id_cliente='"+Formularios.Control.idCliente+"' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();  
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresos16 SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else {              

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresos16(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }            
        }
        public static void ingresos0(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresos0 where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))                
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresos0 SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresos0(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        public static void ingresosExcentos(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresosexcentos where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresosexcentos SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresosexcentos(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        public static void ingresosNoObjeto(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresosnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresosnoobjeto SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresosnoobjeto(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        public static void ingresosMes(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresosmes where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresosmes SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresosmes(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }

        public static void obtenerIdcliente(String pnombre)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from clientes where nombre='"+pnombre+"'"), con);         
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            Formularios.Control.idCliente = reader["id_cliente"].ToString();  

        }

    }
        
    }

