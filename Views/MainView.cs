using System;
using System.Drawing;
using System.Windows.Forms;
using MiniCalculator.Models;
using MiniCalculator.Services;
using MiniCalculator.Views.Components;

namespace MiniCalculator.Views;

public partial class MainView : Form, IMainView
{
    public event EventHandler<ExpressionCalculateEventArgs>? CalculateRequested;
    public event EventHandler? ClearHistoryRequested;
    public event EventHandler<CalculationHistory>? HistoryItemSelected;

    public MainView()
    {
        InitializeComponent();
        RegisterEventHandlers();
    }

    private void RegisterEventHandlers()
    {
        txtCalcExpression.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TriggerCalculation(txtCalcExpression.Text?.Trim() ?? "");
            }
            else if (e.KeyCode == Keys.Left)
            {
                e.SuppressKeyPress = true;
                MoveCaretLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = true;
                MoveCaretRight();
            }
        };

        btn0.Click += (s, e) => InsertAtCursor("0");
        btn1.Click += (s, e) => InsertAtCursor("1");
        btn2.Click += (s, e) => InsertAtCursor("2");
        btn3.Click += (s, e) => InsertAtCursor("3");
        btn4.Click += (s, e) => InsertAtCursor("4");
        btn5.Click += (s, e) => InsertAtCursor("5");
        btn6.Click += (s, e) => InsertAtCursor("6");
        btn7.Click += (s, e) => InsertAtCursor("7");
        btn8.Click += (s, e) => InsertAtCursor("8");
        btn9.Click += (s, e) => InsertAtCursor("9");

        btnDot.Click += (s, e) => InsertAtCursor(".");
        btnComma.Click += (s, e) => InsertAtCursor(", ");

        btnOpenParen.Click += (s, e) => InsertAtCursor("(");
        btnCloseParen.Click += (s, e) => InsertAtCursor(")");

        btnDivide.Click += (s, e) => InsertAtCursor(" / ");
        btnMultiply.Click += (s, e) => InsertAtCursor(" * ");
        btnMinus.Click += (s, e) => InsertAtCursor(" - ");
        btnPlus.Click += (s, e) => InsertAtCursor(" + ");

        btnPower.Click += (s, e) => HandleSmartWrap("pow");
        btnRoot.Click += (s, e) => HandleSmartWrap("root");

        btnLeft.Click += (s, e) => MoveCaretLeft();
        btnRight.Click += (s, e) => MoveCaretRight();

        // Xóa lùi bên trái con trỏ ⌫ (Token-aware Backspace)
        btnBackspace.Click += (s, e) =>
        {
            int pos = txtCalcExpression.SelectionStart;
            string text = txtCalcExpression.Text ?? "";
            if (pos <= 0 || text.Length == 0) return;

            int selLen = txtCalcExpression.SelectionLength;
            if (selLen > 0 && pos + selLen <= text.Length)
            {
                txtCalcExpression.Text = text.Remove(pos, selLen);
                txtCalcExpression.SelectionStart = pos;
                txtCalcExpression.SelectionLength = 0;
                txtCalcExpression.ScrollToCaret();
                txtCalcExpression.Focus();
                lblCalcResult.Text = "";
                return;
            }

            int deleteCount = ExpressionInputHelper.ComputeDeleteCount(text, pos);
            int removeIndex = pos - deleteCount;
            txtCalcExpression.Text = text.Remove(removeIndex, deleteCount);
            txtCalcExpression.SelectionStart = removeIndex;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.ScrollToCaret();
            txtCalcExpression.Focus();
            lblCalcResult.Text = "";
        };

        btnClear.Click += (s, e) =>
        {
            txtCalcExpression.Text = "";
            lblCalcResult.Text = "";
            txtCalcExpression.SelectionStart = 0;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.Focus();
        };

        btnEqual.Click += (s, e) =>
        {
            TriggerCalculation(txtCalcExpression.Text?.Trim() ?? "");
        };

        btnClearHistory.Click += (s, e) =>
        {
            ClearHistoryRequested?.Invoke(this, EventArgs.Empty);
        };
    }

    private void InsertAtCursor(string text)
    {
        string current = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;

        if (pos < 0 || pos > current.Length)
        {
            pos = current.Length;
        }

        int selLen = txtCalcExpression.SelectionLength;
        string newText;
        if (selLen > 0 && pos + selLen <= current.Length)
        {
            newText = current.Remove(pos, selLen).Insert(pos, text);
        }
        else
        {
            newText = current.Insert(pos, text);
        }

        txtCalcExpression.Text = newText;
        txtCalcExpression.SelectionStart = pos + text.Length;
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
        txtCalcExpression.Focus();
        lblCalcResult.Text = "";
    }

    /// <summary>
    /// Chuyển tiếp tới ExpressionInputHelper để bảo toàn tương thích ngược cho unit test.
    /// </summary>
    public static (string newText, int newPos) ComputeSmartWrap(string text, int pos, string funcName)
    {
        return ExpressionInputHelper.ComputeSmartWrap(text, pos, funcName);
    }

    private void HandleSmartWrap(string funcName)
    {
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;

        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap(text, pos, funcName);
        txtCalcExpression.Text = newText;
        txtCalcExpression.SelectionStart = newPos;
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
        txtCalcExpression.Focus();
        lblCalcResult.Text = "";
    }

    private void MoveCaretLeft()
    {
        txtCalcExpression.Focus();
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;
        txtCalcExpression.SelectionStart = ExpressionInputHelper.GetPreviousCaretPosition(text, pos);
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
    }

    private void MoveCaretRight()
    {
        txtCalcExpression.Focus();
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;
        txtCalcExpression.SelectionStart = ExpressionInputHelper.GetNextCaretPosition(text, pos);
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
    }

    private void TriggerCalculation(string expression)
    {
        CalculateRequested?.Invoke(this, new ExpressionCalculateEventArgs(expression));
    }

    public void ShowCalculationSuccess(string formattedResult)
    {
        lblCalcResult.ForeColor = Color.FromArgb(56, 158, 13);
        lblCalcResult.Text = "= " + formattedResult;
    }

    public void ShowCalculationError(string expressionMessage, int? errorPosition)
    {
        lblCalcResult.ForeColor = Color.FromArgb(207, 19, 34);
        lblCalcResult.Text = expressionMessage;

        if (errorPosition.HasValue && errorPosition.Value >= 0 && errorPosition.Value < (txtCalcExpression.Text?.Length ?? 0))
        {
            txtCalcExpression.SelectionStart = errorPosition.Value;
            txtCalcExpression.SelectionLength = 1;
            txtCalcExpression.Focus();
        }
    }

    public void SetExpression(string expression)
    {
        txtCalcExpression.Text = expression;
        txtCalcExpression.SelectionStart = expression?.Length ?? 0;
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
        txtCalcExpression.Focus();
    }

    public void DisplayHistory(IReadOnlyList<CalculationHistory> history)
    {
        pnlHistoryList.SuspendLayout();
        pnlHistoryList.Controls.Clear();

        if (history == null || history.Count == 0)
        {
            pnlHistoryList.Controls.Add(lblEmptyHistory);
            lblEmptyHistory.Visible = true;
            pnlHistoryList.ResumeLayout();
            return;
        }

        lblEmptyHistory.Visible = false;

        // Thêm từ cũ nhất đến mới nhất, phép tính mới nhất (history[0]) được thêm sau cùng
        // với DockStyle.Top sẽ luôn nằm ở hàng đầu tiên trên đỉnh (Top = 0).
        for (int i = history.Count - 1; i >= 0; i--)
        {
            var item = history[i];
            var card = new HistoryItemCard(item);
            card.ItemSelected += (s, selectedItem) => HistoryItemSelected?.Invoke(this, selectedItem);
            pnlHistoryList.Controls.Add(card);
        }

        pnlHistoryList.ResumeLayout();
    }
}
