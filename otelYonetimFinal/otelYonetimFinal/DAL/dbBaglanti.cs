using System;
using MySql.Data.MySqlClient;

namespace otelYonetimFinal.DAL
{
    class dbBaglanti
    {
        private string connectionString = "Server=172.21.54.253;Database=25_132330029; User=25_132330029; Password=!nif.ogr29GU;";

        public MySqlConnection BaglantiAc()
        {
            MySqlConnection baglanti = new MySqlConnection(connectionString);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }

        public void BaglantiKapat(MySqlConnection baglanti)
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
}
