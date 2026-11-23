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
        tableRoot = new TableLayoutPanel();
        pnlCalculator = new Panel();
        tableKeypad = new TableLayoutPanel();
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
        pnlCalcDisplay = new Panel();
        lblCalcResult = new AntdUI.Label();
        txtCalcExpression = new AntdUI.Input();
        pnlHistory = new Panel();
        pnlHistoryList = new Panel();
        lblEmptyHistory = new AntdUI.Label();
        pnlHistoryHeader = new Panel();
        btnClearHistory = new AntdUI.Button();
        lblHistoryTitle = new AntdUI.Label();
        tableRoot.SuspendLayout();
        pnlCalculator.SuspendLayout();
        tableKeypad.SuspendLayout();
        pnlCalcDisplay.SuspendLayout();
        pnlHistory.SuspendLayout();
        pnlHistoryList.SuspendLayout();
        pnlHistoryHeader.SuspendLayout();
        SuspendLayout();
        // 
        // tableRoot
        // 
        tableRoot.BackColor = Color.FromArgb(245, 247, 250);
        tableRoot.ColumnCount = 2;
        tableRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
        tableRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
        tableRoot.Controls.Add(pnlCalculator, 0, 0);
        tableRoot.Controls.Add(pnlHistory, 1, 0);
        tableRoot.Dock = DockStyle.Fill;
        tableRoot.Location = new Point(0, 0);
        tableRoot.Margin = new Padding(0);
        tableRoot.Name = "tableRoot";
        tableRoot.Padding = new Padding(12);
        tableRoot.RowCount = 1;
        tableRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableRoot.Size = new Size(960, 560);
        tableRoot.TabIndex = 0;
        // 
        // pnlCalculator
        // 
        pnlCalculator.BackColor = Color.Transparent;
        pnlCalculator.Controls.Add(tableKeypad);
        pnlCalculator.Controls.Add(pnlCalcDisplay);
        pnlCalculator.Dock = DockStyle.Fill;
        pnlCalculator.Location = new Point(12, 12);
        pnlCalculator.Margin = new Padding(0, 0, 8, 0);
        pnlCalculator.Name = "pnlCalculator";
        pnlCalculator.Size = new Size(581, 536);
        pnlCalculator.TabIndex = 0;
        // 
        // pnlCalcDisplay
        // 
        pnlCalcDisplay.BackColor = Color.Transparent;
        pnlCalcDisplay.Controls.Add(lblCalcResult);
        pnlCalcDisplay.Controls.Add(txtCalcExpression);
        pnlCalcDisplay.Dock = DockStyle.Top;
        pnlCalcDisplay.Location = new Point(0, 0);
        pnlCalcDisplay.Margin = new Padding(0, 0, 0, 8);
        pnlCalcDisplay.Name = "pnlCalcDisplay";
        pnlCalcDisplay.Padding = new Padding(0, 0, 0, 4);
        pnlCalcDisplay.Size = new Size(581, 168);
        pnlCalcDisplay.TabIndex = 0;
        // 
        // txtCalcExpression
        // 
        txtCalcExpression.AutoScroll = true;
        txtCalcExpression.CaretVisible = true;
        txtCalcExpression.Dock = DockStyle.Top;
        txtCalcExpression.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        txtCalcExpression.HideSelection = false;
        txtCalcExpression.Location = new Point(0, 0);
        txtCalcExpression.Name = "txtCalcExpression";
        txtCalcExpression.PlaceholderText = "Bấm phím trên bàn phím máy tính...";
        txtCalcExpression.Radius = 8;
        txtCalcExpression.ReadOnly = true;
        txtCalcExpression.Size = new Size(581, 90);
        txtCalcExpression.TabIndex = 0;
        // 
        // lblCalcResult
        // 
        lblCalcResult.Dock = DockStyle.Fill;
        lblCalcResult.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblCalcResult.ForeColor = Color.FromArgb(38, 38, 38);
        lblCalcResult.Location = new Point(0, 90);
        lblCalcResult.Name = "lblCalcResult";
        lblCalcResult.Padding = new Padding(4, 8, 4, 4);
        lblCalcResult.Size = new Size(581, 74);
        lblCalcResult.TabIndex = 1;
        lblCalcResult.Text = "";
        lblCalcResult.TextAlign = ContentAlignment.TopLeft;
        // 
        // tableKeypad
        // 
        tableKeypad.BackColor = Color.Transparent;
        tableKeypad.ColumnCount = 5;
        tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableKeypad.Controls.Add(btnLeft, 0, 0);
        tableKeypad.Controls.Add(btnRight, 1, 0);
        tableKeypad.Controls.Add(btnClear, 2, 0);
        tableKeypad.Controls.Add(btnBackspace, 3, 0);
        tableKeypad.Controls.Add(btnDivide, 4, 0);
        tableKeypad.Controls.Add(btnOpenParen, 0, 1);
        tableKeypad.Controls.Add(btn7, 1, 1);
        tableKeypad.Controls.Add(btn8, 2, 1);
        tableKeypad.Controls.Add(btn9, 3, 1);
        tableKeypad.Controls.Add(btnMultiply, 4, 1);
        tableKeypad.Controls.Add(btnCloseParen, 0, 2);
        tableKeypad.Controls.Add(btn4, 1, 2);
        tableKeypad.Controls.Add(btn5, 2, 2);
        tableKeypad.Controls.Add(btn6, 3, 2);
        tableKeypad.Controls.Add(btnMinus, 4, 2);
        tableKeypad.Controls.Add(btnRoot, 0, 3);
        tableKeypad.Controls.Add(btn1, 1, 3);
        tableKeypad.Controls.Add(btn2, 2, 3);
        tableKeypad.Controls.Add(btn3, 3, 3);
        tableKeypad.Controls.Add(btnPlus, 4, 3);
        tableKeypad.Controls.Add(btnPower, 0, 4);
        tableKeypad.Controls.Add(btn0, 1, 4);
        tableKeypad.Controls.Add(btnDot, 2, 4);
        tableKeypad.Controls.Add(btnComma, 3, 4);
        tableKeypad.Controls.Add(btnEqual, 4, 4);
        tableKeypad.Dock = DockStyle.Fill;
        tableKeypad.Location = new Point(0, 168);
        tableKeypad.Margin = new Padding(0);
        tableKeypad.Name = "tableKeypad";
        tableKeypad.RowCount = 5;
        tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableKeypad.Size = new Size(581, 414);
        tableKeypad.TabIndex = 1;
        // 
        // btnLeft
        // 
        btnLeft.Dock = DockStyle.Fill;
        btnLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnLeft.Location = new Point(3, 3);
        btnLeft.Margin = new Padding(3);
        btnLeft.Name = "btnLeft";
        btnLeft.Radius = 8;
        btnLeft.Size = new Size(110, 76);
        btnLeft.TabIndex = 0;
        btnLeft.Text = "←";
        // 
        // btnRight
        // 
        btnRight.Dock = DockStyle.Fill;
        btnRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnRight.Location = new Point(119, 3);
        btnRight.Margin = new Padding(3);
        btnRight.Name = "btnRight";
        btnRight.Radius = 8;
        btnRight.Size = new Size(110, 76);
        btnRight.TabIndex = 1;
        btnRight.Text = "→";
        // 
        // btnClear
        // 
        btnClear.Dock = DockStyle.Fill;
        btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnClear.Location = new Point(235, 3);
        btnClear.Margin = new Padding(3);
        btnClear.Name = "btnClear";
        btnClear.Radius = 8;
        btnClear.Size = new Size(110, 76);
        btnClear.TabIndex = 2;
        btnClear.Text = "C";
        // 
        // btnBackspace
        // 
        btnBackspace.Dock = DockStyle.Fill;
        btnBackspace.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnBackspace.Location = new Point(351, 3);
        btnBackspace.Margin = new Padding(3);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Radius = 8;
        btnBackspace.Size = new Size(110, 76);
        btnBackspace.TabIndex = 3;
        btnBackspace.Text = "⌫";
        // 
        // btnDivide
        // 
        btnDivide.Dock = DockStyle.Fill;
        btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnDivide.Location = new Point(467, 3);
        btnDivide.Margin = new Padding(3);
        btnDivide.Name = "btnDivide";
        btnDivide.Radius = 8;
        btnDivide.Size = new Size(111, 76);
        btnDivide.TabIndex = 4;
        btnDivide.Text = "/";
        // 
        // btnOpenParen
        // 
        btnOpenParen.Dock = DockStyle.Fill;
        btnOpenParen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnOpenParen.Location = new Point(3, 85);
        btnOpenParen.Margin = new Padding(3);
        btnOpenParen.Name = "btnOpenParen";
        btnOpenParen.Radius = 8;
        btnOpenParen.Size = new Size(110, 76);
        btnOpenParen.TabIndex = 5;
        btnOpenParen.Text = "(";
        // 
        // btn7
        // 
        btn7.Dock = DockStyle.Fill;
        btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn7.Location = new Point(119, 85);
        btn7.Margin = new Padding(3);
        btn7.Name = "btn7";
        btn7.Radius = 8;
        btn7.Size = new Size(110, 76);
        btn7.TabIndex = 6;
        btn7.Text = "7";
        // 
        // btn8
        // 
        btn8.Dock = DockStyle.Fill;
        btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn8.Location = new Point(235, 85);
        btn8.Margin = new Padding(3);
        btn8.Name = "btn8";
        btn8.Radius = 8;
        btn8.Size = new Size(110, 76);
        btn8.TabIndex = 7;
        btn8.Text = "8";
        // 
        // btn9
        // 
        btn9.Dock = DockStyle.Fill;
        btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn9.Location = new Point(351, 85);
        btn9.Margin = new Padding(3);
        btn9.Name = "btn9";
        btn9.Radius = 8;
        btn9.Size = new Size(110, 76);
        btn9.TabIndex = 8;
        btn9.Text = "9";
        // 
        // btnMultiply
        // 
        btnMultiply.Dock = DockStyle.Fill;
        btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMultiply.Location = new Point(467, 85);
        btnMultiply.Margin = new Padding(3);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Radius = 8;
        btnMultiply.Size = new Size(111, 76);
        btnMultiply.TabIndex = 9;
        btnMultiply.Text = "*";
        // 
        // btnCloseParen
        // 
        btnCloseParen.Dock = DockStyle.Fill;
        btnCloseParen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnCloseParen.Location = new Point(3, 167);
        btnCloseParen.Margin = new Padding(3);
        btnCloseParen.Name = "btnCloseParen";
        btnCloseParen.Radius = 8;
        btnCloseParen.Size = new Size(110, 76);
        btnCloseParen.TabIndex = 10;
        btnCloseParen.Text = ")";
        // 
        // btn4
        // 
        btn4.Dock = DockStyle.Fill;
        btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn4.Location = new Point(119, 167);
        btn4.Margin = new Padding(3);
        btn4.Name = "btn4";
        btn4.Radius = 8;
        btn4.Size = new Size(110, 76);
        btn4.TabIndex = 11;
        btn4.Text = "4";
        // 
        // btn5
        // 
        btn5.Dock = DockStyle.Fill;
        btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn5.Location = new Point(235, 167);
        btn5.Margin = new Padding(3);
        btn5.Name = "btn5";
        btn5.Radius = 8;
        btn5.Size = new Size(110, 76);
        btn5.TabIndex = 12;
        btn5.Text = "5";
        // 
        // btn6
        // 
        btn6.Dock = DockStyle.Fill;
        btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn6.Location = new Point(351, 167);
        btn6.Margin = new Padding(3);
        btn6.Name = "btn6";
        btn6.Radius = 8;
        btn6.Size = new Size(110, 76);
        btn6.TabIndex = 13;
        btn6.Text = "6";
        // 
        // btnMinus
        // 
        btnMinus.Dock = DockStyle.Fill;
        btnMinus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMinus.Location = new Point(467, 167);
        btnMinus.Margin = new Padding(3);
        btnMinus.Name = "btnMinus";
        btnMinus.Radius = 8;
        btnMinus.Size = new Size(111, 76);
        btnMinus.TabIndex = 14;
        btnMinus.Text = "-";
        // 
        // btnRoot
        // 
        btnRoot.Dock = DockStyle.Fill;
        btnRoot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnRoot.Location = new Point(3, 249);
        btnRoot.Margin = new Padding(3);
        btnRoot.Name = "btnRoot";
        btnRoot.Radius = 8;
        btnRoot.Size = new Size(110, 76);
        btnRoot.TabIndex = 15;
        btnRoot.Text = "ⁿ√x";
        // 
        // btn1
        // 
        btn1.Dock = DockStyle.Fill;
        btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn1.Location = new Point(119, 249);
        btn1.Margin = new Padding(3);
        btn1.Name = "btn1";
        btn1.Radius = 8;
        btn1.Size = new Size(110, 76);
        btn1.TabIndex = 16;
        btn1.Text = "1";
        // 
        // btn2
        // 
        btn2.Dock = DockStyle.Fill;
        btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn2.Location = new Point(235, 249);
        btn2.Margin = new Padding(3);
        btn2.Name = "btn2";
        btn2.Radius = 8;
        btn2.Size = new Size(110, 76);
        btn2.TabIndex = 17;
        btn2.Text = "2";
        // 
        // btn3
        // 
        btn3.Dock = DockStyle.Fill;
        btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn3.Location = new Point(351, 249);
        btn3.Margin = new Padding(3);
        btn3.Name = "btn3";
        btn3.Radius = 8;
        btn3.Size = new Size(110, 76);
        btn3.TabIndex = 18;
        btn3.Text = "3";
        // 
        // btnPlus
        // 
        btnPlus.Dock = DockStyle.Fill;
        btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPlus.Location = new Point(467, 249);
        btnPlus.Margin = new Padding(3);
        btnPlus.Name = "btnPlus";
        btnPlus.Radius = 8;
        btnPlus.Size = new Size(111, 76);
        btnPlus.TabIndex = 19;
        btnPlus.Text = "+";
        // 
        // btnPower
        // 
        btnPower.Dock = DockStyle.Fill;
        btnPower.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPower.Location = new Point(3, 331);
        btnPower.Margin = new Padding(3);
        btnPower.Name = "btnPower";
        btnPower.Radius = 8;
        btnPower.Size = new Size(110, 80);
        btnPower.TabIndex = 20;
        btnPower.Text = "xʸ";
        // 
        // btn0
        // 
        btn0.Dock = DockStyle.Fill;
        btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btn0.Location = new Point(119, 331);
        btn0.Margin = new Padding(3);
        btn0.Name = "btn0";
        btn0.Radius = 8;
        btn0.Size = new Size(110, 80);
        btn0.TabIndex = 21;
        btn0.Text = "0";
        // 
        // btnDot
        // 
        btnDot.Dock = DockStyle.Fill;
        btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnDot.Location = new Point(235, 331);
        btnDot.Margin = new Padding(3);
        btnDot.Name = "btnDot";
        btnDot.Radius = 8;
        btnDot.Size = new Size(110, 80);
        btnDot.TabIndex = 22;
        btnDot.Text = ".";
        // 
        // btnComma
        // 
        btnComma.Dock = DockStyle.Fill;
        btnComma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnComma.Location = new Point(351, 331);
        btnComma.Margin = new Padding(3);
        btnComma.Name = "btnComma";
        btnComma.Radius = 8;
        btnComma.Size = new Size(110, 80);
        btnComma.TabIndex = 23;
        btnComma.Text = ",";
        // 
        // btnEqual
        // 
        btnEqual.Dock = DockStyle.Fill;
        btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnEqual.Location = new Point(467, 331);
        btnEqual.Margin = new Padding(3);
        btnEqual.Name = "btnEqual";
        btnEqual.Radius = 8;
        btnEqual.Size = new Size(111, 80);
        btnEqual.TabIndex = 24;
        btnEqual.Text = "=";
        btnEqual.Type = AntdUI.TTypeMini.Primary;
        // 
        // pnlHistory
        // 
        pnlHistory.BackColor = Color.White;
        pnlHistory.Controls.Add(pnlHistoryList);
        pnlHistory.Controls.Add(pnlHistoryHeader);
        pnlHistory.Dock = DockStyle.Fill;
        pnlHistory.Location = new Point(609, 12);
        pnlHistory.Margin = new Padding(8, 0, 0, 0);
        pnlHistory.Name = "pnlHistory";
        pnlHistory.Padding = new Padding(12);
        pnlHistory.Size = new Size(339, 536);
        pnlHistory.TabIndex = 1;
        // 
        // pnlHistoryList
        // 
        pnlHistoryList.AutoScroll = true;
        pnlHistoryList.BackColor = Color.Transparent;
        pnlHistoryList.Controls.Add(lblEmptyHistory);
        pnlHistoryList.Dock = DockStyle.Fill;
        pnlHistoryList.Location = new Point(12, 52);
        pnlHistoryList.Name = "pnlHistoryList";
        pnlHistoryList.Padding = new Padding(0, 4, 2, 4);
        pnlHistoryList.Size = new Size(315, 472);
        pnlHistoryList.TabIndex = 1;
        // 
        // lblEmptyHistory
        // 
        lblEmptyHistory.Dock = DockStyle.Fill;
        lblEmptyHistory.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        lblEmptyHistory.ForeColor = Color.FromArgb(140, 140, 140);
        lblEmptyHistory.Location = new Point(0, 4);
        lblEmptyHistory.Name = "lblEmptyHistory";
        lblEmptyHistory.Size = new Size(313, 464);
        lblEmptyHistory.TabIndex = 0;
        lblEmptyHistory.Text = "Chưa có lịch sử phép tính nào";
        lblEmptyHistory.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlHistoryHeader
        // 
        pnlHistoryHeader.BackColor = Color.Transparent;
        pnlHistoryHeader.Controls.Add(btnClearHistory);
        pnlHistoryHeader.Controls.Add(lblHistoryTitle);
        pnlHistoryHeader.Dock = DockStyle.Top;
        pnlHistoryHeader.Location = new Point(12, 12);
        pnlHistoryHeader.Name = "pnlHistoryHeader";
        pnlHistoryHeader.Size = new Size(315, 40);
        pnlHistoryHeader.TabIndex = 0;
        // 
        // btnClearHistory
        // 
        btnClearHistory.Dock = DockStyle.Right;
        btnClearHistory.Font = new Font("Segoe UI", 9.5F);
        btnClearHistory.Location = new Point(225, 0);
        btnClearHistory.Name = "btnClearHistory";
        btnClearHistory.Radius = 6;
        btnClearHistory.Size = new Size(90, 40);
        btnClearHistory.TabIndex = 1;
        btnClearHistory.Text = "Xóa tất cả";
        // 
        // lblHistoryTitle
        // 
        lblHistoryTitle.Dock = DockStyle.Left;
        lblHistoryTitle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
        lblHistoryTitle.ForeColor = Color.FromArgb(38, 38, 38);
        lblHistoryTitle.Location = new Point(0, 0);
        lblHistoryTitle.Name = "lblHistoryTitle";
        lblHistoryTitle.Size = new Size(180, 40);
        lblHistoryTitle.TabIndex = 0;
        lblHistoryTitle.Text = "Lịch sử phép tính";
        lblHistoryTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(980, 600);
        Controls.Add(tableRoot);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimumSize = new Size(880, 580);
        Name = "MainView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Phân giải và tính toán biểu thức số học";
        tableRoot.ResumeLayout(false);
        pnlCalculator.ResumeLayout(false);
        tableKeypad.ResumeLayout(false);
        pnlCalcDisplay.ResumeLayout(false);
        pnlHistory.ResumeLayout(false);
        pnlHistoryList.ResumeLayout(false);
        pnlHistoryHeader.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel tableRoot;
    private Panel pnlCalculator;
    private Panel pnlCalcDisplay;
    private AntdUI.Input txtCalcExpression;
    private AntdUI.Label lblCalcResult;
    private TableLayoutPanel tableKeypad;

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

    // History controls
    private Panel pnlHistory;
    private Panel pnlHistoryHeader;
    private AntdUI.Label lblHistoryTitle;
    private AntdUI.Button btnClearHistory;
    private Panel pnlHistoryList;
    private AntdUI.Label lblEmptyHistory;

    #endregion
}
