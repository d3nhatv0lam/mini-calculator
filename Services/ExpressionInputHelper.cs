using System;

namespace MiniCalculator.Services;


public static class ExpressionInputHelper
{
    /// <summary>
    /// Tính toán chuỗi mới và vị trí con trỏ mới khi người dùng bấm nút hàm (pow hoặc root).
    /// Tự động nhận diện toán hạng x trước con trỏ để bao bọc thành funcName(x, .
    /// </summary>
    public static (string newText, int newPos) ComputeSmartWrap(string text, int pos, string funcName)
    {
        if (text == null) text = "";
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
            int newPos = targetStart + replacement.Length;
            return (newText, newPos);
        }
        else
        {
            // Không có toán hạng phía trước -> chỉ chèn funcName(
            string insertion = $"{funcName}(";
            string newText = text.Insert(pos, insertion);
            int newPos = pos + insertion.Length;
            return (newText, newPos);
        }
    }

    /// <summary>
    /// Xác định số lượng ký tự cần xóa khi nhấn Backspace bên trái con trỏ.
    /// Nhận diện token: root( (5 ký tự), pow( (4 ký tự), các toán tử kèm khoảng trắng ' + ' (3 ký tự), ', ' (2 ký tự).
    /// </summary>
    public static int ComputeDeleteCount(string text, int pos)
    {
        if (string.IsNullOrEmpty(text) || pos <= 0 || pos > text.Length) return 0;

        string leftSub = text.Substring(0, pos);
        if (leftSub.EndsWith("root("))
        {
            return 5;
        }
        if (leftSub.EndsWith("pow("))
        {
            return 4;
        }
        if (leftSub.EndsWith(" + ") || leftSub.EndsWith(" - ") || 
            leftSub.EndsWith(" * ") || leftSub.EndsWith(" / "))
        {
            return 3;
        }
        if (leftSub.EndsWith(", "))
        {
            return 2;
        }

        return 1;
    }

    /// <summary>
    /// Tính toán vị trí con trỏ mới khi lùi sang trái, tự động bỏ qua toàn bộ các khoảng trắng liền kề.
    /// </summary>
    public static int GetPreviousCaretPosition(string text, int pos)
    {
        if (string.IsNullOrEmpty(text) || pos <= 0) return 0;
        if (pos > text.Length) pos = text.Length;

        pos--;
        while (pos > 0 && char.IsWhiteSpace(text[pos - 1]))
        {
            pos--;
        }

        return pos;
    }

    /// <summary>
    /// Tính toán vị trí con trỏ mới khi tiến sang phải, tự động bỏ qua toàn bộ các khoảng trắng liền kề.
    /// </summary>
    public static int GetNextCaretPosition(string text, int pos)
    {
        if (string.IsNullOrEmpty(text) || pos >= text.Length) return text?.Length ?? 0;
        if (pos < 0) pos = 0;

        pos++;
        while (pos < text.Length && char.IsWhiteSpace(text[pos]))
        {
            pos++;
        }

        return pos;
    }
}
