namespace Config.DataBase.Script;

public static class DataBaseScript
{
    public static string CreateTables()
    {
        string commandCREATE = @"
                CREATE TABLE IF NOT EXISTS Clientes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    CPF TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    Telefone TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Genero TEXT NOT NULL,
                    RendaMensal REAL NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Cartoes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClienteId INTEGER NOT NULL,
                    NumeroCartao TEXT NOT NULL,
                    Titular TEXT NOT NULL,
                    Validade DATE NOT NULL,
                    CVV INTEGER NOT NULL,
                    Limite REAL NOT NULL,
                    Step TEXT NOT NULL,
                    isActive INTEGER NOT NULL,
                    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
                );

                CREATE TABLE IF NOT EXISTS Contas(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumeroAgencia TEXT NOT NULL,
                    NumeroConta TEXT NOT NULL,
                    Saldo REAL NOT NULL,
                    CartaoId INTEGER NOT NULL,
                    ClienteId INTEGER NOT NULL,
                    FOREIGN KEY (CartaoId) REFERENCES Cartoes(Id),
                    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
                );

                CREATE TABLE IF NOT EXISTS Faturas(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Mes TEXT NOT NULL,
                    Valor REAL NOT NULL,
                    isClosed INTEGER NOT NULL,
                    DataFechamento DATE NOT NULL,
                    isPaid INTEGER NOT NULL,
                    CartaoId INTEGER NOT NULL,
                    FOREIGN KEY (CartaoId) REFERENCES Cartoes(Id)
                );

                CREATE TABLE IF NOT EXISTS Transacoes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Valor REAL NOT NULL,
                    DataCompra DATE NOT NULL,
                    Remetente TEXT NOT NULL,  
                    isInstallments INTEGER NOT NULL,
                    ValorParcela REAL,
                    QuantidadeParcelasReferente INTEGER,
                    QuantidadeParcelas INTEGER
                );";

        return commandCREATE;
    }
}