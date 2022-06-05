
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
            this.btn_sendSerialMsg = new System.Windows.Forms.Button();
            this.cb_comName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_braudt = new System.Windows.Forms.ComboBox();
            this.cb_dataBits = new System.Windows.Forms.ComboBox();
            this.cb_checkBit = new System.Windows.Forms.ComboBox();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.btn_openSerial = new System.Windows.Forms.Button();
            this.label_IsOpen = new System.Windows.Forms.Label();
            this.btn_clearReceive = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_clearSend = new System.Windows.Forms.Button();
            this.checkBox_HexSend = new System.Windows.Forms.CheckBox();
            this.checkBox_HexReceive = new System.Windows.Forms.CheckBox();
            this.checkBox_timerSend = new System.Windows.Forms.CheckBox();
            this.textBox_autoSendTime = new System.Windows.Forms.TextBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sendSerialMsg
            // 
            this.btn_sendSerialMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sendSerialMsg.FlatAppearance.BorderSize = 0;
            this.btn_sendSerialMsg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sendSerialMsg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sendSerialMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendSerialMsg.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sendSerialMsg.ForeColor = System.Drawing.Color.White;
            this.btn_sendSerialMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendSerialMsg.Location = new System.Drawing.Point(689, 541);
            this.btn_sendSerialMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sendSerialMsg.Name = "btn_sendSerialMsg";
            this.btn_sendSerialMsg.Size = new System.Drawing.Size(66, 41);
            this.btn_sendSerialMsg.TabIndex = 4;
            this.btn_sendSerialMsg.Text = "发送";
            this.btn_sendSerialMsg.UseVisualStyleBackColor = false;
            this.btn_sendSerialMsg.Click += new System.EventHandler(this.btn_sendSerialMsg_Click);
            // 
            // cb_comName
            // 
            this.cb_comName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_comName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_comName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_comName.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_comName.ForeColor = System.Drawing.Color.White;
            this.cb_comName.FormattingEnabled = true;
            this.cb_comName.Location = new System.Drawing.Point(111, 2);
            this.cb_comName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_comName.Name = "cb_comName";
            this.cb_comName.Size = new System.Drawing.Size(189, 26);
            this.cb_comName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.92233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.07767F));
            this.tableLayoutPanel1.Controls.Add(this.cb_comName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_braudt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_dataBits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_checkBit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_stopBit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_openSerial, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_IsOpen, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.84158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "检验位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_braudt
            // 
            this.cb_braudt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_braudt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_braudt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_braudt.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_braudt.ForeColor = System.Drawing.Color.White;
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
            this.cb_braudt.Location = new System.Drawing.Point(111, 42);
            this.cb_braudt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_braudt.Name = "cb_braudt";
            this.cb_braudt.Size = new System.Drawing.Size(189, 26);
            this.cb_braudt.TabIndex = 2;
            // 
            // cb_dataBits
            // 
            this.cb_dataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_dataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_dataBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_dataBits.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_dataBits.ForeColor = System.Drawing.Color.White;
            this.cb_dataBits.FormattingEnabled = true;
            this.cb_dataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_dataBits.Location = new System.Drawing.Point(111, 82);
            this.cb_dataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.Size = new System.Drawing.Size(189, 26);
            this.cb_dataBits.TabIndex = 2;
            // 
            // cb_checkBit
            // 
            this.cb_checkBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_checkBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_checkBit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_checkBit.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_checkBit.ForeColor = System.Drawing.Color.White;
            this.cb_checkBit.FormattingEnabled = true;
            this.cb_checkBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cb_checkBit.Location = new System.Drawing.Point(111, 120);
            this.cb_checkBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.Size = new System.Drawing.Size(189, 26);
            this.cb_checkBit.TabIndex = 2;
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_stopBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stopBit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_stopBit.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_stopBit.ForeColor = System.Drawing.Color.White;
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cb_stopBit.Location = new System.Drawing.Point(111, 161);
            this.cb_stopBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(189, 26);
            this.cb_stopBit.TabIndex = 2;
            // 
            // btn_openSerial
            // 
            this.btn_openSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_openSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_openSerial.FlatAppearance.BorderSize = 0;
            this.btn_openSerial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_openSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_openSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openSerial.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openSerial.ForeColor = System.Drawing.Color.White;
            this.btn_openSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openSerial.Location = new System.Drawing.Point(111, 201);
            this.btn_openSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_openSerial.Name = "btn_openSerial";
            this.btn_openSerial.Size = new System.Drawing.Size(189, 41);
            this.btn_openSerial.TabIndex = 4;
            this.btn_openSerial.Text = "建立连接";
            this.btn_openSerial.UseVisualStyleBackColor = false;
            this.btn_openSerial.Click += new System.EventHandler(this.btn_openSerial_Click);
            // 
            // label_IsOpen
            // 
            this.label_IsOpen.AutoSize = true;
            this.label_IsOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_IsOpen.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IsOpen.ForeColor = System.Drawing.Color.Red;
            this.label_IsOpen.Location = new System.Drawing.Point(3, 199);
            this.label_IsOpen.Name = "label_IsOpen";
            this.label_IsOpen.Size = new System.Drawing.Size(102, 45);
            this.label_IsOpen.TabIndex = 5;
            this.label_IsOpen.Text = "未连接";
            this.label_IsOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clearReceive
            // 
            this.btn_clearReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clearReceive.FlatAppearance.BorderSize = 0;
            this.btn_clearReceive.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clearReceive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_clearReceive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clearReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearReceive.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clearReceive.ForeColor = System.Drawing.Color.White;
            this.btn_clearReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clearReceive.Location = new System.Drawing.Point(3, 93);
            this.btn_clearReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearReceive.Name = "btn_clearReceive";
            this.btn_clearReceive.Size = new System.Drawing.Size(137, 36);
            this.btn_clearReceive.TabIndex = 11;
            this.btn_clearReceive.Text = "清空接收";
            this.btn_clearReceive.UseVisualStyleBackColor = false;
            this.btn_clearReceive.Click += new System.EventHandler(this.btn_clearReceive_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.32143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.67857F));
            this.tableLayoutPanel2.Controls.Add(this.btn_clearSend, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_HexSend, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_HexReceive, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_clearReceive, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_timerSend, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_autoSendTime, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 279);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.77596F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.40437F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_clearSend
            // 
            this.btn_clearSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clearSend.FlatAppearance.BorderSize = 0;
            this.btn_clearSend.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clearSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_clearSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clearSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearSend.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clearSend.ForeColor = System.Drawing.Color.White;
            this.btn_clearSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clearSend.Location = new System.Drawing.Point(146, 93);
            this.btn_clearSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearSend.Name = "btn_clearSend";
            this.btn_clearSend.Size = new System.Drawing.Size(154, 36);
            this.btn_clearSend.TabIndex = 11;
            this.btn_clearSend.Text = "清空发送";
            this.btn_clearSend.UseVisualStyleBackColor = false;
            this.btn_clearSend.Click += new System.EventHandler(this.btn_clearSend_Click);
            // 
            // checkBox_HexSend
            // 
            this.checkBox_HexSend.AutoSize = true;
            this.checkBox_HexSend.BackColor = System.Drawing.Color.Black;
            this.checkBox_HexSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_HexSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_HexSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_HexSend.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_HexSend.ForeColor = System.Drawing.Color.White;
            this.checkBox_HexSend.Location = new System.Drawing.Point(3, 2);
            this.checkBox_HexSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HexSend.Name = "checkBox_HexSend";
            this.checkBox_HexSend.Size = new System.Drawing.Size(137, 40);
            this.checkBox_HexSend.TabIndex = 0;
            this.checkBox_HexSend.Text = "Hex发送";
            this.checkBox_HexSend.UseVisualStyleBackColor = false;
            this.checkBox_HexSend.CheckedChanged += new System.EventHandler(this.checkBox_HexSend_CheckedChanged);
            // 
            // checkBox_HexReceive
            // 
            this.checkBox_HexReceive.AutoSize = true;
            this.checkBox_HexReceive.BackColor = System.Drawing.Color.Black;
            this.checkBox_HexReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_HexReceive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_HexReceive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_HexReceive.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_HexReceive.ForeColor = System.Drawing.Color.White;
            this.checkBox_HexReceive.Location = new System.Drawing.Point(146, 2);
            this.checkBox_HexReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HexReceive.Name = "checkBox_HexReceive";
            this.checkBox_HexReceive.Size = new System.Drawing.Size(154, 40);
            this.checkBox_HexReceive.TabIndex = 0;
            this.checkBox_HexReceive.Text = "Hex接收";
            this.checkBox_HexReceive.UseVisualStyleBackColor = false;
            this.checkBox_HexReceive.CheckedChanged += new System.EventHandler(this.checkBox_HexReceive_CheckedChanged);
            // 
            // checkBox_timerSend
            // 
            this.checkBox_timerSend.AutoSize = true;
            this.checkBox_timerSend.BackColor = System.Drawing.Color.Black;
            this.checkBox_timerSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_timerSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_timerSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_timerSend.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_timerSend.ForeColor = System.Drawing.Color.White;
            this.checkBox_timerSend.Location = new System.Drawing.Point(3, 46);
            this.checkBox_timerSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_timerSend.Name = "checkBox_timerSend";
            this.checkBox_timerSend.Size = new System.Drawing.Size(137, 43);
            this.checkBox_timerSend.TabIndex = 8;
            this.checkBox_timerSend.Text = "定时发送(ms)";
            this.checkBox_timerSend.UseVisualStyleBackColor = false;
            this.checkBox_timerSend.CheckedChanged += new System.EventHandler(this.checkBox_timerSend_CheckedChanged);
            // 
            // textBox_autoSendTime
            // 
            this.textBox_autoSendTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_autoSendTime.BackColor = System.Drawing.Color.Black;
            this.textBox_autoSendTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_autoSendTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_autoSendTime.ForeColor = System.Drawing.Color.White;
            this.textBox_autoSendTime.Location = new System.Drawing.Point(146, 48);
            this.textBox_autoSendTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_autoSendTime.Name = "textBox_autoSendTime";
            this.textBox_autoSendTime.Size = new System.Drawing.Size(154, 28);
            this.textBox_autoSendTime.TabIndex = 14;
            this.textBox_autoSendTime.Text = "100";
            this.textBox_autoSendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_autoSendTime.TextChanged += new System.EventHandler(this.textBox_autoSendTime_TextChanged);
            // 
            // textBox_receive
            // 
            this.textBox_receive.BackColor = System.Drawing.Color.Gray;
            this.textBox_receive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_receive.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_receive.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_receive.Location = new System.Drawing.Point(324, 13);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.Size = new System.Drawing.Size(431, 395);
            this.textBox_receive.TabIndex = 18;
            this.textBox_receive.TextChanged += new System.EventHandler(this.textBox_receive_TextChanged);
            // 
            // textBox_send
            // 
            this.textBox_send.BackColor = System.Drawing.Color.Gray;
            this.textBox_send.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_send.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_send.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_send.Location = new System.Drawing.Point(10, 414);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(745, 168);
            this.textBox_send.TabIndex = 18;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_receive_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(665, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "接收区";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(665, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "发送区";
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(763, 591);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_sendSerialMsg);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_receive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sendSerialMsg;
        private System.Windows.Forms.ComboBox cb_comName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Button btn_clearReceive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_clearSend;
        private System.Windows.Forms.CheckBox checkBox_HexSend;
        private System.Windows.Forms.CheckBox checkBox_HexReceive;
        private System.Windows.Forms.CheckBox checkBox_timerSend;
        private System.Windows.Forms.TextBox textBox_autoSendTime;
        private System.Windows.Forms.Label label_IsOpen;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}