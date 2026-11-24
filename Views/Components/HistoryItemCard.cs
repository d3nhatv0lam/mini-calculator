using MiniCalculator.Models;

namespace MiniCalculator.Views.Components;

public partial class HistoryItemCard : UserControl
{
    private static readonly Color NormalBg = Color.FromArgb(250, 251, 254);
    private static readonly Color HoverBg = Color.FromArgb(238, 244, 255);

    public CalculationHistory? HistoryItem { get; private set; }

    public event EventHandler<CalculationHistory>? ItemSelected;

    public HistoryItemCard()
    {
        InitializeComponent();
        SetupEvents();
    }

    public HistoryItemCard(CalculationHistory item) : this()
    {
        SetData(item);
    }

    public void SetData(CalculationHistory item)
    {
        HistoryItem = item ?? throw new ArgumentNullException(nameof(item));
        lblExpr.Text = item.Expression;
        lblRes.Text = "= " + item.Result;
        lblTime.Text = item.CreatedAt.ToString("HH:mm:ss");
    }

    private void SetupEvents()
    {
        void SetHover(bool hover)
        {
            pnlCard.Back = hover ? HoverBg : NormalBg;
            pnlCard.Invalidate();
        }

        MouseEnter += (s, e) => SetHover(true);
        MouseLeave += (s, e) => SetHover(false);
        pnlCard.MouseEnter += (s, e) => SetHover(true);
        pnlCard.MouseLeave += (s, e) => SetHover(false);
        lblExpr.MouseEnter += (s, e) => SetHover(true);
        lblExpr.MouseLeave += (s, e) => SetHover(false);
        pnlBottom.MouseEnter += (s, e) => SetHover(true);
        pnlBottom.MouseLeave += (s, e) => SetHover(false);
        lblRes.MouseEnter += (s, e) => SetHover(true);
        lblRes.MouseLeave += (s, e) => SetHover(false);
        lblTime.MouseEnter += (s, e) => SetHover(true);
        lblTime.MouseLeave += (s, e) => SetHover(false);

        void TriggerSelect()
        {
            if (HistoryItem != null)
            {
                ItemSelected?.Invoke(this, HistoryItem);
            }
        }

        Click += (s, e) => TriggerSelect();
        pnlCard.Click += (s, e) => TriggerSelect();
        lblExpr.Click += (s, e) => TriggerSelect();
        pnlBottom.Click += (s, e) => TriggerSelect();
        lblRes.Click += (s, e) => TriggerSelect();
        lblTime.Click += (s, e) => TriggerSelect();
    }
}
