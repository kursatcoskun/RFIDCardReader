using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data.OleDb;
namespace CardReader
{
     class DB
    {
       // MySqlConnection baglanti;
        //Baglanti adında bir bağlantı oluşturdum

        public bool baglanti_kontrol()
        {
            try
            {
                OleDbConnection con;
                
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contacts.mdb");
                con.Open();

                return true;
               
            }

            catch (Exception)
            {
                return false;
               
            }
        }
    }
}
