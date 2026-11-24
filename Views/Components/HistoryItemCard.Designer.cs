namespace MiniCalculator.Views.Components;

partial class HistoryItemCard
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

    #region Component Designer generated code

    private void InitializeComponent()
    {
        pnlCard = new AntdUI.Panel();
        pnlBottom = new System.Windows.Forms.Panel();
        lblRes = new System.Windows.Forms.Label();
        lblTime = new System.Windows.Forms.Label();
        lblExpr = new System.Windows.Forms.Label();
        pnlCard.SuspendLayout();
        pnlBottom.SuspendLayout();
        SuspendLayout();
        // 
        // pnlCard
        // 
        pnlCard.Back = System.Drawing.Color.FromArgb(250, 251, 254);
        pnlCard.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        pnlCard.BorderWidth = 1F;
        pnlCard.Controls.Add(pnlBottom);
        pnlCard.Controls.Add(lblExpr);
        pnlCard.Cursor = System.Windows.Forms.Cursors.Hand;
        pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlCard.Location = new System.Drawing.Point(0, 0);
        pnlCard.Name = "pnlCard";
        pnlCard.Padding = new System.Windows.Forms.Padding(10, 8, 10, 6);
        pnlCard.Radius = 6;
        pnlCard.Size = new System.Drawing.Size(300, 72);
        pnlCard.TabIndex = 0;
        // 
        // pnlBottom
        // 
        pnlBottom.BackColor = System.Drawing.Color.Transparent;
        pnlBottom.Controls.Add(lblRes);
        pnlBottom.Controls.Add(lblTime);
        pnlBottom.Cursor = System.Windows.Forms.Cursors.Hand;
        pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBottom.Location = new System.Drawing.Point(10, 34);
        pnlBottom.Name = "pnlBottom";
        pnlBottom.Size = new System.Drawing.Size(280, 32);
        pnlBottom.TabIndex = 1;
        // 
        // lblRes
        // 
        lblRes.AutoSize = true;
        lblRes.BackColor = System.Drawing.Color.Transparent;
        lblRes.Cursor = System.Windows.Forms.Cursors.Hand;
        lblRes.Dock = System.Windows.Forms.DockStyle.Left;
        lblRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblRes.ForeColor = System.Drawing.Color.FromArgb(40, 140, 30);
        lblRes.Location = new System.Drawing.Point(0, 0);
        lblRes.Name = "lblRes";
        lblRes.Size = new System.Drawing.Size(46, 19);
        lblRes.TabIndex = 0;
        lblRes.Text = "= 182";
        // 
        // lblTime
        // 
        lblTime.AutoSize = true;
        lblTime.BackColor = System.Drawing.Color.Transparent;
        lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTime.Dock = System.Windows.Forms.DockStyle.Right;
        lblTime.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblTime.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        lblTime.Location = new System.Drawing.Point(232, 0);
        lblTime.Name = "lblTime";
        lblTime.Size = new System.Drawing.Size(48, 15);
        lblTime.TabIndex = 1;
        lblTime.Text = "10:00:00";
        // 
        // lblExpr
        // 
        lblExpr.AutoEllipsis = true;
        lblExpr.BackColor = System.Drawing.Color.Transparent;
        lblExpr.Cursor = System.Windows.Forms.Cursors.Hand;
        lblExpr.Dock = System.Windows.Forms.DockStyle.Top;
        lblExpr.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblExpr.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblExpr.Location = new System.Drawing.Point(10, 8);
        lblExpr.Name = "lblExpr";
        lblExpr.Size = new System.Drawing.Size(280, 26);
        lblExpr.TabIndex = 0;
        lblExpr.Text = "12 + 34 * 5";
        // 
        // HistoryItemCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Transparent;
        Controls.Add(pnlCard);
        Dock = System.Windows.Forms.DockStyle.Top;
        Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
        Name = "HistoryItemCard";
        Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
        Size = new System.Drawing.Size(300, 78);
        pnlCard.ResumeLayout(false);
        pnlBottom.ResumeLayout(false);
        pnlBottom.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Panel pnlCard;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.Label lblRes;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Label lblExpr;
}
