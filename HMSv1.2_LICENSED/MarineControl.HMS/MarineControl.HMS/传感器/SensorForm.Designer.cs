
namespace MarineControl.HMS.Sensor
{
    partial class SensorForm
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
            this.panel_timeSeries = new System.Windows.Forms.Panel();
            this.panel_statics = new System.Windows.Forms.Panel();
            this.panel_fatigue = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_use = new HZH_Controls.Controls.UCCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_up = new HZH_Controls.Controls.UCTextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_updateSensorInf = new HZH_Controls.Controls.UCBtnFillet();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_filter = new HZH_Controls.Controls.UCTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sensorType = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_sensorLocation = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sensorName = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_sensorId = new HZH_Controls.Controls.UCTextBoxEx();
            this.interval_long = new HZH_Controls.Controls.UCTextBoxEx();
            this.interval_short = new HZH_Controls.Controls.UCTextBoxEx();
            this.tb_down = new HZH_Controls.Controls.UCTextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_predict = new System.Windows.Forms.Panel();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlExt1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel_titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_timeSeries
            // 
            this.panel_timeSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timeSeries.Location = new System.Drawing.Point(2, 2);
            this.panel_timeSeries.Margin = new System.Windows.Forms.Padding(2);
            this.panel_timeSeries.Name = "panel_timeSeries";
            this.panel_timeSeries.Size = new System.Drawing.Size(778, 529);
            this.panel_timeSeries.TabIndex = 0;
            // 
            // panel_statics
            // 
            this.panel_statics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_statics.Location = new System.Drawing.Point(2, 2);
            this.panel_statics.Margin = new System.Windows.Forms.Padding(2);
            this.panel_statics.Name = "panel_statics";
            this.panel_statics.Size = new System.Drawing.Size(778, 529);
            this.panel_statics.TabIndex = 0;
            // 
            // panel_fatigue
            // 
            this.panel_fatigue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fatigue.Location = new System.Drawing.Point(0, 0);
            this.panel_fatigue.Margin = new System.Windows.Forms.Padding(2);
            this.panel_fatigue.Name = "panel_fatigue";
            this.panel_fatigue.Size = new System.Drawing.Size(782, 533);
            this.panel_fatigue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(298, 586);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.27513F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.72487F));
            this.tableLayoutPanel2.Controls.Add(this.cb_use, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_up, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btn_updateSensorInf, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tb_filter, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_sensorType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_sensorLocation, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_sensorName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_sensorId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.interval_long, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.interval_short, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tb_down, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cb_use
            // 
            this.cb_use.BackColor = System.Drawing.Color.Transparent;
            this.cb_use.Checked = true;
            this.cb_use.Location = new System.Drawing.Point(2, 362);
            this.cb_use.Margin = new System.Windows.Forms.Padding(2);
            this.cb_use.Name = "cb_use";
            this.cb_use.Padding = new System.Windows.Forms.Padding(1);
            this.cb_use.Size = new System.Drawing.Size(90, 36);
            this.cb_use.TabIndex = 1;
            this.cb_use.TextValue = "使用";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "传感器ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_up
            // 
            this.tb_up.BackColor = System.Drawing.Color.Transparent;
            this.tb_up.ConerRadius = 5;
            this.tb_up.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_up.DecLength = 2;
            this.tb_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_up.FillColor = System.Drawing.Color.Empty;
            this.tb_up.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_up.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_up.InputText = "";
            this.tb_up.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_up.IsFocusColor = true;
            this.tb_up.IsRadius = true;
            this.tb_up.IsShowClearBtn = false;
            this.tb_up.IsShowKeyboard = true;
            this.tb_up.IsShowRect = true;
            this.tb_up.IsShowSearchBtn = false;
            this.tb_up.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_up.Location = new System.Drawing.Point(98, 286);
            this.tb_up.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_up.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_up.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_up.Name = "tb_up";
            this.tb_up.Padding = new System.Windows.Forms.Padding(6);
            this.tb_up.PasswordChar = '\0';
            this.tb_up.PromptColor = System.Drawing.Color.Gray;
            this.tb_up.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_up.PromptText = "";
            this.tb_up.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_up.RectWidth = 1;
            this.tb_up.RegexPattern = "";
            this.tb_up.Size = new System.Drawing.Size(192, 28);
            this.tb_up.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "阈值下";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_updateSensorInf
            // 
            this.btn_updateSensorInf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_updateSensorInf.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateSensorInf.BtnImage = global::MarineControl.HMS.Properties.Resources.更新;
            this.btn_updateSensorInf.BtnText = "更新参数";
            this.btn_updateSensorInf.ConerRadius = 5;
            this.btn_updateSensorInf.FillColor = System.Drawing.Color.Transparent;
            this.btn_updateSensorInf.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_updateSensorInf.IsRadius = true;
            this.btn_updateSensorInf.IsShowRect = true;
            this.btn_updateSensorInf.Location = new System.Drawing.Point(122, 368);
            this.btn_updateSensorInf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_updateSensorInf.Name = "btn_updateSensorInf";
            this.btn_updateSensorInf.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btn_updateSensorInf.RectWidth = 1;
            this.btn_updateSensorInf.Size = new System.Drawing.Size(144, 29);
            this.btn_updateSensorInf.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "阈值上";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_filter
            // 
            this.tb_filter.BackColor = System.Drawing.Color.Transparent;
            this.tb_filter.ConerRadius = 5;
            this.tb_filter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_filter.DecLength = 2;
            this.tb_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter.FillColor = System.Drawing.Color.Empty;
            this.tb_filter.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_filter.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.InputText = "";
            this.tb_filter.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_filter.IsFocusColor = true;
            this.tb_filter.IsRadius = true;
            this.tb_filter.IsShowClearBtn = false;
            this.tb_filter.IsShowKeyboard = true;
            this.tb_filter.IsShowRect = true;
            this.tb_filter.IsShowSearchBtn = false;
            this.tb_filter.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_filter.Location = new System.Drawing.Point(98, 246);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_filter.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_filter.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Padding = new System.Windows.Forms.Padding(6);
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.PromptColor = System.Drawing.Color.Gray;
            this.tb_filter.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.PromptText = "";
            this.tb_filter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_filter.RectWidth = 1;
            this.tb_filter.RegexPattern = "";
            this.tb_filter.Size = new System.Drawing.Size(192, 28);
            this.tb_filter.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "滤波器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_sensorType
            // 
            this.tb_sensorType.BackColor = System.Drawing.Color.Transparent;
            this.tb_sensorType.ConerRadius = 5;
            this.tb_sensorType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sensorType.DecLength = 2;
            this.tb_sensorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sensorType.FillColor = System.Drawing.Color.Empty;
            this.tb_sensorType.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_sensorType.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorType.InputText = "";
            this.tb_sensorType.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_sensorType.IsFocusColor = true;
            this.tb_sensorType.IsRadius = true;
            this.tb_sensorType.IsShowClearBtn = false;
            this.tb_sensorType.IsShowKeyboard = true;
            this.tb_sensorType.IsShowRect = true;
            this.tb_sensorType.IsShowSearchBtn = false;
            this.tb_sensorType.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_sensorType.Location = new System.Drawing.Point(98, 86);
            this.tb_sensorType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_sensorType.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_sensorType.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_sensorType.Name = "tb_sensorType";
            this.tb_sensorType.Padding = new System.Windows.Forms.Padding(6);
            this.tb_sensorType.PasswordChar = '\0';
            this.tb_sensorType.PromptColor = System.Drawing.Color.Gray;
            this.tb_sensorType.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorType.PromptText = "";
            this.tb_sensorType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_sensorType.RectWidth = 1;
            this.tb_sensorType.RegexPattern = "";
            this.tb_sensorType.Size = new System.Drawing.Size(192, 28);
            this.tb_sensorType.TabIndex = 8;
            // 
            // tb_sensorLocation
            // 
            this.tb_sensorLocation.BackColor = System.Drawing.Color.Transparent;
            this.tb_sensorLocation.ConerRadius = 5;
            this.tb_sensorLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sensorLocation.DecLength = 2;
            this.tb_sensorLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sensorLocation.FillColor = System.Drawing.Color.Empty;
            this.tb_sensorLocation.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_sensorLocation.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorLocation.InputText = "";
            this.tb_sensorLocation.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_sensorLocation.IsFocusColor = true;
            this.tb_sensorLocation.IsRadius = true;
            this.tb_sensorLocation.IsShowClearBtn = false;
            this.tb_sensorLocation.IsShowKeyboard = true;
            this.tb_sensorLocation.IsShowRect = true;
            this.tb_sensorLocation.IsShowSearchBtn = false;
            this.tb_sensorLocation.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_sensorLocation.Location = new System.Drawing.Point(98, 126);
            this.tb_sensorLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_sensorLocation.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_sensorLocation.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_sensorLocation.Name = "tb_sensorLocation";
            this.tb_sensorLocation.Padding = new System.Windows.Forms.Padding(6);
            this.tb_sensorLocation.PasswordChar = '\0';
            this.tb_sensorLocation.PromptColor = System.Drawing.Color.Gray;
            this.tb_sensorLocation.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorLocation.PromptText = "";
            this.tb_sensorLocation.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_sensorLocation.RectWidth = 1;
            this.tb_sensorLocation.RegexPattern = "";
            this.tb_sensorLocation.Size = new System.Drawing.Size(192, 28);
            this.tb_sensorLocation.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "长周期更新间隔(min)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(2, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 40);
            this.label10.TabIndex = 1;
            this.label10.Text = "传感器名";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(2, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 40);
            this.label13.TabIndex = 1;
            this.label13.Text = "短周期更新间隔(s)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(2, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "传感器类型";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(2, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 40);
            this.label11.TabIndex = 1;
            this.label11.Text = "位置";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_sensorName
            // 
            this.tb_sensorName.BackColor = System.Drawing.Color.Transparent;
            this.tb_sensorName.ConerRadius = 5;
            this.tb_sensorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sensorName.DecLength = 2;
            this.tb_sensorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sensorName.FillColor = System.Drawing.Color.Empty;
            this.tb_sensorName.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_sensorName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorName.InputText = "";
            this.tb_sensorName.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_sensorName.IsFocusColor = true;
            this.tb_sensorName.IsRadius = true;
            this.tb_sensorName.IsShowClearBtn = false;
            this.tb_sensorName.IsShowKeyboard = true;
            this.tb_sensorName.IsShowRect = true;
            this.tb_sensorName.IsShowSearchBtn = false;
            this.tb_sensorName.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_sensorName.Location = new System.Drawing.Point(98, 46);
            this.tb_sensorName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_sensorName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_sensorName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_sensorName.Name = "tb_sensorName";
            this.tb_sensorName.Padding = new System.Windows.Forms.Padding(6);
            this.tb_sensorName.PasswordChar = '\0';
            this.tb_sensorName.PromptColor = System.Drawing.Color.Gray;
            this.tb_sensorName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorName.PromptText = "";
            this.tb_sensorName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_sensorName.RectWidth = 1;
            this.tb_sensorName.RegexPattern = "";
            this.tb_sensorName.Size = new System.Drawing.Size(192, 28);
            this.tb_sensorName.TabIndex = 8;
            // 
            // tb_sensorId
            // 
            this.tb_sensorId.BackColor = System.Drawing.Color.Transparent;
            this.tb_sensorId.ConerRadius = 5;
            this.tb_sensorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sensorId.DecLength = 2;
            this.tb_sensorId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sensorId.FillColor = System.Drawing.Color.Empty;
            this.tb_sensorId.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_sensorId.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorId.InputText = "";
            this.tb_sensorId.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_sensorId.IsFocusColor = true;
            this.tb_sensorId.IsRadius = true;
            this.tb_sensorId.IsShowClearBtn = false;
            this.tb_sensorId.IsShowKeyboard = false;
            this.tb_sensorId.IsShowRect = true;
            this.tb_sensorId.IsShowSearchBtn = false;
            this.tb_sensorId.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.tb_sensorId.Location = new System.Drawing.Point(98, 6);
            this.tb_sensorId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_sensorId.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_sensorId.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_sensorId.Name = "tb_sensorId";
            this.tb_sensorId.Padding = new System.Windows.Forms.Padding(6);
            this.tb_sensorId.PasswordChar = '\0';
            this.tb_sensorId.PromptColor = System.Drawing.Color.Gray;
            this.tb_sensorId.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sensorId.PromptText = "";
            this.tb_sensorId.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_sensorId.RectWidth = 1;
            this.tb_sensorId.RegexPattern = "";
            this.tb_sensorId.Size = new System.Drawing.Size(192, 28);
            this.tb_sensorId.TabIndex = 8;
            // 
            // interval_long
            // 
            this.interval_long.BackColor = System.Drawing.Color.Transparent;
            this.interval_long.ConerRadius = 5;
            this.interval_long.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.interval_long.DecLength = 2;
            this.interval_long.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interval_long.FillColor = System.Drawing.Color.Empty;
            this.interval_long.FocusBorderColor = System.Drawing.Color.Blue;
            this.interval_long.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.interval_long.InputText = "";
            this.interval_long.InputType = HZH_Controls.TextInputType.NotControl;
            this.interval_long.IsFocusColor = true;
            this.interval_long.IsRadius = true;
            this.interval_long.IsShowClearBtn = false;
            this.interval_long.IsShowKeyboard = true;
            this.interval_long.IsShowRect = true;
            this.interval_long.IsShowSearchBtn = false;
            this.interval_long.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.interval_long.Location = new System.Drawing.Point(98, 206);
            this.interval_long.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.interval_long.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.interval_long.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.interval_long.Name = "interval_long";
            this.interval_long.Padding = new System.Windows.Forms.Padding(6);
            this.interval_long.PasswordChar = '\0';
            this.interval_long.PromptColor = System.Drawing.Color.Gray;
            this.interval_long.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.interval_long.PromptText = "";
            this.interval_long.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.interval_long.RectWidth = 1;
            this.interval_long.RegexPattern = "";
            this.interval_long.Size = new System.Drawing.Size(192, 28);
            this.interval_long.TabIndex = 20;
            // 
            // interval_short
            // 
            this.interval_short.BackColor = System.Drawing.Color.Transparent;
            this.interval_short.ConerRadius = 5;
            this.interval_short.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.interval_short.DecLength = 2;
            this.interval_short.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interval_short.FillColor = System.Drawing.Color.Empty;
            this.interval_short.FocusBorderColor = System.Drawing.Color.Blue;
            this.interval_short.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.interval_short.InputText = "";
            this.interval_short.InputType = HZH_Controls.TextInputType.NotControl;
            this.interval_short.IsFocusColor = true;
            this.interval_short.IsRadius = true;
            this.interval_short.IsShowClearBtn = false;
            this.interval_short.IsShowKeyboard = true;
            this.interval_short.IsShowRect = true;
            this.interval_short.IsShowSearchBtn = false;
            this.interval_short.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.interval_short.Location = new System.Drawing.Point(98, 166);
            this.interval_short.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.interval_short.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.interval_short.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.interval_short.Name = "interval_short";
            this.interval_short.Padding = new System.Windows.Forms.Padding(6);
            this.interval_short.PasswordChar = '\0';
            this.interval_short.PromptColor = System.Drawing.Color.Gray;
            this.interval_short.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.interval_short.PromptText = "";
            this.interval_short.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.interval_short.RectWidth = 1;
            this.interval_short.RegexPattern = "";
            this.interval_short.Size = new System.Drawing.Size(192, 28);
            this.interval_short.TabIndex = 20;
            // 
            // tb_down
            // 
            this.tb_down.BackColor = System.Drawing.Color.Transparent;
            this.tb_down.ConerRadius = 5;
            this.tb_down.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_down.DecLength = 2;
            this.tb_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_down.FillColor = System.Drawing.Color.Empty;
            this.tb_down.FocusBorderColor = System.Drawing.Color.Blue;
            this.tb_down.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_down.InputText = "";
            this.tb_down.InputType = HZH_Controls.TextInputType.NotControl;
            this.tb_down.IsFocusColor = true;
            this.tb_down.IsRadius = true;
            this.tb_down.IsShowClearBtn = false;
            this.tb_down.IsShowKeyboard = true;
            this.tb_down.IsShowRect = true;
            this.tb_down.IsShowSearchBtn = false;
            this.tb_down.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.tb_down.Location = new System.Drawing.Point(98, 326);
            this.tb_down.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_down.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_down.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.tb_down.Name = "tb_down";
            this.tb_down.Padding = new System.Windows.Forms.Padding(6);
            this.tb_down.PasswordChar = '\0';
            this.tb_down.PromptColor = System.Drawing.Color.Gray;
            this.tb_down.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_down.PromptText = "";
            this.tb_down.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tb_down.RectWidth = 1;
            this.tb_down.RegexPattern = "";
            this.tb_down.Size = new System.Drawing.Size(192, 28);
            this.tb_down.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControlExt1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(312, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(794, 586);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能";
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.Controls.Add(this.tabPage3);
            this.tabControlExt1.Controls.Add(this.tabPage4);
            this.tabControlExt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExt1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 25);
            this.tabControlExt1.Location = new System.Drawing.Point(2, 18);
            this.tabControlExt1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(790, 566);
            this.tabControlExt1.TabIndex = 8;
            this.tabControlExt1.UncloseTabIndexs = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_timeSeries);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(782, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "时历曲线";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_statics);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(782, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel_fatigue);
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(782, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "疲劳寿命预测";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel_predict);
            this.tabPage4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(782, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "监测数据短期预测";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_predict
            // 
            this.panel_predict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_predict.Location = new System.Drawing.Point(0, 0);
            this.panel_predict.Margin = new System.Windows.Forms.Padding(2);
            this.panel_predict.Name = "panel_predict";
            this.panel_predict.Size = new System.Drawing.Size(782, 533);
            this.panel_predict.TabIndex = 0;
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.panel_titleBar.Controls.Add(this.btn_close);
            this.panel_titleBar.Controls.Add(this.label_title);
            this.panel_titleBar.Controls.Add(this.btn_min);
            this.panel_titleBar.Controls.Add(this.btn_max);
            this.panel_titleBar.Controls.Add(this.button1);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(1116, 38);
            this.panel_titleBar.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::MarineControl.HMS.Properties.Resources.删除_关闭_取消_无边框;
            this.btn_close.Location = new System.Drawing.Point(1073, 2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 34);
            this.btn_close.TabIndex = 7;
            this.btn_close.Tag = "close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(18, 10);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(90, 21);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "传感器详览";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = global::MarineControl.HMS.Properties.Resources.最小化1;
            this.btn_min.Location = new System.Drawing.Point(1438, 6);
            this.btn_min.Margin = new System.Windows.Forms.Padding(2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 2;
            this.btn_min.Tag = "min";
            this.btn_min.UseVisualStyleBackColor = false;
            // 
            // btn_max
            // 
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Image = global::MarineControl.HMS.Properties.Resources.全屏;
            this.btn_max.Location = new System.Drawing.Point(1494, 6);
            this.btn_max.Margin = new System.Windows.Forms.Padding(2);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 1;
            this.btn_max.Tag = "max";
            this.btn_max.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MarineControl.HMS.Properties.Resources.删除_关闭_取消_无边框;
            this.button1.Location = new System.Drawing.Point(1550, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Tag = "close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 632);
            this.ControlBox = false;
            this.Controls.Add(this.panel_titleBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SensorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControlExt1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel_timeSeries;
        private System.Windows.Forms.Panel panel_fatigue;
        private System.Windows.Forms.Panel panel_statics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_close;
        private HZH_Controls.Controls.UCBtnFillet btn_updateSensorInf;
        private HZH_Controls.Controls.UCTextBoxEx tb_sensorType;
        private HZH_Controls.Controls.UCTextBoxEx tb_sensorLocation;
        private HZH_Controls.Controls.UCTextBoxEx tb_sensorName;
        private HZH_Controls.Controls.UCTextBoxEx tb_sensorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private HZH_Controls.Controls.UCCheckBox cb_use;
        private HZH_Controls.Controls.UCTextBoxEx tb_filter;
        private HZH_Controls.Controls.UCTextBoxEx interval_long;
        private HZH_Controls.Controls.UCTextBoxEx interval_short;
        private System.Windows.Forms.Panel panel_predict;
        private HZH_Controls.Controls.UCTextBoxEx tb_up;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCTextBoxEx tb_down;
    }
}