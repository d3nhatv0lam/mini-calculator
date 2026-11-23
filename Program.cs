using MiniCalculator.Models;
using MiniCalculator.Presenters;
using MiniCalculator.Views;

namespace MiniCalculator;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        var historyRepo = new SqliteCalculationHistoryRepository();
        MainView view = new MainView();
        MainViewPresenter viewPresenter = new MainViewPresenter(view, historyRepo);
        
        Application.Run(view);
        
        viewPresenter.Dispose();
    }
}
