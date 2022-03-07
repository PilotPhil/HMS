
namespace MarineControl.HMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_mark = new System.Windows.Forms.Panel();
            this.btn_communiction = new System.Windows.Forms.Button();
            this.btn_mointor = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_otherDevice = new System.Windows.Forms.Button();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_database = new System.Windows.Forms.Button();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.BossSwitch = new HZH_Controls.Controls.UCSwitch();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_HMS = new System.Windows.Forms.Label();
            this.panel_buttonBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_ram = new HZH_Controls.Controls.UCProcessLine();
            this.pl_cpu = new HZH_Controls.Controls.UCProcessLine();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sysRuntime = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel_titleBar.SuspendLayout();
            this.panel_buttonBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Upper
            // 
            this.panel_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Upper.BackColor = System.Drawing.SystemColors.Window;
            this.panel_Upper.Location = new System.Drawing.Point(196, 2);
            this.panel_Upper.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(1520, 776);
            this.panel_Upper.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.tb_login);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.panel_mark);
            this.panel2.Controls.Add(this.btn_communiction);
            this.panel2.Controls.Add(this.btn_mointor);
            this.panel2.Controls.Add(this.btn_setting);
            this.panel2.Controls.Add(this.btn_otherDevice);
            this.panel2.Controls.Add(this.btn_alarm);
            this.panel2.Controls.Add(this.btn_database);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 784);
            this.panel2.TabIndex = 3;
            // 
            // tb_login
            // 
            this.tb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_login.Location = new System.Drawing.Point(65, 745);
            this.tb_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(89, 24);
            this.tb_login.TabIndex = 8;
            this.tb_login.Text = "未登录";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Image = global::MarineControl.HMS.Properties.Resources.用户;
            this.btn_login.Location = new System.Drawing.Point(16, 734);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(44, 41);
            this.btn_login.TabIndex = 7;
            this.btn_login.Tag = "min";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // panel_mark
            // 
            this.panel_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.panel_mark.BackgroundImage = global::MarineControl.HMS.Properties.Resources.箭头__1_;
            this.panel_mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_mark.Location = new System.Drawing.Point(125, 5);
            this.panel_mark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_mark.Name = "panel_mark";
            this.panel_mark.Size = new System.Drawing.Size(60, 41);
            this.panel_mark.TabIndex = 2;
            // 
            // btn_communiction
            // 
            this.btn_communiction.BackColor = System.Drawing.Color.Transparent;
            this.btn_communiction.FlatAppearance.BorderSize = 0;
            this.btn_communiction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_communiction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_communiction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_communiction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_communiction.Image = global::MarineControl.HMS.Properties.Resources.监测__3_;
            this.btn_communiction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_communiction.Location = new System.Drawing.Point(1, 5);
            this.btn_communiction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_communiction.Name = "btn_communiction";
            this.btn_communiction.Size = new System.Drawing.Size(169, 41);
            this.btn_communiction.TabIndex = 1;
            this.btn_communiction.Text = "简要视图";
            this.btn_communiction.UseVisualStyleBackColor = false;
            // 
            // btn_mointor
            // 
            this.btn_mointor.FlatAppearance.BorderSize = 0;
            this.btn_mointor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_mointor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_mointor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mointor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mointor.Image = global::MarineControl.HMS.Properties.Resources.监测__2_;
            this.btn_mointor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mointor.Location = new System.Drawing.Point(1, 51);
            this.btn_mointor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mointor.Name = "btn_mointor";
            this.btn_mointor.Size = new System.Drawing.Size(169, 41);
            this.btn_mointor.TabIndex = 1;
            this.btn_mointor.Text = "详览视图";
            this.btn_mointor.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_setting.Image = global::MarineControl.HMS.Properties.Resources.设置;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 236);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(169, 41);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "参数设置";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_otherDevice
            // 
            this.btn_otherDevice.FlatAppearance.BorderSize = 0;
            this.btn_otherDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_otherDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_otherDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_otherDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_otherDevice.Image = global::MarineControl.HMS.Properties.Resources.外部数据;
            this.btn_otherDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_otherDevice.Location = new System.Drawing.Point(1, 191);
            this.btn_otherDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_otherDevice.Name = "btn_otherDevice";
            this.btn_otherDevice.Size = new System.Drawing.Size(169, 41);
            this.btn_otherDevice.TabIndex = 1;
            this.btn_otherDevice.Text = "外部设备";
            this.btn_otherDevice.UseVisualStyleBackColor = true;
            // 
            // btn_alarm
            // 
            this.btn_alarm.FlatAppearance.BorderSize = 0;
            this.btn_alarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_alarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alarm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_alarm.Image = global::MarineControl.HMS.Properties.Resources.报警信息;
            this.btn_alarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alarm.Location = new System.Drawing.Point(1, 99);
            this.btn_alarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(169, 41);
            this.btn_alarm.TabIndex = 1;
            this.btn_alarm.Text = "报警视图";
            this.btn_alarm.UseVisualStyleBackColor = true;
            // 
            // btn_database
            // 
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btn_database.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_database.Image = global::MarineControl.HMS.Properties.Resources.数据库;
            this.btn_database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_database.Location = new System.Drawing.Point(1, 145);
            this.btn_database.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(169, 41);
            this.btn_database.TabIndex = 1;
            this.btn_database.Text = "数据库";
            this.btn_database.UseVisualStyleBackColor = true;
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.panel_titleBar.Controls.Add(this.BossSwitch);
            this.panel_titleBar.Controls.Add(this.btn_min);
            this.panel_titleBar.Controls.Add(this.btn_max);
            this.panel_titleBar.Controls.Add(this.btn_close);
            this.panel_titleBar.Controls.Add(this.label_HMS);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(1719, 62);
            this.panel_titleBar.TabIndex = 4;
            this.panel_titleBar.SizeChanged += new System.EventHandler(this.panel_titleBar_SizeChanged);
            // 
            // BossSwitch
            // 
            this.BossSwitch.BackColor = System.Drawing.Color.Transparent;
            this.BossSwitch.Checked = false;
            this.BossSwitch.FalseColor = System.Drawing.SystemColors.ButtonShadow;
            this.BossSwitch.FalseTextColr = System.Drawing.Color.White;
            this.BossSwitch.Location = new System.Drawing.Point(5, 11);
            this.BossSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BossSwitch.Name = "BossSwitch";
            this.BossSwitch.Size = new System.Drawing.Size(112, 39);
            this.BossSwitch.SwitchType = HZH_Controls.Controls.SwitchType.Quadrilateral;
            this.BossSwitch.TabIndex = 0;
            this.BossSwitch.Texts = null;
            this.BossSwitch.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.BossSwitch.TrueTextColr = System.Drawing.Color.White;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = global::MarineControl.HMS.Properties.Resources.最小化1;
            this.btn_min.Location = new System.Drawing.Point(1567, 5);
            this.btn_min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(44, 41);
            this.btn_min.TabIndex = 2;
            this.btn_min.Tag = "min";
            this.btn_min.UseVisualStyleBackColor = false;
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Image = global::MarineControl.HMS.Properties.Resources.全屏;
            this.btn_max.Location = new System.Drawing.Point(1616, 5);
            this.btn_max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(44, 41);
            this.btn_max.TabIndex = 1;
            this.btn_max.Tag = "max";
            this.btn_max.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::MarineControl.HMS.Properties.Resources.删除_关闭_取消_无边框;
            this.btn_close.Location = new System.Drawing.Point(1665, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(44, 41);
            this.btn_close.TabIndex = 0;
            this.btn_close.Tag = "close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // label_HMS
            // 
            this.label_HMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_HMS.AutoSize = true;
            this.label_HMS.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_HMS.Location = new System.Drawing.Point(749, 17);
            this.label_HMS.Name = "label_HMS";
            this.label_HMS.Size = new System.Drawing.Size(273, 33);
            this.label_HMS.TabIndex = 5;
            this.label_HMS.Text = "Hull Mointor System";
            // 
            // panel_buttonBar
            // 
            this.panel_buttonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.panel_buttonBar.Controls.Add(this.tableLayoutPanel1);
            this.panel_buttonBar.Controls.Add(this.tb_sysRuntime);
            this.panel_buttonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_buttonBar.Location = new System.Drawing.Point(0, 841);
            this.panel_buttonBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_buttonBar.Name = "panel_buttonBar";
            this.panel_buttonBar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel_buttonBar.Size = new System.Drawing.Size(1719, 70);
            this.panel_buttonBar.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.14986F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.85014F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pl_ram, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pl_cpu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1469, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 70);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_ram
            // 
            this.pl_ram.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.pl_ram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_ram.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_ram.ForeColor = System.Drawing.Color.Black;
            this.pl_ram.Location = new System.Drawing.Point(89, 37);
            this.pl_ram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pl_ram.MaxValue = 100;
            this.pl_ram.Name = "pl_ram";
            this.pl_ram.Size = new System.Drawing.Size(153, 31);
            this.pl_ram.TabIndex = 3;
            this.pl_ram.Text = "ucProcessLine1";
            this.pl_ram.Value = 0;
            this.pl_ram.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.pl_ram.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.pl_ram.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // pl_cpu
            // 
            this.pl_cpu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.pl_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_cpu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_cpu.ForeColor = System.Drawing.Color.Black;
            this.pl_cpu.Location = new System.Drawing.Point(89, 2);
            this.pl_cpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pl_cpu.MaxValue = 100;
            this.pl_cpu.Name = "pl_cpu";
            this.pl_cpu.Size = new System.Drawing.Size(153, 31);
            this.pl_cpu.TabIndex = 3;
            this.pl_cpu.Text = "ucProcessLine1";
            this.pl_cpu.Value = 0;
            this.pl_cpu.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.pl_cpu.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.pl_cpu.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "RAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sysRuntime
            // 
            this.tb_sysRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.tb_sysRuntime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sysRuntime.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_sysRuntime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sysRuntime.Location = new System.Drawing.Point(5, 0);
            this.tb_sysRuntime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sysRuntime.Multiline = true;
            this.tb_sysRuntime.Name = "tb_sysRuntime";
            this.tb_sysRuntime.Size = new System.Drawing.Size(289, 70);
            this.tb_sysRuntime.TabIndex = 0;
            this.tb_sysRuntime.Text = "运行时间";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel_Upper);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1719, 779);
            this.panel4.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1719, 911);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_buttonBar);
            this.Controls.Add(this.panel_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.panel_buttonBar.ResumeLayout(false);
            this.panel_buttonBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_communiction;
        private System.Windows.Forms.Button btn_mointor;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_database;
        private System.Windows.Forms.Button btn_otherDevice;
        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Label label_HMS;
        private System.Windows.Forms.Panel panel_buttonBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_sysRuntime;
        private System.Windows.Forms.Panel panel_mark;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_login;
        private HZH_Controls.Controls.UCSwitch BossSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HZH_Controls.Controls.UCProcessLine pl_ram;
        private HZH_Controls.Controls.UCProcessLine pl_cpu;
        private System.Windows.Forms.Button btn_setting;
    }
}

