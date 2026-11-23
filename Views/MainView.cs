using System.Drawing;

namespace MiniCalculator.Views;

public partial class MainView : Form, IMainView
{
    public event EventHandler<ExpressionCalculateEventArgs>? CalculateRequested;

    public MainView()
    {
        InitializeComponent();
        RegisterEventHandlers();
    }

    private void RegisterEventHandlers()
    {
        // Nhấn Enter trên ô nhập biểu thức để tính
        txtCalcExpression.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TriggerCalculation(txtCalcExpression.Text?.Trim() ?? "");
            }
        };

        // Các nút số và dấu chấm
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

        // Dấu ngoặc
        btnOpenParen.Click += (s, e) => InsertAtCursor("(");
        btnCloseParen.Click += (s, e) => InsertAtCursor(")");

        // Toán tử cơ bản
        btnPlus.Click += (s, e) => InsertAtCursor(" + ");
        btnMinus.Click += (s, e) => InsertAtCursor(" - ");
        btnMultiply.Click += (s, e) => InsertAtCursor(" * ");
        btnDivide.Click += (s, e) => InsertAtCursor(" / ");

        // Hàm toán học (Chuẩn bị sẵn cho Giai đoạn 2)
        btnPower.Click += (s, e) => InsertAtCursor("pow(");
        btnRoot.Click += (s, e) => InsertAtCursor("root(");

        // Điều hướng con trỏ ←
        btnLeft.Click += (s, e) =>
        {
            int pos = txtCalcExpression.SelectionStart;
            if (pos > 0)
            {
                txtCalcExpression.SelectionStart = pos - 1;
                txtCalcExpression.SelectionLength = 0;
            }
            txtCalcExpression.Focus();
        };

        // Điều hướng con trỏ →
        btnRight.Click += (s, e) =>
        {
            int pos = txtCalcExpression.SelectionStart;
            string text = txtCalcExpression.Text ?? "";
            if (pos < text.Length)
            {
                txtCalcExpression.SelectionStart = pos + 1;
                txtCalcExpression.SelectionLength = 0;
            }
            txtCalcExpression.Focus();
        };

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
                txtCalcExpression.Focus();
                lblCalcResult.Text = "";
                return;
            }

            int deleteCount = 1;
            string leftSub = text.Substring(0, pos);
            if (leftSub.EndsWith("root("))
            {
                deleteCount = 5;
            }
            else if (leftSub.EndsWith("pow("))
            {
                deleteCount = 4;
            }
            else if (leftSub.EndsWith(" + ") || leftSub.EndsWith(" - ") || 
                     leftSub.EndsWith(" * ") || leftSub.EndsWith(" / "))
            {
                deleteCount = 3;
            }

            int removeIndex = pos - deleteCount;
            txtCalcExpression.Text = text.Remove(removeIndex, deleteCount);
            txtCalcExpression.SelectionStart = removeIndex;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.Focus();
            lblCalcResult.Text = "";
        };

        // Xóa tiến bên phải con trỏ Del (Token-aware Forward Delete)
        btnDeleteForward.Click += (s, e) =>
        {
            int pos = txtCalcExpression.SelectionStart;
            string text = txtCalcExpression.Text ?? "";
            if (pos >= text.Length) return;

            int selLen = txtCalcExpression.SelectionLength;
            if (selLen > 0 && pos + selLen <= text.Length)
            {
                txtCalcExpression.Text = text.Remove(pos, selLen);
                txtCalcExpression.SelectionStart = pos;
                txtCalcExpression.SelectionLength = 0;
                txtCalcExpression.Focus();
                lblCalcResult.Text = "";
                return;
            }

            int deleteCount = 1;
            string rightSub = text.Substring(pos);
            if (rightSub.StartsWith("root("))
            {
                deleteCount = 5;
            }
            else if (rightSub.StartsWith("pow("))
            {
                deleteCount = 4;
            }
            else if (rightSub.StartsWith(" + ") || rightSub.StartsWith(" - ") || 
                     rightSub.StartsWith(" * ") || rightSub.StartsWith(" / "))
            {
                deleteCount = 3;
            }

            txtCalcExpression.Text = text.Remove(pos, deleteCount);
            txtCalcExpression.SelectionStart = pos;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.Focus();
            lblCalcResult.Text = "";
        };

        // Xóa tất cả C
        btnClear.Click += (s, e) =>
        {
            txtCalcExpression.Text = "";
            lblCalcResult.Text = "";
            txtCalcExpression.SelectionStart = 0;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.Focus();
        };

        // Nút tính toán =
        btnEqual.Click += (s, e) =>
        {
            TriggerCalculation(txtCalcExpression.Text?.Trim() ?? "");
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
        txtCalcExpression.Focus();
        lblCalcResult.Text = "";
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
}
