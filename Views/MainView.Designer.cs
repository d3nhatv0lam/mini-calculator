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
        label1 = new AntdUI.Label();
        txtCalcExpression = new AntdUI.Input();
        lblCalcResult = new AntdUI.Label();

        // Row 0
        btnLeft = new AntdUI.Button();
        btnRight = new AntdUI.Button();
        btnClear = new AntdUI.Button();
        btnDeleteForward = new AntdUI.Button();
        btnBackspace = new AntdUI.Button();

        // Row 1
        btnOpenParen = new AntdUI.Button();
        btn7 = new AntdUI.Button();
        btn8 = new AntdUI.Button();
        btn9 = new AntdUI.Button();
        btnDivide = new AntdUI.Button();

        // Row 2
        btnCloseParen = new AntdUI.Button();
        btn4 = new AntdUI.Button();
        btn5 = new AntdUI.Button();
        btn6 = new AntdUI.Button();
        btnMultiply = new AntdUI.Button();

        // Row 3
        btnRoot = new AntdUI.Button();
        btn1 = new AntdUI.Button();
        btn2 = new AntdUI.Button();
        btn3 = new AntdUI.Button();
        btnMinus = new AntdUI.Button();

        // Row 4
        btnPower = new AntdUI.Button();
        btn0 = new AntdUI.Button();
        btnDot = new AntdUI.Button();
        btnEqual = new AntdUI.Button();
        btnPlus = new AntdUI.Button();

        SuspendLayout();

        // 
        // txtCalcExpression
        // 
        txtCalcExpression.Font = new System.Drawing.Font("Segoe UI", 13F);
        txtCalcExpression.Location = new System.Drawing.Point(60, 20);
        txtCalcExpression.Name = "txtCalcExpression";
        txtCalcExpression.PlaceholderText = "Biểu thức: (ví dụ: (8 + 2) * 5)";
        txtCalcExpression.Radius = 8;
        txtCalcExpression.Size = new System.Drawing.Size(473, 42);
        txtCalcExpression.TabIndex = 0;

        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10F);
        label1.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
        label1.Location = new System.Drawing.Point(62, 70);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(470, 24);
        label1.TabIndex = 22;
        label1.Text = "Kết quả phân giải & tính toán:";

        // 
        // lblCalcResult
        // 
        lblCalcResult.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblCalcResult.ForeColor = System.Drawing.Color.FromArgb(38, 38, 38);
        lblCalcResult.Location = new System.Drawing.Point(62, 98);
        lblCalcResult.Name = "lblCalcResult";
        lblCalcResult.Size = new System.Drawing.Size(470, 42);
        lblCalcResult.TabIndex = 1;
        lblCalcResult.Text = "";
        lblCalcResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;

        // 
        // Row 0 Controls
        // 
        // btnLeft
        btnLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnLeft.Location = new System.Drawing.Point(60, 150);
        btnLeft.Name = "btnLeft";
        btnLeft.Radius = 8;
        btnLeft.Size = new System.Drawing.Size(85, 46);
        btnLeft.TabIndex = 2;
        btnLeft.Text = "←";

        // btnRight
        btnRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnRight.Location = new System.Drawing.Point(157, 150);
        btnRight.Name = "btnRight";
        btnRight.Radius = 8;
        btnRight.Size = new System.Drawing.Size(85, 46);
        btnRight.TabIndex = 3;
        btnRight.Text = "→";

        // btnClear
        btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnClear.Location = new System.Drawing.Point(254, 150);
        btnClear.Name = "btnClear";
        btnClear.Radius = 8;
        btnClear.Size = new System.Drawing.Size(85, 46);
        btnClear.TabIndex = 4;
        btnClear.Text = "C";

        // btnDeleteForward
        btnDeleteForward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDeleteForward.Location = new System.Drawing.Point(351, 150);
        btnDeleteForward.Name = "btnDeleteForward";
        btnDeleteForward.Radius = 8;
        btnDeleteForward.Size = new System.Drawing.Size(85, 46);
        btnDeleteForward.TabIndex = 5;
        btnDeleteForward.Text = "Del";

        // btnBackspace
        btnBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnBackspace.Location = new System.Drawing.Point(448, 150);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Radius = 8;
        btnBackspace.Size = new System.Drawing.Size(85, 46);
        btnBackspace.TabIndex = 6;
        btnBackspace.Text = "⌫";

        // 
        // Row 1 Controls
        // 
        // btnOpenParen
        btnOpenParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnOpenParen.Location = new System.Drawing.Point(60, 208);
        btnOpenParen.Name = "btnOpenParen";
        btnOpenParen.Radius = 8;
        btnOpenParen.Size = new System.Drawing.Size(85, 46);
        btnOpenParen.TabIndex = 7;
        btnOpenParen.Text = "(";

        // btn7
        btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn7.Location = new System.Drawing.Point(157, 208);
        btn7.Name = "btn7";
        btn7.Radius = 8;
        btn7.Size = new System.Drawing.Size(85, 46);
        btn7.TabIndex = 8;
        btn7.Text = "7";

        // btn8
        btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn8.Location = new System.Drawing.Point(254, 208);
        btn8.Name = "btn8";
        btn8.Radius = 8;
        btn8.Size = new System.Drawing.Size(85, 46);
        btn8.TabIndex = 9;
        btn8.Text = "8";

        // btn9
        btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn9.Location = new System.Drawing.Point(351, 208);
        btn9.Name = "btn9";
        btn9.Radius = 8;
        btn9.Size = new System.Drawing.Size(85, 46);
        btn9.TabIndex = 10;
        btn9.Text = "9";

        // btnDivide
        btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDivide.Location = new System.Drawing.Point(448, 208);
        btnDivide.Name = "btnDivide";
        btnDivide.Radius = 8;
        btnDivide.Size = new System.Drawing.Size(85, 46);
        btnDivide.TabIndex = 11;
        btnDivide.Text = "/";

        // 
        // Row 2 Controls
        // 
        // btnCloseParen
        btnCloseParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCloseParen.Location = new System.Drawing.Point(60, 266);
        btnCloseParen.Name = "btnCloseParen";
        btnCloseParen.Radius = 8;
        btnCloseParen.Size = new System.Drawing.Size(85, 46);
        btnCloseParen.TabIndex = 12;
        btnCloseParen.Text = ")";

        // btn4
        btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn4.Location = new System.Drawing.Point(157, 266);
        btn4.Name = "btn4";
        btn4.Radius = 8;
        btn4.Size = new System.Drawing.Size(85, 46);
        btn4.TabIndex = 13;
        btn4.Text = "4";

        // btn5
        btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn5.Location = new System.Drawing.Point(254, 266);
        btn5.Name = "btn5";
        btn5.Radius = 8;
        btn5.Size = new System.Drawing.Size(85, 46);
        btn5.TabIndex = 14;
        btn5.Text = "5";

        // btn6
        btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn6.Location = new System.Drawing.Point(351, 266);
        btn6.Name = "btn6";
        btn6.Radius = 8;
        btn6.Size = new System.Drawing.Size(85, 46);
        btn6.TabIndex = 15;
        btn6.Text = "6";

        // btnMultiply
        btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMultiply.Location = new System.Drawing.Point(448, 266);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Radius = 8;
        btnMultiply.Size = new System.Drawing.Size(85, 46);
        btnMultiply.TabIndex = 16;
        btnMultiply.Text = "*";

        // 
        // Row 3 Controls
        // 
        // btnRoot
        btnRoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnRoot.Location = new System.Drawing.Point(60, 324);
        btnRoot.Name = "btnRoot";
        btnRoot.Radius = 8;
        btnRoot.Size = new System.Drawing.Size(85, 46);
        btnRoot.TabIndex = 17;
        btnRoot.Text = "ⁿ√x";

        // btn1
        btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn1.Location = new System.Drawing.Point(157, 324);
        btn1.Name = "btn1";
        btn1.Radius = 8;
        btn1.Size = new System.Drawing.Size(85, 46);
        btn1.TabIndex = 18;
        btn1.Text = "1";

        // btn2
        btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn2.Location = new System.Drawing.Point(254, 324);
        btn2.Name = "btn2";
        btn2.Radius = 8;
        btn2.Size = new System.Drawing.Size(85, 46);
        btn2.TabIndex = 19;
        btn2.Text = "2";

        // btn3
        btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn3.Location = new System.Drawing.Point(351, 324);
        btn3.Name = "btn3";
        btn3.Radius = 8;
        btn3.Size = new System.Drawing.Size(85, 46);
        btn3.TabIndex = 20;
        btn3.Text = "3";

        // btnMinus
        btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMinus.Location = new System.Drawing.Point(448, 324);
        btnMinus.Name = "btnMinus";
        btnMinus.Radius = 8;
        btnMinus.Size = new System.Drawing.Size(85, 46);
        btnMinus.TabIndex = 21;
        btnMinus.Text = "-";

        // 
        // Row 4 Controls
        // 
        // btnPower
        btnPower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnPower.Location = new System.Drawing.Point(60, 382);
        btnPower.Name = "btnPower";
        btnPower.Radius = 8;
        btnPower.Size = new System.Drawing.Size(85, 46);
        btnPower.TabIndex = 22;
        btnPower.Text = "xʸ";

        // btn0
        btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn0.Location = new System.Drawing.Point(157, 382);
        btn0.Name = "btn0";
        btn0.Radius = 8;
        btn0.Size = new System.Drawing.Size(85, 46);
        btn0.TabIndex = 23;
        btn0.Text = "0";

        // btnDot
        btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDot.Location = new System.Drawing.Point(254, 382);
        btnDot.Name = "btnDot";
        btnDot.Radius = 8;
        btnDot.Size = new System.Drawing.Size(85, 46);
        btnDot.TabIndex = 24;
        btnDot.Text = ".";

        // btnEqual
        btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnEqual.Location = new System.Drawing.Point(351, 382);
        btnEqual.Name = "btnEqual";
        btnEqual.Radius = 8;
        btnEqual.Size = new System.Drawing.Size(85, 46);
        btnEqual.TabIndex = 25;
        btnEqual.Text = "=";
        btnEqual.Type = AntdUI.TTypeMini.Primary;

        // btnPlus
        btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnPlus.Location = new System.Drawing.Point(448, 382);
        btnPlus.Name = "btnPlus";
        btnPlus.Radius = 8;
        btnPlus.Size = new System.Drawing.Size(85, 46);
        btnPlus.TabIndex = 26;
        btnPlus.Text = "+";

        // 
        // MainView Form Setup
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(595, 460);

        Controls.Add(label1);
        Controls.Add(txtCalcExpression);
        Controls.Add(lblCalcResult);

        Controls.Add(btnLeft);
        Controls.Add(btnRight);
        Controls.Add(btnClear);
        Controls.Add(btnDeleteForward);
        Controls.Add(btnBackspace);

        Controls.Add(btnOpenParen);
        Controls.Add(btn7);
        Controls.Add(btn8);
        Controls.Add(btn9);
        Controls.Add(btnDivide);

        Controls.Add(btnCloseParen);
        Controls.Add(btn4);
        Controls.Add(btn5);
        Controls.Add(btn6);
        Controls.Add(btnMultiply);

        Controls.Add(btnRoot);
        Controls.Add(btn1);
        Controls.Add(btn2);
        Controls.Add(btn3);
        Controls.Add(btnMinus);

        Controls.Add(btnPower);
        Controls.Add(btn0);
        Controls.Add(btnDot);
        Controls.Add(btnEqual);
        Controls.Add(btnPlus);

        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Phân giải và tính toán biểu thức số học";

        ResumeLayout(false);
    }

    private AntdUI.Input txtCalcExpression;
    private AntdUI.Label label1;
    private AntdUI.Label lblCalcResult;

    // Row 0
    private AntdUI.Button btnLeft;
    private AntdUI.Button btnRight;
    private AntdUI.Button btnClear;
    private AntdUI.Button btnDeleteForward;
    private AntdUI.Button btnBackspace;

    // Row 1
    private AntdUI.Button btnOpenParen;
    private AntdUI.Button btn7;
    private AntdUI.Button btn8;
    private AntdUI.Button btn9;
    private AntdUI.Button btnDivide;

    // Row 2
    private AntdUI.Button btnCloseParen;
    private AntdUI.Button btn4;
    private AntdUI.Button btn5;
    private AntdUI.Button btn6;
    private AntdUI.Button btnMultiply;

    // Row 3
    private AntdUI.Button btnRoot;
    private AntdUI.Button btn1;
    private AntdUI.Button btn2;
    private AntdUI.Button btn3;
    private AntdUI.Button btnMinus;

    // Row 4
    private AntdUI.Button btnPower;
    private AntdUI.Button btn0;
    private AntdUI.Button btnDot;
    private AntdUI.Button btnEqual;
    private AntdUI.Button btnPlus;

    #endregion
}
