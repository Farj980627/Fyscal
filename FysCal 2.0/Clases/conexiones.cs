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
        public static void ingresosExcentos(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
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
                Formularios.Control.ene16 = "";
                Formularios.Control.feb16 = "";
                Formularios.Control.mar16 = "";
                Formularios.Control.abr16 = "";
                Formularios.Control.may16 = "";
                Formularios.Control.jun16 = "";
                Formularios.Control.jul16 = "";
                Formularios.Control.ago16 = "";
                Formularios.Control.sep16 = "";
                Formularios.Control.oct16 = "";
                Formularios.Control.nov16 = "";
                Formularios.Control.dic16 = "";
                Formularios.Control.tot16 = "";
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
                Formularios.Control.tot16 = tot;
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
                Formularios.Control.ene0 = "";
                Formularios.Control.feb0 = "";
                Formularios.Control.mar0 = "";
                Formularios.Control.abr0 = "";
                Formularios.Control.may0 = "";
                Formularios.Control.jun0 = "";
                Formularios.Control.jul0 = "";
                Formularios.Control.ago0 = "";
                Formularios.Control.sep0 = "";
                Formularios.Control.oct0 = "";
                Formularios.Control.nov0 = "";
                Formularios.Control.dic0 = "";
                Formularios.Control.tot0 = "";
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
                Formularios.Control.tot0 = tot;
            }
        }
        //Obtener la informacion de la tabla ingresosExcentos
        public static void InfoIngresosExcentos()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosexentos where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneExe = "";
                Formularios.Control.febExe = "";
                Formularios.Control.marExe = "";
                Formularios.Control.abrExe = "";
                Formularios.Control.mayExe = "";
                Formularios.Control.junExe = "";
                Formularios.Control.julExe = "";
                Formularios.Control.agoExe = "";
                Formularios.Control.sepExe = "";
                Formularios.Control.octExe = "";
                Formularios.Control.novExe = "";
                Formularios.Control.dicExe = "";
                Formularios.Control.totExe = "";
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
                Formularios.Control.totExe = tot;
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
                Formularios.Control.eneNoo = "";
                Formularios.Control.febNoo = "";
                Formularios.Control.marNoo = "";
                Formularios.Control.abrNoo = "";
                Formularios.Control.mayNoo = "";
                Formularios.Control.junNoo = "";
                Formularios.Control.julNoo = "";
                Formularios.Control.agoNoo = "";
                Formularios.Control.sepNoo = "";
                Formularios.Control.octNoo = "";
                Formularios.Control.novNoo = "";
                Formularios.Control.dicNoo = "";
                Formularios.Control.totNoo = "";
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
                Formularios.Control.totNoo = tot;
            }
        }
        //Obtener la informacion de la tabla ingresosMes
        public static void InfoIngresosMes()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosmes where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            string ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic, tot;
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.eneMes = "";
                Formularios.Control.febMes = "";
                Formularios.Control.marMes = "";
                Formularios.Control.abrMes = "";
                Formularios.Control.mayMes = "";
                Formularios.Control.junMes = "";
                Formularios.Control.julMes = "";
                Formularios.Control.agoMes = "";
                Formularios.Control.sepMes = "";
                Formularios.Control.octMes = "";
                Formularios.Control.novMes = "";
                Formularios.Control.dicMes = "";
                Formularios.Control.totMes = "";
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
                Formularios.Control.totMes = tot;
            }
        }
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
                Formularios.Control.eneRISR = "";
                Formularios.Control.febRISR = "";
                Formularios.Control.marRISR = "";
                Formularios.Control.abrRISR = "";
                Formularios.Control.mayRISR = "";
                Formularios.Control.junRISR = "";
                Formularios.Control.julRISR = "";
                Formularios.Control.agoRISR = "";
                Formularios.Control.sepRISR = "";
                Formularios.Control.octRISR = "";
                Formularios.Control.novRISR = "";
                Formularios.Control.dicRISR = "";
                Formularios.Control.totRISR = "";
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
                Formularios.Control.totRISR = tot;
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
                Formularios.Control.eneRIVA = "";
                Formularios.Control.febRIVA = "";
                Formularios.Control.marRIVA = "";
                Formularios.Control.abrRIVA = "";
                Formularios.Control.mayRIVA = "";
                Formularios.Control.junRIVA = "";
                Formularios.Control.julRIVA = "";
                Formularios.Control.agoRIVA = "";
                Formularios.Control.sepRIVA = "";
                Formularios.Control.octRIVA = "";
                Formularios.Control.novRIVA = "";
                Formularios.Control.dicRIVA = "";
                Formularios.Control.totRIVA = "";
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
                Formularios.Control.totRIVA = tot;
            }
        }
    }
}

