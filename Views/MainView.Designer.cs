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
        tableRoot = new System.Windows.Forms.TableLayoutPanel();
        pnlCalculator = new System.Windows.Forms.Panel();
        tableKeypad = new System.Windows.Forms.TableLayoutPanel();
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
        pnlCalcDisplay = new System.Windows.Forms.Panel();
        lblCalcResult = new AntdUI.Label();
        txtCalcExpression = new AntdUI.Input();
        pnlHistory = new System.Windows.Forms.Panel();
        pnlHistoryList = new System.Windows.Forms.Panel();
        lblEmptyHistory = new AntdUI.Label();
        pnlHistoryHeader = new System.Windows.Forms.Panel();
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
        tableRoot.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tableRoot.ColumnCount = 2;
        tableRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
        tableRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
        tableRoot.Controls.Add(pnlCalculator, 0, 0);
        tableRoot.Controls.Add(pnlHistory, 1, 0);
        tableRoot.Dock = System.Windows.Forms.DockStyle.Fill;
        tableRoot.Location = new System.Drawing.Point(0, 0);
        tableRoot.Margin = new System.Windows.Forms.Padding(0);
        tableRoot.Name = "tableRoot";
        tableRoot.Padding = new System.Windows.Forms.Padding(12);
        tableRoot.RowCount = 1;
        tableRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableRoot.Size = new System.Drawing.Size(980, 600);
        tableRoot.TabIndex = 0;
        // 
        // pnlCalculator
        // 
        pnlCalculator.BackColor = System.Drawing.Color.Transparent;
        pnlCalculator.Controls.Add(tableKeypad);
        pnlCalculator.Controls.Add(pnlCalcDisplay);
        pnlCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlCalculator.Location = new System.Drawing.Point(12, 12);
        pnlCalculator.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
        pnlCalculator.Name = "pnlCalculator";
        pnlCalculator.Size = new System.Drawing.Size(594, 576);
        pnlCalculator.TabIndex = 0;
        // 
        // tableKeypad
        // 
        tableKeypad.BackColor = System.Drawing.Color.Transparent;
        tableKeypad.ColumnCount = 5;
        tableKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
        tableKeypad.Dock = System.Windows.Forms.DockStyle.Fill;
        tableKeypad.Location = new System.Drawing.Point(0, 168);
        tableKeypad.Margin = new System.Windows.Forms.Padding(0);
        tableKeypad.Name = "tableKeypad";
        tableKeypad.RowCount = 5;
        tableKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableKeypad.Size = new System.Drawing.Size(594, 408);
        tableKeypad.TabIndex = 1;
        // 
        // btnLeft
        // 
        btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
        btnLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnLeft.Location = new System.Drawing.Point(3, 3);
        btnLeft.Name = "btnLeft";
        btnLeft.Radius = 8;
        btnLeft.Size = new System.Drawing.Size(112, 75);
        btnLeft.TabIndex = 0;
        btnLeft.Text = "←";
        // 
        // btnRight
        // 
        btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
        btnRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnRight.Location = new System.Drawing.Point(121, 3);
        btnRight.Name = "btnRight";
        btnRight.Radius = 8;
        btnRight.Size = new System.Drawing.Size(112, 75);
        btnRight.TabIndex = 1;
        btnRight.Text = "→";
        // 
        // btnClear
        // 
        btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
        btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnClear.Location = new System.Drawing.Point(239, 3);
        btnClear.Name = "btnClear";
        btnClear.Radius = 8;
        btnClear.Size = new System.Drawing.Size(112, 75);
        btnClear.TabIndex = 2;
        btnClear.Text = "C";
        // 
        // btnBackspace
        // 
        btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
        btnBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnBackspace.Location = new System.Drawing.Point(357, 3);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Radius = 8;
        btnBackspace.Size = new System.Drawing.Size(112, 75);
        btnBackspace.TabIndex = 3;
        btnBackspace.Text = "⌫";
        // 
        // btnDivide
        // 
        btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
        btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDivide.Location = new System.Drawing.Point(475, 3);
        btnDivide.Name = "btnDivide";
        btnDivide.Radius = 8;
        btnDivide.Size = new System.Drawing.Size(116, 75);
        btnDivide.TabIndex = 4;
        btnDivide.Text = "/";
        // 
        // btnOpenParen
        // 
        btnOpenParen.Dock = System.Windows.Forms.DockStyle.Fill;
        btnOpenParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnOpenParen.Location = new System.Drawing.Point(3, 84);
        btnOpenParen.Name = "btnOpenParen";
        btnOpenParen.Radius = 8;
        btnOpenParen.Size = new System.Drawing.Size(112, 75);
        btnOpenParen.TabIndex = 5;
        btnOpenParen.Text = "(";
        // 
        // btn7
        // 
        btn7.Dock = System.Windows.Forms.DockStyle.Fill;
        btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn7.Location = new System.Drawing.Point(121, 84);
        btn7.Name = "btn7";
        btn7.Radius = 8;
        btn7.Size = new System.Drawing.Size(112, 75);
        btn7.TabIndex = 6;
        btn7.Text = "7";
        // 
        // btn8
        // 
        btn8.Dock = System.Windows.Forms.DockStyle.Fill;
        btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn8.Location = new System.Drawing.Point(239, 84);
        btn8.Name = "btn8";
        btn8.Radius = 8;
        btn8.Size = new System.Drawing.Size(112, 75);
        btn8.TabIndex = 7;
        btn8.Text = "8";
        // 
        // btn9
        // 
        btn9.Dock = System.Windows.Forms.DockStyle.Fill;
        btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn9.Location = new System.Drawing.Point(357, 84);
        btn9.Name = "btn9";
        btn9.Radius = 8;
        btn9.Size = new System.Drawing.Size(112, 75);
        btn9.TabIndex = 8;
        btn9.Text = "9";
        // 
        // btnMultiply
        // 
        btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
        btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMultiply.Location = new System.Drawing.Point(475, 84);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Radius = 8;
        btnMultiply.Size = new System.Drawing.Size(116, 75);
        btnMultiply.TabIndex = 9;
        btnMultiply.Text = "*";
        // 
        // btnCloseParen
        // 
        btnCloseParen.Dock = System.Windows.Forms.DockStyle.Fill;
        btnCloseParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCloseParen.Location = new System.Drawing.Point(3, 165);
        btnCloseParen.Name = "btnCloseParen";
        btnCloseParen.Radius = 8;
        btnCloseParen.Size = new System.Drawing.Size(112, 75);
        btnCloseParen.TabIndex = 10;
        btnCloseParen.Text = ")";
        // 
        // btn4
        // 
        btn4.Dock = System.Windows.Forms.DockStyle.Fill;
        btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn4.Location = new System.Drawing.Point(121, 165);
        btn4.Name = "btn4";
        btn4.Radius = 8;
        btn4.Size = new System.Drawing.Size(112, 75);
        btn4.TabIndex = 11;
        btn4.Text = "4";
        // 
        // btn5
        // 
        btn5.Dock = System.Windows.Forms.DockStyle.Fill;
        btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn5.Location = new System.Drawing.Point(239, 165);
        btn5.Name = "btn5";
        btn5.Radius = 8;
        btn5.Size = new System.Drawing.Size(112, 75);
        btn5.TabIndex = 12;
        btn5.Text = "5";
        // 
        // btn6
        // 
        btn6.Dock = System.Windows.Forms.DockStyle.Fill;
        btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn6.Location = new System.Drawing.Point(357, 165);
        btn6.Name = "btn6";
        btn6.Radius = 8;
        btn6.Size = new System.Drawing.Size(112, 75);
        btn6.TabIndex = 13;
        btn6.Text = "6";
        // 
        // btnMinus
        // 
        btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
        btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMinus.Location = new System.Drawing.Point(475, 165);
        btnMinus.Name = "btnMinus";
        btnMinus.Radius = 8;
        btnMinus.Size = new System.Drawing.Size(116, 75);
        btnMinus.TabIndex = 14;
        btnMinus.Text = "-";
        // 
        // btnRoot
        // 
        btnRoot.Dock = System.Windows.Forms.DockStyle.Fill;
        btnRoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnRoot.Location = new System.Drawing.Point(3, 246);
        btnRoot.Name = "btnRoot";
        btnRoot.Radius = 8;
        btnRoot.Size = new System.Drawing.Size(112, 75);
        btnRoot.TabIndex = 15;
        btnRoot.Text = "ⁿ√x";
        // 
        // btn1
        // 
        btn1.Dock = System.Windows.Forms.DockStyle.Fill;
        btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn1.Location = new System.Drawing.Point(121, 246);
        btn1.Name = "btn1";
        btn1.Radius = 8;
        btn1.Size = new System.Drawing.Size(112, 75);
        btn1.TabIndex = 16;
        btn1.Text = "1";
        // 
        // btn2
        // 
        btn2.Dock = System.Windows.Forms.DockStyle.Fill;
        btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn2.Location = new System.Drawing.Point(239, 246);
        btn2.Name = "btn2";
        btn2.Radius = 8;
        btn2.Size = new System.Drawing.Size(112, 75);
        btn2.TabIndex = 17;
        btn2.Text = "2";
        // 
        // btn3
        // 
        btn3.Dock = System.Windows.Forms.DockStyle.Fill;
        btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn3.Location = new System.Drawing.Point(357, 246);
        btn3.Name = "btn3";
        btn3.Radius = 8;
        btn3.Size = new System.Drawing.Size(112, 75);
        btn3.TabIndex = 18;
        btn3.Text = "3";
        // 
        // btnPlus
        // 
        btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
        btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnPlus.Location = new System.Drawing.Point(475, 246);
        btnPlus.Name = "btnPlus";
        btnPlus.Radius = 8;
        btnPlus.Size = new System.Drawing.Size(116, 75);
        btnPlus.TabIndex = 19;
        btnPlus.Text = "+";
        // 
        // btnPower
        // 
        btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
        btnPower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnPower.Location = new System.Drawing.Point(3, 327);
        btnPower.Name = "btnPower";
        btnPower.Radius = 8;
        btnPower.Size = new System.Drawing.Size(112, 78);
        btnPower.TabIndex = 20;
        btnPower.Text = "xʸ";
        // 
        // btn0
        // 
        btn0.Dock = System.Windows.Forms.DockStyle.Fill;
        btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn0.Location = new System.Drawing.Point(121, 327);
        btn0.Name = "btn0";
        btn0.Radius = 8;
        btn0.Size = new System.Drawing.Size(112, 78);
        btn0.TabIndex = 21;
        btn0.Text = "0";
        // 
        // btnDot
        // 
        btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
        btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDot.Location = new System.Drawing.Point(239, 327);
        btnDot.Name = "btnDot";
        btnDot.Radius = 8;
        btnDot.Size = new System.Drawing.Size(112, 78);
        btnDot.TabIndex = 22;
        btnDot.Text = ".";
        // 
        // btnComma
        // 
        btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
        btnComma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnComma.Location = new System.Drawing.Point(357, 327);
        btnComma.Name = "btnComma";
        btnComma.Radius = 8;
        btnComma.Size = new System.Drawing.Size(112, 78);
        btnComma.TabIndex = 23;
        btnComma.Text = ",";
        // 
        // btnEqual
        // 
        btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
        btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnEqual.Location = new System.Drawing.Point(475, 327);
        btnEqual.Name = "btnEqual";
        btnEqual.Radius = 8;
        btnEqual.Size = new System.Drawing.Size(116, 78);
        btnEqual.TabIndex = 24;
        btnEqual.Text = "=";
        btnEqual.Type = AntdUI.TTypeMini.Primary;
        // 
        // pnlCalcDisplay
        // 
        pnlCalcDisplay.BackColor = System.Drawing.Color.Transparent;
        pnlCalcDisplay.Controls.Add(lblCalcResult);
        pnlCalcDisplay.Controls.Add(txtCalcExpression);
        pnlCalcDisplay.Dock = System.Windows.Forms.DockStyle.Top;
        pnlCalcDisplay.Location = new System.Drawing.Point(0, 0);
        pnlCalcDisplay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
        pnlCalcDisplay.Name = "pnlCalcDisplay";
        pnlCalcDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
        pnlCalcDisplay.Size = new System.Drawing.Size(594, 168);
        pnlCalcDisplay.TabIndex = 0;
        // 
        // lblCalcResult
        // 
        lblCalcResult.Dock = System.Windows.Forms.DockStyle.Fill;
        lblCalcResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblCalcResult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
        lblCalcResult.Location = new System.Drawing.Point(0, 90);
        lblCalcResult.Name = "lblCalcResult";
        lblCalcResult.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
        lblCalcResult.Size = new System.Drawing.Size(594, 74);
        lblCalcResult.TabIndex = 1;
        lblCalcResult.Text = "";
        lblCalcResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        // 
        // txtCalcExpression
        // 
        txtCalcExpression.AutoScroll = true;
        txtCalcExpression.Dock = System.Windows.Forms.DockStyle.Top;
        txtCalcExpression.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        txtCalcExpression.HideSelection = false;
        txtCalcExpression.Location = new System.Drawing.Point(0, 0);
        txtCalcExpression.LostFocusClearSelection = false;
        txtCalcExpression.Name = "txtCalcExpression";
        txtCalcExpression.PlaceholderText = "Bấm phím trên bàn phím máy tính...";
        txtCalcExpression.Radius = 8;
        txtCalcExpression.ReadOnly = true;
        txtCalcExpression.Size = new System.Drawing.Size(594, 90);
        txtCalcExpression.TabIndex = 0;
        // 
        // pnlHistory
        // 
        pnlHistory.BackColor = System.Drawing.Color.White;
        pnlHistory.Controls.Add(pnlHistoryList);
        pnlHistory.Controls.Add(pnlHistoryHeader);
        pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlHistory.Location = new System.Drawing.Point(622, 12);
        pnlHistory.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
        pnlHistory.Name = "pnlHistory";
        pnlHistory.Padding = new System.Windows.Forms.Padding(12);
        pnlHistory.Size = new System.Drawing.Size(346, 576);
        pnlHistory.TabIndex = 1;
        // 
        // pnlHistoryList
        // 
        pnlHistoryList.AutoScroll = true;
        pnlHistoryList.BackColor = System.Drawing.Color.Transparent;
        pnlHistoryList.Controls.Add(lblEmptyHistory);
        pnlHistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlHistoryList.Location = new System.Drawing.Point(12, 52);
        pnlHistoryList.Name = "pnlHistoryList";
        pnlHistoryList.Padding = new System.Windows.Forms.Padding(0, 4, 2, 4);
        pnlHistoryList.Size = new System.Drawing.Size(322, 512);
        pnlHistoryList.TabIndex = 1;
        // 
        // lblEmptyHistory
        // 
        lblEmptyHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        lblEmptyHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
        lblEmptyHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)140)), ((int)((byte)140)), ((int)((byte)140)));
        lblEmptyHistory.Location = new System.Drawing.Point(0, 4);
        lblEmptyHistory.Name = "lblEmptyHistory";
        lblEmptyHistory.Size = new System.Drawing.Size(320, 504);
        lblEmptyHistory.TabIndex = 0;
        lblEmptyHistory.Text = "Chưa có lịch sử phép tính nào";
        lblEmptyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pnlHistoryHeader
        // 
        pnlHistoryHeader.BackColor = System.Drawing.Color.Transparent;
        pnlHistoryHeader.Controls.Add(btnClearHistory);
        pnlHistoryHeader.Controls.Add(lblHistoryTitle);
        pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHistoryHeader.Location = new System.Drawing.Point(12, 12);
        pnlHistoryHeader.Name = "pnlHistoryHeader";
        pnlHistoryHeader.Size = new System.Drawing.Size(322, 40);
        pnlHistoryHeader.TabIndex = 0;
        // 
        // btnClearHistory
        // 
        btnClearHistory.Dock = System.Windows.Forms.DockStyle.Right;
        btnClearHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnClearHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)244)), ((int)((byte)67)), ((int)((byte)54)));
        btnClearHistory.Location = new System.Drawing.Point(232, 0);
        btnClearHistory.Name = "btnClearHistory";
        btnClearHistory.Size = new System.Drawing.Size(90, 40);
        btnClearHistory.TabIndex = 1;
        btnClearHistory.Text = "Xóa tất cả";
        // 
        // lblHistoryTitle
        // 
        lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Left;
        lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
        lblHistoryTitle.Location = new System.Drawing.Point(0, 0);
        lblHistoryTitle.Name = "lblHistoryTitle";
        lblHistoryTitle.Size = new System.Drawing.Size(180, 40);
        lblHistoryTitle.TabIndex = 0;
        lblHistoryTitle.Text = "Lịch sử phép tính";
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(980, 600);
        Controls.Add(tableRoot);
        MinimumSize = new System.Drawing.Size(880, 580);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Mini Calculator";
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
