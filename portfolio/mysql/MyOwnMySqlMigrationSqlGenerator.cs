/*using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVerse.Tournaments.Core.MySql
{
    public class MyOwnMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator
    {
        protected override System.Data.Entity.Migrations.Sql.MigrationStatement Generate(System.Data.Entity.Migrations.Model.DropForeignKeyOperation op)
        {
            op.PrincipalTable = op.PrincipalTable.Replace("dbo.", "");
            op.DependentTable = op.DependentTable.Replace("dbo.", "");
            return base.Generate(op);
        }
    }
}
*/