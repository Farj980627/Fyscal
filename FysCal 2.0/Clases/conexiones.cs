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
        //Verificar el Regimen fiscal
        /*public static void regimenFiscal(String ppidCliente)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(String.Format("select regimenFiscal from clientes where id_cliente='"+ppidCliente+"'"), con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Formularios.Inicio.regimen = reader[0].ToString();       

        }*/
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
        //Obtener el id del cliente seleccionado
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
                Formularios.Control.ene16 = reader["enero"].ToString();
                Formularios.Control.feb16 = reader["febrero"].ToString();
                Formularios.Control.mar16 = reader["marzo"].ToString();
                Formularios.Control.abr16 = reader["abril"].ToString();
                Formularios.Control.may16 = reader["mayo"].ToString();
                Formularios.Control.jun16 = reader["junio"].ToString();
                Formularios.Control.jul16 = reader["julio"].ToString();
                Formularios.Control.ago16 = reader["agosto"].ToString();
                Formularios.Control.sep16 = reader["septiembre"].ToString();
                Formularios.Control.oct16 = reader["octubre"].ToString();
                Formularios.Control.nov16 = reader["noviembre"].ToString();
                Formularios.Control.dic16 = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla ingresos0
        public static void InfoIngresos0()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresos0 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.ene0 = reader["enero"].ToString();
                Formularios.Control.feb0 = reader["febrero"].ToString();
                Formularios.Control.mar0 = reader["marzo"].ToString();
                Formularios.Control.abr0 = reader["abril"].ToString();
                Formularios.Control.may0 = reader["mayo"].ToString();
                Formularios.Control.jun0 = reader["junio"].ToString();
                Formularios.Control.jul0 = reader["julio"].ToString();
                Formularios.Control.ago0 = reader["agosto"].ToString();
                Formularios.Control.sep0 = reader["septiembre"].ToString();
                Formularios.Control.oct0 = reader["octubre"].ToString();
                Formularios.Control.nov0 = reader["noviembre"].ToString();
                Formularios.Control.dic0 = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla ingresosExentos
        public static void InfoIngresosExcentos()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosexentos where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.eneExe = reader["enero"].ToString();
                Formularios.Control.febExe = reader["febrero"].ToString();
                Formularios.Control.marExe = reader["marzo"].ToString();
                Formularios.Control.abrExe = reader["abril"].ToString();
                Formularios.Control.mayExe = reader["mayo"].ToString();
                Formularios.Control.junExe = reader["junio"].ToString();
                Formularios.Control.julExe = reader["julio"].ToString();
                Formularios.Control.agoExe = reader["agosto"].ToString();
                Formularios.Control.sepExe = reader["septiembre"].ToString();
                Formularios.Control.octExe = reader["octubre"].ToString();
                Formularios.Control.novExe = reader["noviembre"].ToString();
                Formularios.Control.dicExe = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla ingresosNoObjeto
        public static void InfoIngresosNoObjeto()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ingresosnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.eneNoo = reader["enero"].ToString();
                Formularios.Control.febNoo = reader["febrero"].ToString();
                Formularios.Control.marNoo = reader["marzo"].ToString();
                Formularios.Control.abrNoo = reader["abril"].ToString();
                Formularios.Control.mayNoo = reader["mayo"].ToString();
                Formularios.Control.junNoo = reader["junio"].ToString();
                Formularios.Control.julNoo = reader["julio"].ToString();
                Formularios.Control.agoNoo = reader["agosto"].ToString();
                Formularios.Control.sepNoo = reader["septiembre"].ToString();
                Formularios.Control.octNoo = reader["octubre"].ToString();
                Formularios.Control.novNoo = reader["noviembre"].ToString();
                Formularios.Control.dicNoo = reader["diciembre"].ToString();

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
                Formularios.Control.eneRISR = reader["enero"].ToString();
                Formularios.Control.febRISR = reader["febrero"].ToString();
                Formularios.Control.marRISR = reader["marzo"].ToString();
                Formularios.Control.abrRISR = reader["abril"].ToString();
                Formularios.Control.mayRISR = reader["mayo"].ToString();
                Formularios.Control.junRISR = reader["junio"].ToString();
                Formularios.Control.julRISR = reader["julio"].ToString();
                Formularios.Control.agoRISR = reader["agosto"].ToString();
                Formularios.Control.sepRISR = reader["septiembre"].ToString();
                Formularios.Control.octRISR = reader["octubre"].ToString();
                Formularios.Control.novRISR = reader["noviembre"].ToString();
                Formularios.Control.dicRISR = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla retencionesIVA
        public static void InfoRetencionesIVA()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from retencionesiva where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.eneRIVA = reader["enero"].ToString();
                Formularios.Control.febRIVA = reader["febrero"].ToString();
                Formularios.Control.marRIVA = reader["marzo"].ToString();
                Formularios.Control.abrRIVA = reader["abril"].ToString();
                Formularios.Control.mayRIVA = reader["mayo"].ToString();
                Formularios.Control.junRIVA = reader["junio"].ToString();
                Formularios.Control.julRIVA = reader["julio"].ToString();
                Formularios.Control.agoRIVA = reader["agosto"].ToString();
                Formularios.Control.sepRIVA = reader["septiembre"].ToString();
                Formularios.Control.octRIVA = reader["octubre"].ToString();
                Formularios.Control.novRIVA = reader["noviembre"].ToString();
                Formularios.Control.dicRIVA = reader["diciembre"].ToString();


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
                Formularios.Control.dene16 = reader["enero"].ToString();
                Formularios.Control.dfeb16 = reader["febrero"].ToString();
                Formularios.Control.dmar16 = reader["marzo"].ToString();
                Formularios.Control.dabr16 = reader["abril"].ToString();
                Formularios.Control.dmay16 = reader["mayo"].ToString();
                Formularios.Control.djun16 = reader["junio"].ToString();
                Formularios.Control.djul16 = reader["julio"].ToString();
                Formularios.Control.dago16 = reader["agosto"].ToString();
                Formularios.Control.dsep16 = reader["septiembre"].ToString();
                Formularios.Control.doct16 = reader["octubre"].ToString();
                Formularios.Control.dnov16 = reader["noviembre"].ToString();
                Formularios.Control.ddic16 = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla deducciones0
        public static void InfoDeducciones0()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deducciones0 where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.dene0 = reader["enero"].ToString();
                Formularios.Control.dfeb0 = reader["febrero"].ToString();
                Formularios.Control.dmar0 = reader["marzo"].ToString();
                Formularios.Control.dabr0 = reader["abril"].ToString();
                Formularios.Control.dmay0 = reader["mayo"].ToString();
                Formularios.Control.djun0 = reader["junio"].ToString();
                Formularios.Control.djul0 = reader["julio"].ToString();
                Formularios.Control.dago0 = reader["agosto"].ToString();
                Formularios.Control.dsep0 = reader["septiembre"].ToString();
                Formularios.Control.doct0 = reader["octubre"].ToString();
                Formularios.Control.dnov0 = reader["noviembre"].ToString();
                Formularios.Control.ddic0 = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla deduccionesExentas
        public static void InfoDeduccionesExe()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesexentas where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.deneexe = reader["enero"].ToString();
                Formularios.Control.dfebexe = reader["febrero"].ToString();
                Formularios.Control.dmarexe = reader["marzo"].ToString();
                Formularios.Control.dabrexe = reader["abril"].ToString();
                Formularios.Control.dmayexe = reader["mayo"].ToString();
                Formularios.Control.djunexe = reader["junio"].ToString();
                Formularios.Control.djulexe = reader["julio"].ToString();
                Formularios.Control.dagoexe = reader["agosto"].ToString();
                Formularios.Control.dsepexe = reader["septiembre"].ToString();
                Formularios.Control.doctexe = reader["octubre"].ToString();
                Formularios.Control.dnovexe = reader["noviembre"].ToString();
                Formularios.Control.ddicexe = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla deduccionesNoObjeto
        public static void InfoDeduccionesNoObjeto()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesnoobjeto where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.deneNoo = reader["enero"].ToString();
                Formularios.Control.dfebNoo = reader["febrero"].ToString();
                Formularios.Control.dmarNoo = reader["marzo"].ToString();
                Formularios.Control.dabrNoo = reader["abril"].ToString();
                Formularios.Control.dmayNoo = reader["mayo"].ToString();
                Formularios.Control.djunNoo = reader["junio"].ToString();
                Formularios.Control.djulNoo = reader["julio"].ToString();
                Formularios.Control.dagoNoo = reader["agosto"].ToString();
                Formularios.Control.dsepNoo = reader["septiembre"].ToString();
                Formularios.Control.doctNoo = reader["octubre"].ToString();
                Formularios.Control.dnovNoo = reader["noviembre"].ToString();
                Formularios.Control.ddicNoo = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla estimuloFiscal
        public static void InfoEstimuloFiscal()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from estimulofiscal where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.deneest = reader["enero"].ToString();
                Formularios.Control.dfebest = reader["febrero"].ToString();
                Formularios.Control.dmarest = reader["marzo"].ToString();
                Formularios.Control.dabrest = reader["abril"].ToString();
                Formularios.Control.dmayest = reader["mayo"].ToString();
                Formularios.Control.djunest = reader["junio"].ToString();
                Formularios.Control.djulest = reader["julio"].ToString();
                Formularios.Control.dagoest = reader["agosto"].ToString();
                Formularios.Control.dsepest = reader["septiembre"].ToString();
                Formularios.Control.doctest = reader["octubre"].ToString();
                Formularios.Control.dnovest = reader["noviembre"].ToString();
                Formularios.Control.ddicest = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla deduccionesMes
        public static void InfoDeduccionesMes()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from deduccionesmes where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

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
                Formularios.Control.denemes = reader["enero"].ToString();
                Formularios.Control.dfebmes = reader["febrero"].ToString();
                Formularios.Control.dmarmes = reader["marzo"].ToString();
                Formularios.Control.dabrmes = reader["abril"].ToString();
                Formularios.Control.dmaymes = reader["mayo"].ToString();
                Formularios.Control.djunmes = reader["junio"].ToString();
                Formularios.Control.djulmes = reader["julio"].ToString();
                Formularios.Control.dagomes = reader["agosto"].ToString();
                Formularios.Control.dsepmes = reader["septiembre"].ToString();
                Formularios.Control.doctmes = reader["octubre"].ToString();
                Formularios.Control.dnovmes = reader["noviembre"].ToString();
                Formularios.Control.ddicmes = reader["diciembre"].ToString();

            }

        }
        //Obtener la informacion de la tabla iva acreditable manual
        public static void InfoIVAAcreditable()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ivaacreditablemanual where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();

            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.deneivaAcr = "0";
                Formularios.Control.dfebivaAcr = "0";
                Formularios.Control.dmarivaAcr = "0";
                Formularios.Control.dabrivaAcr = "0";
                Formularios.Control.dmayivaAcr = "0";
                Formularios.Control.djunivaAcr = "0";
                Formularios.Control.djulivaAcr = "0";
                Formularios.Control.dagoivaAcr = "0";
                Formularios.Control.dsepivaAcr = "0";
                Formularios.Control.doctivaAcr = "0";
                Formularios.Control.dnovivaAcr = "0";
                Formularios.Control.ddicivaAcr = "0";
                Formularios.Control.dtotivaAcr = "0";
            }
            else
            {
                Formularios.Control.deneivaAcr = reader["enero"].ToString();
                Formularios.Control.dfebivaAcr = reader["febrero"].ToString();
                Formularios.Control.dmarivaAcr = reader["marzo"].ToString();
                Formularios.Control.dabrivaAcr = reader["abril"].ToString();
                Formularios.Control.dmayivaAcr = reader["mayo"].ToString();
                Formularios.Control.djunivaAcr = reader["junio"].ToString();
                Formularios.Control.djulivaAcr = reader["julio"].ToString();
                Formularios.Control.dagoivaAcr = reader["agosto"].ToString();
                Formularios.Control.dsepivaAcr = reader["septiembre"].ToString();
                Formularios.Control.doctivaAcr = reader["octubre"].ToString();
                Formularios.Control.dnovivaAcr = reader["noviembre"].ToString();
                Formularios.Control.ddicivaAcr = reader["diciembre"].ToString();

            }
        }
        //Obtener la informacion de la tabla Pérdidas
        public static void InfoPerdidas()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from Perdidas where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.denePerdidas = "0";
                Formularios.Control.dfebPerdidas = "0";
                Formularios.Control.dmarPerdidas = "0";
                Formularios.Control.dabrPerdidas = "0";
                Formularios.Control.dmayPerdidas = "0";
                Formularios.Control.djunPerdidas = "0";
                Formularios.Control.djulPerdidas = "0";
                Formularios.Control.dagoPerdidas = "0";
                Formularios.Control.dsepPerdidas = "0";
                Formularios.Control.doctPerdidas = "0";
                Formularios.Control.dnovPerdidas = "0";
                Formularios.Control.ddicPerdidas = "0";
                Formularios.Control.dtotPerdidas = "0";
            }
            else
            {
                Formularios.Control.denePerdidas = reader["enero"].ToString();
                Formularios.Control.dfebPerdidas = reader["febrero"].ToString();
                Formularios.Control.dmarPerdidas = reader["marzo"].ToString();
                Formularios.Control.dabrPerdidas = reader["abril"].ToString();
                Formularios.Control.dmayPerdidas = reader["mayo"].ToString();
                Formularios.Control.djunPerdidas = reader["junio"].ToString();
                Formularios.Control.djulPerdidas = reader["julio"].ToString();
                Formularios.Control.dagoPerdidas = reader["agosto"].ToString();
                Formularios.Control.dsepPerdidas = reader["septiembre"].ToString();
                Formularios.Control.doctPerdidas = reader["octubre"].ToString();
                Formularios.Control.dnovPerdidas = reader["noviembre"].ToString();
                Formularios.Control.ddicPerdidas = reader["diciembre"].ToString();




            }
        }

        //Obtener la informacion de la tabla PTU
        public static void InfoPTU()
        {
            MySqlConnection con = Clases.conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select * from ptu where id_cliente='" + Formularios.Control.idCliente + "' ;"), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(false))
            {
                Formularios.Control.denePtu = "0";
                Formularios.Control.dfebPtu = "0";
                Formularios.Control.dmarPtu = "0";
                Formularios.Control.dabrPtu = "0";
                Formularios.Control.dmayPtu = "0";
                Formularios.Control.djunPtu = "0";
                Formularios.Control.djulPtu = "0";
                Formularios.Control.dagoPtu = "0";
                Formularios.Control.dsepPtu = "0";
                Formularios.Control.doctPtu = "0";
                Formularios.Control.dnovPtu = "0";
                Formularios.Control.ddicPtu = "0";
                Formularios.Control.dtotPtu = "0";
            }
            else
            {
                Formularios.Control.denePtu = reader["enero"].ToString();
                Formularios.Control.dfebPtu = reader["febrero"].ToString();
                Formularios.Control.dmarPtu = reader["marzo"].ToString();
                Formularios.Control.dabrPtu = reader["abril"].ToString();
                Formularios.Control.dmayPtu = reader["mayo"].ToString();
                Formularios.Control.djunPtu = reader["junio"].ToString();
                Formularios.Control.djulPtu = reader["julio"].ToString();
                Formularios.Control.dagoPtu = reader["agosto"].ToString();
                Formularios.Control.dsepPtu = reader["septiembre"].ToString();
                Formularios.Control.doctPtu = reader["octubre"].ToString();
                Formularios.Control.dnovPtu = reader["noviembre"].ToString();
                Formularios.Control.ddicPtu = reader["diciembre"].ToString();

            }
        }
        //Insertar la columna de ingresos totales del mes
        public static void ingTotalesMes(String ppcliente, String ppEnero, String ppFebrero, String ppMarzo, String ppAbril, String ppMayo, String ppJunio, String ppJulio, String ppAgosto, String ppSep, String ppOct, String ppNovi, String ppDic)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingtotalesmes where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingtotalesmes  SET totalenero='{0}',totalfebrero='{1}',totalmarzo='{2}',totalabril='{3}',totalmayo='{4}',totaljunio='{5}',totaljulio='{6}',totalagosto='{7}',totalseptiembre='{8}',totaloctubre='{9}',totalnoviembre='{10}',totaldiciembre='{11}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {
                MySqlConnection con3 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("insert into ingtotalesmes(id_cliente,totalEnero, totalFebrero,totalMarzo,totalAbril,totalMayo,totalJunio,totalJulio, totalAgosto, totalSeptiembre, totalOctubre, totalNoviembre, totalDiciembre) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'  )", ppcliente, ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con3);
                comando.ExecuteNonQuery();
                con3.Close();
            }

        }
        //Insertar la columna de deducciones totales del mes
        public static void dedTotalesMes(String ppcliente, String ppEnero, String ppFebrero, String ppMarzo, String ppAbril, String ppMayo, String ppJunio, String ppJulio, String ppAgosto, String ppSep, String ppOct, String ppNovi, String ppDic)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from dedtotalesmes where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE dedtotalesmes SET totalenero='{0}',totalfebrero='{1}',totalmarzo='{2}',totalabril='{3}',totalmayo='{4}',totaljunio='{5}',totaljulio='{6}',totalagosto='{7}',totalseptiembre='{8}',totaloctubre='{9}',totalnoviembre='{10}',totaldiciembre='{11}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {
                MySqlConnection con3 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("insert into dedtotalesmes(id_cliente,totalEnero, totalFebrero,totalMarzo,totalAbril,totalMayo,totalJunio,totalJulio, totalAgosto, totalSeptiembre, totalOctubre, totalNoviembre, totalDiciembre) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'  )", ppcliente, ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con3);
                comando.ExecuteNonQuery();
                con3.Close();
            }
        }
        //Insertar la columna de deducciones acumuladas
        public static void dedAcumuladas(String ppcliente, String ppEnero, String ppFebrero, String ppMarzo, String ppAbril, String ppMayo, String ppJunio, String ppJulio, String ppAgosto, String ppSep, String ppOct, String ppNovi, String ppDic)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from dedacumulados where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE dedacumulados SET acuenero='{0}',acufebrero='{1}',acumarzo='{2}',acuabril='{3}',acumayo='{4}',acujunio='{5}',acujulio='{6}',acuagosto='{7}',acuseptiembre='{8}',acuoctubre='{9}',acunoviembre='{10}',acudiciembre='{11}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {
                MySqlConnection con3 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("insert into dedacumulados(id_cliente,acuEnero, acuFebrero,acuMarzo,acuAbril,acuMayo,acuJunio,acuJulio, acuAgosto, acuSeptiembre, acuOctubre, acuNoviembre, acuDiciembre) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'  )", ppcliente, ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con3);
                comando.ExecuteNonQuery();
                con3.Close();
            }
        }
        //Insertar la columna de ingresos acumulados
        public static void ingAcumulados(String ppcliente, String ppEnero, String ppFebrero, String ppMarzo, String ppAbril, String ppMayo, String ppJunio, String ppJulio, String ppAgosto, String ppSep, String ppOct, String ppNovi, String ppDic)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ingacumulados where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ingacumulados SET acuenero='{0}',acufebrero='{1}',acumarzo='{2}',acuabril='{3}',acumayo='{4}',acujunio='{5}',acujulio='{6}',acuagosto='{7}',acuseptiembre='{8}',acuoctubre='{9}',acunoviembre='{10}',acudiciembre='{11}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {
                MySqlConnection con3 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("insert into ingacumulados(id_cliente,acuEnero, acuFebrero,acuMarzo,acuAbril,acuMayo,acuJunio,acuJulio, acuAgosto, acuSeptiembre, acuOctubre, acuNoviembre, acuDiciembre) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'  )", ppcliente, ppEnero, ppFebrero, ppMarzo, ppAbril, ppMayo, ppJunio, ppJulio, ppAgosto, ppSep, ppOct, ppNovi, ppDic), con3);
                comando.ExecuteNonQuery();
                con3.Close();
            }
        }
        //CALCULO GENERAL
        public static void datosCalculoGeneralISR(String pMes)
        {
            string ingMes, dedMes, ingAcu, dedAcu;
            MySqlConnection con = Clases.conexiones.conection();
            if (pMes.Equals("Enero"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.totalenero, d16.totalenero from ingtotalesmes i16 join dedtotalesmes d16 where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes = reader[0].ToString();
                dedMes = reader[1].ToString();
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                Formularios.calculoGeneral.ingAcumulado = "0";
                Formularios.calculoGeneral.dedAcumulada = "0";
                con.Close();
            }
            if (pMes.Equals("Febrero"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuEnero, i16.totalfebrero, deda.acuEnero, d16.totalfebrero from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Marzo"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuFebrero, i16.totalmarzo, deda.acuFebrero, d16.totalmarzo from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Abril"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuMarzo, i16.totalabril, deda.acuMarzo, d16.totalabril from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Mayo"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuAbril, i16.totalmayo, deda.acuAbril, d16.totalmayo from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Junio"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuMayo, i16.totaljunio, deda.acuMayo, d16.totaljunio from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Julio"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuJunio, i16.totaljulio, deda.acuJunio, d16.totaljulio from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Agosto"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuJulio, i16.totalagosto, deda.acuJulio, d16.totalagosto from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Septiembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuAgosto, i16.totalseptiembre, deda.acuAgosto, d16.totalseptiembre from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Octubre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuSeptiembre, i16.totalagosto, deda.acuSeptiembre, d16.totaloctubre from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Noviembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuOctubre, i16.totalnoviembre, deda.acuOctubre, d16.totalnoviembre from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
            if (pMes.Equals("Diciembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT inga.acuNoviembre, i16.totaldiciembre, deda.acuNoviembre, d16.totaldiciembre from ingacumulados inga join ingtotalesmes i16 join dedacumulados deda join dedtotalesmes d16 where inga.id_cliente='" + Formularios.Control.idCliente + "' and i16.id_cliente='" + Formularios.Control.idCliente + "' and deda.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "' "), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingAcu = reader[0].ToString();
                ingMes = reader[1].ToString();
                dedAcu = reader[2].ToString();
                dedMes = reader[3].ToString();
                Formularios.calculoGeneral.ingAcumulado = ingAcu;
                Formularios.calculoGeneral.ingTotPeriodo = ingMes;
                Formularios.calculoGeneral.dedAcumulada = dedAcu;
                Formularios.calculoGeneral.dedTotalPeriodo = dedMes;
                con.Close();
            }
        }
        //CALCULO GENERAL IVA
        public static void datosCalculoGeneralIVA(String pMes)
        {
            string ingMes16, dedMes16, ingMes0, dedMes0, ingExe, dedExe, retencion;
            MySqlConnection con = Clases.conexiones.conection();
            if (pMes.Equals("Enero"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.enero, d16.enero, i0.enero, d0.enero, iexe.enero, dexe.enero, ret.enero from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Febrero"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.febrero, d16.febrero, i0.febrero, d0.febrero, iexe.febrero, dexe.febrero, ret.febrero from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Marzo"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.marzo, d16.marzo, i0.marzo, d0.marzo, iexe.marzo, dexe.marzo, ret.marzo from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Abril"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.abril, d16.abril, i0.abril, d0.abril, iexe.abril, dexe.abril, ret.abril from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Mayo"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.mayo, d16.mayo, i0.mayo, d0.mayo, iexe.mayo, dexe.mayo, ret.mayo from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Junio"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.junio, d16.junio, i0.junio, d0.junio, iexe.junio, dexe.junio, ret.junio from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Julio"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.julio, d16.julio, i0.julio, d0.julio, iexe.julio, dexe.julio, ret.julio from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Agosto"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.agosto, d16.agosto, i0.agosto, d0.agosto, iexe.agosto, dexe.agosto, ret.agosto from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Septiembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.septiembre, d16.septiembre, i0.septiembre, d0.septiembre, iexe.septiembre, dexe.septiembre, ret.septiembre from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Octubre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.octubre, d16.octubre, i0.octubre, d0.octubre, iexe.octubre, dexe.octubre, ret.octubre from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Noviembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.noviembre, d16.noviembre, i0.noviembre, d0.noviembre, iexe.noviembre, dexe.noviembre, ret.noviembre from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
            if (pMes.Equals("Diciembre"))
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT i16.diciembre, d16.diciembre, i0.diciembre, d0.diciembre, iexe.diciembre, dexe.diciembre, ret.diciembre from ingresos16 i16 join deducciones16 d16 join ingresos0 i0 join deducciones0 d0 join ingresosexentos iexe join deduccionesexentas dexe join retencionesiva ret where i16.id_cliente='" + Formularios.Control.idCliente + "' and d16.id_cliente='" + Formularios.Control.idCliente + "'and i0.id_cliente='" + Formularios.Control.idCliente + "' and d0.id_cliente='" + Formularios.Control.idCliente + "' and iexe.id_cliente='" + Formularios.Control.idCliente + "' and dexe.id_cliente='" + Formularios.Control.idCliente + "' and ret.id_cliente='" + Formularios.Control.idCliente + "'"), con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ingMes16 = reader[0].ToString();
                dedMes16 = reader[1].ToString();
                ingMes0 = reader[2].ToString();
                dedMes0 = reader[3].ToString();
                ingExe = reader[4].ToString();
                dedExe = reader[5].ToString();
                retencion = reader[6].ToString();
                Formularios.calculoGeneral.ingIVA16 = ingMes16;
                Formularios.calculoGeneral.dedIVA16 = dedMes16;
                Formularios.calculoGeneral.ingIVA0 = ingMes0;
                Formularios.calculoGeneral.dedIVA0 = dedMes0;
                Formularios.calculoGeneral.ingExe = ingExe;
                Formularios.calculoGeneral.dedExe = dedExe;
                Formularios.calculoGeneral.retiva = retencion;
                con.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deducciones IVA Acreditable Manual
        public static void ivaAcreditable(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ivaacreditablemanual where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ivaacreditablemanual SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ivaacreditablemanual(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deducciones PTU
        public static void Ptu(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from ptu where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE ptu SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO ptu(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Insertar o actualizar datos de la tabla deducciones Péerdidas
        public static void Perdidas(String pcliente, String penero, String pfebrero, String pmarzo, String pabril, String pmayo, String pjunio, String pjulio, String pagosto,
            String pseptiembre, String pocctubre, String pnoviembre, String pdiciembre, String ptotal)
        {

            MySqlConnection con = conexiones.conection();
            MySqlCommand com = new MySqlCommand(string.Format("select id_cliente from perdidas where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows.Equals(true))
            {
                MySqlConnection con2 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("UPDATE perdidas SET enero='{0}',febrero='{1}',marzo='{2}',abril='{3}',mayo='{4}',junio='{5}',julio='{6}',agosto='{7}',septiembre='{8}',octubre='{9}',noviembre='{10}',diciembre='{11}',total='{12}' WHERE id_cliente='" + Formularios.Control.idCliente + "'", penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con2);
                comando.ExecuteNonQuery();
                con2.Close();

            }
            else
            {

                MySqlConnection con1 = conexiones.conection();
                MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO perdidas(id_cliente,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre,total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", pcliente, penero, pfebrero, pmarzo, pabril, pmayo, pjunio, pjulio, pagosto, pseptiembre, pocctubre, pnoviembre, pdiciembre, ptotal), con1);
                comando.ExecuteNonQuery();
                con1.Close();
            }
        }
        //Obtener el ISR Retenido
        public static List<string> ISRRet()
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * from retencionesisr where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            List<string> isr = new List<string>();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            for (int i = 2; i <= 14; i++)
            {
                isr.Add(reader[i].ToString());
            }

            return isr;

        }
        //Insertar el total de cada mes
        public static void pagoProvisional(String id_cliente, String ppenero, String ppfebrero, String ppmarzo, String ppabril, String ppmayo, String ppjunio, String ppjulio, String ppagosto, String ppseptiembre, String ppoctubre, String ppnoviembre, String ppdiciembre)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into pagosprovisionalesisr(id_cliente, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre ) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}' )",id_cliente, ppenero, ppfebrero, ppmarzo, ppabril, ppmayo, ppjunio, ppjulio, ppagosto, ppseptiembre, ppoctubre, ppnoviembre, ppdiciembre), con);
            comando.ExecuteNonQuery();

        }
        //Insertar el ISR Art 106 y diferencia
        public static void ISR106Dif(String id_cliente, String ppenero106, String ppfebrero106, String ppmarzo106, String ppabril106, String ppmayo106, String ppjunio106, String ppjulio106, String ppagosto106, String ppseptiembre106, String ppoctubre106, String ppnoviembre106, String ppdiciembre106, String ppenerodif, String ppfebrerodif, String ppmarzodif, String ppabrildif, String ppmayodif, String ppjuniodif, String ppjuliodif, String ppagostodif, String ppseptiembredif, String ppoctubredif, String ppnoviembredif, String ppdiciembredif)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into art106diferencia(id_cliente, enero106, febrero106, marzo106, abril106, mayo106, junio106, julio106, agosto106, septiembre106, octubre106, noviembre106, diciembre106, enerodif, febrerodif, marzodif, abrildif, mayodif, juniodif, juliodif, agostodif, septiembredif, octubredif, noviembredif, diciembredif ) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}',  '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{14}' )", id_cliente, ppenero106, ppfebrero106, ppmarzo106, ppabril106, ppmayo106, ppjunio106, ppjulio106, ppagosto106, ppseptiembre106, ppoctubre106, ppnoviembre106, ppdiciembre106, ppenerodif, ppfebrerodif, ppmarzodif, ppabrildif, ppmayodif, ppjuniodif, ppjuliodif, ppagostodif, ppseptiembredif, ppoctubredif, ppnoviembredif, ppdiciembredif), con);
            comando.ExecuteNonQuery();

        }
        //Obtener el ultimo id creado
        public static String max_id()
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT Max(id_cliente)  from clientes "), con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id = reader[0].ToString();
            return id;     
            
        }

        //Obtener los pagos previos
        public static List<string> pagoProv()
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * from pagosprovisionalesisr where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            List<string> pagoprov = new List<string>();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            for (int i = 2; i < 14; i++)
            {
                
                pagoprov.Add(reader[i].ToString());
            }

            return pagoprov;

        }

        //actualizar la tabla de pago provisionales
        public static void actProvisionales(String mes, String valor)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE pagosprovisionalesisr SET "+mes+" = '{0}' where id_cliente='"+Formularios.Control.idCliente+"'", valor), con);
            comando.ExecuteNonQuery();
        }

        //actualizar la tabla de ISR Art 106 y Diferencia
        public static void get106Dif(String mes, String valor, String valor1)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE art106diferencia SET " + mes + "106 = '{0}'," + mes + "dif = '{1}'  where id_cliente='" + Formularios.Control.idCliente + "'", valor,valor1), con);
            comando.ExecuteNonQuery();
        }
        //Obtener ISR 106 y Diferencia
        public static List<string> obtener106Dif(String mes)
        {
            MySqlConnection con = conexiones.conection();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT "+mes+"106 , "+mes+"dif from art106diferencia where id_cliente='" + Formularios.Control.idCliente + "' "), con);
            List<string> dife106 = new List<string>();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            dife106.Add(reader[0].ToString());
            dife106.Add(reader[1].ToString());


            return dife106;

        }
    }
}

