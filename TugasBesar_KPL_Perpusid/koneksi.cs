using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TugasBesar_KPL_Perpusid
{
    class koneksi
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string koneksiString = "server = localhost; database =tugasakhir; uid = root; password=;";
                koneksi = new MySqlConnection(koneksiString);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
