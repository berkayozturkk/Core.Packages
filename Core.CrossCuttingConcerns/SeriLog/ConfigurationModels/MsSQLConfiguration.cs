using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.SeriLog.ConfigurationModels;

public class MsSQLConfiguration
{
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
    public bool AutoCreateSqlTable { get; set; }

    public MsSQLConfiguration()
    {
        ConnectionString = string.Empty;
        TableName = string.Empty;
    }

    public MsSQLConfiguration(string connectionString,
        string tableName, bool autoCreateSqlTable)
    {
        ConnectionString = connectionString;
        TableName = tableName;
        AutoCreateSqlTable = autoCreateSqlTable;
    }


}
