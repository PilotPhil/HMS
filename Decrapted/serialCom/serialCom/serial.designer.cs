namespace serialCom
{
    partial class serial
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_autoSend = new System.Windows.Forms.NumericUpDown();
            this.checkBox_timerSend = new System.Windows.Forms.CheckBox();
            this.checkBox_HexSend = new System.Windows.Forms.CheckBox();
            this.checkBox_HexReceive = new System.Windows.Forms.CheckBox();
            this.btn_clearReceive = new System.Windows.Forms.Button();
            this.btn_clearSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cb_comName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_openSerial = new System.Windows.Forms.Button();
            this.cb_braudt = new System.Windows.Forms.ComboBox();
            this.cb_dataBits = new System.Windows.Forms.ComboBox();
            this.cb_checkBit = new System.Windows.Forms.ComboBox();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_send = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_receive = new System.Windows.Forms.RichTextBox();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoSend)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            this.groupBox4.Location = new System.Drawing.Point(531, 226);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(342, 113);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "辅助";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_autoSend, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_timerSend, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_HexSend, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_HexReceive, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_clearReceive, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btn_clearSend, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(336, 91);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // numericUpDown_autoSend
            // 
            this.numericUpDown_autoSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_autoSend.Location = new System.Drawing.Point(171, 32);
            this.numericUpDown_autoSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_autoSend.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_autoSend.Name = "numericUpDown_autoSend";
            this.numericUpDown_autoSend.Size = new System.Drawing.Size(162, 25);
            this.numericUpDown_autoSend.TabIndex = 10;
            this.numericUpDown_autoSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_autoSend.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_timerSend
            // 
            this.checkBox_timerSend.AutoSize = true;
            this.checkBox_timerSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_timerSend.Location = new System.Drawing.Point(3, 32);
            this.checkBox_timerSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_timerSend.Name = "checkBox_timerSend";
            this.checkBox_timerSend.Size = new System.Drawing.Size(162, 26);
            this.checkBox_timerSend.TabIndex = 8;
            this.checkBox_timerSend.Text = "定时发送(ms)";
            this.checkBox_timerSend.UseVisualStyleBackColor = true;
            // 
            // checkBox_HexSend
            // 
            this.checkBox_HexSend.AutoSize = true;
            this.checkBox_HexSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_HexSend.Location = new System.Drawing.Point(3, 2);
            this.checkBox_HexSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HexSend.Name = "checkBox_HexSend";
            this.checkBox_HexSend.Size = new System.Drawing.Size(162, 26);
            this.checkBox_HexSend.TabIndex = 0;
            this.checkBox_HexSend.Text = "Hex发送";
            this.checkBox_HexSend.UseVisualStyleBackColor = true;
            // 
            // checkBox_HexReceive
            // 
            this.checkBox_HexReceive.AutoSize = true;
            this.checkBox_HexReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_HexReceive.Location = new System.Drawing.Point(171, 2);
            this.checkBox_HexReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HexReceive.Name = "checkBox_HexReceive";
            this.checkBox_HexReceive.Size = new System.Drawing.Size(162, 26);
            this.checkBox_HexReceive.TabIndex = 0;
            this.checkBox_HexReceive.Text = "Hex接收";
            this.checkBox_HexReceive.UseVisualStyleBackColor = true;
            // 
            // btn_clearReceive
            // 
            this.btn_clearReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearReceive.Location = new System.Drawing.Point(3, 62);
            this.btn_clearReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearReceive.Name = "btn_clearReceive";
            this.btn_clearReceive.Size = new System.Drawing.Size(162, 27);
            this.btn_clearReceive.TabIndex = 11;
            this.btn_clearReceive.Text = "清空接收";
            this.btn_clearReceive.UseVisualStyleBackColor = true;
            // 
            // btn_clearSend
            // 
            this.btn_clearSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearSend.Location = new System.Drawing.Point(171, 62);
            this.btn_clearSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearSend.Name = "btn_clearSend";
            this.btn_clearSend.Size = new System.Drawing.Size(162, 27);
            this.btn_clearSend.TabIndex = 11;
            this.btn_clearSend.Text = "清空发送";
            this.btn_clearSend.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(528, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(345, 199);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口配置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29703F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cb_comName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_openSerial, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cb_braudt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_dataBits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_checkBit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_stopBit, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 147);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(94, 28);
            this.progressBar1.TabIndex = 10;
            // 
            // cb_comName
            // 
            this.cb_comName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_comName.FormattingEnabled = true;
            this.cb_comName.Location = new System.Drawing.Point(103, 2);
            this.cb_comName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_comName.Name = "cb_comName";
            this.cb_comName.Size = new System.Drawing.Size(233, 23);
            this.cb_comName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "检验位：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_openSerial
            // 
            this.btn_openSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_openSerial.Location = new System.Drawing.Point(103, 147);
            this.btn_openSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_openSerial.Name = "btn_openSerial";
            this.btn_openSerial.Size = new System.Drawing.Size(233, 28);
            this.btn_openSerial.TabIndex = 4;
            this.btn_openSerial.Text = "开启";
            this.btn_openSerial.UseVisualStyleBackColor = true;
            this.btn_openSerial.Click += new System.EventHandler(this.btn_openSerial_Click);
            // 
            // cb_braudt
            // 
            this.cb_braudt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_braudt.FormattingEnabled = true;
            this.cb_braudt.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000"});
            this.cb_braudt.Location = new System.Drawing.Point(103, 31);
            this.cb_braudt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_braudt.Name = "cb_braudt";
            this.cb_braudt.Size = new System.Drawing.Size(233, 23);
            this.cb_braudt.TabIndex = 2;
            // 
            // cb_dataBits
            // 
            this.cb_dataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_dataBits.FormattingEnabled = true;
            this.cb_dataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_dataBits.Location = new System.Drawing.Point(103, 60);
            this.cb_dataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.Size = new System.Drawing.Size(233, 23);
            this.cb_dataBits.TabIndex = 2;
            // 
            // cb_checkBit
            // 
            this.cb_checkBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_checkBit.FormattingEnabled = true;
            this.cb_checkBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cb_checkBit.Location = new System.Drawing.Point(103, 89);
            this.cb_checkBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.Size = new System.Drawing.Size(233, 23);
            this.cb_checkBit.TabIndex = 2;
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cb_stopBit.Location = new System.Drawing.Point(103, 118);
            this.cb_stopBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(233, 23);
            this.cb_stopBit.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(511, 139);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.02702F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97297F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_send, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(505, 117);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(391, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 113);
            this.button1.TabIndex = 4;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_send
            // 
            this.richTextBox_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_send.Location = new System.Drawing.Point(3, 2);
            this.richTextBox_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_send.Name = "richTextBox_send";
            this.richTextBox_send.Size = new System.Drawing.Size(382, 113);
            this.richTextBox_send.TabIndex = 5;
            this.richTextBox_send.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox_receive);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(511, 326);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送";
            // 
            // richTextBox_receive
            // 
            this.richTextBox_receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_receive.Location = new System.Drawing.Point(3, 20);
            this.richTextBox_receive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_receive.Name = "richTextBox_receive";
            this.richTextBox_receive.Size = new System.Drawing.Size(505, 304);
            this.richTextBox_receive.TabIndex = 3;
            this.richTextBox_receive.Text = "";
            // 
            // serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "serial";
            this.Text = "serial";
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoSend)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown numericUpDown_autoSend;
        private System.Windows.Forms.CheckBox checkBox_timerSend;
        private System.Windows.Forms.CheckBox checkBox_HexSend;
        private System.Windows.Forms.CheckBox checkBox_HexReceive;
        private System.Windows.Forms.Button btn_clearReceive;
        private System.Windows.Forms.Button btn_clearSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cb_comName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_openSerial;
        private System.Windows.Forms.ComboBox cb_braudt;
        private System.Windows.Forms.ComboBox cb_dataBits;
        private System.Windows.Forms.ComboBox cb_checkBit;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_receive;
    }
}