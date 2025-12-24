using DatabaseManager;
using Newtonsoft.Json.Linq;

namespace TestAppProject
{
    public class DatabaseTests
    {

        private DatabaseHandler databaseManager;

        [SetUp]
        public void Setup()
        {
            // Database parameters (password should be encrypted...)
            string DatabaseServer = "localhost";
            string DatabasePort = "3306";
            string DatabaseName = "mysqldemo";
            string DatabaseUser = "demo";
            string DatabasePassword = "demo";

            String connectionString = "Server=" + DatabaseServer + ";Port=" + DatabasePort + ";Database=" + DatabaseName + ";User=" + DatabaseUser + ";Password=" + DatabasePassword + ";";

            databaseManager = DatabaseHandler.GetInstance(connectionString);
        }

        [Test, Order(1)]
        public void TC01_db_connection()
        {
            databaseManager.ConnectionOpen();
            databaseManager.ConnectionClose();
            Assert.Pass();
        }

        [Test, Order(2)]
        public void TC02_db_users_add()
        {
            string insertSql = "INSERT INTO users (name, surname, email, username, password) VALUES ('name_test', 'surname_test', 'email_test@google.com', 'username_test', 'password_test')";

            databaseManager.ConnectionOpen();
            int rowsAffected = databaseManager.ExecuteNonQuery(insertSql);
            databaseManager.ConnectionClose();
            if (rowsAffected > 0)
            {
                Assert.Pass();
            }
            else {
                Assert.Fail();
            }
        }

        [Test, Order(3)]
        public void TC03_db_users_update()
        {
            string insertSql = "UPDATE users SET name = 'name_test_updated' WHERE username = 'username_test'";

            databaseManager.ConnectionOpen();
            int rowsAffected = databaseManager.ExecuteNonQuery(insertSql);
            databaseManager.ConnectionClose();
            if (rowsAffected > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test, Order(4)]
        public void TC04_db_users_delete()
        {
            string insertSql = "DELETE FROM users WHERE username = 'username_test'";

            databaseManager.ConnectionOpen();
            int rowsAffected = databaseManager.ExecuteNonQuery(insertSql);
            databaseManager.ConnectionClose();
            if (rowsAffected > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test, Order(5)]
        public void TC05_db_refex_users_read()
        {

            List<DatabaseManager.EntityClasses.User> users = databaseManager.GetUsers();

            if (users.Count == 1)
            {
                if (users[0].Username == "demo")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}