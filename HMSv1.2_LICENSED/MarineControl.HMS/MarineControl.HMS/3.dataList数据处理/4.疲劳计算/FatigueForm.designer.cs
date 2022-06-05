
namespace MarineControl.HMS.Fatigue
{
    partial class FatigueForm
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
            this.tb_damage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_k = new System.Windows.Forms.ComboBox();
            this.ultraStress = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_barchart = new System.Windows.Forms.Panel();
            this.histroDegree = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_tableFresh = new System.Windows.Forms.CheckBox();
            this.ckb_barFresh = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraStress)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histroDegree)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_damage
            // 
            this.tb_damage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_damage.Location = new System.Drawing.Point(98, 2);
            this.tb_damage.Margin = new System.Windows.Forms.Padding(2);
            this.tb_damage.Name = "tb_damage";
            this.tb_damage.Size = new System.Drawing.Size(224, 21);
            this.tb_damage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "K参数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_k
            // 
            this.cbb_k.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_k.FormattingEnabled = true;
            this.cbb_k.Items.AddRange(new object[] {
            "B:5.8E12",
            "C:3.464E12",
            "D:1.520E12",
            "E:1.026E12",
            "F:6.319E11",
            "F2:4.33pE11",
            "G:2.481E11",
            "W:9.279E10"});
            this.cbb_k.Location = new System.Drawing.Point(135, 2);
            this.cbb_k.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_k.Name = "cbb_k";
            this.cbb_k.Size = new System.Drawing.Size(129, 20);
            this.cbb_k.TabIndex = 3;
            this.cbb_k.SelectedIndexChanged += new System.EventHandler(this.cbb_k_SelectedIndexChanged);
            // 
            // ultraStress
            // 
            this.ultraStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraStress.Location = new System.Drawing.Point(135, 29);
            this.ultraStress.Margin = new System.Windows.Forms.Padding(2);
            this.ultraStress.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ultraStress.Name = "ultraStress";
            this.ultraStress.Size = new System.Drawing.Size(129, 21);
            this.ultraStress.TabIndex = 4;
            this.ultraStress.Value = new decimal(new int[] {
            235,
            0,
            0,
            0});
            this.ultraStress.ValueChanged += new System.EventHandler(this.ultraStress_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "极限应力(MP)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbb_k, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ultraStress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 55);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel_barchart);
            this.panel1.Location = new System.Drawing.Point(2, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 496);
            this.panel1.TabIndex = 0;
            // 
            // panel_barchart
            // 
            this.panel_barchart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_barchart.Location = new System.Drawing.Point(0, 0);
            this.panel_barchart.Margin = new System.Windows.Forms.Padding(2);
            this.panel_barchart.Name = "panel_barchart";
            this.panel_barchart.Size = new System.Drawing.Size(771, 496);
            this.panel_barchart.TabIndex = 0;
            // 
            // histroDegree
            // 
            this.histroDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histroDegree.Location = new System.Drawing.Point(89, 2);
            this.histroDegree.Margin = new System.Windows.Forms.Padding(2);
            this.histroDegree.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.histroDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.histroDegree.Name = "histroDegree";
            this.histroDegree.Size = new System.Drawing.Size(83, 21);
            this.histroDegree.TabIndex = 0;
            this.histroDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "疲劳损伤度";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "细分度";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckb_tableFresh
            // 
            this.ckb_tableFresh.AutoSize = true;
            this.ckb_tableFresh.Checked = true;
            this.ckb_tableFresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_tableFresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_tableFresh.Location = new System.Drawing.Point(2, 29);
            this.ckb_tableFresh.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_tableFresh.Name = "ckb_tableFresh";
            this.ckb_tableFresh.Size = new System.Drawing.Size(83, 24);
            this.ckb_tableFresh.TabIndex = 9;
            this.ckb_tableFresh.Text = "刷新表格";
            this.ckb_tableFresh.UseVisualStyleBackColor = true;
            // 
            // ckb_barFresh
            // 
            this.ckb_barFresh.AutoSize = true;
            this.ckb_barFresh.Checked = true;
            this.ckb_barFresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_barFresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_barFresh.Location = new System.Drawing.Point(89, 29);
            this.ckb_barFresh.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_barFresh.Name = "ckb_barFresh";
            this.ckb_barFresh.Size = new System.Drawing.Size(83, 24);
            this.ckb_barFresh.TabIndex = 9;
            this.ckb_barFresh.Text = "刷新柱状图";
            this.ckb_barFresh.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.1025F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.8975F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 59);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ckb_tableFresh, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.histroDegree, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ckb_barFresh, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(600, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(174, 55);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69121F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30879F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_damage, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(272, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 55);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // FatigueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FatigueForm";
            this.Text = "RainFlow";
            ((System.ComponentModel.ISupportInitialize)(this.ultraStress)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histroDegree)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_damage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_k;
        private System.Windows.Forms.NumericUpDown ultraStress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown histroDegree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_tableFresh;
        private System.Windows.Forms.CheckBox ckb_barFresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel_barchart;
    }
}