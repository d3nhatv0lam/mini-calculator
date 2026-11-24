using System;
using System.IO;
using MiniCalculator.Models;
using MiniCalculator.Repositories;
using Xunit;

namespace MiniCalculator.Tests;

public class SqliteHistoryTests : IDisposable
{
    private readonly string _testDbPath;
    private readonly SqliteCalculationHistoryRepository _repo;

    public SqliteHistoryTests()
    {
        _testDbPath = Path.Combine(Path.GetTempPath(), $"test_calc_{Guid.NewGuid():N}.db");
        _repo = new SqliteCalculationHistoryRepository(_testDbPath);
    }

    public void Dispose()
    {
        if (File.Exists(_testDbPath))
        {
            try { File.Delete(_testDbPath); } catch { }
        }
    }

    [Fact]
    public void InitializeDatabase_AutomaticallyCreatesTableAndFile()
    {
        Assert.True(File.Exists(_testDbPath));
        var initialList = _repo.GetAll();
        Assert.Empty(initialList);
    }

    [Fact]
    public void Add_And_GetAll_ReturnsDescendingOrder_NewestFirst()
    {
        _repo.Add("2 + 3", "5");
        _repo.Add("pow(2, 3)", "8");

        var list = _repo.GetAll();
        Assert.Equal(2, list.Count);
        Assert.Equal("pow(2, 3)", list[0].Expression);
        Assert.Equal("8", list[0].Result);
        Assert.Equal("2 + 3", list[1].Expression);
        Assert.Equal("5", list[1].Result);
    }

    [Fact]
    public void GetAll_WithLimit_RestrictsReturnedRowCount()
    {
        for (int i = 1; i <= 60; i++)
        {
            _repo.Add($"1 + {i}", $"{1 + i}");
        }

        var list = _repo.GetAll(50);
        Assert.Equal(50, list.Count);
        Assert.Equal("1 + 60", list[0].Expression);
        Assert.Equal("61", list[0].Result);
    }

    [Fact]
    public void SqlInjectionSafety_StoresSpecialCharactersVerbatim()
    {
        string maliciousExpr = "2 + 3'; DROP TABLE Calculations; --";
        string maliciousResult = "\"Special'Chars$#@!";

        _repo.Add(maliciousExpr, maliciousResult);

        var list = _repo.GetAll();
        Assert.Single(list);
        Assert.Equal(maliciousExpr, list[0].Expression);
        Assert.Equal(maliciousResult, list[0].Result);
    }

    [Fact]
    public void ClearAll_RemovesAllRecords()
    {
        _repo.Add("10 * 2", "20");
        _repo.Add("root(64, 2)", "8");
        Assert.Equal(2, _repo.GetAll().Count);

        _repo.ClearAll();

        var list = _repo.GetAll();
        Assert.Empty(list);
    }

    [Fact]
    public void DataPersistence_SurvivesAcrossRepositoryInstances()
    {
        _repo.Add("pow(5, 2)", "25");

        var repoInstance2 = new SqliteCalculationHistoryRepository(_testDbPath);
        var list = repoInstance2.GetAll();

        Assert.Single(list);
        Assert.Equal("pow(5, 2)", list[0].Expression);
        Assert.Equal("25", list[0].Result);
    }
}
