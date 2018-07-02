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

            //"Server=localhost\sqlexpress"
            string message;
            string connectionString = null;
            //ZŁY CONNECTIONSTRING wywala wyjatek<--------------------------------
            connectionString = "Server= GOUDAGRMLN\\SQLEXPRESS, Authentication=Windows Authentication, Database= Konfigurator, Integrated Security=True;";
            SqlConnection db = new SqlConnection(connectionString);
            SqlCommand komenda;
            try
            {
                db.Open();
                
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
