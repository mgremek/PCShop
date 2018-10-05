using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep
{
    class Database
    {
        public Database()
        {

        }
        public bool Connection()
        { 
            bool isCorrect=true;
            string message;
            string connectionString = null;
   
            connectionString= "Data Source=GOUDAGRMLN\\SQLEXPRESS;" +
                              "Initial Catalog=Konfigurator;" +
                              "Integrated Security=SSPI;";


            SqlConnection db = new SqlConnection(connectionString);
            SqlCommand komenda;
            try
            {
                db.Open();
                //SqlCommand command = new SqlCommand(queryString, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message;
                isCorrect = false;
            }
            return isCorrect;
        }
       
    }
}
