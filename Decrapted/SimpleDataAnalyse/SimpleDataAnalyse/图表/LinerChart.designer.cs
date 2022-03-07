
namespace plot
{
    partial class oxyplotLiner
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.axisYmin = new System.Windows.Forms.NumericUpDown();
            this.checkBox_autoY = new System.Windows.Forms.CheckBox();
            this.axisYMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSetAxisY = new System.Windows.Forms.Button();
            this.checkBox_saveEnegeDisp = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.fftSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_setFFT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sampleRate = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYMax)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRate)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.BackColor = System.Drawing.Color.White;
            this.plotView1.Location = new System.Drawing.Point(0, 72);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(800, 378);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.axisYmin, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_autoY, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.axisYMax, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSetAxisY, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 60);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // axisYmin
            // 
            this.axisYmin.BackColor = System.Drawing.Color.White;
            this.axisYmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axisYmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisYmin.Location = new System.Drawing.Point(171, 33);
            this.axisYmin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.axisYmin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.axisYmin.Name = "axisYmin";
            this.axisYmin.Size = new System.Drawing.Size(80, 25);
            this.axisYmin.TabIndex = 5;
            // 
            // checkBox_autoY
            // 
            this.checkBox_autoY.AutoSize = true;
            this.checkBox_autoY.Checked = true;
            this.checkBox_autoY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_autoY.Location = new System.Drawing.Point(3, 3);
            this.checkBox_autoY.Name = "checkBox_autoY";
            this.checkBox_autoY.Size = new System.Drawing.Size(78, 24);
            this.checkBox_autoY.TabIndex = 2;
            this.checkBox_autoY.Text = "自动Y轴";
            this.checkBox_autoY.UseVisualStyleBackColor = true;
            this.checkBox_autoY.CheckedChanged += new System.EventHandler(this.checkBox_autoY_CheckedChanged);
            // 
            // axisYMax
            // 
            this.axisYMax.BackColor = System.Drawing.Color.White;
            this.axisYMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axisYMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisYMax.Location = new System.Drawing.Point(171, 3);
            this.axisYMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.axisYMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.axisYMax.Name = "axisYMax";
            this.axisYMax.Size = new System.Drawing.Size(80, 25);
            this.axisYMax.TabIndex = 5;
            this.axisYMax.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(87, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y轴下限";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(87, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y轴上限";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetAxisY
            // 
            this.buttonSetAxisY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetAxisY.FlatAppearance.BorderSize = 0;
            this.buttonSetAxisY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAxisY.Image = global::SimpleDataAnalyse.Properties.Resources.确认1;
            this.buttonSetAxisY.Location = new System.Drawing.Point(0, 30);
            this.buttonSetAxisY.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetAxisY.Name = "buttonSetAxisY";
            this.buttonSetAxisY.Size = new System.Drawing.Size(84, 30);
            this.buttonSetAxisY.TabIndex = 6;
            this.buttonSetAxisY.UseVisualStyleBackColor = true;
            this.buttonSetAxisY.Click += new System.EventHandler(this.buttonSetAxisY_Click);
            // 
            // checkBox_saveEnegeDisp
            // 
            this.checkBox_saveEnegeDisp.AutoSize = true;
            this.checkBox_saveEnegeDisp.BackColor = System.Drawing.Color.White;
            this.checkBox_saveEnegeDisp.Checked = true;
            this.checkBox_saveEnegeDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saveEnegeDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_saveEnegeDisp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_saveEnegeDisp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_saveEnegeDisp.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_saveEnegeDisp.Location = new System.Drawing.Point(3, 2);
            this.checkBox_saveEnegeDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_saveEnegeDisp.Name = "checkBox_saveEnegeDisp";
            this.checkBox_saveEnegeDisp.Size = new System.Drawing.Size(114, 26);
            this.checkBox_saveEnegeDisp.TabIndex = 10;
            this.checkBox_saveEnegeDisp.Text = "节能显示";
            this.checkBox_saveEnegeDisp.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.67181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.86255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 66);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox_saveEnegeDisp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(263, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(120, 60);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8567F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97196F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.48286F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.fftSize, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_setFFT, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.sampleRate, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(389, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(321, 60);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "设置";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fftSize
            // 
            this.fftSize.BackColor = System.Drawing.Color.White;
            this.fftSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fftSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftSize.Location = new System.Drawing.Point(177, 3);
            this.fftSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.fftSize.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.fftSize.Name = "fftSize";
            this.fftSize.Size = new System.Drawing.Size(141, 25);
            this.fftSize.TabIndex = 5;
            this.fftSize.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "FFT长度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_setFFT
            // 
            this.button_setFFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_setFFT.FlatAppearance.BorderSize = 0;
            this.button_setFFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setFFT.Image = global::SimpleDataAnalyse.Properties.Resources.确认1;
            this.button_setFFT.Location = new System.Drawing.Point(0, 30);
            this.button_setFFT.Margin = new System.Windows.Forms.Padding(0);
            this.button_setFFT.Name = "button_setFFT";
            this.button_setFFT.Size = new System.Drawing.Size(82, 30);
            this.button_setFFT.TabIndex = 6;
            this.button_setFFT.UseVisualStyleBackColor = true;
            this.button_setFFT.Click += new System.EventHandler(this.button_setFFT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(85, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "采样频率";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sampleRate
            // 
            this.sampleRate.BackColor = System.Drawing.Color.White;
            this.sampleRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleRate.Location = new System.Drawing.Point(177, 33);
            this.sampleRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sampleRate.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sampleRate.Name = "sampleRate";
            this.sampleRate.Size = new System.Drawing.Size(141, 25);
            this.sampleRate.TabIndex = 5;
            this.sampleRate.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // oxyplotLiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.plotView1);
            this.Name = "oxyplotLiner";
            this.Text = "oxyplot2";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYMax)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown axisYmin;
        private System.Windows.Forms.CheckBox checkBox_autoY;
        private System.Windows.Forms.NumericUpDown axisYMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSetAxisY;
        private System.Windows.Forms.CheckBox checkBox_saveEnegeDisp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fftSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_setFFT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sampleRate;
    }
}