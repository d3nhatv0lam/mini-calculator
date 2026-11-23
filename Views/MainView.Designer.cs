namespace MiniCalculator.Views;

partial class MainView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtCalcExpression = new AntdUI.Input();
        lblCalcResult = new AntdUI.Label();
        btnLeft = new AntdUI.Button();
        btnRight = new AntdUI.Button();
        btnClear = new AntdUI.Button();
        btnBackspace = new AntdUI.Button();
        btnDivide = new AntdUI.Button();
        btnOpenParen = new AntdUI.Button();
        btn7 = new AntdUI.Button();
        btn8 = new AntdUI.Button();
        btn9 = new AntdUI.Button();
        btnMultiply = new AntdUI.Button();
        btnCloseParen = new AntdUI.Button();
        btn4 = new AntdUI.Button();
        btn5 = new AntdUI.Button();
        btn6 = new AntdUI.Button();
        btnMinus = new AntdUI.Button();
        btnRoot = new AntdUI.Button();
        btn1 = new AntdUI.Button();
        btn2 = new AntdUI.Button();
        btn3 = new AntdUI.Button();
        btnPlus = new AntdUI.Button();
        btnPower = new AntdUI.Button();
        btn0 = new AntdUI.Button();
        btnDot = new AntdUI.Button();
        btnComma = new AntdUI.Button();
        btnEqual = new AntdUI.Button();
        SuspendLayout();
        // 
        // txtCalcExpression
        // 
        txtCalcExpression.AutoScroll = true;
        txtCalcExpression.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        txtCalcExpression.HideSelection = false;
        txtCalcExpression.Location = new Point(50, 18);
        txtCalcExpression.ReadOnly = true;
        txtCalcExpression.CaretVisible = true;
        txtCalcExpression.Name = "txtCalcExpression";
        txtCalcExpression.PlaceholderText = "Bấm phím trên bàn phím máy tính...";
        txtCalcExpression.Radius = 8;
        txtCalcExpression.Size = new Size(492, 75);
        txtCalcExpression.TabIndex = 0;
        // 
        // lblCalcResult
        // 
        lblCalcResult.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblCalcResult.ForeColor = Color.FromArgb(38, 38, 38);
        lblCalcResult.Location = new Point(52, 99);
        lblCalcResult.Name = "lblCalcResult";
        lblCalcResult.Size = new Size(488, 50);
        lblCalcResult.TabIndex = 1;
        lblCalcResult.Text = "";
        lblCalcResult.TextAlign = ContentAlignment.TopLeft;
        // 
        // btnLeft
        // 
        btnLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnLeft.Location = new Point(50, 155);
        btnLeft.Name = "btnLeft";
        btnLeft.Radius = 8;
        btnLeft.Size = new Size(88, 46);
        btnLeft.TabIndex = 2;
        btnLeft.Text = "←";
        // 
        // btnRight
        // 
        btnRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnRight.Location = new Point(151, 155);
        btnRight.Name = "btnRight";
        btnRight.Radius = 8;
        btnRight.Size = new Size(88, 46);
        btnRight.TabIndex = 3;
        btnRight.Text = "→";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnClear.Location = new Point(252, 155);
        btnClear.Name = "btnClear";
        btnClear.Radius = 8;
        btnClear.Size = new Size(88, 46);
        btnClear.TabIndex = 4;
        btnClear.Text = "C";
        // 
        // btnBackspace
        // 
        btnBackspace.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnBackspace.Location = new Point(353, 155);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Radius = 8;
        btnBackspace.Size = new Size(88, 46);
        btnBackspace.TabIndex = 5;
        btnBackspace.Text = "⌫";
        // 
        // btnDivide
        // 
        btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnDivide.Location = new Point(454, 155);
        btnDivide.Name = "btnDivide";
        btnDivide.Radius = 8;
        btnDivide.Size = new Size(88, 46);
        btnDivide.TabIndex = 6;
        btnDivide.Text = "/";
        // 
        // btnOpenParen
        // 
        btnOpenParen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnOpenParen.Location = new Point(50, 213);
        btnOpenParen.Name = "btnOpenParen";
        btnOpenParen.Radius = 8;
        btnOpenParen.Size = new Size(88, 46);
        btnOpenParen.TabIndex = 7;
        btnOpenParen.Text = "(";
        // 
        // btn7
        // 
        btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn7.Location = new Point(151, 213);
        btn7.Name = "btn7";
        btn7.Radius = 8;
        btn7.Size = new Size(88, 46);
        btn7.TabIndex = 8;
        btn7.Text = "7";
        // 
        // btn8
        // 
        btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn8.Location = new Point(252, 213);
        btn8.Name = "btn8";
        btn8.Radius = 8;
        btn8.Size = new Size(88, 46);
        btn8.TabIndex = 9;
        btn8.Text = "8";
        // 
        // btn9
        // 
        btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn9.Location = new Point(353, 213);
        btn9.Name = "btn9";
        btn9.Radius = 8;
        btn9.Size = new Size(88, 46);
        btn9.TabIndex = 10;
        btn9.Text = "9";
        // 
        // btnMultiply
        // 
        btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMultiply.Location = new Point(454, 213);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Radius = 8;
        btnMultiply.Size = new Size(88, 46);
        btnMultiply.TabIndex = 11;
        btnMultiply.Text = "*";
        // 
        // btnCloseParen
        // 
        btnCloseParen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnCloseParen.Location = new Point(50, 271);
        btnCloseParen.Name = "btnCloseParen";
        btnCloseParen.Radius = 8;
        btnCloseParen.Size = new Size(88, 46);
        btnCloseParen.TabIndex = 12;
        btnCloseParen.Text = ")";
        // 
        // btn4
        // 
        btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn4.Location = new Point(151, 271);
        btn4.Name = "btn4";
        btn4.Radius = 8;
        btn4.Size = new Size(88, 46);
        btn4.TabIndex = 13;
        btn4.Text = "4";
        // 
        // btn5
        // 
        btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn5.Location = new Point(252, 271);
        btn5.Name = "btn5";
        btn5.Radius = 8;
        btn5.Size = new Size(88, 46);
        btn5.TabIndex = 14;
        btn5.Text = "5";
        // 
        // btn6
        // 
        btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn6.Location = new Point(353, 271);
        btn6.Name = "btn6";
        btn6.Radius = 8;
        btn6.Size = new Size(88, 46);
        btn6.TabIndex = 15;
        btn6.Text = "6";
        // 
        // btnMinus
        // 
        btnMinus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMinus.Location = new Point(454, 271);
        btnMinus.Name = "btnMinus";
        btnMinus.Radius = 8;
        btnMinus.Size = new Size(88, 46);
        btnMinus.TabIndex = 16;
        btnMinus.Text = "-";
        // 
        // btnRoot
        // 
        btnRoot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnRoot.Location = new Point(50, 329);
        btnRoot.Name = "btnRoot";
        btnRoot.Radius = 8;
        btnRoot.Size = new Size(88, 46);
        btnRoot.TabIndex = 17;
        btnRoot.Text = "ⁿ√x";
        // 
        // btn1
        // 
        btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn1.Location = new Point(151, 329);
        btn1.Name = "btn1";
        btn1.Radius = 8;
        btn1.Size = new Size(88, 46);
        btn1.TabIndex = 18;
        btn1.Text = "1";
        // 
        // btn2
        // 
        btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn2.Location = new Point(252, 329);
        btn2.Name = "btn2";
        btn2.Radius = 8;
        btn2.Size = new Size(88, 46);
        btn2.TabIndex = 19;
        btn2.Text = "2";
        // 
        // btn3
        // 
        btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn3.Location = new Point(353, 329);
        btn3.Name = "btn3";
        btn3.Radius = 8;
        btn3.Size = new Size(88, 46);
        btn3.TabIndex = 20;
        btn3.Text = "3";
        // 
        // btnPlus
        // 
        btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPlus.Location = new Point(454, 329);
        btnPlus.Name = "btnPlus";
        btnPlus.Radius = 8;
        btnPlus.Size = new Size(88, 46);
        btnPlus.TabIndex = 21;
        btnPlus.Text = "+";
        // 
        // btnPower
        // 
        btnPower.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPower.Location = new Point(50, 387);
        btnPower.Name = "btnPower";
        btnPower.Radius = 8;
        btnPower.Size = new Size(88, 46);
        btnPower.TabIndex = 22;
        btnPower.Text = "xʸ";
        // 
        // btn0
        // 
        btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn0.Location = new Point(151, 387);
        btn0.Name = "btn0";
        btn0.Radius = 8;
        btn0.Size = new Size(88, 46);
        btn0.TabIndex = 23;
        btn0.Text = "0";
        // 
        // btnDot
        // 
        btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnDot.Location = new Point(252, 387);
        btnDot.Name = "btnDot";
        btnDot.Radius = 8;
        btnDot.Size = new Size(88, 46);
        btnDot.TabIndex = 24;
        btnDot.Text = ".";
        // 
        // btnComma
        // 
        btnComma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnComma.Location = new Point(353, 387);
        btnComma.Name = "btnComma";
        btnComma.Radius = 8;
        btnComma.Size = new Size(88, 46);
        btnComma.TabIndex = 25;
        btnComma.Text = ",";
        // 
        // btnEqual
        // 
        btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnEqual.Location = new Point(454, 387);
        btnEqual.Name = "btnEqual";
        btnEqual.Radius = 8;
        btnEqual.Size = new Size(88, 46);
        btnEqual.TabIndex = 26;
        btnEqual.Text = "=";
        btnEqual.Type = AntdUI.TTypeMini.Primary;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(595, 452);
        Controls.Add(txtCalcExpression);
        Controls.Add(lblCalcResult);
        Controls.Add(btnLeft);
        Controls.Add(btnRight);
        Controls.Add(btnClear);
        Controls.Add(btnBackspace);
        Controls.Add(btnDivide);
        Controls.Add(btnOpenParen);
        Controls.Add(btn7);
        Controls.Add(btn8);
        Controls.Add(btn9);
        Controls.Add(btnMultiply);
        Controls.Add(btnCloseParen);
        Controls.Add(btn4);
        Controls.Add(btn5);
        Controls.Add(btn6);
        Controls.Add(btnMinus);
        Controls.Add(btnRoot);
        Controls.Add(btn1);
        Controls.Add(btn2);
        Controls.Add(btn3);
        Controls.Add(btnPlus);
        Controls.Add(btnPower);
        Controls.Add(btn0);
        Controls.Add(btnDot);
        Controls.Add(btnComma);
        Controls.Add(btnEqual);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Phân giải và tính toán biểu thức số học";
        ResumeLayout(false);
    }

    private AntdUI.Input txtCalcExpression;
    private AntdUI.Label lblCalcResult;

    // Row 0
    private AntdUI.Button btnLeft;
    private AntdUI.Button btnRight;
    private AntdUI.Button btnClear;
    private AntdUI.Button btnBackspace;
    private AntdUI.Button btnDivide;

    // Row 1
    private AntdUI.Button btnOpenParen;
    private AntdUI.Button btn7;
    private AntdUI.Button btn8;
    private AntdUI.Button btn9;
    private AntdUI.Button btnMultiply;

    // Row 2
    private AntdUI.Button btnCloseParen;
    private AntdUI.Button btn4;
    private AntdUI.Button btn5;
    private AntdUI.Button btn6;
    private AntdUI.Button btnMinus;

    // Row 3
    private AntdUI.Button btnRoot;
    private AntdUI.Button btn1;
    private AntdUI.Button btn2;
    private AntdUI.Button btn3;
    private AntdUI.Button btnPlus;

    // Row 4
    private AntdUI.Button btnPower;
    private AntdUI.Button btn0;
    private AntdUI.Button btnDot;
    private AntdUI.Button btnComma;
    private AntdUI.Button btnEqual;

    #endregion
}
