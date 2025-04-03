namespace Config.DataBase.Script;

public static class DataBaseScript
{
    public static string CreateTables()
    {
        string commandCREATE = @"
                CREATE TABLE IF NOT EXISTS Usuarios(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    CPF TEXT NOT NULL,
                    RendaMensal REAL NOT NULL,
                    GastoMensal REAL NOT NULL,
                    isStable INTEGER NOT NULL CHECK (isStable IN (0, 1)),
                    Email TEXT NOT NULL,
                    Password TEXT NOT NULL
                );";

        return commandCREATE;
    }
}