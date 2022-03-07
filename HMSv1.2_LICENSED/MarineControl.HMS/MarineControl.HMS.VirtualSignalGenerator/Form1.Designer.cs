
namespace MarineControl.HMS.VirtualSignalGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_add1sensor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_startMointor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_comName = new System.Windows.Forms.ComboBox();
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
            this.panel_udp = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add1sensor
            // 
            this.btn_add1sensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add1sensor.FlatAppearance.BorderSize = 0;
            this.btn_add1sensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add1sensor.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add1sensor.ForeColor = System.Drawing.Color.White;
            this.btn_add1sensor.Location = new System.Drawing.Point(395, 12);
            this.btn_add1sensor.Name = "btn_add1sensor";
            this.btn_add1sensor.Size = new System.Drawing.Size(303, 38);
            this.btn_add1sensor.TabIndex = 0;
            this.btn_add1sensor.Text = "添加虚拟传感器";
            this.btn_add1sensor.UseVisualStyleBackColor = false;
            this.btn_add1sensor.Click += new System.EventHandler(this.btn_add1sensor_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(370, 504);
            this.dataGridView1.TabIndex = 3;
            // 
            // column1
            // 
            this.column1.HeaderText = "传感器序号";
            this.column1.MinimumWidth = 8;
            this.column1.Name = "column1";
            this.column1.Width = 150;
            // 
            // column2
            // 
            this.column2.HeaderText = "传感器值";
            this.column2.MinimumWidth = 8;
            this.column2.Name = "column2";
            this.column2.Width = 150;
            // 
            // btn_startMointor
            // 
            this.btn_startMointor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_startMointor.FlatAppearance.BorderSize = 0;
            this.btn_startMointor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startMointor.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_startMointor.ForeColor = System.Drawing.Color.White;
            this.btn_startMointor.Location = new System.Drawing.Point(395, 56);
            this.btn_startMointor.Name = "btn_startMointor";
            this.btn_startMointor.Size = new System.Drawing.Size(303, 38);
            this.btn_startMointor.TabIndex = 0;
            this.btn_startMointor.Text = "开始虚拟监测";
            this.btn_startMointor.UseVisualStyleBackColor = false;
            this.btn_startMointor.Click += new System.EventHandler(this.btn_startMointor_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("黑体", 9F);
            this.tabControl1.Location = new System.Drawing.Point(395, 215);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 301);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel_udp);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UDP";
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.84158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 263);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cb_comName
            // 
            this.cb_comName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_comName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_comName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_comName.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_comName.ForeColor = System.Drawing.Color.White;
            this.cb_comName.FormattingEnabled = true;
            this.cb_comName.Location = new System.Drawing.Point(107, 2);
            this.cb_comName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_comName.Name = "cb_comName";
            this.cb_comName.Size = new System.Drawing.Size(182, 26);
            this.cb_comName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 41);
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
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 44);
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
            this.label5.Location = new System.Drawing.Point(3, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 44);
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
            this.label1.Size = new System.Drawing.Size(98, 44);
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
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 44);
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
            this.cb_braudt.Location = new System.Drawing.Point(107, 46);
            this.cb_braudt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_braudt.Name = "cb_braudt";
            this.cb_braudt.Size = new System.Drawing.Size(182, 26);
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
            this.cb_dataBits.Location = new System.Drawing.Point(107, 90);
            this.cb_dataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.Size = new System.Drawing.Size(182, 26);
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
            this.cb_checkBit.Location = new System.Drawing.Point(107, 131);
            this.cb_checkBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.Size = new System.Drawing.Size(182, 26);
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
            this.cb_stopBit.Location = new System.Drawing.Point(107, 175);
            this.cb_stopBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(182, 26);
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
            this.btn_openSerial.Location = new System.Drawing.Point(107, 219);
            this.btn_openSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_openSerial.Name = "btn_openSerial";
            this.btn_openSerial.Size = new System.Drawing.Size(182, 42);
            this.btn_openSerial.TabIndex = 4;
            this.btn_openSerial.Text = "建立连接";
            this.btn_openSerial.UseVisualStyleBackColor = false;
            // 
            // label_IsOpen
            // 
            this.label_IsOpen.AutoSize = true;
            this.label_IsOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_IsOpen.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IsOpen.ForeColor = System.Drawing.Color.Red;
            this.label_IsOpen.Location = new System.Drawing.Point(3, 217);
            this.label_IsOpen.Name = "label_IsOpen";
            this.label_IsOpen.Size = new System.Drawing.Size(98, 46);
            this.label_IsOpen.TabIndex = 5;
            this.label_IsOpen.Text = "未连接";
            this.label_IsOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_udp
            // 
            this.panel_udp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_udp.Location = new System.Drawing.Point(3, 3);
            this.panel_udp.Name = "panel_udp";
            this.panel_udp.Size = new System.Drawing.Size(290, 261);
            this.panel_udp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_startMointor);
            this.Controls.Add(this.btn_add1sensor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add1sensor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.Button btn_startMointor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_comName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_braudt;
        private System.Windows.Forms.ComboBox cb_dataBits;
        private System.Windows.Forms.ComboBox cb_checkBit;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.Button btn_openSerial;
        private System.Windows.Forms.Label label_IsOpen;
        private System.Windows.Forms.Panel panel_udp;
    }
}

