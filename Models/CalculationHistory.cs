namespace MiniCalculator.Models;

public record CalculationHistory(long Id, string Expression, string Result, DateTime CreatedAt);
