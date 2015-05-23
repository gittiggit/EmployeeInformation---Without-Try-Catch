using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeInformation.DAL.Gateway
{
    public class DBGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;
        
        public SqlConnection ConnectionObj
        {
            get
            {
                return connectionObj;
            }
        }

        public SqlCommand CommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
        public DBGateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString);
            commandObj = new SqlCommand();
        }




    }
}
