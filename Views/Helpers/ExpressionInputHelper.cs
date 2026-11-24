namespace MiniCalculator.Views.Helpers;


public static class ExpressionInputHelper
{
    /// <summary>
    /// Tính toán chuỗi mới và vị trí con trỏ mới khi người dùng bấm nút hàm (pow, root...).
    /// nhận diện toán hạng x trước con trỏ để bao bọc thành funcName(x, .
    /// </summary>
    public static (string newText, int newPos) ComputeSmartWrap(string text, int pos, string funcName)
    {
        text ??= "";
        pos = Math.Clamp(pos, 0, text.Length);
        
        int end = pos;
        while (end > 0 && char.IsWhiteSpace(text[end - 1]))
        {
            end--;
        }

        int start = FindOperandStart(text, end);
        
        string replacement = start >= 0
            ? $"{funcName}({text[start..end]}, "
            : $"{funcName}(";

        int replaceFrom = start >= 0 ? start : pos;
        string newText = string.Concat(text.AsSpan(0, replaceFrom), replacement, text.AsSpan(pos));
        int newPos = replaceFrom + replacement.Length;

        return (newText, newPos);
    }

    /// <summary>
    /// đi ngược từ vị trí end để tìm vị trí bắt đầu của toán hạng (số hoặc cặp ngoặc/hàm).
    /// Trả về -1 nếu không tìm thấy toán hạng hợp lệ.
    /// </summary>
    private static int FindOperandStart(string text, int end)
    {
        if (end <= 0) return -1;

        char lastChar = text[end - 1];

        // 1. Kết thúc bằng ')' thì tìm '(' tương ứng và gom cả tên hàm phía trước (nếu có)
        if (lastChar == ')')
        {
            int depth = 1;
            int i = end - 2;
            while (i >= 0 && depth > 0)
            {
                if (text[i] == ')') depth++;
                else if (text[i] == '(') depth--;
                i--;
            }

            if (depth != 0) return -1; 

            int openParen = i + 1;
            int funcStart = openParen;
            // Gom toàn bộ tên hàm đứng liền trước '(' (ví dụ: pow, root...)
            while (funcStart > 0 && char.IsLetter(text[funcStart - 1]))
            {
                funcStart--;
            }
            return funcStart;
        }

        // Kết thúc bằng số (hỗ trợ số nguyên và số thập phân)
        if (char.IsDigit(lastChar) || lastChar == '.')
        {
            int i = end - 1;
            bool hasDigit = false;
            while (i >= 0 && (char.IsDigit(text[i]) || text[i] == '.'))
            {
                if (char.IsDigit(text[i])) hasDigit = true;
                i--;
            }
            return hasDigit ? i + 1 : -1;
        }

        return -1;
    }

    /// <summary>
    /// số lượng ký tự cần xóa khi nhấn Backspace bên trái con trỏ.
    /// root( (5 ký tự), pow( (4 ký tự), các toán tử kèm khoảng trắng ' + ' (3 ký tự), ', ' (2 ký tự).
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
