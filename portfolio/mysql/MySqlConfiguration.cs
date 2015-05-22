using System.Data.Entity;

namespace ESVerse.Tournaments.Core.MySql
{
    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext(
            "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
            
        }
    }
}
