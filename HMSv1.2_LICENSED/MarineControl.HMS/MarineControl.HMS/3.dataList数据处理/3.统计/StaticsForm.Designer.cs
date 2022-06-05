
namespace MarineControl.HMS.Statics
{
    partial class StaticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_max = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_min = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_mean = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_std = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_skw = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_kut = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_zcr = new HZH_Controls.Controls.UCTextBoxEx();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0625F));
            this.tableLayoutPanel1.Controls.Add(this.tb_max, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_min, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_mean, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_std, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_skw, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_kut, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_zcr, 1, 6);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 255);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "最小值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "平均跨零率";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "峭度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "偏度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "平均值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "标准差";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_max
            // 
            this.tb_max.BackColor = System.Drawing.Color.Transparent;
            this.tb_max.ConerRadius = 5;
            this.tb_max.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_max.DecLength = 2;
            this.tb_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_max.FillColor = System.Drawing.Color.Empty;
            this.tb_max.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_max.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_max.InputText = "";
            this.tb_max.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_max.IsFocusColor = true;
            this.tb_max.IsRadius = true;
            this.tb_max.IsShowClearBtn = false;
            this.tb_max.IsShowKeyboard = false;
            this.tb_max.IsShowRect = true;
            this.tb_max.IsShowSearchBtn = false;
            this.tb_max.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_max.Location = new System.Drawing.Point(99, 5);
            this.tb_max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_max.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_max.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_max.Name = "tb_max";
            this.tb_max.Padding = new System.Windows.Forms.Padding(5);
            this.tb_max.PasswordChar = '\0';
            this.tb_max.PromptColor = System.Drawing.Color.Gray;
            this.tb_max.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_max.PromptText = "";
            this.tb_max.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_max.RectWidth = 1;
            this.tb_max.RegexPattern = "";
            this.tb_max.Size = new System.Drawing.Size(162, 26);
            this.tb_max.TabIndex = 9;
            // 
            // tb_min
            // 
            this.tb_min.BackColor = System.Drawing.Color.Transparent;
            this.tb_min.ConerRadius = 5;
            this.tb_min.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_min.DecLength = 2;
            this.tb_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_min.FillColor = System.Drawing.Color.Empty;
            this.tb_min.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_min.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_min.InputText = "";
            this.tb_min.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_min.IsFocusColor = true;
            this.tb_min.IsRadius = true;
            this.tb_min.IsShowClearBtn = false;
            this.tb_min.IsShowKeyboard = false;
            this.tb_min.IsShowRect = true;
            this.tb_min.IsShowSearchBtn = false;
            this.tb_min.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_min.Location = new System.Drawing.Point(99, 41);
            this.tb_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_min.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_min.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_min.Name = "tb_min";
            this.tb_min.Padding = new System.Windows.Forms.Padding(5);
            this.tb_min.PasswordChar = '\0';
            this.tb_min.PromptColor = System.Drawing.Color.Gray;
            this.tb_min.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_min.PromptText = "";
            this.tb_min.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_min.RectWidth = 1;
            this.tb_min.RegexPattern = "";
            this.tb_min.Size = new System.Drawing.Size(162, 26);
            this.tb_min.TabIndex = 9;
            // 
            // tb_mean
            // 
            this.tb_mean.BackColor = System.Drawing.Color.Transparent;
            this.tb_mean.ConerRadius = 5;
            this.tb_mean.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mean.DecLength = 2;
            this.tb_mean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_mean.FillColor = System.Drawing.Color.Empty;
            this.tb_mean.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_mean.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_mean.InputText = "";
            this.tb_mean.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_mean.IsFocusColor = true;
            this.tb_mean.IsRadius = true;
            this.tb_mean.IsShowClearBtn = false;
            this.tb_mean.IsShowKeyboard = false;
            this.tb_mean.IsShowRect = true;
            this.tb_mean.IsShowSearchBtn = false;
            this.tb_mean.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_mean.Location = new System.Drawing.Point(99, 77);
            this.tb_mean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_mean.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_mean.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_mean.Name = "tb_mean";
            this.tb_mean.Padding = new System.Windows.Forms.Padding(5);
            this.tb_mean.PasswordChar = '\0';
            this.tb_mean.PromptColor = System.Drawing.Color.Gray;
            this.tb_mean.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_mean.PromptText = "";
            this.tb_mean.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_mean.RectWidth = 1;
            this.tb_mean.RegexPattern = "";
            this.tb_mean.Size = new System.Drawing.Size(162, 26);
            this.tb_mean.TabIndex = 9;
            // 
            // tb_std
            // 
            this.tb_std.BackColor = System.Drawing.Color.Transparent;
            this.tb_std.ConerRadius = 5;
            this.tb_std.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_std.DecLength = 2;
            this.tb_std.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_std.FillColor = System.Drawing.Color.Empty;
            this.tb_std.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_std.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_std.InputText = "";
            this.tb_std.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_std.IsFocusColor = true;
            this.tb_std.IsRadius = true;
            this.tb_std.IsShowClearBtn = false;
            this.tb_std.IsShowKeyboard = false;
            this.tb_std.IsShowRect = true;
            this.tb_std.IsShowSearchBtn = false;
            this.tb_std.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_std.Location = new System.Drawing.Point(99, 113);
            this.tb_std.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_std.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_std.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_std.Name = "tb_std";
            this.tb_std.Padding = new System.Windows.Forms.Padding(5);
            this.tb_std.PasswordChar = '\0';
            this.tb_std.PromptColor = System.Drawing.Color.Gray;
            this.tb_std.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_std.PromptText = "";
            this.tb_std.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_std.RectWidth = 1;
            this.tb_std.RegexPattern = "";
            this.tb_std.Size = new System.Drawing.Size(162, 26);
            this.tb_std.TabIndex = 9;
            // 
            // tb_skw
            // 
            this.tb_skw.BackColor = System.Drawing.Color.Transparent;
            this.tb_skw.ConerRadius = 5;
            this.tb_skw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_skw.DecLength = 2;
            this.tb_skw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_skw.FillColor = System.Drawing.Color.Empty;
            this.tb_skw.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_skw.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_skw.InputText = "";
            this.tb_skw.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_skw.IsFocusColor = true;
            this.tb_skw.IsRadius = true;
            this.tb_skw.IsShowClearBtn = false;
            this.tb_skw.IsShowKeyboard = false;
            this.tb_skw.IsShowRect = true;
            this.tb_skw.IsShowSearchBtn = false;
            this.tb_skw.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_skw.Location = new System.Drawing.Point(99, 149);
            this.tb_skw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_skw.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_skw.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_skw.Name = "tb_skw";
            this.tb_skw.Padding = new System.Windows.Forms.Padding(5);
            this.tb_skw.PasswordChar = '\0';
            this.tb_skw.PromptColor = System.Drawing.Color.Gray;
            this.tb_skw.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_skw.PromptText = "";
            this.tb_skw.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_skw.RectWidth = 1;
            this.tb_skw.RegexPattern = "";
            this.tb_skw.Size = new System.Drawing.Size(162, 26);
            this.tb_skw.TabIndex = 9;
            // 
            // tb_kut
            // 
            this.tb_kut.BackColor = System.Drawing.Color.Transparent;
            this.tb_kut.ConerRadius = 5;
            this.tb_kut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_kut.DecLength = 2;
            this.tb_kut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_kut.FillColor = System.Drawing.Color.Empty;
            this.tb_kut.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_kut.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_kut.InputText = "";
            this.tb_kut.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_kut.IsFocusColor = true;
            this.tb_kut.IsRadius = true;
            this.tb_kut.IsShowClearBtn = false;
            this.tb_kut.IsShowKeyboard = false;
            this.tb_kut.IsShowRect = true;
            this.tb_kut.IsShowSearchBtn = false;
            this.tb_kut.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_kut.Location = new System.Drawing.Point(99, 185);
            this.tb_kut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_kut.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_kut.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_kut.Name = "tb_kut";
            this.tb_kut.Padding = new System.Windows.Forms.Padding(5);
            this.tb_kut.PasswordChar = '\0';
            this.tb_kut.PromptColor = System.Drawing.Color.Gray;
            this.tb_kut.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_kut.PromptText = "";
            this.tb_kut.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_kut.RectWidth = 1;
            this.tb_kut.RegexPattern = "";
            this.tb_kut.Size = new System.Drawing.Size(162, 26);
            this.tb_kut.TabIndex = 9;
            // 
            // tb_zcr
            // 
            this.tb_zcr.BackColor = System.Drawing.Color.Transparent;
            this.tb_zcr.ConerRadius = 5;
            this.tb_zcr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_zcr.DecLength = 2;
            this.tb_zcr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_zcr.FillColor = System.Drawing.Color.Empty;
            this.tb_zcr.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_zcr.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_zcr.InputText = "";
            this.tb_zcr.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_zcr.IsFocusColor = true;
            this.tb_zcr.IsRadius = true;
            this.tb_zcr.IsShowClearBtn = false;
            this.tb_zcr.IsShowKeyboard = false;
            this.tb_zcr.IsShowRect = true;
            this.tb_zcr.IsShowSearchBtn = false;
            this.tb_zcr.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_zcr.Location = new System.Drawing.Point(99, 221);
            this.tb_zcr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_zcr.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_zcr.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_zcr.Name = "tb_zcr";
            this.tb_zcr.Padding = new System.Windows.Forms.Padding(5);
            this.tb_zcr.PasswordChar = '\0';
            this.tb_zcr.PromptColor = System.Drawing.Color.Gray;
            this.tb_zcr.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_zcr.PromptText = "";
            this.tb_zcr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_zcr.RectWidth = 1;
            this.tb_zcr.RegexPattern = "";
            this.tb_zcr.Size = new System.Drawing.Size(162, 29);
            this.tb_zcr.TabIndex = 9;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCTextBoxEx tb_max;
        private HZH_Controls.Controls.UCTextBoxEx tb_min;
        private HZH_Controls.Controls.UCTextBoxEx tb_mean;
        private HZH_Controls.Controls.UCTextBoxEx tb_std;
        private HZH_Controls.Controls.UCTextBoxEx tb_skw;
        private HZH_Controls.Controls.UCTextBoxEx tb_kut;
        private HZH_Controls.Controls.UCTextBoxEx tb_zcr;
    }
}