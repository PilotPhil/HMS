
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
            this.cb_localIp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_localPort = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_objIp = new System.Windows.Forms.ComboBox();
            this.tb_objPort = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_localIp
            // 
            this.cb_localIp.BackColor = System.Drawing.Color.Gray;
            this.cb_localIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_localIp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_localIp.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_localIp.ForeColor = System.Drawing.Color.White;
            this.cb_localIp.FormattingEnabled = true;
            this.cb_localIp.Location = new System.Drawing.Point(100, 2);
            this.cb_localIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_localIp.Name = "cb_localIp";
            this.cb_localIp.Size = new System.Drawing.Size(173, 26);
            this.cb_localIp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "本地IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "本地端口";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_localPort
            // 
            this.tb_localPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_localPort.BackColor = System.Drawing.Color.Gray;
            this.tb_localPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_localPort.Font = new System.Drawing.Font("黑体", 9F);
            this.tb_localPort.ForeColor = System.Drawing.Color.White;
            this.tb_localPort.Location = new System.Drawing.Point(100, 45);
            this.tb_localPort.Name = "tb_localPort";
            this.tb_localPort.Size = new System.Drawing.Size(173, 21);
            this.tb_localPort.TabIndex = 5;
            this.tb_localPort.Text = "8848";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Gray;
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("黑体", 9F);
            this.btn_connect.Location = new System.Drawing.Point(100, 151);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(173, 34);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "建立连接";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "目标IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "目标端口";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_objIp
            // 
            this.cb_objIp.BackColor = System.Drawing.Color.Gray;
            this.cb_objIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_objIp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_objIp.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_objIp.ForeColor = System.Drawing.Color.White;
            this.cb_objIp.FormattingEnabled = true;
            this.cb_objIp.Location = new System.Drawing.Point(100, 76);
            this.cb_objIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_objIp.Name = "cb_objIp";
            this.cb_objIp.Size = new System.Drawing.Size(173, 26);
            this.cb_objIp.TabIndex = 3;
            // 
            // tb_objPort
            // 
            this.tb_objPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_objPort.BackColor = System.Drawing.Color.Gray;
            this.tb_objPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_objPort.Font = new System.Drawing.Font("黑体", 9F);
            this.tb_objPort.ForeColor = System.Drawing.Color.White;
            this.tb_objPort.Location = new System.Drawing.Point(100, 119);
            this.tb_objPort.Name = "tb_objPort";
            this.tb_objPort.Size = new System.Drawing.Size(173, 21);
            this.tb_objPort.TabIndex = 5;
            this.tb_objPort.Text = "9090";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.17786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.82214F));
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_localIp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_objPort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_objIp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_localPort, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 188);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // UdpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(276, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UdpForm";
            this.Text = "UdpForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_localIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_localPort;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_objIp;
        private System.Windows.Forms.TextBox tb_objPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}