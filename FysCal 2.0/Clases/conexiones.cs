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
        //Conexion a la base de datos
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
        // Agregar un cliente
        public static void addCliente(String pnombre, String pcurp, String prfc, String pdomicilio, String pregimen)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into clientes(nombre, curp, rfc, domicilioFiscal, regimenFiscal) values ('{0}', '{1}', '{2}', '{3}', '{4}'  )", pnombre, pcurp, prfc, pdomicilio, pregimen), con);
            comando.ExecuteNonQuery();

        }
        // Hacer el login a la aplicacion
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
        //Obtener los datos del cliente seleccionado
        public static void InfoCliete(String ppnombre)
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select curp,rfc,domicilioFiscal,regimenFiscal from clientes where nombre='" + ppnombre + "' ;"), con);
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
        //Insertar o actualizar datos de la tabla ingresos16
        public static void ingresos16(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresos16 where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresos16 SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresos16(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla ingresos0
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
        //Insertar o actualizar datos de la tabla ingresosExentos
        public static void ingresosExentos(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingresosexentos where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingresosexentos SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ingresosexentos(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla ingresosNoObjeto
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
        //Insertar o actualizar datos de la tabla ingresosMes
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
        //Insertar o actualizar datos de la tabla ingresosretencionesIVA
        public static void retencionesIVA(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from retencionesiva where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE retencionesiva SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO retencionesiva(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla retencionesISR
        public static void retencionesISR(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
           String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from retencionesisr where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE retencionesisr SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO retencionesisr(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }

        public static void obtenerIdcliente(String pnombre)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from clientes where nombre='" + pnombre + "'"), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            Formularios.Control.idCliente = reader["id_cliente"].ToString();
        }
        //Obtener la informacion de la tabla ingresos16
        public static void InfoIngresos16()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresos16 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.ene16 = "0";
                Formularios.Control.feb16 = "0";
                Formularios.Control.mar16 = "0";
                Formularios.Control.abr16 = "0";
                Formularios.Control.may16 = "0";
                Formularios.Control.jun16 = "0";
                Formularios.Control.jul16 = "0";
                Formularios.Control.ago16 = "0";
                Formularios.Control.sep16 = "0";
                Formularios.Control.oct16 = "0";
                Formularios.Control.nov16 = "0";
                Formularios.Control.dic16 = "0";
                
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();                
                Formularios.Control.ene16 = ene;
                Formularios.Control.feb16 = feb;
                Formularios.Control.mar16 = mar;
                Formularios.Control.abr16 = abr;
                Formularios.Control.may16 = may;
                Formularios.Control.jun16 = jun;
                Formularios.Control.jul16 = jul;
                Formularios.Control.ago16 = ago;
                Formularios.Control.sep16 = sep;
                Formularios.Control.oct16 = oct;
                Formularios.Control.nov16 = nov;
                Formularios.Control.dic16 = dic;
                
            }
        }
        //Obtener la informacion de la tabla ingresos0
        public static void InfoIngresos0()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresos0 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.ene0 = "0";
                Formularios.Control.feb0 = "0";
                Formularios.Control.mar0 = "0";
                Formularios.Control.abr0 = "0";
                Formularios.Control.may0 = "0";
                Formularios.Control.jun0 = "0";
                Formularios.Control.jul0 = "0";
                Formularios.Control.ago0 = "0";
                Formularios.Control.sep0 = "0";
                Formularios.Control.oct0 = "0";
                Formularios.Control.nov0 = "0";
                Formularios.Control.dic0 = "0";
                
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                
                Formularios.Control.ene0 = ene;
                Formularios.Control.feb0 = feb;
                Formularios.Control.mar0 = mar;
                Formularios.Control.abr0 = abr;
                Formularios.Control.may0 = may;
                Formularios.Control.jun0 = jun;
                Formularios.Control.jul0 = jul;
                Formularios.Control.ago0 = ago;
                Formularios.Control.sep0 = sep;
                Formularios.Control.oct0 = oct;
                Formularios.Control.nov0 = nov;
                Formularios.Control.dic0 = dic;
               
            }
        }
        //Obtener la informacion de la tabla ingresosExentos
        public static void InfoIngresosExcentos()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosexentos where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneExe = "0";
                Formularios.Control.febExe = "0";
                Formularios.Control.marExe = "0";
                Formularios.Control.abrExe = "0";
                Formularios.Control.mayExe = "0";
                Formularios.Control.junExe = "0";
                Formularios.Control.julExe = "0";
                Formularios.Control.agoExe = "0";
                Formularios.Control.sepExe = "0";
                Formularios.Control.octExe = "0";
                Formularios.Control.novExe = "0";
                Formularios.Control.dicExe = "0";
                
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
              
                Formularios.Control.eneExe = ene;
                Formularios.Control.febExe = feb;
                Formularios.Control.marExe = mar;
                Formularios.Control.abrExe = abr;
                Formularios.Control.mayExe = may;
                Formularios.Control.junExe = jun;
                Formularios.Control.julExe = jul;
                Formularios.Control.agoExe = ago;
                Formularios.Control.sepExe = sep;
                Formularios.Control.octExe = oct;
                Formularios.Control.novExe = nov;
                Formularios.Control.dicExe = dic;
             
            }
        }
        //Obtener la informacion de la tabla ingresosNoObjeto
        public static void InfoIngresosNoObjeto()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneNoo = "0";
                Formularios.Control.febNoo = "0";
                Formularios.Control.marNoo = "0";
                Formularios.Control.abrNoo = "0";
                Formularios.Control.mayNoo = "0";
                Formularios.Control.junNoo = "0";
                Formularios.Control.julNoo = "0";
                Formularios.Control.agoNoo = "0";
                Formularios.Control.sepNoo = "0";
                Formularios.Control.octNoo = "0";
                Formularios.Control.novNoo = "0";
                Formularios.Control.dicNoo = "0";
               
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
               
                Formularios.Control.eneNoo = ene;
                Formularios.Control.febNoo = feb;
                Formularios.Control.marNoo = mar;
                Formularios.Control.abrNoo = abr;
                Formularios.Control.mayNoo = may;
                Formularios.Control.junNoo = jun;
                Formularios.Control.julNoo = jul;
                Formularios.Control.agoNoo = ago;
                Formularios.Control.sepNoo = sep;
                Formularios.Control.octNoo = oct;
                Formularios.Control.novNoo = nov;
                Formularios.Control.dicNoo = dic;
             
            }
        }
        /*Obtener la informacion de la tabla ingresosMes
        public static void InfoIngresosMes()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosmes where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneMes = "0";
                Formularios.Control.febMes = "0";
                Formularios.Control.marMes = "0";
                Formularios.Control.abrMes = "0";
                Formularios.Control.mayMes = "0";
                Formularios.Control.junMes = "0";
                Formularios.Control.julMes = "0";
                Formularios.Control.agoMes = "0";
                Formularios.Control.sepMes = "0";
                Formularios.Control.octMes = "0";
                Formularios.Control.novMes = "0";
                Formularios.Control.dicMes = "0";
              
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
             
                Formularios.Control.eneMes = ene;
                Formularios.Control.febMes = feb;
                Formularios.Control.marMes = mar;
                Formularios.Control.abrMes = abr;
                Formularios.Control.mayMes = may;
                Formularios.Control.junMes = jun;
                Formularios.Control.julMes = jul;
                Formularios.Control.agoMes = ago;
                Formularios.Control.sepMes = sep;
                Formularios.Control.octMes = oct;
                Formularios.Control.novMes = nov;
                Formularios.Control.dicMes = dic;
               
            }
        }*/
        //Obtener la informacion de la tabla retencionesISR
        public static void InfoRetencionesISR()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from retencionesisr where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneRISR = "0";
                Formularios.Control.febRISR = "0";
                Formularios.Control.marRISR = "0";
                Formularios.Control.abrRISR = "0";
                Formularios.Control.mayRISR = "0";
                Formularios.Control.junRISR = "0";
                Formularios.Control.julRISR = "0";
                Formularios.Control.agoRISR = "0";
                Formularios.Control.sepRISR = "0";
                Formularios.Control.octRISR = "0";
                Formularios.Control.novRISR = "0";
                Formularios.Control.dicRISR = "0";
              
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
               
                Formularios.Control.eneRISR = ene;
                Formularios.Control.febRISR = feb;
                Formularios.Control.marRISR = mar;
                Formularios.Control.abrRISR = abr;
                Formularios.Control.mayRISR = may;
                Formularios.Control.junRISR = jun;
                Formularios.Control.julRISR = jul;
                Formularios.Control.agoRISR = ago;
                Formularios.Control.sepRISR = sep;
                Formularios.Control.octRISR = oct;
                Formularios.Control.novRISR = nov;
                Formularios.Control.dicRISR = dic;
                
            }
        }
        //Obtener la informacion de la tabla retencionesIVA
        public static void InfoRetencionesIVA()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from retencionesiva where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneRIVA = "0";
                Formularios.Control.febRIVA = "0";
                Formularios.Control.marRIVA = "0";
                Formularios.Control.abrRIVA = "0";
                Formularios.Control.mayRIVA = "0";
                Formularios.Control.junRIVA = "0";
                Formularios.Control.julRIVA = "0";
                Formularios.Control.agoRIVA = "0";
                Formularios.Control.sepRIVA = "0";
                Formularios.Control.octRIVA = "0";
                Formularios.Control.novRIVA = "0";
                Formularios.Control.dicRIVA = "0";
              
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
               
                Formularios.Control.eneRIVA = ene;
                Formularios.Control.febRIVA = feb;
                Formularios.Control.marRIVA = mar;
                Formularios.Control.abrRIVA = abr;
                Formularios.Control.mayRIVA = may;
                Formularios.Control.junRIVA = jun;
                Formularios.Control.julRIVA = jul;
                Formularios.Control.agoRIVA = ago;
                Formularios.Control.sepRIVA = sep;
                Formularios.Control.octRIVA = oct;
                Formularios.Control.novRIVA = nov;
                Formularios.Control.dicRIVA = dic;
                
            }
        }
        //Insertar o actualizar datos de la tabla deducciones16
        public static void deducciones16(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from deducciones16 where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE deducciones16 SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO deducciones16(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deducciones0
        public static void deducciones0(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from deducciones0 where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE deducciones0 SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO deducciones0(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deduccionesExentas
        public static void deduccionesExentas(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from deduccionesexentas where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE deduccionesexentas SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {
                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO deduccionesexentas(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deduccionesNoObjeto
        public static void deduccionesNoObjeto(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from deduccionesnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE deduccionesnoobjeto SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();
            }
            else
            {
                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO deduccionesnoobjeto(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla estimuloFiscal
        public static void estimuloFiscal(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from estimulofiscal where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE estimulofiscal SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();
            }
            else
            {
                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO estimulofiscal(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deduccioneMes
        public static void deduccionesMes(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from deduccionesmes where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE deduccionesmes SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO deduccionesmes(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Obtener la informacion de la tabla deducciones16
        public static void InfoDeducciones16()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deducciones16 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.dene16 = "0";
                Formularios.Control.dfeb16 = "0";
                Formularios.Control.dmar16 = "0";
                Formularios.Control.dabr16 = "0";
                Formularios.Control.dmay16 = "0";
                Formularios.Control.djun16 = "0";
                Formularios.Control.djul16 = "0";
                Formularios.Control.dago16 = "0";
                Formularios.Control.dsep16 = "0";
                Formularios.Control.doct16 = "0";
                Formularios.Control.dnov16 = "0";
                Formularios.Control.ddic16 = "0";
                Formularios.Control.dtot16 = "0";
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.dene16 = ene;
                Formularios.Control.dfeb16 = feb;
                Formularios.Control.dmar16 = mar;
                Formularios.Control.dabr16 = abr;
                Formularios.Control.dmay16 = may;
                Formularios.Control.djun16 = jun;
                Formularios.Control.djul16 = jul;
                Formularios.Control.dago16 = ago;
                Formularios.Control.dsep16 = sep;
                Formularios.Control.doct16 = oct;
                Formularios.Control.dnov16 = nov;
                Formularios.Control.ddic16 = dic;
                Formularios.Control.dtot16 = tot;
            }
        }
        //Obtener la informacion de la tabla deducciones0
        public static void InfoDeducciones0()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deducciones0 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.dene0 = "0";
                Formularios.Control.dfeb0 = "0";
                Formularios.Control.dmar0 = "0";
                Formularios.Control.dabr0 = "0";
                Formularios.Control.dmay0 = "0";
                Formularios.Control.djun0 = "0";
                Formularios.Control.djul0 = "0";
                Formularios.Control.dago0 = "0";
                Formularios.Control.dsep0 = "0";
                Formularios.Control.doct0 = "0";
                Formularios.Control.dnov0 = "0";
                Formularios.Control.ddic0 = "0";
                Formularios.Control.dtot0 = "0";
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.dene0 = ene;
                Formularios.Control.dfeb0 = feb;
                Formularios.Control.dmar0 = mar;
                Formularios.Control.dabr0 = abr;
                Formularios.Control.dmay0 = may;
                Formularios.Control.djun0 = jun;
                Formularios.Control.djul0 = jul;
                Formularios.Control.dago0 = ago;
                Formularios.Control.dsep0 = sep;
                Formularios.Control.doct0 = oct;
                Formularios.Control.dnov0 = nov;
                Formularios.Control.ddic0 = dic;
                Formularios.Control.dtot0 = tot;
            }
        }
        //Obtener la informacion de la tabla deduccionesExentas
        public static void InfoDeduccionesExe()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesexentas where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.deneexe = "0";
                Formularios.Control.dfebexe = "0";
                Formularios.Control.dmarexe = "0";
                Formularios.Control.dabrexe = "0";
                Formularios.Control.dmayexe = "0";
                Formularios.Control.djunexe = "0";
                Formularios.Control.djulexe = "0";
                Formularios.Control.dagoexe = "0";
                Formularios.Control.dsepexe = "0";
                Formularios.Control.doctexe = "0";
                Formularios.Control.dnovexe = "0";
                Formularios.Control.ddicexe = "0";
                Formularios.Control.dtotexe = "0";
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.deneexe = ene;
                Formularios.Control.dfebexe = feb;
                Formularios.Control.dmarexe = mar;
                Formularios.Control.dabrexe = abr;
                Formularios.Control.dmayexe = may;
                Formularios.Control.djunexe = jun;
                Formularios.Control.djulexe = jul;
                Formularios.Control.dagoexe = ago;
                Formularios.Control.dsepexe = sep;
                Formularios.Control.doctexe = oct;
                Formularios.Control.dnovexe = nov;
                Formularios.Control.ddicexe = dic;
                Formularios.Control.dtotexe = tot;
            }
        }
        //Obtener la informacion de la tabla deduccionesNoObjeto
        public static void InfoDeduccionesNoObjeto()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.deneNoo = "0";
                Formularios.Control.dfebNoo = "0";
                Formularios.Control.dmarNoo = "0";
                Formularios.Control.dabrNoo = "0";
                Formularios.Control.dmayNoo = "0";
                Formularios.Control.djunNoo = "0";
                Formularios.Control.djulNoo = "0";
                Formularios.Control.dagoNoo = "0";
                Formularios.Control.dsepNoo = "0";
                Formularios.Control.doctNoo = "0";
                Formularios.Control.dnovNoo = "0";
                Formularios.Control.ddicNoo = "0";
                Formularios.Control.dtotNoo = "0";
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.deneNoo = ene;
                Formularios.Control.dfebNoo = feb;
                Formularios.Control.dmarNoo = mar;
                Formularios.Control.dabrNoo = abr;
                Formularios.Control.dmayNoo = may;
                Formularios.Control.djunNoo = jun;
                Formularios.Control.djulNoo = jul;
                Formularios.Control.dagoNoo = ago;
                Formularios.Control.dsepNoo = sep;
                Formularios.Control.doctNoo = oct;
                Formularios.Control.dnovNoo = nov;
                Formularios.Control.ddicNoo = dic;
                Formularios.Control.dtotNoo = tot;
            }
        }
        //Obtener la informacion de la tabla estimuloFiscal
        public static void InfoEstimuloFiscal()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from estimulofiscal where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                
                Formularios.Control.deneest = "0";
                Formularios.Control.dfebest = "0";
                Formularios.Control.dmarest = "0";
                Formularios.Control.dabrest = "0";
                Formularios.Control.dmayest = "0";
                Formularios.Control.djunest = "0";
                Formularios.Control.djulest = "0";
                Formularios.Control.dagoest = "0";
                Formularios.Control.dsepest = "0";
                Formularios.Control.doctest = "0";
                Formularios.Control.dnovest = "0";
                Formularios.Control.ddicest = "0";
                Formularios.Control.dtotest = "0";
            }
            else
            {
                
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.deneest = ene;
                Formularios.Control.dfebest = feb;
                Formularios.Control.dmarest = mar;
                Formularios.Control.dabrest = abr;
                Formularios.Control.dmayest = may;
                Formularios.Control.djunest = jun;
                Formularios.Control.djulest = jul;
                Formularios.Control.dagoest = ago;
                Formularios.Control.dsepest = sep;
                Formularios.Control.doctest = oct;
                Formularios.Control.dnovest = nov;
                Formularios.Control.ddicest = dic;
                Formularios.Control.dtotest = tot;
            }
        }
        //Obtener la informacion de la tabla deduccionesMes
        public static void InfoDeduccionesMes()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesmes where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.denemes = "0";
                Formularios.Control.dfebmes = "0";
                Formularios.Control.dmarmes = "0";
                Formularios.Control.dabrmes = "0";
                Formularios.Control.dmaymes = "0";
                Formularios.Control.djunmes = "0";
                Formularios.Control.djulmes = "0";
                Formularios.Control.dagomes = "0";
                Formularios.Control.dsepmes = "0";
                Formularios.Control.doctmes = "0";
                Formularios.Control.dnovmes = "0";
                Formularios.Control.ddicmes = "0";
                Formularios.Control.dtotmes = "0";
            }
            else
            {
                ene = reader["enero"].ToString();
                feb = reader["febrero"].ToString();
                mar = reader["marzo"].ToString();
                abr = reader["abril"].ToString();
                may = reader["mayo"].ToString();
                jun = reader["junio"].ToString();
                jul = reader["julio"].ToString();
                ago = reader["agosto"].ToString();
                sep = reader["septiembre"].ToString();
                oct = reader["octubre"].ToString();
                nov = reader["noviembre"].ToString();
                dic = reader["diciembre"].ToString();
                tot = reader["total"].ToString();
                Formularios.Control.denemes = ene;
                Formularios.Control.dfebmes = feb;
                Formularios.Control.dmarmes = mar;
                Formularios.Control.dabrmes = abr;
                Formularios.Control.dmaymes= may;
                Formularios.Control.djunmes= jun;
                Formularios.Control.djulmes = jul;
                Formularios.Control.dagomes = ago;
                Formularios.Control.dsepmes = sep;
                Formularios.Control.doctmes = oct;
                Formularios.Control.dnovmes = nov;
                Formularios.Control.ddicmes = dic;
                Formularios.Control.dtotmes = tot;
            }
        }
    }
}

