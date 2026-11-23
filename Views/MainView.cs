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
        // Nhấn phím trên ô nhập biểu thức
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

        // Các nút số
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

        // Dấu chấm thập phân và Dấu phẩy ngăn cách tham số
        btnDot.Click += (s, e) => InsertAtCursor(".");
        btnComma.Click += (s, e) => InsertAtCursor(", ");

        // Dấu ngoặc
        btnOpenParen.Click += (s, e) => InsertAtCursor("(");
        btnCloseParen.Click += (s, e) => InsertAtCursor(")");

        // Cột toán tử cơ bản
        btnDivide.Click += (s, e) => InsertAtCursor(" / ");
        btnMultiply.Click += (s, e) => InsertAtCursor(" * ");
        btnMinus.Click += (s, e) => InsertAtCursor(" - ");
        btnPlus.Click += (s, e) => InsertAtCursor(" + ");

        // Hàm toán học Smart Auto-Wrap
        btnPower.Click += (s, e) => HandleSmartWrap("pow");
        btnRoot.Click += (s, e) => HandleSmartWrap("root");

        // Điều hướng con trỏ ← (Tự động bỏ qua khoảng trắng liên tiếp)
        btnLeft.Click += (s, e) => MoveCaretLeft();

        // Điều hướng con trỏ → (Tự động bỏ qua khoảng trắng liên tiếp)
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
            else if (leftSub.EndsWith(", "))
            {
                deleteCount = 2;
            }

            int removeIndex = pos - deleteCount;
            txtCalcExpression.Text = text.Remove(removeIndex, deleteCount);
            txtCalcExpression.SelectionStart = removeIndex;
            txtCalcExpression.SelectionLength = 0;
            txtCalcExpression.ScrollToCaret();
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
        txtCalcExpression.ScrollToCaret();
        txtCalcExpression.Focus();
        lblCalcResult.Text = "";
    }

    private void HandleSmartWrap(string funcName)
    {
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;

        if (pos < 0 || pos > text.Length)
        {
            pos = text.Length;
        }

        // Bỏ qua khoảng trắng trước con trỏ (nếu có)
        int scan = pos;
        while (scan > 0 && char.IsWhiteSpace(text[scan - 1]))
        {
            scan--;
        }

        int targetStart = -1;
        int targetEnd = scan;

        if (scan > 0)
        {
            char lastChar = text[scan - 1];

            // Trường hợp 1: Kết thúc bằng dấu ngoặc đóng ')' -> tìm cặp ngoặc '(' tương ứng
            if (lastChar == ')')
            {
                int parenDepth = 1;
                int i = scan - 2;
                while (i >= 0 && parenDepth > 0)
                {
                    if (text[i] == ')') parenDepth++;
                    else if (text[i] == '(') parenDepth--;
                    i--;
                }

                if (parenDepth == 0)
                {
                    targetStart = i + 1;

                    // Nếu trước dấu ngoặc '(' là tên hàm (pow/root), gom cả tên hàm vào
                    int checkFunc = targetStart;
                    while (checkFunc > 0 && char.IsLetter(text[checkFunc - 1]))
                    {
                        checkFunc--;
                    }
                    if (checkFunc < targetStart)
                    {
                        string prefix = text.Substring(checkFunc, targetStart - checkFunc);
                        if (prefix.Equals("pow", StringComparison.OrdinalIgnoreCase) || 
                            prefix.Equals("root", StringComparison.OrdinalIgnoreCase))
                        {
                            targetStart = checkFunc;
                        }
                    }
                }
            }
            // Trường hợp 2: Kết thúc bằng một số (chữ số hoặc dấu chấm thập phân)
            else if (char.IsDigit(lastChar) || lastChar == '.')
            {
                int i = scan - 1;
                while (i >= 0 && (char.IsDigit(text[i]) || text[i] == '.'))
                {
                    i--;
                }
                targetStart = i + 1;
            }
        }

        // Thực hiện bọc hoặc chèn khuôn mẫu
        if (targetStart >= 0 && targetStart < targetEnd)
        {
            // Có toán hạng x phía trước -> viết thành funcName(x, 
            string operand = text.Substring(targetStart, targetEnd - targetStart);
            string replacement = $"{funcName}({operand}, ";

            string newText = text.Remove(targetStart, pos - targetStart).Insert(targetStart, replacement);
            txtCalcExpression.Text = newText;

            // Đặt con trỏ ngay sau dấu phẩy ", "
            int newPos = targetStart + replacement.Length;
            txtCalcExpression.SelectionStart = newPos;
            txtCalcExpression.SelectionLength = 0;
        }
        else
        {
            // Không có toán hạng phía trước -> chỉ chèn funcName(
            InsertAtCursor($"{funcName}(");
        }

        txtCalcExpression.ScrollToCaret();
        txtCalcExpression.Focus();
        lblCalcResult.Text = "";
    }

    private void MoveCaretLeft()
    {
        txtCalcExpression.Focus();
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;
        if (pos <= 0 || text.Length == 0) return;

        // Lùi qua ký tự hiện tại
        pos--;
        // Nếu tiếp tục gặp khoảng trắng bên trái, lùi qua hết các khoảng trắng
        while (pos > 0 && char.IsWhiteSpace(text[pos - 1]))
        {
            pos--;
        }

        txtCalcExpression.SelectionStart = pos;
        txtCalcExpression.SelectionLength = 0;
        txtCalcExpression.ScrollToCaret();
    }

    private void MoveCaretRight()
    {
        txtCalcExpression.Focus();
        string text = txtCalcExpression.Text ?? "";
        int pos = txtCalcExpression.SelectionStart;
        if (pos >= text.Length) return;

        // Tiến qua ký tự hiện tại
        pos++;
        // Nếu tiếp tục gặp khoảng trắng bên phải, tiến qua hết các khoảng trắng
        while (pos < text.Length && char.IsWhiteSpace(text[pos]))
        {
            pos++;
        }

        txtCalcExpression.SelectionStart = pos;
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
}
