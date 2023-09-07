using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace Tournament_App
{
    public class SqliteDataAccess
    {
        public static List<AccountModel> LoadAccount()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountModel>("select * from Account", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Account (Email, Password) values (@Email, @Password)", account);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
