
namespace MarineControl.HMS.Communiction
{
    partial class SerialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialForm));
            this.cb_portName = new HZH_Controls.Controls.UCCombox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_braudt = new HZH_Controls.Controls.UCCombox();
            this.cb_dataBits = new HZH_Controls.Controls.UCCombox();
            this.cb_checkBit = new HZH_Controls.Controls.UCCombox();
            this.cb_stopBit = new HZH_Controls.Controls.UCCombox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_portName
            // 
            this.cb_portName.BackColor = System.Drawing.Color.Transparent;
            this.cb_portName.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_portName.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_portName.ConerRadius = 8;
            this.cb_portName.DropPanelHeight = -1;
            this.cb_portName.FillColor = System.Drawing.Color.White;
            this.cb_portName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_portName.IsRadius = true;
            this.cb_portName.IsShowRect = true;
            this.cb_portName.ItemWidth = 10;
            this.cb_portName.Location = new System.Drawing.Point(74, 5);
            this.cb_portName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_portName.Name = "cb_portName";
            this.cb_portName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_portName.RectWidth = 1;
            this.cb_portName.SelectedIndex = -1;
            this.cb_portName.SelectedValue = "";
            this.cb_portName.Size = new System.Drawing.Size(122, 24);
            this.cb_portName.Source = null;
            this.cb_portName.TabIndex = 5;
            this.cb_portName.TextValue = null;
            this.cb_portName.TriangleColor = System.Drawing.Color.Blue;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "校验位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_braudt
            // 
            this.cb_braudt.BackColor = System.Drawing.Color.Transparent;
            this.cb_braudt.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_braudt.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_braudt.ConerRadius = 8;
            this.cb_braudt.DropPanelHeight = -1;
            this.cb_braudt.FillColor = System.Drawing.Color.White;
            this.cb_braudt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_braudt.IsRadius = true;
            this.cb_braudt.IsShowRect = true;
            this.cb_braudt.ItemWidth = 10;
            this.cb_braudt.Location = new System.Drawing.Point(74, 39);
            this.cb_braudt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_braudt.Name = "cb_braudt";
            this.cb_braudt.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_braudt.RectWidth = 1;
            this.cb_braudt.SelectedIndex = -1;
            this.cb_braudt.SelectedValue = "";
            this.cb_braudt.Size = new System.Drawing.Size(122, 24);
            this.cb_braudt.Source = null;
            this.cb_braudt.TabIndex = 5;
            this.cb_braudt.TextValue = null;
            this.cb_braudt.TriangleColor = System.Drawing.Color.Blue;
            // 
            // cb_dataBits
            // 
            this.cb_dataBits.BackColor = System.Drawing.Color.Transparent;
            this.cb_dataBits.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_dataBits.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_dataBits.ConerRadius = 8;
            this.cb_dataBits.DropPanelHeight = -1;
            this.cb_dataBits.FillColor = System.Drawing.Color.White;
            this.cb_dataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_dataBits.IsRadius = true;
            this.cb_dataBits.IsShowRect = true;
            this.cb_dataBits.ItemWidth = 10;
            this.cb_dataBits.Location = new System.Drawing.Point(74, 73);
            this.cb_dataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_dataBits.RectWidth = 1;
            this.cb_dataBits.SelectedIndex = -1;
            this.cb_dataBits.SelectedValue = "";
            this.cb_dataBits.Size = new System.Drawing.Size(122, 24);
            this.cb_dataBits.Source = null;
            this.cb_dataBits.TabIndex = 5;
            this.cb_dataBits.TextValue = null;
            this.cb_dataBits.TriangleColor = System.Drawing.Color.Blue;
            // 
            // cb_checkBit
            // 
            this.cb_checkBit.BackColor = System.Drawing.Color.Transparent;
            this.cb_checkBit.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_checkBit.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_checkBit.ConerRadius = 8;
            this.cb_checkBit.DropPanelHeight = -1;
            this.cb_checkBit.FillColor = System.Drawing.Color.White;
            this.cb_checkBit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_checkBit.IsRadius = true;
            this.cb_checkBit.IsShowRect = true;
            this.cb_checkBit.ItemWidth = 10;
            this.cb_checkBit.Location = new System.Drawing.Point(74, 107);
            this.cb_checkBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_checkBit.RectWidth = 1;
            this.cb_checkBit.SelectedIndex = -1;
            this.cb_checkBit.SelectedValue = "";
            this.cb_checkBit.Size = new System.Drawing.Size(122, 24);
            this.cb_checkBit.Source = null;
            this.cb_checkBit.TabIndex = 5;
            this.cb_checkBit.TextValue = null;
            this.cb_checkBit.TriangleColor = System.Drawing.Color.Blue;
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.BackColor = System.Drawing.Color.Transparent;
            this.cb_stopBit.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_stopBit.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_stopBit.ConerRadius = 8;
            this.cb_stopBit.DropPanelHeight = -1;
            this.cb_stopBit.FillColor = System.Drawing.Color.White;
            this.cb_stopBit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_stopBit.IsRadius = true;
            this.cb_stopBit.IsShowRect = true;
            this.cb_stopBit.ItemWidth = 10;
            this.cb_stopBit.Location = new System.Drawing.Point(74, 141);
            this.cb_stopBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cb_stopBit.RectWidth = 1;
            this.cb_stopBit.SelectedIndex = -1;
            this.cb_stopBit.SelectedValue = "";
            this.cb_stopBit.Size = new System.Drawing.Size(122, 27);
            this.cb_stopBit.Source = null;
            this.cb_stopBit.TabIndex = 5;
            this.cb_stopBit.TextValue = null;
            this.cb_stopBit.TriangleColor = System.Drawing.Color.Blue;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_checkBit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_braudt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_portName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_dataBits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_stopBit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 174);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(227, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SerialForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCCombox cb_portName;
        private HZH_Controls.Controls.UCCombox cb_braudt;
        private HZH_Controls.Controls.UCCombox cb_dataBits;
        private HZH_Controls.Controls.UCCombox cb_checkBit;
        private HZH_Controls.Controls.UCCombox cb_stopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}