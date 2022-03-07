namespace serialCom
{
    partial class Fouries
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
            this.panel_fftChart = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_fftChart
            // 
            this.panel_fftChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fftChart.Location = new System.Drawing.Point(0, 0);
            this.panel_fftChart.Name = "panel_fftChart";
            this.panel_fftChart.Size = new System.Drawing.Size(800, 450);
            this.panel_fftChart.TabIndex = 0;
            // 
            // Fouries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_fftChart);
            this.Name = "Fouries";
            this.Text = "Fouries";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fftChart;
    }
}