using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVfinal.DB
{
    class db_conn
    {
        private string caminho_str_conn = 
            "../../DB/db_str_conn.txt";
        private string str_conn;
        

        public db_conn() {
            this.str_conn = getStrConn();
            
        }

        private string getStrConn()
        {
            StreamReader sr = new StreamReader(caminho_str_conn);
            string st = sr.ReadLine();
            sr.Close();
            return st;
        }

        public MySqlConnection getConn()
        {
            MySqlConnection conn = new MySqlConnection(str_conn);
            return conn;
        }
        
  

       

    }
}
