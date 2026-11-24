using System.Diagnostics;
using System.Globalization;
using MiniCalculator.Models;
using MiniCalculator.Repositories;
using MiniCalculator.Views;

namespace MiniCalculator.Presenters;

public class MainViewPresenter : IDisposable
{
    private readonly IMainView _view;
    private readonly ICalculationHistoryRepository _historyRepo;


    public MainViewPresenter(IMainView view, ICalculationHistoryRepository historyRepo)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _historyRepo = historyRepo ?? throw new ArgumentNullException(nameof(historyRepo));

        _view.CalculateRequested += OnCalculateRequested;
        _view.ClearHistoryRequested += OnClearHistoryRequested;
        _view.HistoryItemSelected += OnHistoryItemSelected;

        LoadHistory();
    }

    private void LoadHistory()
    {
        try
        {
            var history = _historyRepo.GetAll(50);
            _view.DisplayHistory(history);
        }
        catch
        {
            // Tránh crash nếu có sự cố đọc DB
        }
    }

    private void OnHistoryItemSelected(object? sender, CalculationHistory item)
    {
        if (item == null) return;
        _view.SetExpression(item.Expression);
        _view.ShowCalculationSuccess(item.Result);
    }

    private void OnClearHistoryRequested(object? sender, EventArgs e)
    {
        try
        {
            _historyRepo.ClearAll();
            LoadHistory();
        }
        catch
        {
            // Tránh crash nếu có sự cố xóa DB
        }
    }

    private void OnCalculateRequested(object? sender, ExpressionCalculateEventArgs e)
    {
        var expr = e.Expression;

        if (string.IsNullOrWhiteSpace(expr))
        {
            _view.ShowCalculationError("Vui lòng nhập biểu thức số học!", null);
            return;
        }

        try
        {
            var result = ExpressionCalculator.Calculate(expr);
            var formattedResult = result.ToString("G15", CultureInfo.InvariantCulture);

            _view.ShowCalculationSuccess(formattedResult);
            
            try
            {
                _historyRepo.Add(expr, formattedResult);
                LoadHistory();
            }
            catch
            {
               // ignore
            }
        }
        catch (DivideByZeroException ex)
        {
            _view.ShowCalculationError(string.IsNullOrWhiteSpace(ex.Message) ? "Lỗi toán học: Không thể chia cho 0!" : ex.Message, null);
        }
        catch (ExpressionParseException ex)
        {
            if (ex.ExpressionMessage.StartsWith("Lỗi toán học", StringComparison.OrdinalIgnoreCase))
            {
                _view.ShowCalculationError(ex.ExpressionMessage, ex.Position);
            }
            else
            {
                var nonSpacePos = CountNonWhitespaceCharacters(expr, ex.Position);
                var locationText = nonSpacePos > 0 ? $"tại ký tự thứ {nonSpacePos}: " : "";

                _view.ShowCalculationError($"Lỗi cú pháp {locationText}{ex.ExpressionMessage}", ex.Position);
            }
        }
        catch (Exception)
        {
            _view.ShowCalculationError("Biểu thức không hợp lệ. Vui lòng kiểm tra lại!", null);
        }
    }

    private static int CountNonWhitespaceCharacters(string text, int upToIndex)
    {
        int count = 0;
        for (int i = 0; i <= upToIndex && i < text.Length; i++)
        {
            if (!char.IsWhiteSpace(text[i]))
            {
                count++;
            }
        }
        return count;
    }

    public void Dispose()
    {
        _view.CalculateRequested -= OnCalculateRequested;
        _view.ClearHistoryRequested -= OnClearHistoryRequested;
        _view.HistoryItemSelected -= OnHistoryItemSelected;
    }
}
