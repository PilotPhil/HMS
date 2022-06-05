
namespace MarineControl.HMS.Communiction
{
    partial class UdpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_objPort = new HZH_Controls.Controls.UCTextBoxEx();
            this.cb_objIp = new HZH_Controls.Controls.UCCombox();
            this.tb_localPort = new HZH_Controls.Controls.UCTextBoxEx();
            this.cb_localIp = new HZH_Controls.Controls.UCCombox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "本地IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "本地端口";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "目标IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "目标端口";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_objPort
            // 
            this.tb_objPort.BackColor = System.Drawing.Color.Transparent;
            this.tb_objPort.ConerRadius = 5;
            this.tb_objPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_objPort.DecLength = 2;
            this.tb_objPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_objPort.FillColor = System.Drawing.Color.Empty;
            this.tb_objPort.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_objPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_objPort.InputText = "8848";
            this.tb_objPort.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_objPort.IsFocusColor = true;
            this.tb_objPort.IsRadius = true;
            this.tb_objPort.IsShowClearBtn = true;
            this.tb_objPort.IsShowKeyboard = true;
            this.tb_objPort.IsShowRect = true;
            this.tb_objPort.IsShowSearchBtn = false;
            this.tb_objPort.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.tb_objPort.Location = new System.Drawing.Point(75, 142);
            this.tb_objPort.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_objPort.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_objPort.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_objPort.Name = "tb_objPort";
            this.tb_objPort.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_objPort.PasswordChar = '\0';
            this.tb_objPort.PromptColor = System.Drawing.Color.Gray;
            this.tb_objPort.PromptFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_objPort.PromptText = "";
            this.tb_objPort.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_objPort.RectWidth = 1;
            this.tb_objPort.RegexPattern = "";
            this.tb_objPort.Size = new System.Drawing.Size(193, 32);
            this.tb_objPort.TabIndex = 8;
            // 
            // cb_objIp
            // 
            this.cb_objIp.BackColor = System.Drawing.Color.Transparent;
            this.cb_objIp.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_objIp.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_objIp.ConerRadius = 8;
            this.cb_objIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_objIp.DropPanelHeight = -1;
            this.cb_objIp.FillColor = System.Drawing.Color.White;
            this.cb_objIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_objIp.IsRadius = true;
            this.cb_objIp.IsShowRect = true;
            this.cb_objIp.ItemWidth = 70;
            this.cb_objIp.Location = new System.Drawing.Point(75, 97);
            this.cb_objIp.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cb_objIp.Name = "cb_objIp";
            this.cb_objIp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_objIp.RectWidth = 1;
            this.cb_objIp.SelectedIndex = -1;
            this.cb_objIp.SelectedValue = "";
            this.cb_objIp.Size = new System.Drawing.Size(193, 31);
            this.cb_objIp.Source = null;
            this.cb_objIp.TabIndex = 8;
            this.cb_objIp.TextValue = null;
            this.cb_objIp.TriangleColor = System.Drawing.Color.Blue;
            // 
            // tb_localPort
            // 
            this.tb_localPort.BackColor = System.Drawing.Color.Transparent;
            this.tb_localPort.ConerRadius = 5;
            this.tb_localPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_localPort.DecLength = 2;
            this.tb_localPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_localPort.FillColor = System.Drawing.Color.Empty;
            this.tb_localPort.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_localPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_localPort.InputText = "9090";
            this.tb_localPort.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_localPort.IsFocusColor = true;
            this.tb_localPort.IsRadius = true;
            this.tb_localPort.IsShowClearBtn = true;
            this.tb_localPort.IsShowKeyboard = true;
            this.tb_localPort.IsShowRect = true;
            this.tb_localPort.IsShowSearchBtn = false;
            this.tb_localPort.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.tb_localPort.Location = new System.Drawing.Point(75, 52);
            this.tb_localPort.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_localPort.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_localPort.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_localPort.Name = "tb_localPort";
            this.tb_localPort.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_localPort.PasswordChar = '\0';
            this.tb_localPort.PromptColor = System.Drawing.Color.Gray;
            this.tb_localPort.PromptFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_localPort.PromptText = "";
            this.tb_localPort.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_localPort.RectWidth = 1;
            this.tb_localPort.RegexPattern = "";
            this.tb_localPort.Size = new System.Drawing.Size(193, 31);
            this.tb_localPort.TabIndex = 8;
            // 
            // cb_localIp
            // 
            this.cb_localIp.BackColor = System.Drawing.Color.Transparent;
            this.cb_localIp.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_localIp.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_localIp.ConerRadius = 8;
            this.cb_localIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_localIp.DropPanelHeight = -1;
            this.cb_localIp.FillColor = System.Drawing.Color.White;
            this.cb_localIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_localIp.IsRadius = true;
            this.cb_localIp.IsShowRect = true;
            this.cb_localIp.ItemWidth = 70;
            this.cb_localIp.Location = new System.Drawing.Point(75, 7);
            this.cb_localIp.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cb_localIp.Name = "cb_localIp";
            this.cb_localIp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_localIp.RectWidth = 1;
            this.cb_localIp.SelectedIndex = -1;
            this.cb_localIp.SelectedValue = "";
            this.cb_localIp.Size = new System.Drawing.Size(193, 31);
            this.cb_localIp.Source = null;
            this.cb_localIp.TabIndex = 8;
            this.cb_localIp.TextValue = null;
            this.cb_localIp.TriangleColor = System.Drawing.Color.Blue;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.Controls.Add(this.tb_objPort, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_localPort, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_objIp, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_localIp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 181);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // UdpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 296);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UdpForm";
            this.Text = "UdpForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCCombox cb_localIp;
        private HZH_Controls.Controls.UCCombox cb_objIp;
        private HZH_Controls.Controls.UCTextBoxEx tb_localPort;
        private HZH_Controls.Controls.UCTextBoxEx tb_objPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}