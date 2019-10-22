using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace School.Class
{
    class ConnectionDatabase
    {
        public SchoolDatabaseDataSet studentDatabase = new SchoolDatabaseDataSet();
        public SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public SqlConnection sqlConnection = new SqlConnection();
        public SqlCommand sqlCommand = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\garya\Documents\Developpement\Application\C#\School\School\SchoolDatabaseDataSet.xsd';Integrated Security=True";
    }
}
