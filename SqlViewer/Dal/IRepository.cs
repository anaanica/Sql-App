using SqlViewer.Models;
using System.Data;
using System.Data.SqlClient;

namespace SqlViewer.Dal
{
    internal interface IRepository
    {
        DataSet CreateDataSet(DBEntity dbEntity);
        DataTable ExecuteQuery(string query, SqlInfoMessageEventHandler OnInfoMessageGenerated, StatementCompletedEventHandler OnStatementCompleted);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
    }
}