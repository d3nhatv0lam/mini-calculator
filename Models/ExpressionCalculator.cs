using System.Globalization;

namespace MiniCalculator.Models;

public static class ExpressionCalculator
{
    public static double Calculate(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Biểu thức rỗng. Vui lòng nhập biểu thức.");
        }

        var parser = new Parser(expression);
        var result = parser.CheckExpression();
        parser.EnsureEndOfInput("Biểu thức");
        return result;
    }
    
    public static double CheckTerm(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Số hạng (Term) rỗng.");
        }

        var parser = new Parser(expression);
        double result = parser.CheckTerm();
        parser.EnsureEndOfInput("Số hạng");
        return result;
    }

    public static double CheckFactor(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Thừa số (Factor) rỗng.");
        }

        var parser = new Parser(expression);
        double result = parser.CheckFactor();
        parser.EnsureEndOfInput("Thừa số");
        return result;
    }
    
    // E -> T E'
    // E' -> + T E' | - T E' | ε
    // T  -> F T'
    // T' -> * F T' | / F T' | ε
    // F  -> (E) | id | -F | +F | pow(E, E) | root(E, E)
    private sealed class Parser
    {
        private readonly string _input;
        private int _currentPos;
        
        public Parser(string input)
        {
            _input = input;
            _currentPos = 0;
        }

        private void SkipWhitespace()
        {
            while (_currentPos < _input.Length && char.IsWhiteSpace(_input[_currentPos]))
            {
                _currentPos++;
            }
        }
        
        public void EnsureEndOfInput(string? context = null)
        {
            SkipWhitespace();
            if (_currentPos < _input.Length)
            {
                var leftover = _input[_currentPos];
                if (leftover == ')')
                {
                    throw new ExpressionParseException(_currentPos, "Thừa dấu ngoặc đóng ')' không có dấu mở tương ứng.");
                }
                
                var msg = context != null 
                    ? $"Ký tự dư thừa sau {context}: '{leftover}'."
                    : $"Ký tự dư thừa không hợp lệ '{leftover}'.";
                
                throw new ExpressionParseException(_currentPos, msg);
            }
        }


        public double CheckExpression()
        {
            double result = CheckTerm();

            while (_currentPos < _input.Length)
            {
                SkipWhitespace();
                if (_currentPos >= _input.Length)
                {
                    break;
                }

                char op = _input[_currentPos];
                if (op != '+' && op != '-')
                {
                    break;
                }

                int opPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length)
                {
                    throw new ExpressionParseException(opPos, $"Toán tử '{op}' ở cuối biểu thức thiếu toán hạng tiếp theo.");
                }

                double result1 = CheckTerm();
                if (op == '+')
                {
                    result += result1;
                }
                else
                {
                    result -= result1;
                }
            }

            return result;
        }


        public double CheckTerm()
        {
            double result = CheckFactor();

            while (_currentPos < _input.Length)
            {
                SkipWhitespace();
                if (_currentPos >= _input.Length)
                {
                    break;
                }

                char op = _input[_currentPos];
                if (op != '*' && op != '/')
                {
                    break;
                }

                int opPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length)
                {
                    throw new ExpressionParseException(opPos, $"Toán tử '{op}' ở cuối biểu thức thiếu toán hạng tiếp theo.");
                }

                double result1 = CheckFactor();
                if (op == '*')
                {
                    result *= result1;
                }
                else
                {
                    if (Math.Abs(result1) < 1e-15)
                    {
                        throw new DivideByZeroException("Không thể thực hiện phép chia cho 0.");
                    }
                    result /= result1;
                }
            }

            return result;
        }

     
        public double CheckFactor()
        {
            SkipWhitespace();
            if (_currentPos >= _input.Length)
            {
                int errorPos = _currentPos > 0 ? _currentPos - 1 : 0;
                throw new ExpressionParseException(errorPos, "Biểu thức thiếu toán hạng.");
            }

            char c = _input[_currentPos];

            // Xử lý hàm pow(E, E) -> pow(cơ_số, số_mũ)
            if (_currentPos + 3 <= _input.Length && string.Compare(_input, _currentPos, "pow", 0, 3, StringComparison.OrdinalIgnoreCase) == 0)
            {
                int funcPos = _currentPos;
                _currentPos += 3;
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != '(')
                {
                    throw new ExpressionParseException(_currentPos < _input.Length ? _currentPos : funcPos, "Hàm 'pow' thiếu dấu ngoặc mở '(' sau tên hàm.");
                }

                int openParenPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos < _input.Length && _input[_currentPos] == ')')
                {
                    throw new ExpressionParseException(openParenPos, "Hàm 'pow()' rỗng không chứa tham số.");
                }

                double arg1 = CheckExpression();
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != ',')
                {
                    int errPos = _currentPos < _input.Length ? _currentPos : funcPos;
                    throw new ExpressionParseException(errPos, "Hàm 'pow' thiếu dấu phẩy ',' phân tách giữa cơ số và số mũ.");
                }

                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] == ')')
                {
                    int errPos = _currentPos < _input.Length ? _currentPos : funcPos;
                    throw new ExpressionParseException(errPos, "Hàm 'pow' thiếu tham số số mũ thứ hai.");
                }

                double arg2 = CheckExpression();
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != ')')
                {
                    throw new ExpressionParseException(openParenPos, "Hàm 'pow' thiếu dấu ngoặc đóng ')' tương ứng.");
                }

                _currentPos++;

                // Kiểm tra ràng buộc toán học
                if (Math.Abs(arg1) < 1e-15 && Math.Abs(arg2) < 1e-15)
                {
                    throw new ExpressionParseException(funcPos, "Lỗi toán học: Phép tính 0 mũ 0 không xác định.");
                }
                if (Math.Abs(arg1) < 1e-15 && arg2 < 0)
                {
                    throw new DivideByZeroException("Lỗi toán học: Không thể chia cho 0 (0 mũ âm).");
                }
                if (arg1 < 0 && Math.Abs(arg2 - Math.Round(arg2)) > 1e-12)
                {
                    throw new ExpressionParseException(funcPos, "Lỗi toán học: Không thể lấy số mũ không nguyên của số âm.");
                }

                return Math.Pow(arg1, arg2);
            }

            // Xử lý hàm root(E, E) -> root(số, bậc)
            if (_currentPos + 4 <= _input.Length && string.Compare(_input, _currentPos, "root", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
            {
                int funcPos = _currentPos;
                _currentPos += 4;
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != '(')
                {
                    throw new ExpressionParseException(_currentPos < _input.Length ? _currentPos : funcPos, "Hàm 'root' thiếu dấu ngoặc mở '(' sau tên hàm.");
                }

                int openParenPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos < _input.Length && _input[_currentPos] == ')')
                {
                    throw new ExpressionParseException(openParenPos, "Hàm 'root()' rỗng không chứa tham số.");
                }

                double arg1 = CheckExpression();
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != ',')
                {
                    int errPos = _currentPos < _input.Length ? _currentPos : funcPos;
                    throw new ExpressionParseException(errPos, "Hàm 'root' thiếu dấu phẩy ',' phân tách giữa số cần khai căn và bậc căn.");
                }

                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] == ')')
                {
                    int errPos = _currentPos < _input.Length ? _currentPos : funcPos;
                    throw new ExpressionParseException(errPos, "Hàm 'root' thiếu tham số bậc căn thứ hai.");
                }

                double arg2 = CheckExpression();
                SkipWhitespace();

                if (_currentPos >= _input.Length || _input[_currentPos] != ')')
                {
                    throw new ExpressionParseException(openParenPos, "Hàm 'root' thiếu dấu ngoặc đóng ')' tương ứng.");
                }

                _currentPos++;

                // Kiểm tra ràng buộc toán học
                if (Math.Abs(arg2) < 1e-15)
                {
                    throw new ExpressionParseException(funcPos, "Lỗi toán học: Bậc căn không thể bằng 0.");
                }

                if (arg1 < 0)
                {
                    bool isInteger = Math.Abs(arg2 - Math.Round(arg2)) < 1e-12;
                    if (!isInteger)
                    {
                        throw new ExpressionParseException(funcPos, "Lỗi toán học: Không thể khai căn bậc không nguyên của số âm.");
                    }

                    long degInt = (long)Math.Round(arg2);
                    if (degInt % 2 == 0)
                    {
                        throw new ExpressionParseException(funcPos, "Lỗi toán học: Không thể lấy căn bậc chẵn của số âm.");
                    }

                    // Khai căn bậc lẻ của số âm: root(-8, 3) = -2
                    return -Math.Pow(-arg1, 1.0 / arg2);
                }

                return Math.Pow(arg1, 1.0 / arg2);
            }

            // Xử lý dấu ngoặc (E)
            if (c == '(')
            {
                int openParenPos = _currentPos;
                _currentPos++;
                
                SkipWhitespace();
                if (_currentPos < _input.Length && _input[_currentPos] == ')')
                {
                    throw new ExpressionParseException(openParenPos, "Cặp ngoặc rỗng '()' không chứa biểu thức.");
                }

                double result = CheckExpression();

                SkipWhitespace();
                if (_currentPos < _input.Length && _input[_currentPos] == ')')
                {
                    _currentPos++;
                    return result;
                }

                throw new ExpressionParseException(openParenPos, "Thiếu dấu ngoặc đóng ')' tương ứng.");
            }
            
            if (c == '-')
            {
                _currentPos++;
                return -CheckFactor();
            }

            if (c == '+')
            {
                _currentPos++;
                return CheckFactor();
            }

            if (char.IsDigit(c) || c == '.')
            {
                return GetDigits();
            }

            if (c == ')')
            {
                throw new ExpressionParseException(_currentPos, "Thừa dấu ngoặc đóng ')' không hợp lệ.");
            }

            if (c == '*' || c == '/')
            {
                throw new ExpressionParseException(_currentPos, $"Toán tử '{c}' không thể đứng ở vị trí này.");
            }

            throw new ExpressionParseException(_currentPos, $"Ký tự không hợp lệ '{c}'.");
        }


        public double GetDigits()
        {
            int startPos = _currentPos;
            bool hasDot = false;

            while (_currentPos < _input.Length)
            {
                char ch = _input[_currentPos];
                if (char.IsDigit(ch))
                {
                    _currentPos++;
                }
                else if (ch == '.')
                {
                    if (hasDot)
                    {
                        throw new ExpressionParseException(_currentPos, "Số chứa nhiều hơn một dấu chấm thập phân '.'.");
                    }
                    hasDot = true;
                    _currentPos++;
                }
                else
                {
                    break;
                }
            }

            string numStr = _input.Substring(startPos, _currentPos - startPos);
            if (numStr == ".")
            {
                throw new ExpressionParseException(startPos, "Dấu chấm thập phân '.' không có chữ số đi kèm.");
            }

            if (double.TryParse(numStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
            {
                return value;
            }

            throw new ExpressionParseException(startPos, $"Không thể phân giải '{numStr}' thành số hợp lệ.");
        }
    }
}
