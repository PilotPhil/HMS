
namespace SimpleDataAnalyse
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_Fatigue = new System.Windows.Forms.Button();
            this.button_fft = new System.Windows.Forms.Button();
            this.button_chart = new System.Windows.Forms.Button();
            this.button_com = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "HMS(demo)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_filter);
            this.panel1.Controls.Add(this.button_Fatigue);
            this.panel1.Controls.Add(this.button_fft);
            this.panel1.Controls.Add(this.button_chart);
            this.panel1.Controls.Add(this.button_com);
            this.panel1.Controls.Add(this.panelBar);
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 631);
            this.panel1.TabIndex = 3;
            // 
            // button_filter
            // 
            this.button_filter.FlatAppearance.BorderSize = 0;
            this.button_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_filter.Image = global::SimpleDataAnalyse.Properties.Resources.信息过滤;
            this.button_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_filter.Location = new System.Drawing.Point(23, 228);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(140, 50);
            this.button_filter.TabIndex = 0;
            this.button_filter.Text = "滤波   ";
            this.button_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button_Fatigue
            // 
            this.button_Fatigue.FlatAppearance.BorderSize = 0;
            this.button_Fatigue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Fatigue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fatigue.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Fatigue.Image = global::SimpleDataAnalyse.Properties.Resources.雨伞;
            this.button_Fatigue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Fatigue.Location = new System.Drawing.Point(23, 172);
            this.button_Fatigue.Name = "button_Fatigue";
            this.button_Fatigue.Size = new System.Drawing.Size(140, 50);
            this.button_Fatigue.TabIndex = 0;
            this.button_Fatigue.Text = "疲劳损伤";
            this.button_Fatigue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Fatigue.UseVisualStyleBackColor = true;
            this.button_Fatigue.Click += new System.EventHandler(this.button_fatigue_Click);
            // 
            // button_fft
            // 
            this.button_fft.FlatAppearance.BorderSize = 0;
            this.button_fft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_fft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fft.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_fft.Image = global::SimpleDataAnalyse.Properties.Resources.数据转换;
            this.button_fft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fft.Location = new System.Drawing.Point(23, 116);
            this.button_fft.Name = "button_fft";
            this.button_fft.Size = new System.Drawing.Size(140, 50);
            this.button_fft.TabIndex = 0;
            this.button_fft.Text = "FFT分析 ";
            this.button_fft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_fft.UseVisualStyleBackColor = true;
            this.button_fft.Click += new System.EventHandler(this.button_fft_Click);
            // 
            // button_chart
            // 
            this.button_chart.FlatAppearance.BorderSize = 0;
            this.button_chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chart.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_chart.Image = global::SimpleDataAnalyse.Properties.Resources.图表;
            this.button_chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_chart.Location = new System.Drawing.Point(23, 60);
            this.button_chart.Name = "button_chart";
            this.button_chart.Size = new System.Drawing.Size(140, 50);
            this.button_chart.TabIndex = 0;
            this.button_chart.Text = "时历曲线";
            this.button_chart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_chart.UseVisualStyleBackColor = true;
            this.button_chart.Click += new System.EventHandler(this.button_chart_Click);
            // 
            // button_com
            // 
            this.button_com.FlatAppearance.BorderSize = 0;
            this.button_com.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_com.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_com.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_com.Image = global::SimpleDataAnalyse.Properties.Resources.网络传输;
            this.button_com.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_com.Location = new System.Drawing.Point(23, 4);
            this.button_com.Name = "button_com";
            this.button_com.Size = new System.Drawing.Size(140, 50);
            this.button_com.TabIndex = 0;
            this.button_com.Text = "通信设置";
            this.button_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_com.UseVisualStyleBackColor = true;
            this.button_com.Click += new System.EventHandler(this.button_com_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBar.Location = new System.Drawing.Point(3, 4);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(29, 50);
            this.panelBar.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(210, 68);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(965, 631);
            this.mainPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SimpleDataAnalyse.Properties.Resources.船撞_R;
            this.pictureBox2.Location = new System.Drawing.Point(178, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleDataAnalyse.Properties.Resources.船撞;
            this.pictureBox1.Location = new System.Drawing.Point(1, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 710);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_com;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button button_Fatigue;
        private System.Windows.Forms.Button button_fft;
        private System.Windows.Forms.Button button_chart;
        private System.Windows.Forms.Button button_filter;
    }
}

