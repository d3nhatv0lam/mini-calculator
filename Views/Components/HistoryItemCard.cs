using System;
using System.Drawing;
using System.Windows.Forms;
using MiniCalculator.Models;

namespace MiniCalculator.Views.Components;

/// <summary>
/// Thẻ hiển thị một bản ghi phép tính trong Khung cuộn Lịch sử.
/// Kế thừa từ AntdUI.Panel hỗ trợ bo tròn góc (Radius = 6), viền mờ tinh tế và tự động xử lý hover/click.
/// </summary>
public class HistoryItemCard : AntdUI.Panel
{
    private static readonly Color NormalBg = Color.FromArgb(250, 251, 254);
    private static readonly Color HoverBg = Color.FromArgb(238, 244, 255);
    private static readonly Color BorderCl = Color.FromArgb(226, 232, 240);

    public CalculationHistory HistoryItem { get; }

    public event EventHandler<CalculationHistory>? ItemSelected;

    public HistoryItemCard(CalculationHistory item)
    {
        HistoryItem = item ?? throw new ArgumentNullException(nameof(item));

        // Cấu hình thẻ AntdUI.Panel
        Dock = DockStyle.Top;
        Height = 72;
        Margin = new Padding(0, 0, 0, 6);
        Padding = new Padding(10, 8, 10, 6);
        Radius = 6;
        BorderWidth = 1f;
        BorderColor = BorderCl;
        Back = NormalBg;
        Cursor = Cursors.Hand;

        // Label biểu thức (nằm trên)
        var lblExpr = new Label
        {
            Text = item.Expression,
            Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 41, 59),
            Dock = DockStyle.Top,
            Height = 26,
            AutoEllipsis = true,
            Cursor = Cursors.Hand,
            BackColor = Color.Transparent
        };

        // Panel chứa kết quả và thời gian (nằm dưới)
        var pnlBottom = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent,
            Cursor = Cursors.Hand
        };

        var lblRes = new Label
        {
            Text = "= " + item.Result,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
            ForeColor = Color.FromArgb(40, 140, 30),
            Dock = DockStyle.Left,
            AutoSize = true,
            Cursor = Cursors.Hand,
            BackColor = Color.Transparent
        };

        var lblTime = new Label
        {
            Text = item.CreatedAt.ToString("HH:mm:ss"),
            Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
            ForeColor = Color.FromArgb(148, 163, 184),
            Dock = DockStyle.Right,
            AutoSize = true,
            Cursor = Cursors.Hand,
            BackColor = Color.Transparent
        };

        pnlBottom.Controls.Add(lblRes);
        pnlBottom.Controls.Add(lblTime);

        Controls.Add(pnlBottom);
        Controls.Add(lblExpr);

        // Hiệu ứng hover
        void SetHover(bool hover)
        {
            Back = hover ? HoverBg : NormalBg;
            Invalidate();
        }

        MouseEnter += (s, e) => SetHover(true);
        MouseLeave += (s, e) => SetHover(false);
        lblExpr.MouseEnter += (s, e) => SetHover(true);
        lblExpr.MouseLeave += (s, e) => SetHover(false);
        pnlBottom.MouseEnter += (s, e) => SetHover(true);
        pnlBottom.MouseLeave += (s, e) => SetHover(false);
        lblRes.MouseEnter += (s, e) => SetHover(true);
        lblRes.MouseLeave += (s, e) => SetHover(false);
        lblTime.MouseEnter += (s, e) => SetHover(true);
        lblTime.MouseLeave += (s, e) => SetHover(false);

        // Lan truyền sự kiện Click khi click vào thẻ hoặc các control con
        void TriggerSelect()
        {
            ItemSelected?.Invoke(this, HistoryItem);
        }

        Click += (s, e) => TriggerSelect();
        lblExpr.Click += (s, e) => TriggerSelect();
        pnlBottom.Click += (s, e) => TriggerSelect();
        lblRes.Click += (s, e) => TriggerSelect();
        lblTime.Click += (s, e) => TriggerSelect();
    }
}
