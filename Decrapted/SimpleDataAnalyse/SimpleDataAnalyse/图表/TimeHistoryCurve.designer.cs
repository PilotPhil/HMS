
namespace plot
{
    partial class MyPlotWithData
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_saveEnegeDisp = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.axisYmin = new System.Windows.Forms.NumericUpDown();
            this.checkBox_autoY = new System.Windows.Forms.CheckBox();
            this.axisYMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSetAxisY = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartMinAnn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chartMaxAnn = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYMax)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMinAnn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxAnn)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.BackColor = System.Drawing.Color.White;
            this.plotView1.Location = new System.Drawing.Point(0, 73);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(797, 374);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51064F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.checkBox_saveEnegeDisp, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(473, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(114, 64);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // checkBox_saveEnegeDisp
            // 
            this.checkBox_saveEnegeDisp.AutoSize = true;
            this.checkBox_saveEnegeDisp.Checked = true;
            this.checkBox_saveEnegeDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saveEnegeDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_saveEnegeDisp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_saveEnegeDisp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_saveEnegeDisp.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_saveEnegeDisp.Location = new System.Drawing.Point(3, 2);
            this.checkBox_saveEnegeDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_saveEnegeDisp.Name = "checkBox_saveEnegeDisp";
            this.checkBox_saveEnegeDisp.Size = new System.Drawing.Size(108, 28);
            this.checkBox_saveEnegeDisp.TabIndex = 9;
            this.checkBox_saveEnegeDisp.Text = "节能显示";
            this.checkBox_saveEnegeDisp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.axisYmin, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_autoY, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.axisYMax, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSetAxisY, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(198, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 64);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // axisYmin
            // 
            this.axisYmin.BackColor = System.Drawing.Color.White;
            this.axisYmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axisYmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisYmin.Location = new System.Drawing.Point(157, 35);
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
            this.axisYmin.Size = new System.Drawing.Size(232, 25);
            this.axisYmin.TabIndex = 5;
            this.axisYmin.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            // 
            // checkBox_autoY
            // 
            this.checkBox_autoY.AutoSize = true;
            this.checkBox_autoY.Checked = true;
            this.checkBox_autoY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_autoY.Location = new System.Drawing.Point(3, 3);
            this.checkBox_autoY.Name = "checkBox_autoY";
            this.checkBox_autoY.Size = new System.Drawing.Size(82, 26);
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
            this.axisYMax.Location = new System.Drawing.Point(157, 3);
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
            this.axisYMax.Size = new System.Drawing.Size(232, 25);
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
            this.label4.Location = new System.Drawing.Point(91, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y轴下限";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(91, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
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
            this.buttonSetAxisY.Location = new System.Drawing.Point(0, 32);
            this.buttonSetAxisY.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetAxisY.Name = "buttonSetAxisY";
            this.buttonSetAxisY.Size = new System.Drawing.Size(88, 32);
            this.buttonSetAxisY.TabIndex = 6;
            this.buttonSetAxisY.UseVisualStyleBackColor = true;
            this.buttonSetAxisY.Click += new System.EventHandler(this.buttonSetAxisY_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chartMinAnn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartMaxAnn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 64);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "阈值上限";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMinAnn
            // 
            this.chartMinAnn.BackColor = System.Drawing.Color.White;
            this.chartMinAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartMinAnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartMinAnn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMinAnn.Location = new System.Drawing.Point(97, 35);
            this.chartMinAnn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.chartMinAnn.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.chartMinAnn.Name = "chartMinAnn";
            this.chartMinAnn.Size = new System.Drawing.Size(89, 25);
            this.chartMinAnn.TabIndex = 2;
            this.chartMinAnn.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.chartMinAnn.ValueChanged += new System.EventHandler(this.chartMinAnn_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "阈值下限";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMaxAnn
            // 
            this.chartMaxAnn.BackColor = System.Drawing.Color.White;
            this.chartMaxAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartMaxAnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartMaxAnn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMaxAnn.Location = new System.Drawing.Point(97, 3);
            this.chartMaxAnn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.chartMaxAnn.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.chartMaxAnn.Name = "chartMaxAnn";
            this.chartMaxAnn.Size = new System.Drawing.Size(89, 25);
            this.chartMaxAnn.TabIndex = 2;
            this.chartMaxAnn.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.chartMaxAnn.ValueChanged += new System.EventHandler(this.chartMaxAnn_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(593, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(204, 64);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "ML-查看数值\nMR-平移区域\nMC-区域放大双击还原";
            // 
            // MyPlotWithData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.plotView1);
            this.Name = "MyPlotWithData";
            this.Text = "oxyplot";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYMax)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMinAnn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxAnn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown chartMinAnn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown chartMaxAnn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox_autoY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown axisYMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown axisYmin;
        private System.Windows.Forms.Button buttonSetAxisY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBox_saveEnegeDisp;
    }
}