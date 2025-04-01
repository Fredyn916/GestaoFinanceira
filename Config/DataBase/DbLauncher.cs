using Config.DataBase.Script;
using Dapper;
using System.Data.SQLite;

namespace Config.DataBase;

public static class DbLauncher
{
    public static void Initialize()
    {
        using var connection = new SQLiteConnection("Data Source=GestaoFinanceira.db");

        connection.Execute(DataBaseScript.CreateTables());
    }
}