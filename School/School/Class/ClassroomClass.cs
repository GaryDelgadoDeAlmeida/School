using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Class
{
    public static class ClassroomClass
    {
        private static ConnectionDatabase connectionStudentDatabase = null;

        public static string addClassroom(
            string name,
            string stringDate
            )
        {
            try
            {
                DateTime date = Convert.ToDateTime(stringDate);

                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
                string insertData = "INSERT INTO [dbo].[Class] (Name, PromotionYear) VALUES (" +
                            "'" + name + "', " +
                            "'" + date + "')"; 
                connectionStudentDatabase.sqlCommand.CommandText = insertData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "La nouvelle classe, " + name + ", a bien été ajouté dans la base de données";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string editClassroom(
            string id,
            string name,
            string stringDate
            )
        {
            try
            {
                DateTime date = Convert.ToDateTime(stringDate);
                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
                string updateData = "UPDATE [dbo].[Class] SET Name='"+name+"', PromotionYear='"+date+"' WHERE Id='"+id+"'";
                connectionStudentDatabase.sqlCommand.CommandText = updateData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "La mise à jour de la classe " + name + " a été enregistrée.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string deleteClassroom(string id)
        {
            try
            {
                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
                string deleteData = "DELETE FROM [dbo].[Class] WHERE id = '" + id + "';";
                connectionStudentDatabase.sqlCommand.CommandText = deleteData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "La suppression de la classe a bien été effectuée.";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }


        /// <summary>
        /// Ouvre la connection à la base de données
        /// </summary>
        private static void openConnectionToDatabase()
        {
            connectionStudentDatabase = new ConnectionDatabase();
            connectionStudentDatabase.sqlConnection.ConnectionString = connectionStudentDatabase.locate;
            connectionStudentDatabase.sqlConnection.Open();

            connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
        }

        /// <summary>
        /// Ferme la connection à la base de données
        /// </summary>
        private static void closeConnectionToDatabse()
        {
            if (connectionStudentDatabase != null)
            {
                connectionStudentDatabase.sqlConnection.Close();
            }
        }
    }
}
