namespace MiniCalculator.Models;

public interface ICalculationHistoryRepository
{
    void Add(string expression, string result);
    IReadOnlyList<CalculationHistory> GetAll(int limit = 50);
    void ClearAll();
}
