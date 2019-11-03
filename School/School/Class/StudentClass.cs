using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Class
{
    public static class StudentClass
    {
        private static ConnectionDatabase connectionStudentDatabase = null;
        public static string addStudent(
            string firstName, 
            string lastName, 
            string email, 
            string studentClass
            )
        {
            try
            {
                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
                string insertData = "INSERT INTO [dbo].[Student] (FirstName, LastName, Email, Class) VALUES (" +
                            "'" + firstName + "', " +
                            "'" + lastName + "', " +
                            "'" + email + "', " +
                            "'" + studentClass + "')";
                connectionStudentDatabase.sqlCommand.CommandText = insertData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "Le nouvel étudiant, " + firstName + " " + lastName + ", a été ajouté à la base de données";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public static string updateStudent(
            string id,
            string firstName,
            string lastName,
            string email,
            string studentClass
            )
        {
            try
            {
                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;

                string updateData = "" /* update table*/;

                connectionStudentDatabase.sqlCommand.CommandText = updateData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "La mise à jour de l'étudiant " + firstName + " " + lastName + " s'est bien dérouler.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string deleteStudent(string id)
        {
            try
            {
                openConnectionToDatabase();
                connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;

                string deleteData = "DELETE FROM [dbo].[Student] WHERE id='" + id + "'";

                connectionStudentDatabase.sqlCommand.CommandText = deleteData;
                connectionStudentDatabase.sqlCommand.ExecuteNonQuery();
                connectionStudentDatabase.studentDatabase.AcceptChanges();
                closeConnectionToDatabse();
                return "L'identifiant " + id + " a bien été supprimer de la base de données.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static void openConnectionToDatabase()
        {
            connectionStudentDatabase = new ConnectionDatabase();
            connectionStudentDatabase.sqlConnection.ConnectionString = connectionStudentDatabase.locate;
            connectionStudentDatabase.sqlConnection.Open();

            connectionStudentDatabase.sqlCommand.Connection = connectionStudentDatabase.sqlConnection;
        }

        private static void closeConnectionToDatabse()
        {
            if(connectionStudentDatabase != null)
            {
                connectionStudentDatabase.sqlConnection.Close();
            }
        }
    }
}
