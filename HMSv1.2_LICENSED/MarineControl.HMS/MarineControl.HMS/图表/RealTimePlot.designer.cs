
namespace MarineControl.HMS.Plot
{
    partial class RealTimePlot
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
            this.components = new System.ComponentModel.Container();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_saveEnegeDisp = new HZH_Controls.Controls.UCCheckBox();
            this.checkBox_autoY = new HZH_Controls.Controls.UCCheckBox();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.BackColor = System.Drawing.Color.White;
            this.plotView1.Location = new System.Drawing.Point(0, 2);
            this.plotView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(598, 325);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.checkBox_saveEnegeDisp, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_autoY, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 330);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(600, 30);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // checkBox_saveEnegeDisp
            // 
            this.checkBox_saveEnegeDisp.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_saveEnegeDisp.Checked = true;
            this.checkBox_saveEnegeDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_saveEnegeDisp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_saveEnegeDisp.Location = new System.Drawing.Point(3, 3);
            this.checkBox_saveEnegeDisp.Name = "checkBox_saveEnegeDisp";
            this.checkBox_saveEnegeDisp.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_saveEnegeDisp.Size = new System.Drawing.Size(94, 24);
            this.checkBox_saveEnegeDisp.TabIndex = 2;
            this.checkBox_saveEnegeDisp.TextValue = "节能显示";
            // 
            // checkBox_autoY
            // 
            this.checkBox_autoY.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_autoY.Checked = true;
            this.checkBox_autoY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_autoY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_autoY.Location = new System.Drawing.Point(103, 3);
            this.checkBox_autoY.Name = "checkBox_autoY";
            this.checkBox_autoY.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_autoY.Size = new System.Drawing.Size(94, 24);
            this.checkBox_autoY.TabIndex = 2;
            this.checkBox_autoY.TextValue = "自动Y轴";
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // RealTimePlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.plotView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RealTimePlot";
            this.Text = "oxyplot";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private HZH_Controls.Controls.UCCheckBox checkBox_saveEnegeDisp;
        private HZH_Controls.Controls.UCCheckBox checkBox_autoY;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
    }
}