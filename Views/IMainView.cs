using MiniCalculator.Models;

namespace MiniCalculator.Views;

public class ExpressionCalculateEventArgs : EventArgs
{
    public string Expression { get; }

    public ExpressionCalculateEventArgs(string expression)
    {
        Expression = expression;
    }
}

public interface IMainView
{
    event EventHandler<ExpressionCalculateEventArgs>? CalculateRequested;
    event EventHandler? ClearHistoryRequested;
    event EventHandler<CalculationHistory>? HistoryItemSelected;

    void ShowCalculationSuccess(string formattedResult);
    void ShowCalculationError(string expressionMessage, int? errorPosition);
    void DisplayHistory(IReadOnlyList<CalculationHistory> history);
    void SetExpression(string expression);
}
