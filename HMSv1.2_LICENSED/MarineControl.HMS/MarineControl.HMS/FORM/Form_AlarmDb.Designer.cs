
namespace MarineControl.HMS.FORM
{
    partial class Form_AlarmDb
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_overWay = new System.Windows.Forms.ComboBox();
            this.refreshSpan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dispalyNum = new System.Windows.Forms.NumericUpDown();
            this.cb_whichSensor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispalyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(282, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 871);
            this.dataGridView1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.9708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.0292F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1644, 879);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cb_overWay, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dispalyNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cb_whichSensor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.refreshSpan, 1, 3);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 229);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // cb_overWay
            // 
            this.cb_overWay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_overWay.BackColor = System.Drawing.Color.White;
            this.cb_overWay.FormattingEnabled = true;
            this.cb_overWay.Items.AddRange(new object[] {
            "\"up\"",
            "\"down\"",
            "不限定"});
            this.cb_overWay.Location = new System.Drawing.Point(139, 128);
            this.cb_overWay.Margin = new System.Windows.Forms.Padding(4);
            this.cb_overWay.Name = "cb_overWay";
            this.cb_overWay.Size = new System.Drawing.Size(127, 28);
            this.cb_overWay.TabIndex = 7;
            // 
            // refreshSpan
            // 
            this.refreshSpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshSpan.BackColor = System.Drawing.Color.White;
            this.refreshSpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshSpan.Location = new System.Drawing.Point(139, 186);
            this.refreshSpan.Margin = new System.Windows.Forms.Padding(4);
            this.refreshSpan.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.refreshSpan.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.refreshSpan.Name = "refreshSpan";
            this.refreshSpan.Size = new System.Drawing.Size(127, 27);
            this.refreshSpan.TabIndex = 4;
            this.refreshSpan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 3;
            this.label3.Text = "刷新间隔(S)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "限定种类";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "显示条数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "限定传感器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dispalyNum
            // 
            this.dispalyNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dispalyNum.BackColor = System.Drawing.Color.White;
            this.dispalyNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispalyNum.Location = new System.Drawing.Point(139, 15);
            this.dispalyNum.Margin = new System.Windows.Forms.Padding(4);
            this.dispalyNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.dispalyNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dispalyNum.Name = "dispalyNum";
            this.dispalyNum.Size = new System.Drawing.Size(127, 27);
            this.dispalyNum.TabIndex = 4;
            this.dispalyNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cb_whichSensor
            // 
            this.cb_whichSensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_whichSensor.BackColor = System.Drawing.Color.White;
            this.cb_whichSensor.FormattingEnabled = true;
            this.cb_whichSensor.Items.AddRange(new object[] {
            "\"sensor1\"",
            "\"sensor2\"",
            "\"sensor3\"",
            "\"sensor4\"",
            "\"sensor5\"",
            "\"sensor6\"",
            "不限制"});
            this.cb_whichSensor.Location = new System.Drawing.Point(139, 71);
            this.cb_whichSensor.Margin = new System.Windows.Forms.Padding(4);
            this.cb_whichSensor.Name = "cb_whichSensor";
            this.cb_whichSensor.Size = new System.Drawing.Size(127, 28);
            this.cb_whichSensor.TabIndex = 5;
            // 
            // Form_AlarmDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1644, 879);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AlarmDb";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispalyNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_overWay;
        private System.Windows.Forms.NumericUpDown refreshSpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dispalyNum;
        private System.Windows.Forms.ComboBox cb_whichSensor;
    }
}