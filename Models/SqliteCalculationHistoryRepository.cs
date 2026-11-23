using System.Globalization;
using Microsoft.Data.Sqlite;

namespace MiniCalculator.Models;

public class SqliteCalculationHistoryRepository : ICalculationHistoryRepository
{
    private readonly string _connectionString;

    public SqliteCalculationHistoryRepository(string dbPath = "calculator_history.db")
    {
        _connectionString = $"Data Source={dbPath}";
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        const string createTableSql = @"
            CREATE TABLE IF NOT EXISTS Calculations (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Expression TEXT NOT NULL,
                Result TEXT NOT NULL,
                CreatedAt TEXT NOT NULL
            );";

        using var command = new SqliteCommand(createTableSql, connection);
        command.ExecuteNonQuery();
    }

    public void Add(string expression, string result)
    {
        if (string.IsNullOrWhiteSpace(expression)) return;

        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        const string insertSql = @"
            INSERT INTO Calculations (Expression, Result, CreatedAt)
            VALUES ($expr, $res, $date);";

        using var command = new SqliteCommand(insertSql, connection);
        command.Parameters.AddWithValue("$expr", expression.Trim());
        command.Parameters.AddWithValue("$res", result?.Trim() ?? "");
        command.Parameters.AddWithValue("$date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));

        command.ExecuteNonQuery();
    }

    public IReadOnlyList<CalculationHistory> GetAll(int limit = 50)
    {
        var list = new List<CalculationHistory>();

        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        const string selectSql = @"
            SELECT Id, Expression, Result, CreatedAt
            FROM Calculations
            ORDER BY Id DESC
            LIMIT $limit;";

        using var command = new SqliteCommand(selectSql, connection);
        command.Parameters.AddWithValue("$limit", limit > 0 ? limit : 50);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            long id = reader.GetInt64(0);
            string expr = reader.GetString(1);
            string res = reader.GetString(2);
            string dateStr = reader.GetString(3);

            if (!DateTime.TryParseExact(dateStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var createdAt))
            {
                createdAt = DateTime.Now;
            }

            list.Add(new CalculationHistory(id, expr, res, createdAt));
        }

        return list;
    }

    public void ClearAll()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        const string clearSql = "DELETE FROM Calculations;";
        using var command = new SqliteCommand(clearSql, connection);
        command.ExecuteNonQuery();
    }
}
