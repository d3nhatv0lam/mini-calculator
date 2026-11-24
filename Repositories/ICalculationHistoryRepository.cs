using MiniCalculator.Models;

namespace MiniCalculator.Repositories;

public interface ICalculationHistoryRepository
{
    void Add(string expression, string result);
    IReadOnlyList<CalculationHistory> GetAll(int limit = 50);
    void ClearAll();
}
